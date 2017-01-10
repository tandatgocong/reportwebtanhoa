using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing;

namespace QuanLyKhachHang.View
{
    public partial class GanMoi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!txtDiaChi.Text.Trim().Equals(""))
            { txtDiaChi.Focus(); }
            else if (!txtDienthoai.Text.Trim().Equals(""))
            { txtDienthoai.Focus(); }
            else if (!txtDanhBo.Text.Trim().Equals(""))
            { txtDanhBo.Focus(); }
            MaintainScrollPositionOnPostBack = true;
            if (IsPostBack)
                return;
            pSearch.Visible = false;
            pResult.Visible = false;
           
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "View")
            {

                string db = e.CommandArgument.ToString();
                Label1.Text = db;
                Result();
            }
        }
        protected void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            search();
        }
        protected void txtDienthoai_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        protected void txtDanhBo_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        protected void GridView1_RowCreated(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("onmouseover", "this.className='onmouseoverrow'");
                e.Row.Attributes.Add("onmouseout", "this.className='normalrow'");
            }
        }

        void search()
        {
            if (!txtDanhBo.Text.Trim().Equals(""))
            {
                Result();
            }
            else
            {
                DataTable tb = new DataTable();
                string sql = "SELECT DANHBO,HOTEN, (SONHA+' '+ TENDUONG) as DIACHI,DIENTHOAI FROM TB_DULIEUKHACHHANG ";
                if (!txtDiaChi.Text.Trim().Equals(""))
                {
                    sql += " WHERE (SONHA+' '+ TENDUONG) LIKE '" + txtDiaChi.Text.Replace("*", "%") + "' ORDER BY LOTRINH ASC ";
                }
                else if (!txtDienthoai.Text.Trim().Equals(""))
                {
                    sql += " WHERE DIENTHOAI LIKE '" + txtDienthoai.Text.Replace("*", "%") + "' ORDER BY LOTRINH ASC ";
                }

                tb = Class.LinQConnection.getDataTable(sql);
                GridView1.DataSource = tb;
                GridView1.DataBind();
                pSearch.Visible = true;
            }
        }
        
        void Result()
        {
            pSearch.Visible = false;
            pResult.Visible = true;
        
        }
        
       
    }
}