using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementApp.API.Domain.Orgs;
using TaskManagementApp.API.Domain.Tasks;

namespace TaskManagementApp.API.Domain.Users
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public List<AppTask> Tasks { get; set; }
        public Org MemberOf { get; set; }
    }
}
