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

namespace SLua
{
	using System.Collections;
	using System.Collections.Generic;
	using System;

	public class ByteArray
	{
		static void ReAlloc (ref byte[] ba, int pos, int size)
		{
			if (ba.Length < (pos + size)) {
				Array.Resize<byte> (ref ba, (int)(ba.Length + size + 1024));
			}
		}

		private byte[] data_;
		private int pos_;

		public ByteArray() {
			data_ = new byte[32];
			pos_ = 0;
		}

		public ByteArray(byte[] data) {
			SetData (data);
		}

		public void SetData (byte[] data)
		{
			data_ = data;
			pos_ = 0;
		}

		public void SetData (byte[] data, int len, int pos)
		{
			data_ = data;
			pos_ = pos;
		}

		public void Clear ()
		{
			pos_ = 0;
		}

		public int Length {
			get {
				return data_.Length;
			}
		}

		public int Position {
			get {
				return pos_;
			}
			set {
				pos_ = value;
			}
		}

		public byte[] GetData ()
		{
			return data_;
		}

		public bool ReadBool ()
		{
			return (ReadByte () == 1 ? true : false);
		}

		public int ReadInt ()
		{
			int oldPos = pos_;
			pos_ += 4;
			return BitConverter.ToInt32 (data_, oldPos);
		}

		public uint ReadUInt ()
		{
			int oldPos = pos_;
			pos_ += 4;
			return BitConverter.ToUInt32 (data_, oldPos);
		}

		public sbyte ReadChar ()
		{
			return ReadSByte ();
		}

		public byte ReadUChar ()
		{
			return ReadByte ();
		}

		public byte ReadByte ()
		{
			return data_ [pos_++];
		}

		public void Read (ref byte[] arr)
		{        
			for (int i = 0; i < arr.Length; ++i) {
				arr [i] = data_ [pos_++];
			}
		}

		public sbyte ReadSByte ()
		{
			if (data_ [pos_] > 127)
				return (sbyte)(data_ [pos_++] - 256);
			else
				return (sbyte)(data_ [pos_++]);
		}

		public short ReadShort ()
		{
			return ReadInt16 ();
		}

		public ushort ReadUShort ()
		{
			return ReadUInt16 ();
		}

		public short ReadInt16 ()
		{
			int oldPos = pos_;
			pos_ += 2;
			return BitConverter.ToInt16 (data_, oldPos);
			;
		}

		public ushort ReadUInt16 ()
		{
			int oldPos = pos_;
			pos_ += 2;
			return BitConverter.ToUInt16 (data_, oldPos);
		}

		public Int64 ReadInt64 ()
		{
			int oldPos = pos_;
			pos_ += 8;
			return BitConverter.ToInt64 (data_, oldPos);
		}

		public float ReadFloat ()
		{
			int oldPos = pos_;
			pos_ += 4;
			return BitConverter.ToSingle (data_, oldPos);
		}

		public double ReadDouble ()
		{
			int oldPos = pos_;
			pos_ += 8;
			return BitConverter.ToDouble (data_, oldPos);
		}

		public string ReadString ()
		{
			int len = (int)ReadVarInt ();
			int oldPos = pos_;
			pos_ += len;
			return System.Text.UTF8Encoding.UTF8.GetString (data_, oldPos, len);
		}

		public void WriteByteArray (ByteArray v)
		{
			Write (v);
		}

		public void WriteBool (bool v)
		{
			Write (v);
		}

		public void WriteInt (int v)
		{
			Write (v);
		}

		public void Write (ByteArray v)
		{
			if (v != null) {
				ReAlloc (ref data_, pos_, v.Position);
				byte[] arr = v.GetData ();
				arr.CopyTo (data_, pos_);
			}
		}

		public void Write (bool v)
		{
			Write (Convert.ToByte (v));
		}

		public void Write (int v)
		{
			ReAlloc (ref data_, pos_, 4);
			BitConverter.GetBytes (v).CopyTo (data_, pos_);
			pos_ += 4;
		}

		public void Write (uint v)
		{
			ReAlloc (ref data_, pos_, 4);
			BitConverter.GetBytes (v).CopyTo (data_, pos_);
			pos_ += 4;
		}

		public void WriteUInt (uint v)
		{
			Write (v);
		}

		public void Write (char v)
		{
			ReAlloc (ref data_, pos_, 1);
			data_ [pos_] = (byte)v;
			pos_++;
		}

		public void WriteChar (sbyte v)
		{
			WriteSByte (v);
		}

		public void Write (byte[] arr)
		{
			ReAlloc (ref data_, pos_, arr.Length);
			foreach (byte v in arr) {
				data_ [pos_++] = v;
			}
		}

		public void Write (byte v)
		{
			ReAlloc (ref data_, pos_, 1);
			data_ [pos_] = v;
			pos_++;
		}

		public void WriteByte (byte v)
		{
			Write (v);
		}

		public void WriteUChar (byte v)
		{
			Write (v);
		}

		public void Write (sbyte v)
		{
			ReAlloc (ref data_, pos_, 1);
			BitConverter.GetBytes (v).CopyTo (data_, pos_);
			pos_++;
		}

		public void WriteSByte (sbyte v)
		{
			Write (v);
		}

		public void Write (short v)
		{
			ReAlloc (ref data_, pos_, 2);
			data_ [pos_] = (byte)(v & 0xff);
			pos_++;
			data_ [pos_] = (byte)(v >> 8);
			pos_++;
		}

		public void Write (ushort v)
		{
			Write ((short)v);
		}

		public void WriteUShort (ushort v)
		{
			Write (v);
		}

		public void WriteShort (short v)
		{
			Write (v);
		}

		public void Write (float v)
		{
			ReAlloc (ref data_, pos_, 4);
			BitConverter.GetBytes (v).CopyTo (data_, pos_);
			pos_ += 4;
		}

		public void WriteFloat (float v)
		{
			Write (v);
		}

		public void Write (double v)
		{
			ReAlloc (ref data_, pos_, 8);
			BitConverter.GetBytes (v).CopyTo (data_, pos_);
			pos_ += 8;
		}

		public void WriteNum (double v)
		{
			Write (v);
		}

		public void Write (string v)
		{
			byte[] bytes = System.Text.Encoding.UTF8.GetBytes (v);
			int len = bytes.Length;
			WriteVarInt (bytes.Length);
			ReAlloc (ref data_, pos_, len);
			bytes.CopyTo (data_, pos_);
			pos_ += len;
		}

		public void WriteString (string v)
		{
			Write (v);
		}

		public void WriteUInt (uint v, int pos)
		{
			BitConverter.GetBytes (v).CopyTo (data_, pos);
		}

		public void Write (Int64 v)
		{
			BitConverter.GetBytes (v).CopyTo (data_, pos_);
		}

		public void WriteInt64 (Int64 v)
		{
			Write (v);
		}

		public Int64 ReadVarInt ()
		{
			byte ch = ReadByte ();
			Int64 v = ch & 0x7f;
			int shift = 7;
			while ((ch & 0x80) > 0 && pos_<data_.Length-1) {
				ch = ReadByte ();
				v |= (((Int64)(ch & 0x7f)) << shift);
				shift += 7;
			}

			return v;
		}

		public void WriteVarInt (Int64 v)
		{
			UInt64 uv = (UInt64)v;
			while (uv >= 0x80) {
				WriteByte ((byte)(uv | 0x80));
				uv >>= 7;
			}

			WriteByte ((byte)uv);
		}
	}
}