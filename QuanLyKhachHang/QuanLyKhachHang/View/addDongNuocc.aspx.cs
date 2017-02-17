using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuanLyKhachHang.DataBase;
using System.Drawing;

namespace QuanLyKhachHang.View
{
    public partial class addDongNuocc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            MaintainScrollPositionOnPostBack = true;
            if (IsPostBack)
                return;
            dataLoad();

        }
        public void dataLoad()
        {
        }

        protected void btXemBangKe_Click(object sender, EventArgs e)
        {
            try
            {
                string lat = Request.QueryString["lat"];
                string lng = Request.QueryString["lng"];
                //=(10.7523028428119,106.5858256816864)
                KT_DongNuoc xv = new KT_DongNuoc();
                xv.lat = lat;
                xv.lng = lng;
                try
                {
                    xv.TuNgay = DateTime.ParseExact(tungay.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                }
                catch (Exception)
                {
                }
                try
                {
                    xv.DenNgay = DateTime.ParseExact(denngay.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                }
                catch (Exception)
                {
                }


                xv.TuGio = tugio.Text;
                xv.DenGio = dengio.Text;

                xv.NoiDung = this.txtNoiDungCT.Text;
                xv.CreateDate = DateTime.Now;

                Class.C_CallCenter.Insert(xv);
                lbThanhCong.ForeColor = Color.Blue;
                this.lbThanhCong.Text = "Cập Nhật Thành Công.";
                this.tugio.Text = "";
                this.dengio.Text = "";
                this.txtNoiDungCT.Text = "";
                dataLoad();
            }
            catch (Exception)
            {
                lbThanhCong.ForeColor = Color.Red;
                this.lbThanhCong.Text = "Cập Nhật Thất Bại.";

            }
        }

    }
}