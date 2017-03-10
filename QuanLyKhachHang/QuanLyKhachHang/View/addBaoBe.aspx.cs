using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLyKhachHang.View
{
    public partial class addBaoBe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["lng"] != null)
            {
                string dienthoai = Request.QueryString["dienthoai"].ToString();
                string ghichu = Request.QueryString["ghichu"].ToString();
                string diachi = Request.QueryString["diachi"].ToString();
                string type = Request.QueryString["type"].ToString();
                string lat = Request.QueryString["lat"].ToString();
                string lng = Request.QueryString["lng"].ToString(); 
                
                Class.C_CallCenter.ExecuteCommand("UPDATE KT_DongNuoc SET DongMo='False' WHERE ID='" + Request.QueryString["id"].ToString() + "' ");
                Response.Redirect(@"dongnuoc.aspx");
            }

        }
    }
}