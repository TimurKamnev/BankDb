using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW35
{
    public class Departments
    {
        public int Id { get; set; }
        public string DepartmentName {get; set; }
        public int ManagersId { get; set; }
        public Managers Managers { get; set; }
    }

}
