using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuanLyKhachHang.DataBase;
using System.Text;

namespace QuanLyKhachHang
{
    public partial class callBaoBeAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["lng"] != null)
            {
                string dienthoai = Request.QueryString["dienthoai"].ToString();
                string ghichu = Request.QueryString["ghichu"];
                string tenkh = Request.QueryString["tenkh"];
                string sonha = Request.QueryString["sonha"];
                string diachi = HttpUtility.UrlDecode(Request.QueryString["diachi"], Encoding.GetEncoding("utf-8"));
                string type = Request.QueryString["type"].ToString();
                string lat = Request.QueryString["lat"].ToString();
                string lng = Request.QueryString["lng"].ToString();
                string phuong = Request.QueryString["phuong"].ToString();
                string quan = Request.QueryString["quan"].ToString();

                string sohoso = Class.C_TrungTamKhachHang.IdentityBienNhan();
                KT_BaoBe kt = new KT_BaoBe();
                kt.SoHoSo = sohoso;
                kt.TinhTrang = 1;
                kt.Lat = lat;
                kt.Lng = lng;
                kt.SoDT = dienthoai;
                kt.LoaiBao = type;
                kt.SoNha = sonha;
                kt.TenDuong = diachi;
                kt.Phuong = phuong;
                kt.Quan = quan;
                kt.NgayBao = DateTime.Now;
                kt.DonViSuaBe = "DTCTB";
                kt.NgayChuyenSuaBe = DateTime.Now;
                kt.GhiChu = ghichu;
                kt.CreateDate = DateTime.Now;
                kt.CreateBy = Session["login"].ToString();
                Class.C_KyThuat.Insert(kt);

                TTKH_TiepNhan tn = new TTKH_TiepNhan();
                tn.LoaiTN = "KH";
                tn.SoHoSo = sohoso;
                tn.DanhBo = "";
                tn.DienThoai = dienthoai;
                tn.TenKH = tenkh;
                tn.SoNha = sonha;
                tn.TenDuong = diachi;
                tn.Phuong = phuong;
                tn.Quan = quan;
                tn.LoaiHs = "10";
                tn.NgayNhan = DateTime.Now;
                tn.ChuyenHS = true;
                tn.NgayChuyen = DateTime.Now;
                tn.MaDVChuyen = 1;
                tn.DonViChuyen = "Đội TCTB";
                tn.Mess = true;
                tn.GhiChu = ghichu;
                tn.CreateBy = Session["login"].ToString();
                tn.CreateDate = DateTime.Now;
                Class.C_TrungTamKhachHang.Insert(tn);


                //  Class.C_CallCenter.ExecuteCommand("UPDATE KT_DongNuoc SET DongMo='False' WHERE ID='" + Request.QueryString["id"].ToString() + "' ");

                Response.Redirect(@"callBaoBe.aspx");
            }


            if (Request.QueryString["id"] != null)
            {
                Class.C_KyThuat.ExecuteCommand("DELETE KT_BaoBe WHERE ID='" + Request.QueryString["id"].ToString() + "' AND CreateBy='" + Session["login"].ToString() + "' ");
                Response.Redirect(@"callBaoBe.aspx");
            }
        }
    }
}