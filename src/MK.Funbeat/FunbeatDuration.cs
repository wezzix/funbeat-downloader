using System;

namespace MK.Funbeat
{
    public class FunbeatDuration
    {
        public int? Hours { get; set; }
        public int? Minutes { get; set; }
        public int? Seconds { get; set; }

        public TimeSpan TimeSpan
        {
            get
            {
                return new TimeSpan(
                    0, Hours.GetValueOrDefault(), Minutes.GetValueOrDefault(), Seconds.GetValueOrDefault());
            }
        }
    }
}