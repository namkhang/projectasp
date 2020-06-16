using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace Doannhom
{
    public partial class giohang : System.Web.UI.Page
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\hoc asp\Doannhom\Doannhom\App_Data\webbanhang.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            string q = "select DONHANG.mahang,tenhang,DONHANG.size,gia,soluong,"
            + "soluong*gia as thanhtien from DONHANG,MATHANG "
            + " where MATHANG.mahang = DONHANG.mahang";
            SqlDataAdapter da = new SqlDataAdapter(q, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.GridView1.DataSource = dt;
            this.GridView1.DataBind();
            double tong = 0;
             foreach (DataRow row in dt.Rows)
             {
                 double tien = Convert.ToDouble(row["thanhtien"]);
                tong += tien;
             }
             this.Label1.Text = "Tổng thành tiền: " + tong + " đồng";
        }
    }
}