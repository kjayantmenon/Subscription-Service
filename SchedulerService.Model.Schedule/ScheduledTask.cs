using System;

namespace SchedulerService.Model
{
    public class ScheduledTask
    {
        public string id { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }
        public int Frequency { get; set; }
    }
}