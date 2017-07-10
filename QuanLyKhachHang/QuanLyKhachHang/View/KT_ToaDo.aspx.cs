using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace QuanLyKhachHang.View
{
    public partial class KT_ToaDo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string sql = " SELECT db AS DANHBO ,  kh.Lat as lat,kh.Long as lng FROM [KYTHUAT].[dbo].[DANHBO] kh ";
            DataTable tb = Class.C_KyThuat.getDataTable(sql);
            Session["dsBaoBe"] = tb;


             string sql2 = " SELECT DBDONGHONUOC AS DANHBO ,  kh.Lat as lat,kh.Long as lng  ";
             sql2 += "  FROM [KYTHUAT].[dbo].[DongHo] kh WHERE  kh.DBDONGHONUOC in (SELECT db  FROM [KYTHUAT].[dbo].[DANHBO])  ";

             tb = Class.C_KyThuat.getDataTable(sql2);
            Session["dsMOi"] = tb;
        }
    }
}