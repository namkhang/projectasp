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
    public partial class chitietsp : System.Web.UI.Page
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\hoc asp\Doannhom\Doannhom\App_Data\webbanhang.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            string q;
            if (Context.Items["mh"] == null)
                q = "SELECT * FROM MATHANG";
            else
            {
                string mahang = Context.Items["mh"].ToString();
                q = "SELECT * FROM MATHANG WHERE mahang = '" + mahang + "'";
            }
            SqlDataAdapter da = new SqlDataAdapter(q, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.DataList1.DataSource = dt;
            this.DataList1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button mua = (Button)sender;
            string mahang = mua.CommandArgument.ToString();
            DataListItem item = (DataListItem)mua.Parent;
            string soluong = ((DropDownList)item.FindControl("DropDownList1")).Text;
            string size = ((DropDownList)item.FindControl("DropDownList2")).Text;
            if (Request.Cookies["tendangnhap"] == null) return;
            string ten = Request.Cookies["tendangnhap"].Value;
            connect.Open();
            string sql = "SELECT *FROM DONHANG WHERE tendangnhap ='" + ten + "' AND mahang='" + mahang + "'";
            SqlCommand cmd = new SqlCommand(sql, connect);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                cmd = new SqlCommand("UPDATE DONHANG SET soluong=soluong+ " + soluong + "WHERE tendangnhap ='" + ten + "'AND mahang='" + mahang + "'", connect);

            }
            else
            {
                reader.Close();
                cmd = new SqlCommand("INSERT INTO DONHANG " + "(tendangnhap,mahang,soluong,size) VALUES('" + ten + "','" + mahang + "','" + soluong + "','" + size + "')", connect);
            }
            cmd.ExecuteNonQuery();
            connect.Close();

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Server.Transfer("giohang.aspx");
        }
    }
}