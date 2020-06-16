using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Doannhom
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\hoc asp\Doannhom\Doannhom\App_Data\webbanhang.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ten = TextBox1.Text;
            string matkhau = TextBox2.Text;
            string sql = "SELECT * FROM TAIKHOAN WHERE tendangnhap='" + ten + "' AND matkhau = '" + matkhau + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                Response.Cookies["tendangnhap"].Value = ten;
                Response.Write("<script>alert('Đăng nhập thành công');</script>");
                Server.Transfer("sanpham.aspx");
            }
            else
            {
                Response.Write("<script>alert('Account không tồn tại');</script>");
            }
        }
    }
}