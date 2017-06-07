using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuanLyKhachHang.Class;

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
        }

        public void pagLoad()
        {
            if (Request.QueryString["u"] != null)
                Session["login"] = Request.QueryString["u"].ToString();
            else if (Session["login"] == null)
                Session["login"] = "callcenter";

            //DateTime tNgay = DateTime.ParseExact(tungay.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            //DateTime dNgay = DateTime.ParseExact(denngay.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

            string sql = " SELECT * FROM KT_BaoBe  ";
            sql += " WHERE CONVERT(DATE,NgayBao,103) BETWEEN CONVERT(DATE,'" + tungay.Text + "',103) AND CONVERT(DATE,'" + denngay.Text + "',103) ";
            //string sql = " SELECT * from KT_BaoBe  where CAST(GETDATE() as date) =  CAST(NgayBao as date)  ";
            Session["dsBaoBe"] = C_KyThuat.getDataTable(sql);

        }

        protected void btXemBangKe_Click(object sender, EventArgs e)
        {

        }

        protected void chekHien_CheckedChanged(object sender, EventArgs e)
        {
            if (chekHien.Checked == true)
                Panel2.Visible = true;
            else Panel2.Visible = false;
        }
    }
}