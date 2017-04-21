﻿using BmpListener.Bgp;

namespace BmpListener.Serialization.Models
{
    public class PeerUpNotificationModel
    {
        public int BmpMsgLength { get; set; }
        public int BgpMsgLength { get; set; }
        public PeerHeaderModel Peer { get; set; }
        public int LocalPort { get; set; }
        public int RemotePort { get; set; }
        //public BgpOpenMessage SentOpenMessage { get; set; }
        //public BgpOpenMessage ReceivedOpenMessage { get; set; }
    }
}