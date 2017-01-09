using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerService.Model
{
    public class Schedule
    {
        public string Id { get; set; }

        public string OrgId { get; set; }

        public string SiteId { get; set; }
        public User user { get; set; }

        public ScheduledTask task { get; set; }
    }
}
