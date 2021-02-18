using Gym_Management.BLL;
using Gym_Management.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management.UI
{
    public partial class SIgnUp : Form
    {
        public SIgnUp()
        {
            InitializeComponent();
        }

        private void ClosePicture_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin login = new frmLogin();
            login.Show();
        }

        SignUp s = new SignUp();
        SignUpDal sdal = new SignUpDal();

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            #region Throw Error

            if (txtUserName.Text == "" && txtPassword.Text == "" && txtConfirm_Password.Text == "")
                MessageBox.Show(" PLEASE FILL ALL THE DETAILS ......... !! ");

            else if (txtUserName.Text == "")
                MessageBox.Show(" PLEASE ENTER USERNAME ........ !! ");

            else if (txtPassword.Text == "")
                MessageBox.Show(" PLEASE ENTER PASSWORD ........ !! ");

            else if (txtConfirm_Password.Text == "")
                MessageBox.Show(" PLEASE ENTER CONFIRM PASSWORD ........ !! ");

            #endregion

            else
            {
                s.Username = txtUserName.Text;
                s.Password = txtPassword.Text;
                s.Confirm_Password = txtConfirm_Password.Text;

                bool Success = sdal.SignUp_Check(s);
                if (Success == true)
                    MessageBox.Show(" REGISTRATION SUCCESSFUL....... !! ");

                else if (Success == false)
                    MessageBox.Show(" REGISTRATION FAILED ..... PLEASE TRY AGAIN ");

                Clear();
            }
        }

        public void Clear()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirm_Password.Text = "";
        }
    }
}
