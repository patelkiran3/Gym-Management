using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management.BLL
{
    class User_RegistrationBLL
    {
        public int User_id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string Email_ID { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Shift_Type { get; set; }
        public string Package_Type { get; set; }
        public string Trainer_Name{ get; set; }
    }
}
