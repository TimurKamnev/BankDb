using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW35
{
    public class Clients
    {
        public int Id { get; set; }

        public string PassportId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char Gender { get; set; }
        public byte Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte CreditRating { get; set; }
        public ulong TelephoneNumber { get; set; }
        public string Address { get; set; }
        public int DepartmentsId { get; set; }
        public Departments? Departments { get; set; }
    }
}
