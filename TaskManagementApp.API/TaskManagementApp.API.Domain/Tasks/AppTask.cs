using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementApp.API.Domain.Users;

namespace TaskManagementApp.API.Domain.Tasks
{
    public class AppTask
    {
        public int AppTaskID { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public string Status { get; set; }
        public List<ChecklistItem> ChecklistItems { get; set; }
        public User AssignedTo { get; set; }
    }
}
