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
    public partial class Package_Entry : Form
    {
        public Package_Entry()
        {
            InitializeComponent();
        }

        Package_EntryBLL PB = new Package_EntryBLL();
        Package_EntryDal PDal = new Package_EntryDal();

        private void Package_Entry_Load(object sender, EventArgs e)
        {
            DataTable DT = PDal.Select();
            dgvPackage_Entry.DataSource = DT;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            #region Throw Error

            if (txtPackage_Id.Text == "" && txtPackage_Name.Text == "" && txtPackage_Amount.Text == "" && txtPackage_Duration.Text == "" && txtPackage_Description.Text == "")
                MessageBox.Show(" PLEASE FILL ALL THE DETAILS.......... !! ");

            else if (txtPackage_Name.Text == "")
                MessageBox.Show(" PLEASE ENTER PACKAGE NAME ....... !! ");

            else if (txtPackage_Amount.Text == "")
                MessageBox.Show(" PLEASE ENTER PACKAGE AMOUNT ....... !! ");

            else if (txtPackage_Duration.Text == "")
                MessageBox.Show(" PLEASE ENTER PACKAGE DURATION ..... !! ");

            else if (txtPackage_Description.Text == "")
                MessageBox.Show(" PLEASE ENTER PACKAGE DESCRIPTION ...... !! ");

            #endregion

            else
            {
                PB.Package_Name = txtPackage_Name.Text;
                PB.Package_Amount = Convert.ToInt32(txtPackage_Amount.Text);
                PB.Package_Duration = Convert.ToInt32(txtPackage_Duration.Text);
                PB.Package_Description = txtPackage_Description.Text;

                bool Success = PDal.Insert(PB);
                if (Success == true)
                {
                    MessageBox.Show(" PACKAGE ENTRY SUCCESSFULLY INSERTED ...... ");
                    Clear();
                }

                else
                    MessageBox.Show(" PACKAGE ENTRY FAILED PLEASE TRY AGAIN ......... !! ");

                DataTable DT = PDal.Select();
                dgvPackage_Entry.DataSource = DT;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard D = new Dashboard();
            D.Show();
            this.Hide();
        }

        public void Clear()
        {
            txtPackage_Id.Text = "";
            txtPackage_Name.Text = "";
            txtPackage_Amount.Text = "";
            txtPackage_Duration.Text = "";
            txtPackage_Description.Text = "";
            txtSearch.Text = "";
        }

        private void dgvPackage_Entry_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowsindex = e.RowIndex;
            txtPackage_Id.Text = dgvPackage_Entry.Rows[rowsindex].Cells[0].Value.ToString();
            txtPackage_Name.Text = dgvPackage_Entry.Rows[rowsindex].Cells[1].Value.ToString();
            txtPackage_Amount.Text = dgvPackage_Entry.Rows[rowsindex].Cells[2].Value.ToString();
            txtPackage_Duration.Text = dgvPackage_Entry.Rows[rowsindex].Cells[3].Value.ToString();
            txtPackage_Description.Text = dgvPackage_Entry.Rows[rowsindex].Cells[4].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            #region Throw Error

            if (txtPackage_Id.Text == "" && txtPackage_Name.Text == "" && txtPackage_Amount.Text == "" && txtPackage_Duration.Text == "" && txtPackage_Description.Text == "")
                MessageBox.Show(" PLEASE SELECT A ROW IN DATAGRID-VIEW IN DATA THEN UPDATE DATA !! ");

            #endregion

            else
            {
                PB.Package_id = Convert.ToInt32(txtPackage_Id.Text);
                PB.Package_Name = txtPackage_Name.Text;
                PB.Package_Amount = Convert.ToInt32(txtPackage_Amount.Text);
                PB.Package_Duration = Convert.ToInt32(txtPackage_Duration.Text);
                PB.Package_Description = txtPackage_Description.Text;

                bool Success = PDal.Update(PB);

                if (Success == true)
                {
                    MessageBox.Show(" PACKAGE ENTRY UPDATED SUCCESSFULLY ");
                    Clear();
                }

                else
                {
                    MessageBox.Show(" PACKAGE ENTRY FAILED TO UPDATED PLEASE TRY AGAIN ");
                }

                DataTable DT = PDal.Select();
                dgvPackage_Entry.DataSource = DT;
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            #region Throw Error

            if (txtPackage_Id.Text == "" && txtPackage_Name.Text == "" && txtPackage_Amount.Text == "" && txtPackage_Duration.Text == "" && txtPackage_Description.Text == "")
                MessageBox.Show(" PLEASE SELECT A ROW IN DATAGRID-VIEW IN DATA THEN DELETE DATA !! ");

            #endregion

            else
            {
                PB.Package_id = Convert.ToInt32(txtPackage_Id.Text);

                bool Success = PDal.Delete(PB);
                if (Success == true)
                {
                    MessageBox.Show(" PACKAGE ENTRY DELETED SUCCESSFULLY ");
                    Clear();
                }

                else
                    MessageBox.Show(" FAILED TO DELETE PACKAGE ENTRY  ");

                DataTable DT = PDal.Select();
                dgvPackage_Entry.DataSource = DT;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;
            if (keywords != null)
            {
                DataTable DT = PDal.Search(keywords);
                dgvPackage_Entry.DataSource = DT;
            }

            else
            {
                DataTable DT = PDal.Select();
                dgvPackage_Entry.DataSource = DT;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
