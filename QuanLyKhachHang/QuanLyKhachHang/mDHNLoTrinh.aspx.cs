using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace QuanLyKhachHang
{
    public partial class mDHNLoTrinh : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MaintainScrollPositionOnPostBack = true;
            if (IsPostBack)
                return;
            pgLoad();
        }
        void pgLoad()
        {
            txtNam.Text = DateTime.Now.Year.ToString();
            DataTable tb = Class.LinQConnectionDS.getDataTable("select May from NguoiDung where May is not null order by May asc");
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                cbMay.Items.Add(tb.Rows[i][0].ToString());
            }
        }

        void GetSoDocSO()
        {
            string sql = " SELECT  ds.Latitude as lat,ds.Longitude as lng,ds.DanhBa as DANHBO,ds.MLT1 as LOTRINH,kh.TenKH as HOTEN,(kh.So + ' ' +kh.Duong ) as DIACHI,ds.HieuCu  ";
            sql += " FROM DocSoSP01.dbo.DocSo ds , DocSoSP01.dbo.KhachHang kh   ";
            sql += " WHERE ds.Latitude is not null and ds.DanhBa= kh.DanhBa AND ds.Nam=" + txtNam.Text + " AND ds.Ky='" + cbKy.SelectedValue + "' AND ds.Dot='" + cbDot.SelectedValue + "' AND ds.May=" + cbMay.SelectedValue + " ORDER BY ds.MLT1 ASC";

            DataTable tb = Class.LinQConnectionDS.getDataTable(sql);


            string triangleCoords = "  [ ";
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                if (!"".Equals(tb.Rows[i]["lat"].ToString()))
                    triangleCoords += "{lat: " + tb.Rows[i]["lat"].ToString() + ", lng: " + tb.Rows[i]["lng"].ToString() + "},";
            }

            triangleCoords = triangleCoords.Remove(triangleCoords.Length - 1, 1) + " ]; ";

            Session["poy"] = triangleCoords;
            Session["dsBaoBe"] = tb;

        }

        protected void btXemBangKe_Click(object sender, EventArgs e)
        {
            GetSoDocSO();
        }
    }
}