using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management.BLL
{
    class Shift_EntryBLL
    {
        public int Shift_id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public string TypeOfShift { get; set; }
        public DateTime Shift_From { get; set; }
        public DateTime Shift_To { get; set; }
    }
}
