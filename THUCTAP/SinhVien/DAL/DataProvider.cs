using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SinhVien.DAL
{
    class DataProvider
    {
        private static SqlConnection conn;

        public static SqlConnection Connect()
        {
            try
            {
                string sql = @"Data Source=DOQUANG\SQLSERVER;Initial Catalog=QUANLYDIEM;Integrated Security=True";
                SqlConnection conn = new SqlConnection(sql);
                conn.Open();

                return conn;
            }
            catch (SqlException)
            {
                return null;
            }
        }

        public static DataTable GetData(string proc)
        {
            try
            {
                conn = Connect();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(proc, conn);
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (SqlException)
            {
                conn.Close();
                return null;
            }
        }
        public static DataTable GetDatadk(string proc,SqlParameter [] para)
        {
            try
            {   //kết nối
                conn = Connect();
                //khởi tạo 1 datatable chứa dữ liệu
                DataTable dt = new DataTable();
                // command thực thi các thao tác với dữ liệu sql
                SqlCommand cmd = new SqlCommand(proc, conn);
                //kiểu thực thi,ở đây thủ tục
                cmd.CommandType = CommandType.StoredProcedure;
                    //add tham số
                if (para != null) 
                    cmd.Parameters.AddRange(para);
                
                //lấy dữ liệu thông qua command
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //đổ dữ liệu vào datatable
                da.Fill(dt);
                //đóng kết nối
                conn.Close();
                return dt;
            }
            catch (SqlException)
            {
                conn.Close();
                return null;
            }
        }
        public static int ExecuteNonQuery(string proc, SqlParameter[] para)
        {
            try
            {
                conn = Connect();
                SqlCommand cmd = new SqlCommand(proc,conn);
                cmd.CommandType = CommandType.StoredProcedure;
                if (para != null)
                    cmd.Parameters.AddRange(para);

                int val = cmd.ExecuteNonQuery();
                conn.Close();
                return val;
            }
            catch (SqlException)
            {
                return 0;
            }
        }

    }


}
