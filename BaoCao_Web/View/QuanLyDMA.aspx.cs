using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace BaoCao_Web.View.KTCN
{
    public partial class QuanLyDMA : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MaintainScrollPositionOnPostBack = true;
            if (IsPostBack)
                return;
            pLoad();
        }
        public void pLoad()
        {
            listDMA.DataSource = Class.LinQConnection.getDataTable("SELECT ID,MADMA FROM GNKDT_THONGTINDMA ORDER BY ID ASC");
            listDMA.DataTextField = "MADMA";
            listDMA.DataValueField = "MADMA";
            listDMA.DataBind();

        }

        protected void listDMA_SelectedIndexChanged(object sender, EventArgs e)
        {
            string flag = "'123'";
            foreach (ListItem item in listDMA.Items)
            {
                if (item.Selected)
                {
                    flag += ",'" + item.Value + "'";
                }

            }
            string sql = "SELECT ID,MADMA FROM GNKDT_THONGTINDMA WHERE MADMA IN (" + flag + ") ORDER BY ID ASC";
            DataTable tb = Class.LinQConnection.getDataTable(sql);
            Session["chamcong"] = tb;

            //DataList1.DataSource = 
            //DataList1.DataBind();
        }

        protected void cAll_CheckedChanged(object sender, EventArgs e)
        {
            if (cAll.Checked)
            {
                string flag = "'123'";
                foreach (ListItem item in listDMA.Items)
                {
                    flag += ",'" + item.Value + "'";
                    item.Selected = true;
                }
                string sql = "SELECT ID,MADMA FROM GNKDT_THONGTINDMA WHERE MADMA IN (" + flag + ") ORDER BY ID ASC";
                DataTable tb = Class.LinQConnection.getDataTable(sql);
                Session["chamcong"] = tb;
            }
            else
            {
                foreach (ListItem item in listDMA.Items)
                {
                    item.Selected = false;
                }

                Session["chamcong"] = null;
            }
        }
    }
}