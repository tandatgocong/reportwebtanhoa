using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLyKhachHang.View
{
    public partial class pThongTinKhachHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string db = Request.QueryString["db"].ToString();
                DetailsView1.DataSource = Class.C_KyThuat.getDataTable("SELECT * FROM W_THONGTINKH WHERE DANHBO='"+db+"' ");
                DetailsView1.DataBind();
                
                GridView1.DataSource = Class.C_DuLieuKhachHang.getListHoaDonReport(db);
                GridView1.DataBind();
            }
            catch (Exception )
            {
                 
            }
           
        }
    }
}