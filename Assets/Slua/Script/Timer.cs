// The MIT License (MIT)

// Copyright 2015 Siney/Pangweiwei siney@yeah.net
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using LuaInterface;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace SLua
{
    public class Timer
    {
        class Timer
        {
            internal int sn;
            internal int cycle;
            internal int deadline;
            internal Func<int, bool> handler;
            internal bool delete;
            internal int pause;
            internal LinkedList<Timer> container;
        }
        class Wheel
        {
            internal static int dial_scale = 256;
            internal int head;
            internal LinkedList<Timer>[] vecDial;
            internal int dialSize;                      
            internal int timeRange;                     
            internal Wheel nextWheel;
            internal Wheel(int dialSize)
            {
                this.dialSize = dialSize;
                this.timeRange = dialSize * dial_scale;
                this.head = 0;
                this.vecDial = new LinkedList<Timer>[dial_scale];
                for (int i = 0; i < dial_scale; ++i)
                {
                    this.vecDial[i] = new LinkedList<Timer>();
                }
            }
            internal LinkedList<Timer> nextDial()
            {
                return vecDial[head++];
            }
            internal void add(int delay, Timer tm)
            {
                var container = vecDial[(head + (delay - (dialSize - jiffies_msec)) / dialSize) % dial_scale];
                container.AddLast(tm);
                tm.container = container;
            }
        }
        static int nextSn = 0;
        static int jiffies_msec = 20;        
        static float jiffies_sec = jiffies_msec * .001f;
        static Wheel[] wheels;
        static float pileSecs;
        static float nowTime;
        static Dictionary<int, Timer> mapSnTimer;
        static LinkedList<Timer> executeTimers;

        static int intpow(int n, int m)
        {
            int ret = 1;
            for (int i = 0; i < m; ++i)
                ret *= n;
            return ret;
        }

        static void innerAdd(int deadline, Timer tm)
        {
            tm.deadline = deadline;
            int delay = Math.Max(0, deadline - now());
            Wheel suitableWheel = wheels[wheels.Length - 1]; ;
            for (int i = 0; i < wheels.Length; ++i)
            {
                var wheel = wheels[i];
                if (delay < wheel.timeRange)
                {
                    suitableWheel = wheel;
                    break;
                }
            }
            suitableWheel.add(delay, tm);
        }

        static void innerDel(Timer tm)
        {
            tm.delete = true;
            if (tm.container != null)
            {
                tm.container.Remove(tm);
                tm.container = null;
            }
            mapSnTimer.Remove(tm.sn);
        }

        void innerPause(Timer tm)
        {
            if (tm.pause > 0)
                return;
            tm.pause = now();
            if (tm.container != null)
            {
                tm.container.Remove(tm);
                tm.container = null;
            }
        }

        void innerResume(Timer tm)
        {
            if (tm.pause == 0)
                return;
            int pauseTime = now() - tm.pause;
            tm.pause = 0;
            innerAdd(tm.deadline + pauseTime, tm);
        }

        public int now()
        {
            return (int)(nowTime * 1000);
        }

        public static void tick(float deltaTime)
        {
            nowTime += deltaTime;
            pileSecs += deltaTime;
            int cycle = 0;
            while (pileSecs >= jiffies_sec)
            {
                pileSecs -= jiffies_sec;
                cycle++;
            }
            for (int i = 0; i < cycle; ++i)
            {
                var timers = wheels[0].nextDial();
                LinkedListNode<Timer> node = timers.First;
                for (int j = 0; j < timers.Count; ++j)
                {
                    var tm = node.Value;
                    executeTimers.AddLast(tm);
                    node = node.Next;
                }
                timers.Clear();

                for (int j = 0; j < wheels.Length; ++j)
                {
                    var wheel = wheels[j];
                    if (wheel.head == Wheel.dial_scale)
                    {
                        wheel.head = 0;
                        if (wheel.nextWheel != null)
                        {
                            var tms = wheel.nextWheel.nextDial();
                            LinkedListNode<Timer> tmsNode = tms.First;
                            for (int k = 0; k < tms.Count; ++k)
                            {
                                var tm = tmsNode.Value;
                                if (tm.delete)
                                {
                                    mapSnTimer.Remove(tm.sn);
                                }
                                else
                                {
                                    innerAdd(tm.deadline, tm);
                                }
                                tmsNode = tmsNode.Next;
                            }
                            tms.Clear();
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            while (executeTimers.Count > 0)
            {
                var tm = executeTimers.First.Value;
                executeTimers.Remove(tm);
                if (!tm.delete && tm.handler(tm.sn) && tm.cycle > 0)
                {
                    innerAdd(now() + tm.cycle, tm);
                }
                else
                {
                    mapSnTimer.Remove(tm.sn);
                }
            }
        }

        public static void init()
        {
            wheels = new Wheel[4];
            for (int i = 0; i < 4; ++i)
            {
                wheels[i] = new Wheel(jiffies_msec * intpow(Wheel.dial_scale, i));
                if (i > 0)
                {
                    wheels[i - 1].nextWheel = wheels[i];
                }
            }
            mapSnTimer = new Dictionary<int, Timer>();
            executeTimers = new LinkedList<Timer>();
        }

        static int fetchSn()
        {
            return ++nextSn;
        }

        public static int add(int delay, Action<int> handler)
        {
            return add(delay, 0, (int sn) =>
            {
                handler(sn);
                return false;
            });
        }

        public static int add(int delay, int cycle, Func<int, bool> handler)
        {
            Timer tm = new Timer();
            tm.sn = fetchSn();
            tm.cycle = cycle;
            tm.handler = handler;
            mapSnTimer[tm.sn] = tm;
            innerAdd(now() + delay, tm);
            return tm.sn;
        }

        public static void del(int sn)
        {
            Timer tm;
            if (mapSnTimer.TryGetValue(sn, out tm))
            {
                innerDel(tm);
            }
        }
    }

}