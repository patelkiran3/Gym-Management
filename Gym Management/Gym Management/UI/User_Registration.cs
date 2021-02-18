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

namespace Gym_Management
{
    public partial class User_Registration : Form
    {
        public User_Registration()
        {
            InitializeComponent();
        }

        Shift_EntryDal SED = new Shift_EntryDal();
        Package_EntryDal PED = new Package_EntryDal();
        Trainer_RegistrationDal TED = new Trainer_RegistrationDal();
        User_RegistrationBLL UR = new User_RegistrationBLL();
        User_RegistrationDal UDAL = new User_RegistrationDal();

        private void User_Registration_Load(object sender, EventArgs e)
        {
            DataTable PDT = PED.Select();
            cmbPackage_Type.DataSource = PDT;
            cmbPackage_Type.DisplayMember = "Package_Name";

            DataTable TDT = TED.Select();
            cmbTrainer_Name.DataSource = TDT;
            cmbTrainer_Name.DisplayMember = "Name";

            DataTable DT = UDAL.Select();
            dgvUser_Registration.DataSource = DT;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard D = new Dashboard();
            D.Show();
            this.Hide();
        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            #region Throw Error

            if (txtUser_Id.Text == "" && txtFirstName.Text == "" && txtLastName.Text == "" && txtMobile_No.Text == "" && txtEmail_Id.Text == "" && dtpBitrh_Date.Text == "" && txtAddress.Text == "" && cmbShift_Type.Text == "" && cmbPackage_Type.Text == "" && cmbTrainer_Name.Text == "")
                MessageBox.Show(" PLEASE FILL ALL THE DETAILS ");

            else if (txtFirstName.Text == "")
                MessageBox.Show(" PLEASE ENTER FIRST NAME ");

            else if (txtLastName.Text == "")
                MessageBox.Show(" PLEASE ENTER LAST NAME ");

            else if (txtMobile_No.Text == "")
                MessageBox.Show(" PLEASE ENTER MOBILE NUMBER ");

            else if (txtEmail_Id.Text == "")
                MessageBox.Show(" PLEASE ENTER EMAIL ID ");

            else if (dtpBitrh_Date.Text == "")
                MessageBox.Show(" PLEASE SELECT DATE OF BIRTH ");

            else if (txtAddress.Text == "")
                MessageBox.Show(" PLEASE ENTER ADDRESS ");

            else if (cmbShift_Type.Text == "")
                MessageBox.Show(" PLEASE SELECT SHIFT TYPE ");

            else if (cmbTrainer_Name.Text == "")
                MessageBox.Show(" PLEASE SELECT PACKAGE TYPE ");

            else if (cmbTrainer_Name.Text == "")
                MessageBox.Show(" PLEASE SELECT TRAINER NAME ");

            #endregion

            else
            {

                UR.FirstName = txtFirstName.Text;
                UR.LastName = txtLastName.Text;
                UR.Mobile = txtMobile_No.Text;
                UR.Email_ID = txtEmail_Id.Text;
                UR.DateOfBirth = Convert.ToDateTime(dtpBitrh_Date.Text);
                UR.Address = txtAddress.Text;
                UR.Shift_Type = cmbShift_Type.Text;
                UR.Package_Type = cmbPackage_Type.Text;
                UR.Trainer_Name = cmbTrainer_Name.Text;


                bool Success = UDAL.Insert(UR);
                if (Success == true)
                {
                    MessageBox.Show(" USER REGISTRATION SUCCESSFULLY INSERTED ...... ");
                    Clear();
                }

                else
                    MessageBox.Show(" USER REGISTRATION FAILED PLEASE TRY AGAIN ......... !! ");

                DataTable DT = UDAL.Select();
                dgvUser_Registration.DataSource = DT;
            }
        }

        public void Clear()
        {
            txtUser_Id.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtMobile_No.Text = "";
            txtEmail_Id.Text = "";
            dtpBitrh_Date.Text = "";
            txtAddress.Text = "";
            cmbShift_Type.Text = "";
            cmbPackage_Type.Text = "";
            cmbTrainer_Name.Text = "";
        }

