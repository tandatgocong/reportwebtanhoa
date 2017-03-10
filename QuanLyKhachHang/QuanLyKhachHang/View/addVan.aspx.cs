using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuanLyKhachHang.DataBase;
using QuanLyKhachHang.Class;

namespace QuanLyKhachHang.View
{
    public partial class addVan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                Class.C_CallCenter.ExecuteCommand("UPDATE KT_Van SET Xoa='True',ModifyDate=GETDATE(),ModifyBy='" + Session["login"].ToString() + "' WHERE ID='" + Request.QueryString["id"].ToString() + "' ");
                Response.Redirect(@"QuanLyVan.aspx");
            }
            
            if (Request.QueryString["lng"] != null)
            {
                string lat = Request.QueryString["lat"];
                string lng = Request.QueryString["lng"];
                string duongchinh = Request.QueryString["duongchinh"];
                string diachi = Request.QueryString["diachi"];
                string phuong = Request.QueryString["phuong"];
                string quan = Request.QueryString["quan"];
                string tuyenong = Request.QueryString["tuyenong"];
                string covan = Request.QueryString["covan"];
                string chantuyen = Request.QueryString["chantuyen"];
                string xacan = Request.QueryString["xacan"];
                string TCH = Request.QueryString["TCH"];
                string vanbien = Request.QueryString["vanbien"];
                string masovan = Request.QueryString["masovan"];
                string thongtin = Request.QueryString["thongtin"];
                string ghichu = Request.QueryString["ghichu"];
                KT_Van v = new KT_Van();
                v.Lat = lat;
                v.Lng = lng;
                v.TuyenOng = tuyenong;
                v.CoVan = covan;
                v.MaSo = masovan;
                v.TenDuong = duongchinh;
                v.DiaChi = diachi;
                v.Phuong = phuong;
                v.Quan = quan;
                v.ChanTuyen = bool.Parse(chantuyen);
                v.XaCan = bool.Parse(xacan);
                v.TCH = bool.Parse(TCH);
                v.TLKCoLon = false;
                v.VanBien = bool.Parse(vanbien);
                v.LoaiVan = false;
                v.ChieuDong = "";
                v.SoVong = ""; ;
                v.DoSau = "";
                v.ThongTinMang = thongtin;
                v.GhiChu = ghichu;
                v.Xoa = false;
                v.CreateDate = DateTime.Now;
                v.CreateBy = Session["login"].ToString();
                C_CallCenter.Insert(v);

                Response.Redirect(@"QuanLyVan.aspx");
            }
        }
    }
}