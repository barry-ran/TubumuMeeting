﻿namespace TubumuMeeting.Meeting.Server
{
    public class PullResult
    {
        public Peer SelfPeer { get; set; }

        public PeerProducer[] ExistsProducers { get; set; }

        public string RoomId { get; set; }

        public string TargetPeerId { get; set; }

        public string[] ProduceSources { get; set; }
    }
}