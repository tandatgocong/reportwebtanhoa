using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaoCao_Web.DataBase;
using log4net;
using System.Data;

namespace BaoCao_Web.Class
{
    public class SoLieuKinhDoanh
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(SoLieuKinhDoanh).Name);
        
        public static DataTable getSoLieuByYear(string year)
        {
            string query = "SELECT * FROM BAOCAO_KINHDOANH WHERE NAM='"+year+"'  ORDER BY KY ASC ";
            return LinQConnection.getDataTable(query);
        }
    }
}