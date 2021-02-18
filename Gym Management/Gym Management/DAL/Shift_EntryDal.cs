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
    class Shift_EntryDal
    {
        static string MyConnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Select Data From Database

        public DataTable Select()
        {
            SqlConnection CON = new SqlConnection(MyConnstrng);
            DataTable DT = new DataTable();

            try
            {
                string SQL = " Select * From tbl_Shift ";
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
        #region Insert Method For Shift_Entry Details

        public bool Insert(Shift_EntryBLL S)
        {
            bool isSuccess = false;
            SqlConnection CON = new SqlConnection(MyConnstrng);

            try
            {
                String SQL = " INSERT Into tbl_Shift ( FirstName , LastName , Role , TypeOfShift , Shift_From , Shift_To ) Values ( @FirstName , @LastName , @Role , @TypeOfShift , @Shift_From , @Shift_To) ";
                SqlCommand CMD = new SqlCommand(SQL, CON);

                CMD.Parameters.AddWithValue("@FirstName ", S.FirstName);
                CMD.Parameters.AddWithValue("@LastName ", S.LastName);
                CMD.Parameters.AddWithValue("@Role ", S.Role);
                CMD.Parameters.AddWithValue("@TypeOfShift ", S.TypeOfShift);
                CMD.Parameters.AddWithValue("@Shift_From ", S.Shift_From);
                CMD.Parameters.AddWithValue("@Shift_To ", S.Shift_To);

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
        #region Update Method For Shift_Entry Details

        public bool Update(Shift_EntryBLL S)
        {
            bool isSuccess = false;
            SqlConnection CON = new SqlConnection(MyConnstrng);

            try
            {
                string SQL = " Update tbl_Shift SET FirstName = @FirstName , LastName = @LastName , Role = @Role , TypeOfShift= @TypeOfShift , Shift_From = @Shift_From , Shift_To = @Shift_To WHERE Shift_id = @Shift_id ";
                SqlCommand CMD = new SqlCommand(SQL, CON);

                CMD.Parameters.AddWithValue("@FirstName ", S.FirstName);
                CMD.Parameters.AddWithValue("@LastName ", S.LastName);
                CMD.Parameters.AddWithValue("@Role ", S.Role);
                CMD.Parameters.AddWithValue("@TypeOfShift ", S.TypeOfShift);
                CMD.Parameters.AddWithValue("@Shift_From ", S.Shift_From);
                CMD.Parameters.AddWithValue("@Shift_To ", S.Shift_To);
                CMD.Parameters.AddWithValue("@Shift_id ", S.Shift_id);

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
        #region Delete Method For Shift_Entry Details

        public bool Delete(Shift_EntryBLL S)
        {
            bool isSuccess = false;
            SqlConnection CON = new SqlConnection(MyConnstrng);

            try
            {
                string SQL = " DELETE From tbl_Shift WHERE Shift_id = @Shift_id ";
                SqlCommand CMD = new SqlCommand(SQL, CON);

                CMD.Parameters.AddWithValue("@Shift_id ", S.Shift_id);

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
                string SQL = " Select * From tbl_Shift WHERE Shift_id LIKE '%" + keywords + "%' OR FirstName LIKE '%" + keywords + "%' OR LastName LIKE '%" + keywords + "%'";
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
