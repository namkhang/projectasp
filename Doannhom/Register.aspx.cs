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
    public partial class Register : System.Web.UI.Page
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\hoc asp\Doannhom\Doannhom\App_Data\webbanhang.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ten = TextBox1.Text;
                string pass = TextBox2.Text;
                string query = "INSERT TAIKHOAN VALUES('" + ten + "','" + pass + "')";
                connect.Open();
                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.ExecuteNonQuery();
                connect.Close();
                Response.Redirect("Login.aspx");

            }
            catch(Exception)
            {
                Response.Write("<script>alert('Đăng ký không thành công');</script>");

            }

        }
    }
}