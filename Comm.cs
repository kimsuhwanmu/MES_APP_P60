using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
////using System.Media;

using System.Data.SqlClient;



namespace Comm
{
    public class DbConn
    {
        ////SqlConnection 개체를 반환하는 메서드.
        public static SqlConnection GetConn_unierp5()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Server=112.185.255.249;Database=unierp5;uid=sa;pwd=doha@#&%8ehgk";

            return new SqlConnection(conn.ConnectionString);
        }
        public static SqlConnection GetConn()
        {
            ////string msg1 = "";

            string @CONN_DB = "";
            string @CONN_INFO = "";

            DataTable dataT;
            dataT = new DataTable();

            SqlConnection conn = new SqlConnection();

            string sql = "";
            sql += " SELECT  TOP 1  ";
            sql += " RTRIM(UD_MINOR_NM) AS CONN_DB  ";
            sql += " ,  RTRIM(UD_REFERENCE) AS CONN_INFO  ";
            sql += " FROM B_USER_DEFINED_MINOR (nolock) ";
            sql += " WHERE 1=1  ";
            sql += " AND UD_MAJOR_CD = 'TPC01'   ";
            ////sql += " AND UD_MINOR_CD = '10'  ;  ";
            sql += " AND UD_MINOR_CD = 'DEV'  ;  ";
            SqlDataAdapter sda = new SqlDataAdapter(sql, Comm.DbConn.GetConn_unierp5());
            sda.Fill(dataT);

            try
            {
                if (dataT.Rows.Count > 0)
                {
                    @CONN_DB = dataT.Rows[0]["CONN_DB"].ToString().Trim();
                    @CONN_INFO = dataT.Rows[0]["CONN_INFO"].ToString().Trim();
                     
                    conn.ConnectionString = @CONN_INFO;
                }
            }
            catch (SqlException ex)
            {
                ////msg1 = ex.Message;
                ////MessageBox.Show(msg1);

                sda.Dispose();

                conn.ConnectionString = @"Server=112.185.255.249;Database=unierp5;uid=sa;pwd=doha@#&%8ehgk";
                return new SqlConnection(conn.ConnectionString);
            }
            finally
            { 
                sda.Dispose();
            } 

            return new SqlConnection(conn.ConnectionString);
        }



    } 

}
