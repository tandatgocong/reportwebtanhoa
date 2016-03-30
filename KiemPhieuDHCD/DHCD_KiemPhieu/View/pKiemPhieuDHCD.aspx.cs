using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DHCD_KiemPhieu.View
{
    public partial class pKiemPhieuDHCD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            MaintainScrollPositionOnPostBack = true;
            if (IsPostBack)
                return;
            Binddata();
            this.txtCoDong.Text = "";
            this.tungay.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
        }
        private void Binddata()
        {
            LoadDongY();
            LoadKhongDongY();
        }




        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Binddata();
        }

        public void LoadDongY()
        {
            string sql = " SELECT ROW_NUMBER() OVER (ORDER BY STTCD  ASC) [STT],STTCD, MACD, TENCD, CMND, NGAYCAP, NOICAP, DIACHI, CDGD, PHONGTOA, TONGCD ";
            sql += " FROM DSCODONG_THAMDU ";
            sql += " WHERE MACD NOT IN (SELECT MACD FROM KIEMPHIEU WHERE LANBQ= " + DropDownList1.SelectedValue.ToString() + " AND CONVERT(VARCHAR(50),NGAYBQ,103)='" + this.tungay.Text + "' ) ";

            DataTable dt = Class.LinQConnection.getDataTable(sql);
            G_DY.DataSource = dt;
            G_DY.DataBind();


            dy_sl.Text = "0";
            dy_cp.Text = "0";
            dy_tl.Text = "0";

            try
            {
                double sum = Convert.ToDouble(dt.Compute("SUM(TONGCD)", string.Empty));
                dy_sl.Text = String.Format("{0:0,0}", dt.Rows.Count);
                dy_cp.Text = String.Format("{0:0,0}", sum);

                double tl = sum / Class.LinQConnection.ReturnResult("SELECT SUM(TONGCD) FROM DSCODONG_THAMDU");
                dy_tl.Text = String.Format("{0:0.##}", tl * 100) + "%";
            }
            catch (Exception)
            {
               
            }
            

        }
        public void LoadKhongDongY()
        {

            string sql = " SELECT kp.ID, ROW_NUMBER() OVER (ORDER BY CREATEDATE  desc) [STT],cd.STTCD, cd.MACD, TENCD, CMND, NGAYCAP, NOICAP, DIACHI, CDGD, PHONGTOA, cd.TONGCD";
            sql += " FROM DSCODONG_THAMDU cd, KIEMPHIEU kp ";
            sql += " WHERE cd.MACD=kp.MACD AND LANBQ= " + DropDownList1.SelectedValue.ToString() + " AND CONVERT(VARCHAR(50),NGAYBQ,103)='" + this.tungay.Text + "'  ";

            DataTable dt = Class.LinQConnection.getDataTable(sql);
            G_KDY.DataSource = dt;
            G_KDY.DataBind();

            kdy_sl.Text = "0";
            kdy_cp.Text = "0";
            kdy_tl.Text = "0";

            try
            {

                double sum = Convert.ToDouble(dt.Compute("SUM(TONGCD)", string.Empty));
                kdy_sl.Text = String.Format("{0:0,0}", dt.Rows.Count);
                kdy_cp.Text = String.Format("{0:0,0}", sum);

                double tl = sum / Class.LinQConnection.ReturnResult("SELECT SUM(TONGCD) FROM DSCODONG_THAMDU");
                kdy_tl.Text = String.Format("{0:0.##}", tl * 100) + "%";
            }
            catch (Exception)
            {


            }
        }

        protected void btCapNhat2_Click(object sender, EventArgs e)
        {
        }

        protected void G_KDY_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            Class.LinQConnection.ExecuteCommand("DELETE FROM KIEMPHIEU WHERE ID='" + e.CommandArgument.ToString() + "'");
            Binddata();
        }

        protected void txtCoDong_TextChanged(object sender, EventArgs e)
        {

            string sql = " INSERT INTO KIEMPHIEU(LANBQ,NGAYBQ,LOAIBQ,STTCD,MACD,TONGCD,CREATEBY,CREATEDATE) ";
            sql += " SELECT " + DropDownList1.SelectedValue.ToString() + " AS LANBQ,'" + DateTime.ParseExact(tungay.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture) + "' AS NGAYBQ,0 AS LOAIBQ,STTCD,MACD,TONGCD,'" + Session["login"] + "' AS CREATEBY, GETDATE() AS CREATEDATE ";
            sql += " FROM DSCODONG_THAMDU WHERE ( STTCD=REPLACE('" + this.txtCoDong.Text.Replace(" ", "") + "','THW','') OR MACD='" + this.txtCoDong.Text.Replace(" ", "") + "' )";
            Class.LinQConnection.ExecuteCommand(sql);
            Binddata();
            this.txtCoDong.Focus();
        }
    }
}