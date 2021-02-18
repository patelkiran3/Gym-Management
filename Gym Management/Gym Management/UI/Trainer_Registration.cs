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
    public partial class Trainer_Registration : Form
    {
        public Trainer_Registration()
        {
            InitializeComponent();
        }

        Trainer_RegistrationBLL TRB = new Trainer_RegistrationBLL();
        Trainer_RegistrationDal TDAL = new Trainer_RegistrationDal();
        Shift_EntryDal SDAL = new Shift_EntryDal();
        private void Trainer_Registration_Load(object sender, EventArgs e)
        {
            DataTable DT = TDAL.Select();
            dgvTrainer_Registration.DataSource = DT;
        }

        private void Pic_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard D = new Dashboard();
            D.Show();
            this.Hide();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            #region Throw Error

            if (txtTrainer_Id.Text == "" && txtName.Text == "" && txtMobile_No.Text == "" && txtEmail_Id.Text == "" && dtpBitrh_Date.Text == "" && txtAddress.Text == "" && cmbShift_Type.Text == "")
                MessageBox.Show(" Please Fills All The Details ");

            else if (txtName.Text == "")
                MessageBox.Show(" Please Enter Name ");

            else if (txtMobile_No.Text == "")
                MessageBox.Show(" Please Enter Mobile Number ");

            else if (txtEmail_Id.Text == "")
                MessageBox.Show(" Please Enter Email Id");

            else if (dtpBitrh_Date.Text == "")
                MessageBox.Show(" Please Select Date Of Birth ");

            else if (txtAddress.Text == "")
                MessageBox.Show(" Please Enter Address ");

            else if (cmbShift_Type.Text == "")
                MessageBox.Show(" Select Shift Type ");

            #endregion

            else
            {

                TRB.Name = txtName.Text;
                TRB.Mobile = txtMobile_No.Text;
                TRB.Email_ID = txtEmail_Id.Text;
                TRB.DateOfBirth = dtpBitrh_Date.Text;
                TRB.Address = txtAddress.Text;
                TRB.Shift_Type = cmbShift_Type.Text;
               

                bool Success = TDAL.Insert(TRB);
                if (Success == true)
                {
                    MessageBox.Show(" TRAINER REGISTRATION SUCCESSFULLY INSERTED ...... ");
                    Clear();
                }

                else
                    MessageBox.Show(" TRAINER REGISTRATION FAILED PLEASE TRY AGAIN ......... !! ");

                DataTable DT = TDAL.Select();
                dgvTrainer_Registration.DataSource = DT;
            }
        }

        public void Clear()
        {
            txtTrainer_Id.Text = "";
            txtName.Text = "";
            txtMobile_No.Text = "";
            txtEmail_Id.Text = "";
            dtpBitrh_Date.Text = "";
            txtAddress.Text = "";
            cmbShift_Type.Text = "";
            txtSearch.Text = "";
        }

        private void dgvTrainer_Registration_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowsindex = e.RowIndex;
            txtTrainer_Id.Text = dgvTrainer_Registration.Rows[rowsindex].Cells[0].Value.ToString();
            txtName.Text = dgvTrainer_Registration.Rows[rowsindex].Cells[1].Value.ToString();
            txtMobile_No.Text = dgvTrainer_Registration.Rows[rowsindex].Cells[2].Value.ToString();
            txtEmail_Id.Text = dgvTrainer_Registration.Rows[rowsindex].Cells[3].Value.ToString();
            dtpBitrh_Date.Text = dgvTrainer_Registration.Rows[rowsindex].Cells[4].Value.ToString();
            txtAddress.Text = dgvTrainer_Registration.Rows[rowsindex].Cells[5].Value.ToString();
            cmbShift_Type.Text = dgvTrainer_Registration.Rows[rowsindex].Cells[6].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            #region Throw Error

            if (txtTrainer_Id.Text == "" && txtName.Text == "" && txtMobile_No.Text == "" && txtEmail_Id.Text == "" && txtAddress.Text == "" && cmbShift_Type.Text == "")
                MessageBox.Show(" PLEASE SELECT A ROW IN DATAGRID-VIEW THEN UPDATE DATA ");

            #endregion

            else
            {
                TRB.Trainer_id = Convert.ToInt32(txtTrainer_Id.Text.ToString());
                TRB.Name = txtName.Text;
                TRB.Mobile = txtMobile_No.Text;
                TRB.Email_ID = txtEmail_Id.Text;
                TRB.DateOfBirth = dtpBitrh_Date.Text;
                TRB.Address = txtAddress.Text;
                TRB.Shift_Type = cmbShift_Type.Text;

                bool Success = TDAL.Update(TRB);

                if (Success == true)
                {
                    MessageBox.Show(" TRAINER REGISTRATION ENTRY UPDATED SUCCESSFULLY ");
                    Clear();
                }

                else
                {
                    MessageBox.Show(" TRAINER REGISTRATION ENTRY FAILED TO UPDATED PLEASE TRY AGAIN ");
                }

                DataTable DT = TDAL.Select();
                dgvTrainer_Registration.DataSource = DT;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            #region Throw Error

            if (txtTrainer_Id.Text == "" && txtName.Text == "" && txtMobile_No.Text == "" && txtEmail_Id.Text == "" && txtAddress.Text == "" && cmbShift_Type.Text == "")
                MessageBox.Show(" PLEASE SELECT A ROW IN DATAGRID-VIEW THEN DELETE DATA ");

            #endregion

            else
            {
                TRB.Trainer_id = Convert.ToInt32(txtTrainer_Id.Text);

                bool Success = TDAL.Delete(TRB);
                if (Success == true)
                {
                    MessageBox.Show(" TRAINER REGISTRATION ENTRY DELETED SUCCESSFULLY ");
                    Clear();
                }

                else
                    MessageBox.Show(" FAILED TO DELETE TRAINER REGISTRATION ENTRY  ");

                DataTable DT = TDAL.Select();
                dgvTrainer_Registration.DataSource = DT;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;
            if (keywords != null)
            {
                DataTable DT = TDAL.Search(keywords);
                dgvTrainer_Registration.DataSource = DT;
            }

            else
            {
                DataTable DT = TDAL.Select();
                dgvTrainer_Registration.DataSource = DT;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
