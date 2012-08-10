using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BaoCao_Web.DataBase;

namespace BaoCao_Web.View.BaoKinhDoanh
{
    public partial class UpdateKinhDoanh : System.Web.UI.UserControl
    {
        BAOCAO_KINHDOANH kd = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            int y = DateTime.Now.Year;
            for (int i = y - 2; i < y + 3; i++)
            {
                year.Items.Add(i + "");
            }
            year.SelectedIndex = 2;
        }

        void refesh() {
            this.txtDoanhThu.Text = "";
            this.txtTiLeDTKy.Text = "";
            this.txtTiLeDT4Ky.Text = "";
            this.txtSanLuong.Text = "";
            this.txtDHN.Text = "";
            this.txtTangDHN.Text = "";
            this.txtHoaDonNho3.Text = "";
            this.txtGiaBinhQuan.Text = "";
            this.txtHoaDonDM.Text = "";
            this.hdTBPN.Text = "";
            this.HdTBTB.Text = "";
            this.hdtbTP.Text = "";
            this.hdtbTongCong.Text = "";
            this.hdtbTANGGIAM.Text = "";
            this.hd0MPN.Text = "";
            this.hd0mTB.Text = "";
            this.hd0mTP.Text = "";
            this.hd0mTONG.Text = "";
            this.hd0mTANGGIAM.Text = "";
            this.hd4mPN.Text = "";
            this.hd4mTB.Text = "";
            this.hd4mTP.Text = "";
            this.hd4mTONGCONG.Text = "";
            this.hd4mTANGGIAM.Text = "";
            this.hdTonKyTruoc.Text = "";
            this.hdTonTG.Text = "";
            this.hdTonCQ.Text = "";
            this.hdTonTONGCONG.Text = "";
            this.dtTonTG.Text = "";
            this.dtTonCQ.Text = "";
            this.dtTonTONGCONG.Text = "";
            txtDoanhThu.Focus();

        }
        protected void ky_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nam = year.Text;
            string ky_ = ky.Text;
            kd = Class.SoLieuKinhDoanh.findByKy(int.Parse(ky_), int.Parse(nam));
            if (kd != null)
            {
                this.txtDoanhThu.Text = kd.DOANHTHU + "";
                this.txtTiLeDTKy.Text = kd.DT_KY + "";
                this.txtTiLeDT4Ky.Text = kd.DT_4KY + "";
                this.txtSanLuong.Text = kd.SANLUONG + "";
                this.txtDHN.Text = kd.SLDHN + "";
                this.txtTangDHN.Text = kd.TANGDHN + "";
                this.txtHoaDonNho3.Text = kd.DHN_NHO3 + "";
                this.txtGiaBinhQuan.Text = kd.GIABQ + "";
                this.txtHoaDonDM.Text = kd.TONG_DM + "";
                this.hdTBPN.Text = kd.HDTB_PN + "";
                this.HdTBTB.Text = kd.HDTB_TB + "";
                this.hdtbTP.Text = kd.HDTB_TP + "";
                this.hdtbTongCong.Text = kd.HDTB + "";
                this.hdtbTANGGIAM.Text = kd.HDTB_TANG + "";
                this.hd0MPN.Text = kd.HOADON0_PN + "";
                this.hd0mTB.Text = kd.HOADON0_TB + ""; ;
                this.hd0mTP.Text = kd.HOADON0_TP + "";
                this.hd0mTONG.Text = kd.HOADON0 + "";
                this.hd0mTANGGIAM.Text = kd.HOADON0_TG + "";
                this.hd4mPN.Text = kd.HOADON4_PN + "";
                this.hd4mTB.Text = kd.HOADON4_TB + "";
                this.hd4mTP.Text = kd.HOADON4_TP + "";
                this.hd4mTONGCONG.Text = kd.HOADON4 + "";
                this.hd4mTANGGIAM.Text = kd.HOADON4_TG + "";
                this.hdTonKyTruoc.Text = kd.HDTON_TRUOC + "";
                this.hdTonTG.Text = kd.HDTON_TG + "";
                this.hdTonCQ.Text = kd.HDTON_CQ + "";
                this.hdTonTONGCONG.Text = kd.HDTON_TONG + "";
                this.dtTonTG.Text = kd.SLTON_TG + "";
                this.dtTonCQ.Text = kd.SLTON_CQ + "";
                this.dtTonTONGCONG.Text = kd.SLTON_TONG + "";
            }
            else {
                refesh();
            }
        }
    }
}