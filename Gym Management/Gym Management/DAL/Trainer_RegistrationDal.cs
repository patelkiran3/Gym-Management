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
    class Trainer_RegistrationDal
    {
        static string MyConnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Select Data From Database

        public DataTable Select()
        {
            SqlConnection CON = new SqlConnection(MyConnstrng);
            DataTable DT = new DataTable();

            try
            {
                string SQL = " Select * From tbl_Trainer_Registration ";
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
        #region Insert Method For Trainer_Registration Details

        public bool Insert(Trainer_RegistrationBLL TRB)
        {
            bool isSuccess = false;
            SqlConnection CON = new SqlConnection(MyConnstrng);

            try
            {
                String SQL = " INSERT Into tbl_Trainer_Registration ( Name , Mobile , Email_ID , DateOfBirth , Address , Shift_Type ) Values ( @Name , @Mobile , @Email_ID , @DateOfBirth , @Address , @Shift_Type) ";
                SqlCommand CMD = new SqlCommand(SQL, CON);

                CMD.Parameters.AddWithValue("@Name ", TRB.Name);
                CMD.Parameters.AddWithValue("@Mobile ", TRB.Mobile);
                CMD.Parameters.AddWithValue("@Email_ID ", TRB.Email_ID);
                CMD.Parameters.AddWithValue("@DateOfBirth ", TRB.DateOfBirth);
                CMD.Parameters.AddWithValue("@Address ", TRB.Address);
                CMD.Parameters.AddWithValue("@Shift_Type", TRB.Shift_Type);

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
        #region Update Method For Trainer_Registration Details

        public bool Update(Trainer_RegistrationBLL TRB)
        {
            bool isSuccess = false;
            SqlConnection CON = new SqlConnection(MyConnstrng);

            try
            {
                string SQL = " Update tbl_Trainer_Registration SET Name = @Name , Mobile = @Mobile , Email_ID = @Email_ID ,  DateOfBirth = @DateOfBirth , Address = @Address , Shift_Type = @Shift_Type  WHERE Trainer_id = @Trainer_id ";
                SqlCommand CMD = new SqlCommand(SQL, CON);

                CMD.Parameters.AddWithValue("@Name ", TRB.Name);
                CMD.Parameters.AddWithValue("@Mobile ", TRB.Mobile);
                CMD.Parameters.AddWithValue("@Email_ID ", TRB.Email_ID);
                CMD.Parameters.AddWithValue("@DateOfBirth ", TRB.DateOfBirth);
                CMD.Parameters.AddWithValue("@Address ", TRB.Address);
                CMD.Parameters.AddWithValue("@Shift_Type", TRB.Shift_Type);
                CMD.Parameters.AddWithValue("@Trainer_id ", TRB.Trainer_id);

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
        #region Delete Method For Trainer_Registration Details

        public bool Delete(Trainer_RegistrationBLL TRB)
        {
            bool isSuccess = false;
            SqlConnection CON = new SqlConnection(MyConnstrng);

            try
            {
                string SQL = " DELETE From tbl_Trainer_Registration WHERE Trainer_id = @Trainer_id ";
                SqlCommand CMD = new SqlCommand(SQL, CON);

                CMD.Parameters.AddWithValue("@Trainer_id ", TRB.Trainer_id);

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
                string SQL = " Select * From tbl_Trainer_Registration WHERE Trainer_id LIKE '%" + keywords + "%' OR Name LIKE '%" + keywords + "%'";
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
