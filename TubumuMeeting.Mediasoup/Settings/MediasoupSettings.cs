﻿namespace TubumuMeeting.Mediasoup
{
    public class MediasoupSettings
    {
        public WorkerSettings WorkerSettings { get; set; }

        public RouterSettings RouterSettings { get; set; }

        public WebRtcTransportSettings WebRtcTransportSettings { get; set; }
    }
}
