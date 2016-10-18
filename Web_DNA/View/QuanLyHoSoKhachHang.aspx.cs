using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace BaoCao_Web.View
{
    public partial class QuanLyHoSoKhachHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MaintainScrollPositionOnPostBack = true;
            if (IsPostBack)
                return;
        }

        public void search()
        {
            string shs = this.txtSoDon.Text;
            string diachi = this.txtDiaChi.Text;
            string madot = this.txtDotTC.Text;


            WSTH.THService se = new WSTH.THService();

            GridView1.DataSource = se.getSearchKH(shs, diachi, madot);
            GridView1.DataBind();


        }
        protected void btSubmit_Click(object sender, EventArgs e)
        {
            search();
        }
    }
}