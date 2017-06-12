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
            Session["page"] = "bbNhapThongTinBe.aspx";
            if (Session["login"] == null)
            {
                Response.Redirect(@"Login.aspx");
            }
            else if (("TOCNTT".Contains(Session["phong"].ToString())))
            {

            }
            else if (!Session["phong"].ToString().Equals("GNKDT"))
            {
                 Response.Redirect(@"zphanquyen.aspx");
            }

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
            //DateTime tNgay = DateTime.ParseExact(tungay.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            //DateTime dNgay = DateTime.ParseExact(denngay.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            string sql = " SELECT * FROM W_BAOBE  ";
            sql += " WHERE CONVERT(DATE,NgayBao,103) BETWEEN CONVERT(DATE,'" + tungay.Text + "',103) AND CONVERT(DATE,'" + denngay.Text + "',103) ";
            //string sql = " SELECT * from KT_BaoBe  where CAST(GETDATE() as date) =  CAST(NgayBao as date)  ";
            
            DataTable tb = C_KyThuat.getDataTable(sql);
            Session["dsBaoBe"] = tb;
            if (chekHien.Checked == true)
            {
                gChuyen.DataSource = tb;
                gChuyen.DataBind();
            }

            cbDonViSuaBe.DataSource = C_KyThuat.getDataTable("SELECT * FROM KT_DonViSuaBe");
            cbDonViSuaBe.DataValueField = "MaDonVi";
            cbDonViSuaBe.DataTextField = "TenDonVi";
            cbDonViSuaBe.DataBind();
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
           // Label1.Text = listID.Remove(listID.Length - 1, 1);

            string sql = "UPDATE KT_BaoBe SET SoBangKe='" + this.TextBox1.Text + "', DonViSuaBe='" + cbDonViSuaBe.SelectedValue.ToString() + "',NgayChuyenSuaBe=GETDATE() WHERE ID IN (" + listID.Remove(listID.Length - 1, 1) + ")";
            C_KyThuat.ExecuteCommand(sql);
            pagLoad();
        }

        
    }
}