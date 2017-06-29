using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace QuanLyKhachHang.View
{
    public partial class QuanLyMangLuoi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MaintainScrollPositionOnPostBack = true;
            if (IsPostBack)
                return;

            Session["thuadat"] = "0";
            Session["tuyenduong"] = "0";
            Session["tuyenong"] = "0";
            Session["dongho"] = "0";
            Session["iddma"] = "0";
            Session["dma"] = "0";
            pagLoad();
        }
        public void pagLoad()
        {
            DataTable table = new DataTable("TONGKETKINHPHI");
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("MADMA", typeof(string));
            DataRow myDataRow = table.NewRow();

            myDataRow["ID"] = 0;
            myDataRow["MADMA"] = "";

            table.Rows.Add(myDataRow);


            string sql = "SELECT DM.ID,REPLACE(REPLACE(KH.MADMA,'TH-',''),'-','.') AS DMA FROM CAPNUOCTANHOA.dbo.TB_DULIEUKHACHHANG KH, CAPNUOCTANHOA.dbo.GNKDT_THONGTINDMA DM WHERE KH.MADMA=DM.MADMA GROUP BY DM.ID,KH.MADMA ";
            DataTable tb2 = Class.C_KyThuat.getDataTable(sql);
            table.Merge(tb2);

            MaDMA.DataSource = table;
            MaDMA.DataValueField = "ID";
            MaDMA.DataTextField = "DMA";
            MaDMA.DataBind();
          
        }

        protected void ckThuaDat_CheckedChanged(object sender, EventArgs e)
        {
            if (ckThuaDat.Checked == true)
                Session["thuadat"] = "1";
            else
                Session["thuadat"] = "0";
        }

        protected void ckTuyenDuong_CheckedChanged(object sender, EventArgs e)
        {
            if (ckTuyenDuong.Checked == true)
                Session["tuyenduong"] = "1";
            else
                Session["tuyenduong"] = "0";

        }

        protected void ckTuyenOng_CheckedChanged(object sender, EventArgs e)
        {
            if (ckTuyenOng.Checked == true)
                Session["tuyenong"] = "1";
            else
                Session["tuyenong"] = "0";



        }

        protected void ckDongHo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckDongHo.Checked == true)
                Session["dongho"] = "1";
            else
                Session["dongho"] = "0";


        }

        protected void MaDMA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!MaDMA.SelectedValue.ToString().Equals("0"))
            {
                  Session["thuadat"] = "0";
                Session["tuyenduong"] = "0";
                Session["tuyenong"] = "0";
                Session["dongho"] = "0";
                Session["iddma"] = "0";
              

                Session["dma"] = "DMA " + MaDMA.SelectedItem.Text;
                Session["iddma"] = MaDMA.SelectedValue.ToString();
                try
                {
                    DataTable tb = Class.C_KyThuat.getDataTable("SELECT TOP(1) Lat,Long FROM DongHo where DMA='" + MaDMA.SelectedValue.ToString() + "'");
                    Session["lat"] = tb.Rows[0]["Lat"].ToString();
                    Session["lng"] = tb.Rows[0]["Long"].ToString();
                }
                catch (Exception)
                {

                }



            }
            else
            {
                Session["dma"] = "0";
            }
        }
    }
}