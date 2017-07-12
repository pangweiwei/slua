using System;

namespace SLua
{
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

