﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLyKhachHang.View
{
    public partial class QuanLyMangLuoi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void clear()
        {
            try
            {
                string db = Request.QueryString["db"].ToString();
            }
            catch (Exception)
            {
                 
            }
            
        }
    }
}