using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppraisalDemo.Utilities
{
    public class SqlHelper
    {
        public static string ConStr { get; set; }
        public static DataTable ExecuteTable(string cmdTxt)
        {
            using (SqlConnection conn = new SqlConnection(ConStr))
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(cmdTxt,conn);
                SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return ds.Tables[0]; 
            }
        }

        public static int ExecuteNonQuery(string cmdTxt, params SqlParameter[] sqlParameters)
        {
            using(SqlConnection conn = new SqlConnection(ConStr))
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(cmdTxt,conn);
                sqlCommand.Parameters.AddRange(sqlParameters);
                int rows = sqlCommand.ExecuteNonQuery();
                if (rows<=0)
                {
                    throw new Exception("DataBase Operation Fails.");
                }
                return rows; 
            }
        }

    }
}