        private void dgvUser_Registration_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowsindex = e.RowIndex;
            txtUser_Id.Text = dgvUser_Registration.Rows[rowsindex].Cells[0].Value.ToString();
            txtFirstName.Text = dgvUser_Registration.Rows[rowsindex].Cells[1].Value.ToString();
            txtLastName.Text = dgvUser_Registration.Rows[rowsindex].Cells[2].Value.ToString();
            txtMobile_No.Text = dgvUser_Registration.Rows[rowsindex].Cells[3].Value.ToString();
            txtEmail_Id.Text = dgvUser_Registration.Rows[rowsindex].Cells[4].Value.ToString();
            dtpBitrh_Date.Text = dgvUser_Registration.Rows[rowsindex].Cells[5].Value.ToString();
            txtAddress.Text = dgvUser_Registration.Rows[rowsindex].Cells[6].Value.ToString();
            cmbShift_Type.Text = dgvUser_Registration.Rows[rowsindex].Cells[7].Value.ToString();
            cmbPackage_Type.Text = dgvUser_Registration.Rows[rowsindex].Cells[8].Value.ToString();
            cmbTrainer_Name.Text = dgvUser_Registration.Rows[rowsindex].Cells[9].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            #region Throw Error

            if (txtUser_Id.Text == "" && txtFirstName.Text == "" && txtLastName.Text == "" && txtMobile_No.Text == "" && txtEmail_Id.Text == "" &&  txtAddress.Text == "" && cmbShift_Type.Text == "")
                MessageBox.Show(" PLEASE SELECT A ROW IN DATAGRID-VIEW THEN UPDATE DATE ");

            #endregion

            else
            {
                UR.User_id = Convert.ToInt32(txtUser_Id.Text.ToString());
                UR.FirstName = txtFirstName.Text;
                UR.LastName = txtLastName.Text;
                UR.Mobile = txtMobile_No.Text;
                UR.Email_ID = txtEmail_Id.Text;
                UR.DateOfBirth = Convert.ToDateTime(dtpBitrh_Date.Text);
                UR.Address = txtAddress.Text;
                UR.Shift_Type = cmbShift_Type.Text;
                UR.Package_Type = cmbPackage_Type.Text;
                UR.Trainer_Name = cmbTrainer_Name.Text;

                bool Success = UDAL.Update(UR);
                if (Success == true)
                {
                    MessageBox.Show(" USER REGISTRATION ENTRY UPDATED SUCCESSFULLY ");
                    Clear();
                }

                else
                {
                    MessageBox.Show(" USER REGISTRATION ENTRY FAILED TO UPDATED PLEASE TRY AGAIN ");
                }

                DataTable DT = UDAL.Select();
                dgvUser_Registration.DataSource = DT;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            #region Throw Error

            if (txtUser_Id.Text == "" && txtFirstName.Text == "" && txtLastName.Text == "" && txtMobile_No.Text == "" && txtEmail_Id.Text == "" && txtAddress.Text == "" && cmbShift_Type.Text == "")
                MessageBox.Show(" PLEASE SELECT A ROW IN DATAGRID-VIEW THEN DELETE DATE ");

            #endregion

            else
            {
                UR.User_id = Convert.ToInt32(txtUser_Id.Text);

                bool Success = UDAL.Delete(UR);
                if (Success == true)
                {
                    MessageBox.Show(" USER REGISTRATION ENTRY DELETED SUCCESSFULLY ");
                    Clear();
                }

                else
                    MessageBox.Show(" FAILED TO DELETE USER REGISTRATION ENTRY  ");

                DataTable DT = UDAL.Select();
                dgvUser_Registration.DataSource = DT;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;
            if (keywords != null)
            {
                DataTable DT = UDAL.Search(keywords);
                dgvUser_Registration.DataSource = DT;
            }

            else
            {
                DataTable DT = UDAL.Select();
                dgvUser_Registration.DataSource = DT;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
