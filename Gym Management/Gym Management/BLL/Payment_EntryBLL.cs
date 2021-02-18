using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management.BLL
{
    class Payment_EntryBLL
    {
        public int Payment_id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public string Payment_Type { get; set; }
        public int Paid_Amount { get; set; }
        public DateTime Payment_Date { get; set; }
        public DateTime Payment_Due { get; set; }
    }
}
