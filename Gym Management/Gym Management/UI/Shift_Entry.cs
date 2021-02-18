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
    public partial class Shift_Entry : Form
    {
        public Shift_Entry()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard D = new Dashboard();
            D.Show();
            this.Hide();
        }

        Shift_EntryBLL S = new Shift_EntryBLL();
        Shift_EntryDal SDal = new Shift_EntryDal();

        private void Shift_Entry_Load(object sender, EventArgs e)
        {
            DataTable DT = SDal.Select();
            dgvShift_Entry.DataSource = DT;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            #region Throw Error

            if (txtShift_Id.Text == "" && txtFirst_Name.Text == "" && txtLast_Name.Text == "" && cmbRole.Text == "" && cmbType_Of_Shift.Text == "" && dtp_Shift_From_Date.Text == "" && dtp_Shift_To_Date.Text == "")
                MessageBox.Show(" PLEASE FILL ALL THE DETAILS.......... !! ");

            else if (txtFirst_Name.Text == "")
                MessageBox.Show(" PLEASE ENTER FIRSTNAME ....... !! ");

            else if (txtLast_Name.Text == "")
                MessageBox.Show(" PLEASE  ENTER LASTNAME ....... !! ");

            else if (cmbRole.Text == "")
                MessageBox.Show(" PLEASE SELECT ROLE STAFF OR USER ..... !! ");

            else if (cmbType_Of_Shift.Text == "")
                MessageBox.Show(" PLEASE SELECT TYPE OF SHIFT ...... !! ");

            #endregion

            else
            {
                S.FirstName = txtFirst_Name.Text;
                S.LastName = txtLast_Name.Text;
                S.Role = cmbRole.Text;
                S.TypeOfShift = cmbType_Of_Shift.Text;
                S.Shift_From = DateTime.Now;
                S.Shift_To = DateTime.Now;

                bool Success = SDal.Insert(S);
                if (Success == true)
                {
                    MessageBox.Show(" YOUR SHIFT ENTRY SUCCESSFULLY INSERTED ...... ");
                    Clear();
                }

                else
                    MessageBox.Show(" YOUR SHIFT ENTRY FAILED PLEASE TRY AGAIN ......... !! ");

                DataTable DT = SDal.Select();
                dgvShift_Entry.DataSource = DT;
            }
        }

            public void Clear()
            {
                txtShift_Id.Text = "";
                txtFirst_Name.Text = "";
                txtLast_Name.Text = "";
                cmbRole.Text = "";
                cmbType_Of_Shift.Text = "";
                txtSearch.Text = "";
            }

        private void dgvShift_Entry_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowsindex = e.RowIndex;
            txtShift_Id.Text = dgvShift_Entry.Rows[rowsindex].Cells[0].Value.ToString();
            txtFirst_Name.Text = dgvShift_Entry.Rows[rowsindex].Cells[1].Value.ToString();
            txtLast_Name.Text = dgvShift_Entry.Rows[rowsindex].Cells[2].Value.ToString();
            cmbRole.Text = dgvShift_Entry.Rows[rowsindex].Cells[3].Value.ToString();
            cmbType_Of_Shift.Text = dgvShift_Entry.Rows[rowsindex].Cells[4].Value.ToString();
            dtp_Shift_From_Date.Text = dgvShift_Entry.Rows[rowsindex].Cells[5].Value.ToString();
            dtp_Shift_To_Date.Text = dgvShift_Entry.Rows[rowsindex].Cells[6].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            #region Throw Error

            if (txtShift_Id.Text == "" && txtFirst_Name.Text == "" && txtLast_Name.Text == "" && cmbRole.Text == "" && cmbType_Of_Shift.Text == "")
                MessageBox.Show(" PLEASE SELECT ROW IN DATAGRID-VIEW THAN UPDATE DATA  !! ");

            #endregion

           else
            {
                S.Shift_id = Convert.ToInt32(txtShift_Id.Text.ToString());
                S.FirstName = txtFirst_Name.Text;
                S.LastName = txtLast_Name.Text;
                S.Role = cmbRole.Text;
                S.TypeOfShift = cmbType_Of_Shift.Text;
                S.Shift_From = DateTime.Now;
                S.Shift_To = DateTime.Now;

                bool Success = SDal.Update(S);

                if (Success == true)
                {
                    MessageBox.Show(" YOUR SHIFT ENTRY UPDATED SUCCESSFULLY ");
                    Clear();
                }

                else
                {
                    MessageBox.Show(" YOUR SHIFT ENTRY FAILED TO UPDATED ");
                }

                DataTable DT = SDal.Select();
                dgvShift_Entry.DataSource = DT;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            #region Throw Error

            if (txtShift_Id.Text == "" && txtFirst_Name.Text == "" && txtLast_Name.Text == "" && cmbRole.Text == "" && cmbType_Of_Shift.Text == "") 
                MessageBox.Show(" PLEASE SELECT ROW IN DATAGRID-View THEN DELETE DATA !! ");

            #endregion
            
            else
            {
                S.Shift_id = Convert.ToInt32(txtShift_Id.Text);

                bool Success = SDal.Delete(S);
                if (Success == true)
                {
                    MessageBox.Show(" SHIFT ENTRY DELETED SUCCESSFULLY ");
                    Clear();
                }

                else
                    MessageBox.Show(" FAILED TO DELETE SHIFT ENTRY  ");

                DataTable DT = SDal.Select();
                dgvShift_Entry.DataSource = DT;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;
            if (keywords != null)
            {
                DataTable DT = SDal.Search(keywords);
                dgvShift_Entry.DataSource = DT;
            }

            else
            {
                DataTable DT = SDal.Select();
                dgvShift_Entry.DataSource = DT;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtShift_Id.Text = "";
            txtFirst_Name.Text = "";
            txtLast_Name.Text = "";
            cmbRole.Text = "";
            cmbType_Of_Shift.Text = "";
            txtSearch.Text = "";
        }
    }
}
