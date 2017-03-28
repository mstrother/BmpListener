﻿using System.Net;

namespace BmpListener.Bgp
{
    public class PathAttributeAggregator : PathAttribute
    {
        public PathAttributeAggregator(byte[] data, int offset)
            : base(data, offset)
        {
            Decode(data, Offset);
        }

        public int AS { get; private set; }
        public IPAddress IPAddress { get; private set; }

        protected void Decode(byte[] data, int offset)
        {
            // TODO: fix
            //AS = BitConverter.ToInt16(data, 0);
            //if (data.Length == 6)
            //{
            //    var ipBytes = data.Skip(2).ToArray();
            //    IPAddress = new IPAddress(ipBytes);
            //}
            //else
            //{
            //    var ipBytes = data.Skip(4).ToArray();
            //    IPAddress = new IPAddress(ipBytes);
            //}
        }
    }
}