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
    public partial class hc_CapNhatGiayXP : System.Web.UI.Page
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
        string connectionString="";
        public void PageLoad()
        {
            cbNam.Items.Add((DateTime.Now.Year - 1)+"");
            cbNam.Items.Add((DateTime.Now.Year ) + "");
            cbNam.Items.Add((DateTime.Now.Year +1) + "");
            this.cbNam.SelectedIndex = 1;

            this.tungay.Text = Class.Format.NgayVNVN(DateTime.Now.Date) + "/" + DateTime.Now.Year.ToString();
            this.cbThang.SelectedIndex = DateTime.Now.Month-1;
            this.cbThang0.SelectedIndex = DateTime.Now.Month - 1;
            //cbPhongBanDoi.DataSource = Class.LinQConnection.getDataTable("SELECT * FROM TCHC_PHONGBAN WHERE ID <> 1 ORDER BY ID ASC ");
            //cbPhongBanDoi.DataTextField = "MAPHONG";
            //cbPhongBanDoi.DataValueField = "ID";
            //cbPhongBanDoi.DataBind();
            /* ---------------------- */
             connectionString= ConfigurationManager.ConnectionStrings["WiseEyeOn39ConnectionString"].ConnectionString;
            string sql = " SELECT info.UserEnrollNumber, info.UserFullName FROM UserInfo info order by UserFullCode asc ";

            cpNhanVien.DataSource = Class.OledbConnection.getDataTable(connectionString, sql);
            cpNhanVien.DataTextField = "UserFullName";
            cpNhanVien.DataValueField = "UserEnrollNumber";
            cpNhanVien.DataBind();

            dataLoad();

        }

        protected void btXemBangKe_Click(object sender, EventArgs e)
        {
            try
            {
                 connectionString = ConfigurationManager.ConnectionStrings["WiseEyeOn39ConnectionString"].ConnectionString;
                 string sql = "INSERT INTO tblGiayXinVe(MANV,TENNV,LOAIGP,TENLOAI,BUOICT,TUNGAY,DENNGAY,PHUTVAO,PHUTRA,THANG,NAM) ";
                sql += "VALUES (";
                sql += this.cpNhanVien.SelectedItem.Value;
                sql += ", '" + this.cpNhanVien.SelectedItem.Text + "' ";
                sql += ", '" + this.cpLoaiGiayPhep.SelectedValue + "' ";
                sql += ", '" + this.cpLoaiGiayPhep.SelectedItem.Text + "' ";    
                sql += ", '" + cbGiayCongTac.Text + "' ";                
                try
                {
                    sql += ",'" + DateTime.ParseExact(tungay.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture) + "' ";
                }
                catch (Exception)
                {
                    sql += ",null ";
                }

                try
                {
                    sql += ",'" + DateTime.ParseExact(denngay.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture) + "' ";
                }
                catch (Exception)
                {
                    sql += ",null ";
                }
                try
                {
                    sql += "," + int.Parse(this.txtPhutVao.Text);
                }
                catch (Exception)
                {
                    sql += ",null ";
                }
                try
                {
                    sql += "," + int.Parse(this.txtPhutRa.Text);
                }
                catch (Exception)
                {
                    sql += ",null ";
                }

                sql += "," + this.cbThang.Text;
                sql += "," + DateTime.Now.Year.ToString();
                sql += " )";

              
                Class.OledbConnection.ExecuteCommand(connectionString,sql);


                lbThanhCong.ForeColor = Color.Blue;
                this.lbThanhCong.Text = "Cập Nhật Thành Công.";
                this.txtPhutVao.Text = "";
                this.txtPhutRa.Text = "";
                this.txtNoiDungCT.Text = "";
                dataLoad();
            }
            catch (Exception)
            {
                lbThanhCong.ForeColor = Color.Red;
                this.lbThanhCong.Text = "Cập Nhật Thất Bại.";

            }

        }

        protected void cpLoaiGiayPhep_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Label3.Visible = false;
            this.cbGiayCongTac.Visible = false;
            this.Label1.Visible = true;
            this.tungay.Visible = true;
            this.Label2.Visible = true;
            this.denngay.Visible = true;
            this.txtPhutRa.Visible = true;
            this.txtPhutVao.Visible = true;
            Label4.Visible = true;
            Label5.Visible = true;
            Label6.Visible = false;
            txtNoiDungCT.Visible = false;
            if (cpLoaiGiayPhep.SelectedIndex == 0)
            {// trong ngày
                this.Label1.Text = "NGÀY";
                this.tungay.Text = Class.Format.NgayVNVN(DateTime.Now.Date) + "/" + DateTime.Now.Year.ToString();
                this.Label2.Visible = false;
                this.denngay.Visible = false;
                this.Label1.Visible = true;
                this.tungay.Visible = true;
            }
            else if (cpLoaiGiayPhep.SelectedIndex == 1)
            {//có thời hạn
                this.Label1.Text = "TỪ NGÀY";
                this.tungay.Text = "";
                this.Label2.Visible = true;
                this.denngay.Visible = true;
                this.Label1.Visible = true;
                this.tungay.Visible = true;
            }
            else if (cpLoaiGiayPhep.SelectedIndex == 2)
            {//không thời hạn
                this.Label1.Visible = false;
                this.tungay.Visible = false;
                this.Label2.Visible = false;
                this.denngay.Visible = false;
                this.tungay.Text = "";
                this.denngay.Text = "";
            }
            else if (cpLoaiGiayPhep.SelectedIndex == 3)
            {//công tác
                this.Label1.Visible = true;
                this.tungay.Visible = true;
                this.Label2.Visible = true;
                this.denngay.Visible = true;
                this.txtPhutRa.Visible = false;
                this.txtPhutVao.Visible = false;
                this.Label3.Visible = true;
                this.cbGiayCongTac.Visible = true;
                this.Label1.Visible = true;
                this.tungay.Visible = true;
                this.Label2.Visible = true;
                this.denngay.Visible = true;
                Label4.Visible = false;
                Label5.Visible = false;
                Label6.Visible = true;
                txtNoiDungCT.Visible = true;
            }
            else if (cpLoaiGiayPhep.SelectedIndex == 4)
            {// đi ngoài
                this.Label1.Visible = false;
                this.tungay.Visible = false;
                this.Label2.Visible = false;
                this.denngay.Visible = false;
                this.txtPhutRa.Visible = false;
                this.txtPhutVao.Visible = false;
                this.Label3.Visible = false;
                this.cbGiayCongTac.Visible = false;
                this.Label1.Visible = false;
                this.tungay.Visible = false;
                this.Label2.Visible = false;
                this.denngay.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;
                this.tungay.Text = "";
                this.denngay.Text = "";

            }
        }
        int stt = 1;
        public string get_stt()
        {
            return Convert.ToString(stt++);
        }
        public void dataLoad()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["WiseEyeOn39ConnectionString"].ConnectionString;
            string sql = " SELECT ID,MANV,TENNV,TENLOAI,BUOICT, Format(TUNGAY,'dd/mm/yyyy') as TNGAY ,Format(DENNGAY,'dd/mm/yyyy') as DNGAY ,PHUTVAO,PHUTRA,THANG FROM tblGiayXinVe WHERE THANG=" + cbThang0.Text + "  AND NAM=" + cbNam.Text + "  ";
            DataTable tb = Class.OledbConnection.getDataTable(connectionString, sql);
            GridView1.DataSource = tb;
            GridView1.DataBind();
        }
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex; 
            dataLoad();
        }

       

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["WiseEyeOn39ConnectionString"].ConnectionString;
            Class.OledbConnection.ExecuteCommand(connectionString,"DELETE FROM tblGiayXinVe WHERE ID=" + e.CommandArgument.ToString() + " ");
            dataLoad();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dataLoad();
        }
       
    }
}