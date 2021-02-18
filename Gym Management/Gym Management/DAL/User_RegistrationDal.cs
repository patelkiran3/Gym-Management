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
    class User_RegistrationDal
    {
        static string MyConnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Select Data From Database

        public DataTable Select()
        {
            SqlConnection CON = new SqlConnection(MyConnstrng);
            DataTable DT = new DataTable();

            try
            {
                string SQL = " Select * From tbl_User_Registration ";
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
        #region Insert Method For User_Registration Details

        public bool Insert(User_RegistrationBLL URB)
        {
            bool isSuccess = false;
            SqlConnection CON = new SqlConnection(MyConnstrng);

            try
            {
                String SQL = " INSERT Into tbl_User_Registration ( FirstName , LastName , Mobile , Email_ID , DateOfBirth , Address , Shift_Type , Package_Type , Trainer_Name ) Values ( @FirstName , @LastName , @Mobile , @Email_ID , @DateOfBirth , @Address , @Shift_Type , @Package_Type , @Trainer_Name) ";
                SqlCommand CMD = new SqlCommand(SQL, CON);

                CMD.Parameters.AddWithValue("@FirstName ", URB.FirstName);
                CMD.Parameters.AddWithValue("@LastName ", URB.LastName);
                CMD.Parameters.AddWithValue("@Mobile ", URB.Mobile);
                CMD.Parameters.AddWithValue("@Email_ID ", URB.Email_ID);
                CMD.Parameters.AddWithValue("@DateOfBirth ", URB.DateOfBirth);
                CMD.Parameters.AddWithValue("@Address ", URB.Address);
                CMD.Parameters.AddWithValue("@Shift_Type", URB.Shift_Type);
                CMD.Parameters.AddWithValue("@Package_Type", URB.Package_Type);
                CMD.Parameters.AddWithValue("@Trainer_Name", URB.Trainer_Name);

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
        #region Update Method For User_Registration Details

        public bool Update(User_RegistrationBLL URB)
        {
            bool isSuccess = false;
            SqlConnection CON = new SqlConnection(MyConnstrng);

            try
            {
                string SQL = " Update tbl_User_Registration SET FirstName = @FirstName , LastName = @LastName , Mobile = @Mobile , Email_ID = @Email_ID ,  DateOfBirth = @DateOfBirth , Address = @Address , Shift_Type = @Shift_Type , Package_Type = @Package_Type , Trainer_Name = @Trainer_Name WHERE User_id = @User_id ";
                SqlCommand CMD = new SqlCommand(SQL, CON);

                CMD.Parameters.AddWithValue("@FirstName ", URB.FirstName);
                CMD.Parameters.AddWithValue("@LastName ", URB.LastName);
                CMD.Parameters.AddWithValue("@Mobile ", URB.Mobile);
                CMD.Parameters.AddWithValue("@Email_ID ", URB.Email_ID);
                CMD.Parameters.AddWithValue("@DateOfBirth ", URB.DateOfBirth);
                CMD.Parameters.AddWithValue("@Address ", URB.Address);
                CMD.Parameters.AddWithValue("@Shift_Type", URB.Shift_Type);
                CMD.Parameters.AddWithValue("@Package_Type", URB.Package_Type);
                CMD.Parameters.AddWithValue("@Trainer_Name", URB.Trainer_Name);
                CMD.Parameters.AddWithValue("@User_id ", URB.User_id);

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
        #region Delete Method For User_Registrtion Details

        public bool Delete(User_RegistrationBLL URB)
        {
            bool isSuccess = false;
            SqlConnection CON = new SqlConnection(MyConnstrng);

            try
            {
                string SQL = " DELETE From tbl_User_Registration WHERE User_id = @User_id ";
                SqlCommand CMD = new SqlCommand(SQL, CON);

                CMD.Parameters.AddWithValue("@User_id ", URB.User_id);

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
                string SQL = " Select * From tbl_User_Registration WHERE User_id LIKE '%" + keywords + "%' OR FirstName LIKE '%" + keywords + "%' OR LastName LIKE '%" + keywords + "%'";
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
