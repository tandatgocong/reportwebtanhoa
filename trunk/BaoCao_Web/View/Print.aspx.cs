using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaoCao_Web.View
{
    public partial class Print : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string sql = "";
            string title="";
            if ("TK".Equals(Request.Params["page"] + ""))
            {
                sql = "SELECT ISNULL(kh.LOTRINH,hd.KHU) as LOTRINH,hd.DANHBO,hd.HOPDONG,ISNULL(kh.HOTEN,hd.TENKH) as HOTEN,ISNULL(kh.SONHA,hd.SONHA) as SONHA, ";
                sql+=" ISNULL(kh.TENDUONG,hd.DUONG) as TENDUONG,ISNULL(kh.HIEUDH,'') as HIEU,ISNULL(kh.CODH,hd.CODH) as CO,ISNULL(YEAR(NGAYTHAY),'') as NAM,hd.CODE,hd.LNCC as 'TIEUTHU' ";
                sql += " FROM HOADONTH" + Session["tuky"] + " hd ";
                sql+=" LEFT JOIN TB_DULIEUKHACHHANG kh ";
                sql+=" ON kh.DANHBO = hd.DANHBO ";
                sql+=" WHERE hd.LNCC=0 ";
                sql+=" ORDER BY kh.LOTRINH ASC ";

                title = "DANH SÁCH ĐHN TIÊU THỤ = 0 M3 KỲ " + Session["tuky"].ToString().Replace("_",@"/");

            }
            else if ("DK".Equals(Request.Params["page"] + ""))
            {
                sql = "SELECT ISNULL(kh.LOTRINH,hd.KHU) as LOTRINH,hd.DANHBO,hd.HOPDONG,ISNULL(kh.HOTEN,hd.TENKH) as HOTEN,ISNULL(kh.SONHA,hd.SONHA) as SONHA, ";
                sql += " ISNULL(kh.TENDUONG,hd.DUONG) as TENDUONG,ISNULL(kh.HIEUDH,'') as HIEU,ISNULL(kh.CODH,hd.CODH) as CO,ISNULL(YEAR(NGAYTHAY),'') as NAM,hd.CODE,hd.LNCC as 'TIEUTHU' ";
                sql += " FROM HOADONTH" + Session["denky"] + " hd ";
                sql += " LEFT JOIN TB_DULIEUKHACHHANG kh ";
                sql += " ON kh.DANHBO = hd.DANHBO ";
                sql += " WHERE hd.LNCC=0 ";
                sql += " ORDER BY kh.LOTRINH ASC ";
                title = "DANH SÁCH ĐHN TIÊU THỤ = 0 M3 KỲ " + Session["denky"].ToString().Replace("_", @"/");
            }
            else if ("2K".Equals(Request.Params["page"] + ""))
            {
                sql = " SELECT K01.KHU as LOTRINH,K01.DANHBO,K01.HOPDONG,K01.TENKH as HOTEN,K01.SONHA, ";
                sql += " K01.DUONG as TENDUONG,K01.HIEUDH as HIEU,K01.CODH  as CO,K01.NAMLD as NAM,K01.CODE,K01.LNCC as 'TIEUTHU'  ";
                sql += " FROM HOADONTH" + Session["tuky"] + " K12, HOADONTH" + Session["denky"] + " K01  ";
                sql += " WHERE K12.DANHBO= K01.DANHBO AND K12.LNCC =0 AND K01.LNCC = 0 ";
                sql += " ORDER BY K01.KHU ASC ";

                title = "DANH SÁCH ĐHN TIÊU THỤ = 0 M3 KỲ " + Session["tuky"].ToString().Replace("_", @"/") + " VÀ KỲ " + Session["denky"].ToString().Replace("_", @"/");
            }
            else if ("DL".Equals(Request.Params["page"] + ""))
            {
                sql = " SELECT K01.KHU as LOTRINH,K01.DANHBO,K01.HOPDONG,K01.TENKH as HOTEN,K01.SONHA, ";
                sql += " K01.DUONG as TENDUONG,K01.HIEUDH as HIEU,K01.CODH  as CO,K01.NAMLD as NAM,K01.CODE,K01.LNCC as 'TIEUTHU'  ";
                sql += " FROM HOADONTH" + Session["tuky"] + " K12, HOADONTH" + Session["denky"] + " K01  ";
                sql += " WHERE K12.DANHBO= K01.DANHBO AND K12.LNCC =0 AND K01.LNCC <> 0";
                sql += " ORDER BY K01.KHU ASC ";

                 title = "DANH SÁCH ĐHN TIÊU THỤ = 0 M3 KỲ " + Session["tuky"].ToString().Replace("_", @"/") + " SỬ DỤNG LẠI KỲ " + Session["denky"].ToString().Replace("_", @"/");
            }
            else if ("PS".Equals(Request.Params["page"] + ""))
            {
                sql = " SELECT K01.KHU as LOTRINH,K01.DANHBO,K01.HOPDONG,K01.TENKH as HOTEN,K01.SONHA, ";
                sql += " K01.DUONG as TENDUONG,K01.HIEUDH as HIEU,K01.CODH  as CO,K01.NAMLD as NAM,K01.CODE,K01.LNCC as 'TIEUTHU'  ";
                sql += " FROM HOADONTH" + Session["tuky"] + " K12, HOADONTH" + Session["denky"] + " K01  ";
                sql += " WHERE K12.DANHBO= K01.DANHBO AND K12.LNCC <> 0 AND K01.LNCC = 0";
                sql += " ORDER BY K01.KHU ASC ";

                title = "DANH SÁCH ĐHN KỲ " + Session["tuky"].ToString().Replace("_", @"/") + " CÓ TIÊU THỤ = 0M3 KỲ " + Session["denky"].ToString().Replace("_", @"/");
            }

            CrystalReportSource1.ReportDocument.SetDataSource(Class.LinQConnection.getDataTable(sql));
            CrystalReportSource1.ReportDocument.SetParameterValue("title", title);
            CrystalReportSource1.ReportDocument.ExportToHttpResponse(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Response, false, "DANH_SACH_DHN");
    
        }
    }
}