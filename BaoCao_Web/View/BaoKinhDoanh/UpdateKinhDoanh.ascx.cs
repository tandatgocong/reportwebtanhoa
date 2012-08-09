using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaoCao_Web.View.BaoKinhDoanh
{
    public partial class UpdateKinhDoanh : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int y = DateTime.Now.Year;
            for (int i = y - 2; i < y + 3; i++)
            {
                year.Items.Add(i + "");
            }
            year.SelectedIndex = 2;
        }

        protected void ky_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}