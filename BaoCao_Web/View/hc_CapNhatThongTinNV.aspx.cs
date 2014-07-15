using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using BaoCao_Web.DataBase;
using System.Drawing;

namespace BaoCao_Web.View
{
    public partial class hc_CapNhatThongTinNV : System.Web.UI.Page
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
            PageLoad();

        }
        public void PageLoad()
        {
           
            cbPhongBanDoi.DataSource = Class.LinQConnection.getDataTable("SELECT * FROM TCHC_PHONGBAN  ORDER BY ID ASC ");
            cbPhongBanDoi.DataTextField = "MAPHONG";
            cbPhongBanDoi.DataValueField = "ID";
            cbPhongBanDoi.DataBind();

            cbPhongBanDoi0.DataSource = Class.LinQConnection.getDataTable("SELECT * FROM TCHC_PHONGBAN WHERE ID <> 1 ORDER BY ID ASC ");
            cbPhongBanDoi0.DataTextField = "MAPHONG";
            cbPhongBanDoi0.DataValueField = "ID";
            cbPhongBanDoi0.DataBind();

            /* ---------------------- */
            string connectionString = ConfigurationManager.ConnectionStrings["CAPNUOCTANHOA.Properties.Settings.AccessFile"].ConnectionString;
            string sql = " SELECT info.UserFullCode, info.UserFullName, dt.Dept";
            sql += " FROM UserInfo info,Dept dt WHERE info.IDD=dt.IDD ";
            if (!"1".Equals(cbPhongBanDoi.SelectedValue))
            {
                sql += " AND info.IDD=" + cbPhongBanDoi.SelectedValue;
            }
            //if (ckNV.Checked)
            //{
            //    sql += " AND info.UserLoaiNV='VP' ";
            //}
            //if (ckCN.Checked)
            //{
            //    sql += " AND info.UserLoaiNV='CN' ";
            //}
            sql += " ORDER BY info.IDD ASC, info.UserFullCode ASC ";
            cpNhanVien.DataSource = Class.OledbConnection.getDataTable(connectionString, sql);
            cpNhanVien.DataTextField = "UserFullName";
            cpNhanVien.DataValueField = "UserFullCode";
            cpNhanVien.DataBind();


        }

      
        protected void cbPhongBanDoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* ---------------------- */
            string connectionString = ConfigurationManager.ConnectionStrings["CAPNUOCTANHOA.Properties.Settings.AccessFile"].ConnectionString;
            string sql = " SELECT info.UserFullCode, info.UserFullName, dt.Dept";
            sql += " FROM UserInfo info,Dept dt WHERE info.IDD=dt.IDD ";
            if (!"1".Equals(cbPhongBanDoi.SelectedValue))
            {
                sql += " AND info.IDD=" + cbPhongBanDoi.SelectedValue;
            }
            //if (ckNV.Checked)
            //{
            //    sql += " AND info.UserLoaiNV='VP' ";
            //}
            //if (ckCN.Checked)
            //{
            //    sql += " AND info.UserLoaiNV='CN' ";
            //}
            sql += " ORDER BY info.IDD ASC, info.UserFullCode ASC ";
            cpNhanVien.DataSource = Class.OledbConnection.getDataTable(connectionString, sql);
            cpNhanVien.DataTextField = "UserFullName";
            cpNhanVien.DataValueField = "UserFullCode";
            cpNhanVien.DataBind();
        }

        int stt = 1;
        public string get_stt()
        {
            return Convert.ToString(stt++);
        }

        protected void btXemBangKe_Click(object sender, EventArgs e)
        {
            string loainv = "VP";
            if (ckNV0.Checked)
            {
                loainv = "VP";
            }
            if (ckCN0.Checked)
            {
                loainv = "CN";
            }

            string sql = " UPDATE UserInfo SET IDD ='" + cbPhongBanDoi0.SelectedValue + "', UserLoaiNV='" + loainv + "'  WHERE UserFullCode='" + cpNhanVien.SelectedValue + "'";
            string connectionString = ConfigurationManager.ConnectionStrings["CAPNUOCTANHOA.Properties.Settings.AccessFile"].ConnectionString;

            try
            {
                Class.OledbConnection.ExecuteCommand(connectionString, sql);
                this.lbThanhCong.Text = "Cập Nhật Thành Công.";
            }
            catch (Exception)
            {
                lbThanhCong.ForeColor = Color.Red;
                this.lbThanhCong.Text = "Cập Nhật Thất Bại.";

            }
           
        }
        
       
    }
}