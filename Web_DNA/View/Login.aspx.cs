using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Text;
using BaoCao_Web.DataBase;
using System.Data;
using System.Configuration;

namespace BaoCao_Web.View
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       
        public bool UserLogin(string userName, string passWord)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["WiseEyeOn39ConnectionString"].ConnectionString;
            string sql = " SELECT UserAccount,Pass FROM UserAccount where UserAccount='" + userName + "' and Pass='" + passWord + "' ";
            DataTable tb = Class.OledbConnection.getDataTable(connectionString, sql);
            if (tb.Rows.Count>0)
            {
                Session["login"] = tb.Rows[0]["UserAccount"].ToString();
                return true;
            }
            return false;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (UserLogin(this.txtusername.Text, this.txtpassword.Text) == true)
                Response.Redirect("hc_CapNhatGiayXP.aspx?page=KD");
            else
                this.mess.Visible = true;
        }
    }
}