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

// Compile this file need /unsafe flag, so split it to single dll

namespace SLua
{
	using System;
	public class BytesHelper
	{
		static public unsafe void MoveToBytes(byte[] bytes,int p,Int64 v) {
			fixed(byte* b = bytes) {
				*((Int64*)(b + p)) = v;
			}
		}

		static public unsafe void MoveToBytes(byte[] bytes,int p,UInt64 v) {
			fixed(byte* b = bytes) {
				*((UInt64*)(b + p)) = v;
			}
		}

		static public unsafe void MoveToBytes(byte[] bytes,int p,int v) {
			fixed(byte* b = bytes) {
				*((int*)(b + p)) = v;
			}
		}

		static public unsafe void MoveToBytes(byte[] bytes,int p,uint v) {
			fixed(byte* b = bytes) {
				*((uint*)(b + p)) = v;
			}
		}

		static public unsafe void MoveToBytes(byte[] bytes,int p,float v) {
			fixed(byte* b = bytes) {
				*((float*)(b + p)) = v;
			}
		}

		static public unsafe void MoveToBytes(byte[] bytes,int p,double v) {
			fixed(byte* b = bytes) {
				*((double*)(b + p)) = v;
			}
		}

		static public unsafe void MoveToBytes(byte[] bytes,int p,short v) {
			fixed(byte* b = bytes) {
				*((short*)(b + p)) = v;
			}
		}

		static public unsafe void MoveToBytes(byte[] bytes,int p,ushort v) {
			fixed(byte* b = bytes) {
				*((ushort*)(b + p)) = v;
			}
		}

		static public unsafe void MoveToBytes(byte[] bytes,int p,sbyte v) {
			fixed(byte* b = bytes) {
				*((sbyte*)(b + p)) = v;
			}
		}
	}
}

