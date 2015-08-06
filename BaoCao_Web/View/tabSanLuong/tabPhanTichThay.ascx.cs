using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaoCao_Web.View.tabSanLuong
{
    public partial class tabPhanTichThay : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            nam.Text = DateTime.Now.Year.ToString();
            //if (DateTime.Now.Month == 0)
            //{
            //    this.ky.SelectedIndex = 0;
            //}
            //else
            //{
            //    this.ky.SelectedIndex = DateTime.Now.Month - 1;
            //}
        }

        protected void btXemBangKe_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"tabSanLuong\PhanTichThayDHN.aspx?m="+ky.SelectedValue+"&y="+nam.Text+"&code="+code.SelectedValue);
        }

        
    }
}