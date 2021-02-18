using Gym_Management.BLL;
using Gym_Management.DAL;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        SignUp S = new SignUp();
        SignUpDal Dal = new SignUpDal();

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SIgnUp S = new SIgnUp();
            S.Show();
            this.Hide();
        }

        LoginBLL L = new LoginBLL();
        LoginDal LDal = new LoginDal();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            #region Throw Error

            if (txtUserName.Text == "" && txtPassword.Text == "")
                MessageBox.Show(" PLEASE ENTER USERNAME AND PASSWORD ");

            else if (txtUserName.Text == "")
                MessageBox.Show(" PLEASE ENTER USERNAME ");

            else if (txtPassword.Text == "")
                MessageBox.Show(" PLEASE ENTER PASSWORD ");

            #endregion

            L.Username = txtUserName.Text;
            L.Password = txtPassword.Text;

            bool Success = LDal.LoginCheck(L);
            if (Success == true)
            {
                MessageBox.Show(" Login Successfully ");
                Dashboard DS = new Dashboard();
                DS.Show();
                this.Hide();
            }

            else
                MessageBox.Show(" Login Failed ..... Please Try Again ");
        }
    }
}
