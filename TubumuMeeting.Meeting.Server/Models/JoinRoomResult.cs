﻿namespace TubumuMeeting.Meeting.Server
{
    public class JoinRoomResult
    {
        public PeerWithRoomAppData SelfPeer { get; set; }

        public PeerWithRoomAppData[] Peers { get; set; }
    }
}