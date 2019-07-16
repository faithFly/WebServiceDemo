using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebDemo2
{
    public class DBHelper
    {
        public static SqlConnection conn = new SqlConnection("Data Source=FAITH-PC;Initial Catalog=DoNetTest;Integrated Security=True");
        //查询
        public static DataTable GetTable(string sql) {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
                dap.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        
        }
        //增删改
        public static bool Updata(string sql)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                int rows = cmd.ExecuteNonQuery();
                conn.Close();
                return rows > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}