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
    public partial class Attendence_Form : Form
    {
        public Attendence_Form()
        {
            InitializeComponent();
        }

        private void Attendence_Form_Load(object sender, EventArgs e)
        {
            DataTable DT = ADal.Select();
            dgvAttendence_Form.DataSource = DT;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard D = new Dashboard();
            D.Show();
        }

        AttendenceBLL AB = new AttendenceBLL();
        AttendenceDal ADal = new AttendenceDal();

        private void btnInsert_Click(object sender, EventArgs e)
        {
            #region Throw Error

            if (txtAttendence_Id.Text == "" && txtFirstName.Text == "" && txtLastName.Text == "" && cmbAttendence.Text == "" && cmbRole.Text == "")
                MessageBox.Show(" PLEASE FILL ALL THE DETAILS.......... !! ");

            else if (txtFirstName.Text == "")
                MessageBox.Show(" PLEASE ENTER FIRSTNAME ....... !! ");

            else if (txtLastName.Text == "")
                MessageBox.Show(" PLEASE  ENTER LASTNAME ....... !! ");

            else if (cmbAttendence.Text == "")
                MessageBox.Show(" PLEASE SELECT ATTENDENCE PRESENT OR NOT ....... !! ");

            else if (cmbRole.Text == "")
                MessageBox.Show(" PLEASE SELECT ROLE STAFF OR USER ..... !! ");

            #endregion

            else
            {
                AB.FirstName = txtFirstName.Text;
                AB.LastName = txtLastName.Text;
                AB.Attendence = cmbAttendence.Text;
                AB.Attendence_Date = DateTime.Now;
                AB.Role = cmbRole.Text;
         
                bool Success = ADal.Insert(AB);
                if (Success == true)
                {
                    MessageBox.Show(" ATTENDENCE ENTRY SUCCESSFULLY INSERTED ...... ");
                    Clear();
                }

                else
                    MessageBox.Show(" ATTENDENCE ENTRY FAILED TO INSERTING PLEASE TRY AGAIN ......... !! ");

                DataTable DT = ADal.Select();
                dgvAttendence_Form.DataSource = DT;
            }
        }

        public void Clear()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            cmbAttendence.Text = "";
            cmbRole.Text = "";
            txtSearch.Text = "";
        }

        private void dgvAttendence_Form_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowsindex = e.RowIndex;
            txtAttendence_Id.Text = dgvAttendence_Form.Rows[rowsindex].Cells[0].Value.ToString();
            txtFirstName.Text = dgvAttendence_Form.Rows[rowsindex].Cells[1].Value.ToString();
            txtLastName.Text = dgvAttendence_Form.Rows[rowsindex].Cells[2].Value.ToString();
            cmbAttendence.Text = dgvAttendence_Form.Rows[rowsindex].Cells[3].Value.ToString();
            dtpAttendence_Date.Text = dgvAttendence_Form.Rows[rowsindex].Cells[4].Value.ToString();
            cmbRole.Text = dgvAttendence_Form.Rows[rowsindex].Cells[5].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            #region Throw Error

            if (txtAttendence_Id.Text == "" && txtFirstName.Text == "" && txtLastName.Text == "" && cmbAttendence.Text == "" && cmbRole.Text == "")
                MessageBox.Show(" PLEASE SELECT ROW IN DATAGRID-VIEW THEN UPDATE DATA !! ");

            #endregion

            else
            {
                AB.Attendence_id = Convert.ToInt32(txtAttendence_Id.Text.ToString());
                AB.FirstName = txtFirstName.Text;
                AB.LastName = txtLastName.Text;
                AB.Attendence = cmbAttendence.Text;
                AB.Attendence_Date = DateTime.Now;
                AB.Role = cmbRole.Text;

                bool Success = ADal.Update(AB);

                if (Success == true)
                {
                    MessageBox.Show(" ATTENDENCE ENTRY UPDATED SUCCESSFULLY ");
                    Clear();
                }

                else
                {
                    MessageBox.Show(" ATTENDENCE ENTRY FAILED TO UPDATED PLEASE TRY AGAIN ");
                }

                DataTable DT = ADal.Select();
                dgvAttendence_Form.DataSource = DT;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            #region Throw Error

            if (txtAttendence_Id.Text == "" && txtFirstName.Text == "" && txtLastName.Text == "" && cmbAttendence.Text == "" && cmbRole.Text == "")
                MessageBox.Show(" PLEASE SELECT ROW IN DATAGRID-VIEW THEN DELETE DATA !! ");

            #endregion

            else
            {
                AB.Attendence_id = Convert.ToInt32(txtAttendence_Id.Text);

                bool Success = ADal.Delete(AB);
                if (Success == true)
                {
                    MessageBox.Show(" ATTENDENCE ENTRY DELETED SUCCESSFULLY ");
                    Clear();
                }

                else
                    MessageBox.Show(" FAILED TO DELETE ATTENDENCE ENTRY  ");

                DataTable DT = ADal.Select();
                dgvAttendence_Form.DataSource = DT;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;
            if (keywords != null)
            {
                DataTable DT = ADal.Search(keywords);
                dgvAttendence_Form.DataSource = DT;
            }

            else
            {
                DataTable DT = ADal.Select();
                dgvAttendence_Form.DataSource = DT;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            cmbAttendence.Text = "";
            cmbRole.Text = "";
            txtSearch.Text = "";
        }

        private void dgvAttendence_Form_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void cmbAttendence_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpAttendence_Date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAttendence_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblAttendence_Date_Click(object sender, EventArgs e)
        {

        }

        private void lblAttend_Click(object sender, EventArgs e)
        {

        }

        private void lblLast_Name_Click(object sender, EventArgs e)
        {

        }

        private void lblFirst_Name_Click(object sender, EventArgs e)
        {

        }

        private void lblAttendence_Id_Click(object sender, EventArgs e)
        {

        }

        private void lblAttendence_Click(object sender, EventArgs e)
        {

        }
    }
}
