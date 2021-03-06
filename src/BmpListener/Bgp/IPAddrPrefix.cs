﻿using System;
using System.Net;

namespace BmpListener.Bgp
{
    public class IPAddrPrefix
    {
        public int Length { get; private set; }
        public IPAddress Prefix { get; private set; }

        public override string ToString()
        {
            return ($"{Prefix}/{Length}");
        }

        public static (IPAddrPrefix prefix, int byteLength) Decode(byte[] data, int offset, AddressFamily afi)
        {
            var bitLength = data[offset];
            var byteLength = (bitLength + 7) / 8;
            var ipBytes = afi == AddressFamily.IP
                ? new byte[4]
                : new byte[16];
            Array.Copy(data, offset + 1, ipBytes, 0, byteLength);
            var prefix = new IPAddress(ipBytes);
            var ipAddrPrefix = new IPAddrPrefix { Length = bitLength, Prefix = prefix };
            return (ipAddrPrefix, byteLength + 1);
        }
    }
}

