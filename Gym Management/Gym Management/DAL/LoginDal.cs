using Gym_Management.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management.DAL
{
    class LoginDal
    {
        static string MyConnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public bool LoginCheck(LoginBLL L)
        {
            bool isSuccess = false;
            SqlConnection CON = new SqlConnection(MyConnstrng);

            try
            {
                string SQL = " Select * From tbl_Login WHERE Username = @Username AND Password = @Password ";
                SqlCommand CMD = new SqlCommand(SQL, CON);

                CMD.Parameters.AddWithValue("@Username", L.Username);
                CMD.Parameters.AddWithValue("@Password", L.Password);

                SqlDataAdapter SDA = new SqlDataAdapter(CMD);
                DataTable DT = new DataTable();
                SDA.Fill(DT);

                if (DT.Rows.Count > 0)
                    isSuccess = true;

                else
                    isSuccess = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                CON.Close();
            }

            return isSuccess;
        }
    }
}
