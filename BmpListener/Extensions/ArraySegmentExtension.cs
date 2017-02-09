﻿using System;
using System.Linq;

namespace BmpListener.Extensions
{
    public static class ArraySegmentExtension
    {
        private static readonly bool IsLittleEndian = BitConverter.IsLittleEndian;

        public static ushort ToUInt16(this ArraySegment<byte> data, int index)
        {
            var bytes = IsLittleEndian
                ? data.Skip(index).Take(2).Reverse() :
                data.Skip(index).Take(2);
            return BitConverter.ToUInt16(bytes.ToArray(), 0);
        }
        
        public static int ToInt32(this ArraySegment<byte> data, int index)
        {
            var bytes = IsLittleEndian
                ? data.Skip(index).Take(4).Reverse() :
                data.Skip(index).Take(4);
            return BitConverter.ToInt32(bytes.ToArray(), 0);
        }

        public static uint ToUInt32(this byte[] data, int index)
        {
            var bytes = IsLittleEndian
                ? data.Skip(index).Take(4).Reverse() :
                data.Skip(index).Take(4);
            return BitConverter.ToUInt32(bytes.ToArray(), 0);
        }

        public static uint ToUInt32(this ArraySegment<byte> data, int index)
        {
            var bytes = IsLittleEndian
                ? data.Skip(index).Take(4).Reverse() :
                data.Skip(index).Take(4);
            return BitConverter.ToUInt32(bytes.ToArray(), 0);
        }        
    }
}