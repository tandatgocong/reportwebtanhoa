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
    public partial class addCallBaoBe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["lng"] != null)
            {
                string dienthoai = Request.QueryString["dienthoai"].ToString();
                string ghichu =Request.QueryString["ghichu"];
                string diachi = HttpUtility.UrlDecode(Request.QueryString["diachi"], Encoding.GetEncoding("utf-8"));
                string type = Request.QueryString["type"].ToString();
                string lat = Request.QueryString["lat"].ToString();
                string lng = Request.QueryString["lng"].ToString();
                string phuong = Request.QueryString["phuong"].ToString();
                string quan = Request.QueryString["quan"].ToString();
                KT_BaoBe kt = new KT_BaoBe();
                kt.TinhTrang =1;
                kt.Lat = lat;
                kt.Lng = lng;
                kt.SoDT = dienthoai;
                kt.LoaiBao = type;
                kt.DiaChi = diachi;
                kt.Phuong = phuong;
                kt.Quan = quan;
                kt.NgayBao = DateTime.Now;
                kt.GhiChu = ghichu;
                kt.CreateDate = DateTime.Now;
                kt.CreateBy = "callcenter";
                Class.C_CallCenter.Insert(kt);

              //  Class.C_CallCenter.ExecuteCommand("UPDATE KT_DongNuoc SET DongMo='False' WHERE ID='" + Request.QueryString["id"].ToString() + "' ");
                 Response.Redirect(@"callBaoBe.aspx");
            }
            if (Request.QueryString["id"] != null)
            {
                Class.C_CallCenter.ExecuteCommand("DELETE KT_BaoBe WHERE ID='" + Request.QueryString["id"].ToString() + "' ");
                Response.Redirect(@"callBaoBe.aspx");
            }
            
        }
    }
}