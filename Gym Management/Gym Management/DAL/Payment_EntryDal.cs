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
    class Payment_EntryDal
    {
        static string MyConnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Select Data From Database

        public DataTable Select()
        {
            SqlConnection CON = new SqlConnection(MyConnstrng);
            DataTable DT = new DataTable();

            try
            {
                string SQL = " Select * From tbl_Payment ";
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
        #region Insert Method For Payment_Entry Details

        public bool Insert(Payment_EntryBLL P)
        {
            bool isSuccess = false;
            SqlConnection CON = new SqlConnection(MyConnstrng);

            try
            {
                String SQL = " INSERT Into tbl_Payment ( FirstName , LastName , Role , Payment_Type , Paid_Amount , Payment_Date , Payment_Due ) Values ( @FirstName , @LastName , @Role , @Payment_Type , @Paid_Amount , @Payment_Date , @Payment_Due) ";
                SqlCommand CMD = new SqlCommand(SQL, CON);

                CMD.Parameters.AddWithValue("@FirstName ", P.FirstName);
                CMD.Parameters.AddWithValue("@LastName ", P.LastName);
                CMD.Parameters.AddWithValue("@Role ", P.Role);
                CMD.Parameters.AddWithValue("@Payment_Type ", P.Payment_Type);
                CMD.Parameters.AddWithValue("@Paid_Amount ", P.Paid_Amount);
                CMD.Parameters.AddWithValue("@Payment_Date ", P.Payment_Date);
                CMD.Parameters.AddWithValue("@Payment_Due", P.Payment_Due);

                CON.Open();
                int rows = CMD.ExecuteNonQuery();
                if (rows > 0)
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
        #endregion
        #region Update Method For Payment_Entry Details

        public bool Update(Payment_EntryBLL P)
        {
            bool isSuccess = false;
            SqlConnection CON = new SqlConnection(MyConnstrng);

            try
            {
                string SQL = " Update tbl_Payment SET FirstName = @FirstName , LastName = @LastName , Role = @Role , Payment_Type = @Payment_Type ,  Paid_Amount = @Paid_Amount , Payment_Date = @Payment_Date , Payment_Due = @Payment_Due WHERE Payment_id = @Payment_id ";
                SqlCommand CMD = new SqlCommand(SQL, CON);

                CMD.Parameters.AddWithValue("@FirstName ", P.FirstName);
                CMD.Parameters.AddWithValue("@LastName ", P.LastName);
                CMD.Parameters.AddWithValue("@Role ", P.Role);
                CMD.Parameters.AddWithValue("@Payment_Type ", P.Payment_Type);
                CMD.Parameters.AddWithValue("@Paid_Amount ", P.Paid_Amount);
                CMD.Parameters.AddWithValue("@Payment_Date ", P.Payment_Date);
                CMD.Parameters.AddWithValue("@Payment_Due ", P.Payment_Due);
                CMD.Parameters.AddWithValue("@Payment_id ", P.Payment_id);

                CON.Open();
                int rows = CMD.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }

                else
                {
                    isSuccess = false;
                }
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
        #region Delete Method For Payment_Entry Details

        public bool Delete(Payment_EntryBLL P)
        {
            bool isSuccess = false;
            SqlConnection CON = new SqlConnection(MyConnstrng);

            try
            {
                string SQL = " DELETE From tbl_Payment WHERE Payment_id = @Payment_id ";
                SqlCommand CMD = new SqlCommand(SQL, CON);

                CMD.Parameters.AddWithValue("@Payment_id ", P.Payment_id);

                CON.Open();
                int rows = CMD.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }

                else
                {
                    isSuccess = false;
                }
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
        #region Search User On Databse UsingKeywords

        public DataTable Search(string keywords)
        {
            SqlConnection CON = new SqlConnection(MyConnstrng);
            DataTable DT = new DataTable();

            try
            {
                string SQL = " Select * From tbl_Payment WHERE Payment_id LIKE '%" + keywords + "%' OR FirstName LIKE '%" + keywords + "%' OR LastName LIKE '%" + keywords + "%'";
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
    }
}
