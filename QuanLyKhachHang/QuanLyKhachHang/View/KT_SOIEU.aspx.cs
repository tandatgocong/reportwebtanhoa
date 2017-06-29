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
    public partial class KT_SOIEU : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session["page"] = "bbNhapThongTinBe.aspx";
            //if (Session["login"] == null)
            //{
            //    Response.Redirect(@"Login.aspx");
            //}
            //else if (("TOCNTT".Contains(Session["phong"].ToString())))
            //{

            //}
            //else if (!Session["phong"].ToString().Equals("GNKDT"))
            //{
            //     Response.Redirect(@"zphanquyen.aspx");
            //}

            MaintainScrollPositionOnPostBack = true;
            if (IsPostBack)
                return;

            
            pagLoad();
            Panel2.Visible = false;
            
        }

        public void pagLoad()//DM.ID,REPLACE(REPLACE(KH.MADMA,'TH-',''),'-','.')
        {
            string sql = "SELECT KH.MADMA AS DMA FROM CAPNUOCTANHOA.dbo.TB_DULIEUKHACHHANG KH, CAPNUOCTANHOA.dbo.GNKDT_THONGTINDMA DM WHERE KH.MADMA=DM.MADMA GROUP BY DM.ID,KH.MADMA ";
            DataTable tb2 = Class.C_KyThuat.getDataTable(sql);
            MaDMA.DataSource = tb2;
            MaDMA.DataValueField = "DMA";
            MaDMA.DataTextField = "DMA";
            MaDMA.DataBind();
             
             
        }

        protected void btXemBangKe_Click(object sender, EventArgs e)
        {
            string sql = " SELECT  DongHo.Lat as lat,DongHo.Long as lng, DANHBO,HOTEN,SONHA,TENDUONG FROM CAPNUOCTANHOA.dbo.TB_DULIEUKHACHHANG kh ";
            sql += " LEFt JOIN DongHo   ";
            sql += " ON kh.DANHBO= DongHo.DBDONGHONUOC ";
            sql += " WHERE  SUBSTRING(LOTRINH,1,2)='" + cbDot.SelectedValue + "' AND SUBSTRING(LOTRINH,3,2)='" + cbMay.SelectedValue + "' ORDER BY LOTRINH ASC ";
            DataTable tb = Class.C_KyThuat.getDataTable(sql);
            gChuyen.DataSource = tb;
            gChuyen.DataBind();

            string triangleCoords = "  [ ";
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                triangleCoords += "{lat: " + tb.Rows[i]["lat"].ToString() + ", lng: " + tb.Rows[i]["lng"].ToString() + "},";
            }

            triangleCoords = triangleCoords.Remove(triangleCoords.Length - 1, 1) + " ]; ";            

            Session["poy"] = triangleCoords;
            Session["dsBaoBe"] = tb;
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

        

        protected void MaDMA_SelectedIndexChanged(object sender, EventArgs e)
        {

            string dot = "SELECT  SUBSTRING(LOTRINH,1,2) as DOT FROM CAPNUOCTANHOA.dbo.TB_DULIEUKHACHHANG KH, CAPNUOCTANHOA.dbo.GNKDT_THONGTINDMA DM WHERE KH.MADMA=DM.MADMA AND  DM.MADMA='" + MaDMA.SelectedValue + "' GROUP BY SUBSTRING(LOTRINH,1,2)";
            cbDot.DataSource = Class.C_KyThuat.getDataTable(dot);
            cbDot.DataValueField = "DOT";
            cbDot.DataTextField = "DOT";
            cbDot.DataBind();
            cbDot_SelectedIndexChanged(sender, e);

        }

        protected void cbDot_SelectedIndexChanged(object sender, EventArgs e)
        {
            string may = "SELECT  SUBSTRING(LOTRINH,3,2) as MAY FROM CAPNUOCTANHOA.dbo.TB_DULIEUKHACHHANG KH, CAPNUOCTANHOA.dbo.GNKDT_THONGTINDMA DM WHERE KH.MADMA=DM.MADMA AND  DM.MADMA='" + MaDMA.SelectedValue + "' AND SUBSTRING(LOTRINH,1,2)= '" + cbDot.SelectedValue + "' GROUP BY SUBSTRING(LOTRINH,3,2) ";
            cbMay.DataSource = Class.C_KyThuat.getDataTable(may);
            cbMay.DataValueField = "MAY";
            cbMay.DataTextField = "MAY";
            cbMay.DataBind();
        }

        
    }
}