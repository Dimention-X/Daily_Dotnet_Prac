using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class Student_DAL
    {
        public string connstr = "data source=localhost;database=Student;integrated Security=true";
        public Student_DAL()
        {

        }

        public int Insert(int SNO,string First_Name,string lastName,int Age)
        {
            
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = String.Format("Insert into student values("+SNO+",'"+First_Name+"','"+lastName + "',"+Age+")");
            cmd.CommandType = CommandType.Text;

            try
            {
                return cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
            }
        }

        public int update(int SNO, string FirstName, string lastName, int Age)
        {
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = String.Format("Update student set (SNO= " +SNO+ ", First_Name = '"+ FirstName + "',Last_Name ='" + lastName + "'," + Age + ") where SNO="+SNO+"");
            cmd.CommandType = CommandType.Text;
            try
            {
                return cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
            }

        }

        public int delete (int Sno)
        {
            SqlConnection con = new SqlConnection(connstr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = String.Format("delete from stundent where SNO=" + Sno + "");
            cmd.CommandType = CommandType.Text;
            try
            {
                return cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
                con.Dispose();
            }
        }

        public DataTable Load()
        {
            SqlConnection con = new SqlConnection(connstr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = String.Format("Select * from Student");
            cmd.CommandType = CommandType.Text;
           

            try
            {
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch
            {
                throw;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
                con.Dispose();
            }
        }
    }
}
