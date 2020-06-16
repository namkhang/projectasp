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
    public partial class sanpham : System.Web.UI.Page
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\hoc asp\Doannhom\Doannhom\App_Data\webbanhang.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            string q;
            if (Context.Items["ml"] == null)
                q = "SELECT *FROM MATHANG";
            else
            {
                string maloai = Context.Items["ml"].ToString();
                q = "SELECT *FROM MATHANG WHERE maloai ='" + maloai + "'";
            }
            SqlDataAdapter da = new SqlDataAdapter(q, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.DataList1.DataSource = dt;
            this.DataList1.DataBind();

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            string mahang = ((LinkButton)sender).CommandArgument;
            Context.Items["mh"] = mahang;
            Server.Transfer("chitietsp.aspx");
        }
    }
}