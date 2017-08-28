using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebMobile
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            //pageLoad();

        }
        [System.Web.Script.Services.ScriptMethod()]
        [System.Web.Services.WebMethod]
        public static List<string> SearchCustomers(string prefixText, int count)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager
                        .ConnectionStrings["CallCenterConnectionString"].ConnectionString;
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "select DUONG from TENDUONG  WHERE  DUONG like '%" + prefixText + "%'";
                    cmd.Connection = conn;
                    conn.Open();
                    List<string> customers = new List<string>();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            customers.Add(sdr["DUONG"].ToString());
                        }
                    }
                    conn.Close();
                    return customers;
                }
            }
        }
        public void pageLoad()
        {
            cbPhuong.DataSource = Class.C_KyThuat.getDataTable("SELECT * FROM  QuanPhuong ");
            cbPhuong.DataTextField = "TenPhuong";
            cbPhuong.DataValueField = "MaPhuong";
            cbPhuong.DataBind();

            cbQuan.DataSource = Class.C_KyThuat.getDataTable("SELECT MaQuan,TenQuan FROM  QuanPhuong    GROUP BY MaQuan,TenQuan");
            cbQuan.DataTextField = "TenQuan";
            cbQuan.DataValueField = "MaQuan";
            cbQuan.DataBind();

            cbMaDMA.DataSource = Class.C_KyThuat.getDataTable("SELECT * FROM  THONGTINDMA ORDER BY MaDma");
            cbMaDMA.DataTextField = "MaDma";
            cbMaDMA.DataValueField = "MaDma";
            cbMaDMA.DataBind();

            
        }


        //[System.Web.Script.Services.ScriptMethod()]
        //[System.Web.Services.WebMethod]
        //public static List<string> SearchCustomers(string prefixText, int count)
        //{
           

        //    DataTable dt = Class.C_KyThuat.getDataTable("SELECT * FROM TENDUONG");

        //    string[] items = new string[dt.Rows.Count];
        //    int i = 0;
        //    List<string> customers = new List<string>();

        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        customers.Add(dr["DUONG"].ToString());
                
        //    }
        //    return customers;

        //}

        [System.Web.Services.WebMethodAttribute(), System.Web.Script.Services.ScriptMethodAttribute()]
        public static string[] GetKeyWords(string prefixText)
        {
            //string sql = "Select * from Search Where SearchName like @prefixText";
            //SqlDataAdapter da = new SqlDataAdapter(sql, "server=.; database=TestAutoCom; integrated security = true;");
            //da.SelectCommand.Parameters.Add("@prefixText", SqlDbType.VarChar, 50).Value = prefixText + "%";
            DataTable dt = Class.C_KyThuat.getDataTable("SELECT * FROM TENDUONG");
             
            string[] items = new string[dt.Rows.Count];
            int i = 0;
            foreach (DataRow dr in dt.Rows)
            {
                items.SetValue(dr["DUONG"].ToString(), i);
                i++;
            }
            return items;
        }
    }
}