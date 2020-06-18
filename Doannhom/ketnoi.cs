using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Doannhom
{
    public class ketnoi
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\hoc asp\Doannhom\Doannhom\App_Data\webbanhang.mdf;Integrated Security=True");
        private void layknoi()
        {
            connect.Open();
        }
        private void dongketnoi()
        {
            if (connect.State == ConnectionState.Open)
                connect.Close();
        }
        public DataTable laydata(string sql)
        {
            DataTable dt = new DataTable();

            layknoi();
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            da.Fill(dt);

            dongketnoi();
            return dt;
        }
        public int xuly(string sql)
        {
            int kq = 0;

            layknoi();
            SqlCommand cmd = new SqlCommand(sql, connect);
            kq = cmd.ExecuteNonQuery();

            dongketnoi();

            return kq;
        }
    }
}