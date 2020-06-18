using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Doannhom
{
    public partial class Admin : System.Web.UI.Page
    {
        ketnoi kn = new ketnoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                GridView1.DataSource = kn.laydata("SELECT * FROM LOAIHANG");
                GridView1.DataBind();
                GridView2.DataSource = kn.laydata("SELECT * FROM MATHANG");
                GridView2.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox TextBox1 = (TextBox)GridView1.FooterRow.FindControl("TextBox1");
            TextBox TextBox2 = (TextBox)GridView1.FooterRow.FindControl("TextBox2");
            string maloai = TextBox1.Text;
            string tenloai = TextBox2.Text;
            int kq = kn.xuly("insert into LOAIHANG values ('" + maloai + "', '" + tenloai +
            "')");
            if (kq > 0)
            {
                Response.Write("<script>alert('Thêm thành công');</script>");
                GridView1.DataSource = kn.laydata("SELECT * FROM LOAIHANG");
                GridView1.DataBind();
            }
            else
            {
                Response.Write("<script>alert('Thêm không thanh công');</script>");
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string maloai = e.Values["maloai"].ToString();

            int kq = kn.xuly("DELETE LOAIHANG WHERE maloai = '" + maloai + "'");
            if (kq > 0)
            {
                Response.Write("<script>alert('Xóa thành công');</script>");
                GridView1.DataSource = kn.laydata("SELECT * FROM LOAIHANG");
                GridView1.DataBind();
            }
            else
            {
                Response.Write("<script>alert('Xóa không thanh công');</script>");
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = kn.laydata("SELECT * FROM LOAIHANG");
            GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string maloai = e.NewValues["maloai"].ToString();
            string tenloai = e.NewValues["tenloai"].ToString();
            int kq = kn.xuly("UPDATE LOAIHANG SET tenloai='" + tenloai + "' WHERE maloai='" + maloai + "'");

            if (kq > 0)
            {
                Response.Write("<script>alert('Cập nhật thành công');</script>");
                GridView1.DataSource = kn.laydata("SELECT * FROM LOAIHANG");
                GridView1.EditIndex = -1;
                GridView1.DataBind();
            }
            else
            {
                Response.Write("<script>alert('Cập nhật không thành công');</script>");
            }
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GridView1.DataSource = kn.laydata("SELECT * FROM LOAIHANG");
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox TextBox3 = (TextBox)GridView2.FooterRow.FindControl("TextBox3");
            TextBox TextBox4 = (TextBox)GridView2.FooterRow.FindControl("TextBox4");
            TextBox TextBox5 = (TextBox)GridView2.FooterRow.FindControl("TextBox5");
            TextBox TextBox6 = (TextBox)GridView2.FooterRow.FindControl("TextBox6");
            TextBox TextBox7 = (TextBox)GridView2.FooterRow.FindControl("TextBox7");
            TextBox TextBox8 = (TextBox)GridView2.FooterRow.FindControl("TextBox8");
            TextBox TextBox9 = (TextBox)GridView2.FooterRow.FindControl("TextBox9");
            string mahang = TextBox3.Text;
            string tenhang = TextBox4.Text;
            string mota = TextBox5.Text;
            string gia = TextBox6.Text;
            string maloai = TextBox7.Text;
            string hinh = TextBox8.Text;
            string size = TextBox9.Text;
            int kq = kn.xuly("insert into MATHANG values ('" + mahang + "', N'" + tenhang + "', N'" + mota + "', '" + gia + "', '" + maloai + "', '" + hinh + "', '" + size + "')");
           
    
                if (kq > 0)
                {
                    Response.Write("<script>alert('Thêm thành công');</script>");
                    GridView2.DataSource = kn.laydata("SELECT * FROM MATHANG");
                    GridView2.DataBind();
                }
                else
                {
                    Response.Write("<script>alert('Thêm không thanh công');</script>");
                }
            
           
        }

        protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string mahang = e.Values["mahang"].ToString();

            int kq = kn.xuly("DELETE MATHANG WHERE mahang = '" + mahang + "'");
            if (kq > 0)
            {
                Response.Write("<script>alert('Xóa thành công');</script>");
                GridView2.DataSource = kn.laydata("SELECT * FROM MATHANG");
                GridView2.DataBind();
            }
            else
            {
                Response.Write("<script>alert('Xóa không thanh công');</script>");
            }
        }

        protected void GridView2_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView2.EditIndex = e.NewEditIndex;
            GridView2.DataSource = kn.laydata("SELECT * FROM MATHANG");
            GridView2.DataBind();
        }

        protected void GridView2_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView2.EditIndex = -1;
            GridView2.DataSource = kn.laydata("SELECT * FROM MATHANG");
            GridView2.DataBind();

        }

        protected void GridView2_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string mahang = e.NewValues["mahang"].ToString();
            string tenhang = e.NewValues["tenhang"].ToString();
            string mota = e.NewValues["mota"].ToString();
            string gia = e.NewValues["gia"].ToString();
            string maloai = e.NewValues["maloai"].ToString();
            string hinh = e.NewValues["hinh"].ToString();
            string size = e.NewValues["size"].ToString();

            int kq = kn.xuly("UPDATE MATHANG SET tenhang=N'" + tenhang + "' ,mota=N'" + mota + "',gia='" + gia + "',maloai='" + maloai + "',hinh='" + hinh + "',size='" + size + "' WHERE mahang='" + mahang + "'");


            if (kq > 0)
            {
                Response.Write("<script>alert('Cập nhật thành công');</script>");
                GridView2.DataSource = kn.laydata("SELECT * FROM MATHANG");
                GridView2.EditIndex = -1;
                GridView2.DataBind();
            }
            else
            {
                Response.Write("<script>alert('Cập nhật không thành công');</script>");
            }  
            
        }
    }
}