using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DHCD_KiemPhieu.View
{
    public partial class pBauCuDHCD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            MaintainScrollPositionOnPostBack = true;
            if (IsPostBack)
                return;
            this.tungay.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
        }

        private void Binddata()
        {
            checkName.DataSource = Class.LinQConnection.getDataTable("SELECT * FROM BAUCU WHERE LANBC= " + DropDownList1.SelectedValue.ToString() + " AND CONVERT(VARCHAR(50),NGAYBC,103)='" + this.tungay.Text + "'");
            checkName.DataTextField = "TENBC";
            checkName.DataValueField = "STT";
            checkName.DataBind();
            loadKQ();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Binddata();
        }

        protected void G_KDY_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            Class.LinQConnection.ExecuteCommand("DELETE FROM KIEMPHIEU WHERE ID='" + e.CommandArgument.ToString() + "'");
            Binddata();
        }
        protected void checkName_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < checkName.Items.Count; i++)
            {
                if (checkName.Items[i].Selected)
                    checkName.Items[i].Attributes.Add("style", "text-decoration:line-through; color:Red;");
            }
        }

        void loadKQ()
        {
            this.tc_thuvao.Text = "0";
            string sql = " SELECT STT,  TENBC,SUM(SLDY) AS DY, ";
            sql += " ROUND(100.0*((SUM(SLDY)*1.0)/(SUM(SLDY)+SUM(SLKDY) )),2)  AS TLDY ,";
            sql += " SUM(SLKDY) AS KDY ,  ";
            sql += " ROUND(100.0*((SUM(SLKDY)*1.0)/(SUM(SLDY)+SUM(SLKDY) )),2)  AS TLKDY1 ";
            sql += " FROM BAUCU WHERE LANBC= " + DropDownList1.SelectedValue.ToString() + " AND CONVERT(VARCHAR(50),NGAYBC,103)='" + this.tungay.Text + "' ";
            sql += " GROUP BY STT,TENBC ORDER BY STT ASC  ";

            DataTable tb = Class.LinQConnection.getDataTable(sql);
            gTK.DataSource = tb;
            gTK.DataBind();
            try
            {
                int kq = int.Parse(tb.Rows[0]["DY"].ToString()) + int.Parse(tb.Rows[0]["KDY"].ToString());
                this.tc_thuvao.Text = kq+"" ;
            }
            catch (Exception)
            {
            }

        }
        protected void btSubmit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkName.Items.Count; i++)
            {
                if (checkName.Items[i].Selected)
                {
                    string sql = "UPDATE BAUCU SET SLKDY= (SLKDY+1) WHERE STT=" + checkName.Items[i].Value + " AND LANBC= " + DropDownList1.SelectedValue.ToString() + " AND CONVERT(VARCHAR(50),NGAYBC,103)='" + this.tungay.Text + "'";
                    Class.LinQConnection.ExecuteCommand(sql);
                    checkName.Items[i].Selected = false;
                }
                else
                {
                    string sql = "UPDATE BAUCU SET SLDY= (SLDY+1) WHERE STT=" + checkName.Items[i].Value + " AND  LANBC= " + DropDownList1.SelectedValue.ToString() + " AND CONVERT(VARCHAR(50),NGAYBC,103)='" + this.tungay.Text + "'";
                    Class.LinQConnection.ExecuteCommand(sql);
                }
            }

            Binddata();
           
        }

        protected void lSort_Click(object sender, EventArgs e)
        {
            string sql = " SELECT STT,  TENBC,SUM(SLDY) AS DY, ";
            sql += " ROUND(100.0*((SUM(SLDY)*1.0)/(SUM(SLDY)+SUM(SLKDY) )),2)  AS TLDY ,";
            sql += " SUM(SLKDY) AS KDY ,  ";
            sql += " ROUND(100.0*((SUM(SLKDY)*1.0)/(SUM(SLDY)+SUM(SLKDY) )),2)  AS TLKDY1 ";
            sql += " FROM BAUCU WHERE LANBC= " + DropDownList1.SelectedValue.ToString() + " AND CONVERT(VARCHAR(50),NGAYBC,103)='" + this.tungay.Text + "' ";
            sql += " GROUP BY STT,TENBC ORDER BY SUM(SLDY) DESC  ";

            gTK.DataSource = Class.LinQConnection.getDataTable(sql);
            gTK.DataBind();
        }

        protected void txtTheTV_TextChanged(object sender, EventArgs e)
        {
            this.tc_phatra.Text = String.Format("{0:0,0}", txtTheTV.Text);
        }
    }
}