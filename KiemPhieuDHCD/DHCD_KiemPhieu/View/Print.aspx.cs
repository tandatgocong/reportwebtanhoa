using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using DHCD_KiemPhieu.DataBase;

namespace DHCD_KiemPhieu.View
{
    public partial class Print : System.Web.UI.Page
    {
        log4net.ILog log = log4net.LogManager.GetLogger("File");
        protected void Page_Load(object sender, EventArgs e)
        {

            string sql = "";
            string title = "";
       
            if ("BQ".Equals(Request.Params["page"] + ""))
            {
                sql = Session["SQL"] + "";
                CrystalReportSource1.Report.FileName = "inKQBieuQuyet.rpt";
                //title = Session["treport"] + "";
                //CrystalReportSource1.ReportDocument.SetDataSource(Class.LinQConnection.getDataTable(sql));
                //CrystalReportSource1.ReportDocument.SetParameterValue("title", title);
                //CrystalReportSource1.ReportDocument.SetParameterValue("ky1", Session["TU"] + "");
                //CrystalReportSource1.ReportDocument.SetParameterValue("ky2", Session["DEN"] + "");
                CrystalReportSource1.ReportDocument.ExportToHttpResponse(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Response, false, "KET_QUA_BIEU_QUYET");

            }
        }
    }
}