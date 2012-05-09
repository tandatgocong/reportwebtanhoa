using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaoCao_Web.DataBase;
using System.Data;

namespace BaoCao_Web.Class
{
    public class C_DHN
    {
        TanHoaDataContext db = new TanHoaDataContext();
        // Thong Ke Dong Ho Nuoc
        public static DataTable getCoDHN()
        {
            string sql = "SELECT CONVERT(INT,CODH) AS CODH,COUNT(*) AS SODH ";
            sql += " FROM TB_DULIEUKHACHHANG";
            sql += " GROUP BY CODH";
            sql += " ORDER BY CONVERT(INT,CODH) ASC";
            return LinQConnection.getDataTable(sql);
        }

        public static DataTable getNamGanDHN()
        {
            string sql = "SELECT  YEAR(NGAYTHAY) as NGAYTHAY ,COUNT(*) AS SODH ";
            sql += " FROM TB_DULIEUKHACHHANG WHERE NGAYTHAY IS NOT NULL ";
            sql += " GROUP BY YEAR(NGAYTHAY) ";
            sql += " ORDER BY YEAR(NGAYTHAY) ASC";
            return LinQConnection.getDataTable(sql);
        }
    }
}