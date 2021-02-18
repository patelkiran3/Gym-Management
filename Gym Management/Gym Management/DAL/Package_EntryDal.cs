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
    class Package_EntryDal
    {
        static string MyConnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Select Data From Database

        public DataTable Select()
        {
            SqlConnection CON = new SqlConnection(MyConnstrng);
            DataTable DT = new DataTable();

            try
            {
                string SQL = " Select * From tbl_Package ";
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
        #region Insert Method For Package_Entry Details

        public bool Insert(Package_EntryBLL P)
        {
            bool isSuccess = false;
            SqlConnection CON = new SqlConnection(MyConnstrng);

            try
            {
                String SQL = " INSERT Into tbl_Package ( Package_Name , Package_Amount , Package_Duration , Package_Description ) Values ( @Package_Name , @Package_Amount , @Package_Duration , @Package_Description) ";
                SqlCommand CMD = new SqlCommand(SQL, CON);

                CMD.Parameters.AddWithValue("@Package_Name ", P.Package_Name);
                CMD.Parameters.AddWithValue("@Package_Amount ", P.Package_Amount);
                CMD.Parameters.AddWithValue("@Package_Duration ", P.Package_Duration);
                CMD.Parameters.AddWithValue("@Package_Description ", P.Package_Description);

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
        #region Update Method For Package_Entry Details

        public bool Update(Package_EntryBLL P)
        {
            bool isSuccess = false;
            SqlConnection CON = new SqlConnection(MyConnstrng);

            try
            {
                string SQL = " Update tbl_Package SET Package_Name = @Package_Name , Package_Amount = @Package_Amount , Package_Duration = @Package_Duration , Package_Description = @Package_Description  WHERE Package_id = @Package_id ";
                SqlCommand CMD = new SqlCommand(SQL, CON);

                CMD.Parameters.AddWithValue("@Package_Name ", P.Package_Name);
                CMD.Parameters.AddWithValue("@Package_Amount ", P.Package_Amount );
                CMD.Parameters.AddWithValue("@Package_Duration ", P.Package_Duration );
                CMD.Parameters.AddWithValue("@Package_Description ", P.Package_Description);
                CMD.Parameters.AddWithValue("@Package_id ", P.Package_id);

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
        #region Delete Method For Package_Entry Details

        public bool Delete(Package_EntryBLL P)
        {
            bool isSuccess = false;
            SqlConnection CON = new SqlConnection(MyConnstrng);

            try
            {
                string SQL = " DELETE From tbl_Package WHERE Package_id = @Package_id ";
                SqlCommand CMD = new SqlCommand(SQL, CON);

                CMD.Parameters.AddWithValue("@Package_id ", P.Package_id);

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
                string SQL = " Select * From tbl_Package WHERE Package_id LIKE '%" + keywords + "%' OR Package_Name LIKE '%" + keywords + "%' OR Package_Amount LIKE '%" + keywords + "%'";
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
