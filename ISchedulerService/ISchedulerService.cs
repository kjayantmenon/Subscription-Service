using SchedulerService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerService.Domain
{
    public interface ISchedulerService
    {
        Task CreateNewSchedule(Schedule schedule);

        Task UpdateSchedule(string scheduleId, Schedule schedule);

        Task RemoveSchedule(String scheduleId);
    }
}
