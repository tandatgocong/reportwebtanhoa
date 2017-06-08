using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuanLyKhachHang.Class;
using System.Data;

namespace QuanLyKhachHang.View
{
    public partial class bbNhapThongTinBe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MaintainScrollPositionOnPostBack = true;
            if (IsPostBack)
                return;

            tungay.Text = Format.NgayVNVN(DateTime.Now.Date);
            denngay.Text = Format.NgayVNVN(DateTime.Now.Date);
            pagLoad();
            Panel2.Visible = false;
        }

        public void pagLoad()
        {
            if (Request.QueryString["u"] != null)
                Session["login"] = Request.QueryString["u"].ToString();
            else if (Session["login"] == null)
                Session["login"] = "callcenter";

            //DateTime tNgay = DateTime.ParseExact(tungay.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            //DateTime dNgay = DateTime.ParseExact(denngay.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

            string sql = " SELECT ROW_NUMBER() OVER (ORDER BY NgayBao  ASC) [STT],* FROM KT_BaoBe  ";
            sql += " WHERE CONVERT(DATE,NgayBao,103) BETWEEN CONVERT(DATE,'" + tungay.Text + "',103) AND CONVERT(DATE,'" + denngay.Text + "',103) ";
            //string sql = " SELECT * from KT_BaoBe  where CAST(GETDATE() as date) =  CAST(NgayBao as date)  ";
            
            DataTable tb = C_KyThuat.getDataTable(sql);
            Session["dsBaoBe"] = tb;
            if (chekHien.Checked == true)
            {
                gChuyen.DataSource = tb;
                gChuyen.DataBind();
            }
        }

        protected void btXemBangKe_Click(object sender, EventArgs e)
        {
            pagLoad();
        }

        protected void chekHien_CheckedChanged(object sender, EventArgs e)
        {
            if (chekHien.Checked == true)
            {
                Panel2.Visible = true;
                pagLoad();
            }
            else
            {
                Panel2.Visible = false;
            }
        }

        protected void btChuyen_Click(object sender, EventArgs e)
        {
            string listID = "";
            foreach (GridViewRow row in gChuyen.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkRow = (row.Cells[0].FindControl("chkRow") as CheckBox);
                    if (chkRow.Checked)
                    {
                         Label lbID = (row.Cells[1].FindControl("lbID") as Label);
                         listID += ("'" + lbID.Text + "',");
                    }
                }
            }
            Label1.Text = listID.Remove(listID.Length - 1, 1);
        }

        
    }
}