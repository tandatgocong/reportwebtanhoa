using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaoCao_Web.View.tabDHN
{
    public partial class tabThongKeDHN : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DONGHONUOC.DataSource = Class.C_DHN.getCoDHN();
            DONGHONUOC.DataBind();

            NAMGAN.DataSource = Class.C_DHN.getNamGanDHN();
            NAMGAN.DataBind();
            
        }
        decimal totalPrice = 0M;
        protected void DONGHONUOC_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Label lblPrice = (Label)e.Row.FindControl("Label1");

                decimal price = Decimal.Parse(lblPrice.Text);

                totalPrice += price;
            }

            if (e.Row.RowType == DataControlRowType.Footer)
            {
                Label lblTotalPrice = (Label)e.Row.FindControl("lbSum");

                lblTotalPrice.Text = String.Format("{0:0,0}", totalPrice);

            } 
        }
        decimal totalPrice2 = 0M;
        protected void NAMGAN_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Label lblPrice = (Label)e.Row.FindControl("Label1");

                decimal price = Decimal.Parse(lblPrice.Text);

                totalPrice2 += price;
            }

            if (e.Row.RowType == DataControlRowType.Footer)
            {
                Label lblTotalPrice = (Label)e.Row.FindControl("lbSum");

                lblTotalPrice.Text = String.Format("{0:0,0}", totalPrice2);

            } 
        }
    }
}