using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementApp.API.Domain.Users;

namespace TaskManagementApp.API.Domain.Orgs
{
    public class Org
    {
        public int OrgId { get; set; }
        public string OrgName { get; set; }
        public List<User> Members { get; set; }
    }
}
