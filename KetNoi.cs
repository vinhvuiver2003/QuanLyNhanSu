
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien
{
    internal class KetNoi
    {
        SqlConnection conn;
        String sqlString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\quanlynhansu.mdf;Integrated Security=True;Connect Timeout=30";


        public KetNoi()
        {
            conn = new SqlConnection(sqlString);
        }
        public void opDB()
        {
            try
            {
                if (conn == null)
                {
                    throw new Exception("Lỗi khởi tạo kết nối.");
                }

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi mở kết nối: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        public void closeDB()
        {
            try
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đóng kết nối: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public int ExscutedNonQuerry(string sqlQuery, SqlParameter[] parameters)
        {
            int rowsAffected = 0;
            try
            {
                opDB();
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực thi câu lệnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                closeDB();
            }
            return rowsAffected;
        }

     
        public DataTable ExscutedQuerry(string sqlQuery, SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            try
            {
                opDB();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, conn);
                if (parameters != null)
                {
                    dataAdapter.SelectCommand.Parameters.AddRange(parameters);
                }
                dataAdapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực thi truy vấn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                closeDB();
            }
            return dt;
        }
    }

}
