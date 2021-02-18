using Gym_Management.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Attendence_Entry_Click(object sender, EventArgs e)
        {
            this.Close();
            Attendence_Form AE = new Attendence_Form();
            AE.Show();
            this.Hide();
        }

        private void Shift_Entry_Click(object sender, EventArgs e)
        {
            this.Close();
            Shift_Entry SE = new Shift_Entry();
            SE.Show();
            this.Hide();
        }

        private void Package_Entry_Click(object sender, EventArgs e)
        {
            this.Close();
            Package_Entry PE = new Package_Entry();
            PE.Show();
            this.Hide();
        }

        private void Logout_Strip_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void User_Registration_Click(object sender, EventArgs e)
        {
            this.Close();
            User_Registration UR = new User_Registration();
            UR.Show();
            this.Hide();
        }

        private void Trainer_Registration_Click(object sender, EventArgs e)
        {
            this.Close();
            Trainer_Registration TR = new Trainer_Registration();
            TR.Show();
            this.Hide();
        }

        private void Payment_Entry_Click(object sender, EventArgs e)
        {
            this.Close();
            Payment_Entry PE = new Payment_Entry();
            PE.Show();
            this.Hide();
        }

        private void Attendence_Report_Click(object sender, EventArgs e)
        {
            AttendenceReport ar = new AttendenceReport();
            ar.Show();
            this.Hide();
        }

        private void Shift_Report_Click(object sender, EventArgs e)
        {
            ShiftDetailsReport sdr = new ShiftDetailsReport();
            sdr.Show();
            this.Hide();
        }

        private void User_Report_Click(object sender, EventArgs e)
        {
            UserDetailsReport udr = new UserDetailsReport();
            udr.Show();
            this.Hide();
        }

        private void Package_Report_Click(object sender, EventArgs e)
        {
            PackageDetailsReport pdr = new PackageDetailsReport();
            pdr.Show();
            this.Hide();
        }

        private void Payment_Report_Click(object sender, EventArgs e)
        {
            PaymentDetailsReport pdr = new PaymentDetailsReport();
            pdr.Show();
            this.Hide();
        }

        private void Trainer_Report_Click(object sender, EventArgs e)
        {
            TrainerDetailsReport tdr = new TrainerDetailsReport();
            tdr.Show();
            this.Hide();
        }
    }
}
