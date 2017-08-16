using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuanLyKhachHang.Class;
using QuanLyKhachHang.DataBase;
using System.Drawing;
using System.IO;
using System.Data;
using System.ComponentModel;


namespace QuanLyKhachHang
{
    public partial class mMangLuoi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MaintainScrollPositionOnPostBack = true;
            if (IsPostBack)
                return;
            pagLoad();
        }
        public void pagLoad()
        {
            Session["dsVan"] = null;
            string sql = " SELECT   * FROM HeThongVan Where ID=3";
            Session["dsVan"] = C_KyThuat.getDataTable(sql);

            try
            {
                Session["ConfigPath"] = null;
                sql = " SELECT   * FROM ConfigPath Where ID=1";
                Session["ConfigPath"] = C_KyThuat.getDataTable(sql).Rows[0][1].ToString();
            }
            catch (Exception)
            {

            }


        }
    }
}