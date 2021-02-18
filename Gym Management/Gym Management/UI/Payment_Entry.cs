﻿using Gym_Management.BLL;
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
    public partial class Payment_Entry : Form
    {
        public Payment_Entry()
        {
            InitializeComponent();
        }

        Payment_EntryBLL PB = new Payment_EntryBLL();
        Payment_EntryDal PDal = new Payment_EntryDal();
        private void btnInsert_Click(object sender, EventArgs e)
        {
            #region Throw Error

            if (txtPayment_Id.Text == "" && txtFirstName.Text == "" && txtLastName.Text == "" && cmbRole.Text == "" && cmbPayment_Type.Text == "" && txtPaid_Amount.Text == "")
                MessageBox.Show(" PLEASE FILL ALL THE DETAILS.......... !! ");

            else if (txtFirstName.Text == "")
                MessageBox.Show(" PLEASE ENTER FIRST NAME ....... !! ");

            else if (txtLastName.Text == "")
                MessageBox.Show(" PLEASE ENTER LAST NAME ....... !! ");

            else if (cmbRole.Text == "")
                MessageBox.Show(" PLEASE SELECT ROLE ..... !! ");

            else if (cmbPayment_Type.Text == "")
                MessageBox.Show(" PLEASE SELECT YOUR PAYMENT TYPE ...... !! ");

            else if (txtPaid_Amount.Text == "")
                MessageBox.Show(" PLEASE ENTER PAID AMOUNT ...... !! ");

            #endregion

            else
            {
                PB.FirstName = txtFirstName.Text;
                PB.LastName = txtLastName.Text;
                PB.Role = cmbRole.Text;
                PB.Payment_Type = cmbPayment_Type.Text;
                PB.Paid_Amount = Convert.ToInt32(txtPaid_Amount.Text);
                PB.Payment_Date = DateTime.Now;
                PB.Payment_Due = DateTime.Now;

                bool Success = PDal.Insert(PB);
                if (Success == true)
                {
                    MessageBox.Show(" PAYMENT ENTRY SUCCESSFULLY INSERTED ...... ");
                    Clear();
                }

                else
                    MessageBox.Show(" PAYMENT ENTRY FAILED PLEASE TRY AGAIN ......... !! ");

                DataTable DT = PDal.Select();
                dgvPayment_Entry.DataSource = DT;
            }
        }

        public void Clear()
        {
            txtPayment_Id.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            cmbRole.Text = "";
            cmbPayment_Type.Text = "";
            txtPaid_Amount.Text = "";
            txtSearch.Text = "";
        }

        private void Payment_Entry_Load(object sender, EventArgs e)
        {
            DataTable DT = PDal.Select();
            dgvPayment_Entry.DataSource = DT;
        }

        private void dgvPayment_Entry_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowsindex = e.RowIndex;
            txtPayment_Id.Text = dgvPayment_Entry.Rows[rowsindex].Cells[0].Value.ToString();
            txtFirstName.Text = dgvPayment_Entry.Rows[rowsindex].Cells[1].Value.ToString();
            txtLastName.Text = dgvPayment_Entry.Rows[rowsindex].Cells[2].Value.ToString();
            cmbRole.Text = dgvPayment_Entry.Rows[rowsindex].Cells[3].Value.ToString();
            cmbPayment_Type.Text = dgvPayment_Entry.Rows[rowsindex].Cells[4].Value.ToString();
            txtPaid_Amount.Text = dgvPayment_Entry.Rows[rowsindex].Cells[5].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            #region Throw Error

            if (txtPayment_Id.Text == "" && txtFirstName.Text == "" && txtLastName.Text == "" && cmbRole.Text == "" && cmbPayment_Type.Text == "" && txtPaid_Amount.Text == "")
                MessageBox.Show(" PLEASE SELECT A ROW IN DATAGRID-VIEW THEN UPDATE DATA ");

            #endregion

            else
            {
                PB.Payment_id = Convert.ToInt32(txtPayment_Id.Text);
                PB.FirstName = txtFirstName.Text;
                PB.LastName = txtLastName.Text;
                PB.Role = cmbRole.Text;
                PB.Payment_Type = cmbPayment_Type.Text;
                PB.Paid_Amount = Convert.ToInt32(txtPaid_Amount.Text);
                PB.Payment_Date = DateTime.Now;
                PB.Payment_Due = DateTime.Now;

                bool Success = PDal.Update(PB);

                if (Success == true)
                {
                    MessageBox.Show(" PAYMENT ENTRY UPDATED SUCCESSFULLY ");
                    Clear();
                }

                else
                {
                    MessageBox.Show(" PAYMENT ENTRY FAILED TO UPDATED PLEASE TRY AGAIN ");
                }

                DataTable DT = PDal.Select();
                dgvPayment_Entry.DataSource = DT;
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            #region Throw Error

            if (txtPayment_Id.Text == "" && txtFirstName.Text == "" && txtLastName.Text == "" && cmbRole.Text == "" && cmbPayment_Type.Text == "" && txtPaid_Amount.Text == "")
                MessageBox.Show(" PLEASE SELECT A ROW IN DATAGRID-VIEW THEN DELETE DATA ");

            #endregion

            else
            {
                PB.Payment_id = Convert.ToInt32(txtPayment_Id.Text);

                bool Success = PDal.Delete(PB);
                if (Success == true)
                {
                    MessageBox.Show(" PAYMENT ENTRY DELETED SUCCESSFULLY ");
                    Clear();
                }

                else
                    MessageBox.Show(" FAILED TO DELETE PAYMENT ENTRY  ");

                DataTable DT = PDal.Select();
                dgvPayment_Entry.DataSource = DT;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;
            if (keywords != null)
            {
                DataTable DT = PDal.Search(keywords);
                dgvPayment_Entry.DataSource = DT;
            }

            else
            {
                DataTable DT = PDal.Select();
                dgvPayment_Entry.DataSource = DT;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard D = new Dashboard();
            D.Show();
            this.Hide();
        }
    }
}