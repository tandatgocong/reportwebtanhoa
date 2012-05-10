using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaoCao_Web.View
{
    public partial class QuanLyDHN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MaintainScrollPositionOnPostBack = true;
            if("DTTDK".Equals(Request.Params["type"]+"")){
              
                this.Panel1.Controls.Clear();
                Control control = LoadControl("tabDHN/tabThongKeDHN.ascx");
                this.Panel1.Controls.Add(control);
                title.Text = "THỐNG KÊ ĐỒNG HỒ NƯỚC";
            }
            else if ("TDSL".Equals(Request.Params["type"] + ""))
            {
               
                this.Panel1.Controls.Clear();
                Control control = LoadControl("tabDHN/tabTheoDoiSanLuong.ascx");
                this.Panel1.Controls.Add(control);
                title.Text = "THEO DÕI SẢN LƯỢNG";
            }
            
        }
    }
}