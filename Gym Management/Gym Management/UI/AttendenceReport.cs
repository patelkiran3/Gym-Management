using Gym_Management.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management.UI
{
    public partial class AttendenceReport : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-473917O\YOURFATHER;Initial Catalog=GymManagementSystem;Integrated Security=True");
        public AttendenceReport()
        {
            InitializeComponent();
         
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            CrystalReport1 cr = new CrystalReport1();
            string sql = "SELECT * FROM tbl_Attendence Where Attendence_id = '"+textBox1.Text+"'";
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            sda.Fill(ds, "CrystalReport1");
            cr.SetDataSource(ds.Tables["CrystalReport1"]);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();
        }

        private void AttendenceReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }
    }
}
