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
    class SignUpDal
    {
        static string MyConnStrng = ConfigurationManager.ConnectionStrings["Connstrng"].ConnectionString;

        #region Select Data From Database

        public DataTable Select()
        {
            SqlConnection CON = new SqlConnection(MyConnStrng);
            DataTable DT = new DataTable();

            try
            {
                string SQL = " Select * From tbl_Login ";
                SqlCommand CMD = new SqlCommand(SQL, CON);
                SqlDataAdapter ADAPTER = new SqlDataAdapter(CMD);
                CON.Open();
                ADAPTER.Fill(DT);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                CON.Close();
            }

            return DT;
        }
        #endregion
        #region Insert Data in Databse

        public bool SignUp_Check(SignUp S)
        {
            bool isSuccess = false;
            SqlConnection CON = new SqlConnection(MyConnStrng);

            try
            {
                String SQL = " INSERT Into tbl_Login ( Username , Password , Confirm_Password ) Values ( @Username , @Password , @Confirm_Password ) ";
                SqlCommand CMD = new SqlCommand(SQL, CON);

                CMD.Parameters.AddWithValue("@Username ", S.Username);
                CMD.Parameters.AddWithValue("@Password ", S.Password);
                CMD.Parameters.AddWithValue("@Confirm_Password ", S.Confirm_Password);

                CON.Open();
                if (S.Confirm_Password == S.Password)
                {
                    isSuccess = true;
                    SqlDataAdapter SDA = new SqlDataAdapter(CMD);
                    DataTable DT = new DataTable();
                    SDA.Fill(DT);
                }

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
        #endregion
    }
}
