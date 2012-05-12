using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaoCao_Web.DataBase;
using System.Data;

namespace BaoCao_Web.Class
{
    public class C_BaoCaoCodeDS
    {
        static log4net.ILog log = log4net.LogManager.GetLogger("File");
        static TanHoaDataContext db = new TanHoaDataContext();

        public static void RESET_CODE_DS() {
            LinQConnection.ExecuteCommand("UPDATE W_BAOCAO_CODE SET KN_CODE4 = 0,KN_CODE5 = 0,KN_CODE6 = 0,KN_CODE8 = 0,KN_CODEM = 0,KN_CODEN = 0,KN_CODEQ = 0,KN_CODEF = 0,KN_CODEK = 0,KT_CODE4 = 0,KT_CODE5 = 0,KT_CODE6 = 0,KT_CODE8 = 0,KT_CODEM = 0,KT_CODEN = 0,KT_CODEQ = 0,KT_CODEF = 0,KT_CODEK = 0");
        }

        public static DataTable get_BAOCAO_CODE()
        {
            return  LinQConnection.getDataTable("SELECT * FROM W_BAOCAO_CODE");
        }
        public static void CAPNHATSOLIEU_BAOCAO_CODE_KYNAY(string nam, int ky)
        {
            string sql = "UPDATE W_BAOCAO_CODE SET ";
            sql += "  W_BAOCAO_CODE.KN_CODE4 = t2.CODE4, W_BAOCAO_CODE.KN_CODE5= t2.CODE5, ";
            sql += "  W_BAOCAO_CODE.KN_CODE6 = t2.CODE6, W_BAOCAO_CODE.KN_CODE8= t2.CODE8, ";
            sql += "  W_BAOCAO_CODE.KN_CODEM = t2.CODEM, W_BAOCAO_CODE.KN_CODEN= t2.CODEN, ";
            sql += "  W_BAOCAO_CODE.KN_CODEQ = t2.CODEQ, W_BAOCAO_CODE.KN_CODEF= t2.CODEF, ";
            sql += "  W_BAOCAO_CODE.KN_CODEK = t2.CODEK ";
            sql += " FROM W_BAOCAO_CODE INNER JOIN ";
            sql += " ( ";
            sql += " SELECT TODS,";
            sql += " COUNT(case when CODE LIKE '4%' then 1 else null end) AS CODE4,";
            sql += " COUNT(case when CODE LIKE '5%' then 1 else null end) AS CODE5,";
            sql += " COUNT(case when CODE LIKE '6%' then 1 else null end) AS CODE6,";
            sql += " COUNT(case when CODE LIKE '8%' then 1 else null end) AS CODE8,";
            sql += " COUNT(case when CODE LIKE 'M%' then 1 else null end) AS CODEM,";
            sql += " COUNT(case when CODE LIKE 'N%' then 1 else null end) AS CODEN,";
            sql += " COUNT(case when CODE LIKE 'Q%' then 1 else null end) AS CODEQ,";
            sql += " COUNT(case when CODE LIKE 'F%' then 1 else null end) AS CODEF,";
            sql += " COUNT(case when CODE LIKE 'K%' then 1 else null end) AS CODEK";
            sql += " FROM DocSo_PHT.dbo.DS" + nam;
            sql += " WHERE  KY=" + ky;
            sql += " GROUP BY TODS ";
            sql += " ) as t2 ";
            sql += " ON	W_BAOCAO_CODE.TODS = t2.TODS";

            try
            {
                int resqult = LinQConnection.ExecuteCommand(sql.Replace(@"\t", " "));

            }
            catch (Exception ex)
            {
                log.Error("CAPNHATSOLIEU_BAOCAO_CODE_KYNAY " + ex.Message);
            }
        }

        public static void CAPNHATSOLIEU_BAOCAO_CODE_KYTRUOC(string nam, int ky)
        {
            string sql = "UPDATE W_BAOCAO_CODE SET ";
            sql += "  W_BAOCAO_CODE.KT_CODE4 = t2.CODE4, W_BAOCAO_CODE.KT_CODE5= t2.CODE5, ";
            sql += "  W_BAOCAO_CODE.KT_CODE6 = t2.CODE6, W_BAOCAO_CODE.KT_CODE8= t2.CODE8, ";
            sql += "  W_BAOCAO_CODE.KT_CODEM = t2.CODEM, W_BAOCAO_CODE.KT_CODEN= t2.CODEN, ";
            sql += "  W_BAOCAO_CODE.KT_CODEQ = t2.CODEQ, W_BAOCAO_CODE.KT_CODEF= t2.CODEF, ";
            sql += "  W_BAOCAO_CODE.KT_CODEK = t2.CODEK ";
            sql += "FROM W_BAOCAO_CODE INNER JOIN ";
            sql += " ( ";
            sql += " SELECT TODS,";
            sql += " COUNT(case when CODE LIKE '4%' then 1 else null end) AS CODE4,";
            sql += " COUNT(case when CODE LIKE '5%' then 1 else null end) AS CODE5,";
            sql += " COUNT(case when CODE LIKE '6%' then 1 else null end) AS CODE6,";
            sql += " COUNT(case when CODE LIKE '8%' then 1 else null end) AS CODE8,";
            sql += " COUNT(case when CODE LIKE 'M%' then 1 else null end) AS CODEM,";
            sql += " COUNT(case when CODE LIKE 'N%' then 1 else null end) AS CODEN,";
            sql += " COUNT(case when CODE LIKE 'Q%' then 1 else null end) AS CODEQ,";
            sql += " COUNT(case when CODE LIKE 'F%' then 1 else null end) AS CODEF,";
            sql += " COUNT(case when CODE LIKE 'K%' then 1 else null end) AS CODEK";
            sql += " FROM DocSo_PHT.dbo.DS" + nam;
            sql += " WHERE  KY=" + ky;
            sql += " GROUP BY TODS ";
            sql += " ) as t2 ";
            sql += " ON	W_BAOCAO_CODE.TODS = t2.TODS";

            try
            {
                int resqult = LinQConnection.ExecuteCommand(sql.Replace(@"\t", " "));

            }
            catch (Exception ex)
            {
                log.Error("CAPNHATSOLIEU_BAOCAO_CODE_KYTRUOC " + ex.Message);
            }
        }


        /// chi tiet tung may doc so 
        /// 
        public static DataTable get_BAOCAO_CODE_MAY(int tods)
        {
            string sql = "SELECT * FROM W_BAOCAO_CODE_MAY WHERE TODS='" + tods + "' ORDER BY MAYDS ASC ";
            return LinQConnection.getDataTable(sql.Replace(@"\t", " "));
        }

        public static void CAPNHATSOLIEU_BAOCAO_CODE_MAY_KYNAY(string nam, int ky)
        {
            string sql = " INSERT INTO W_BAOCAO_CODE_MAY ";
            sql += " SELECT MAQUAN,MAPHUONG,";
            sql += " COUNT(case when ds.CODE LIKE '4%' then 1 else null end) AS KN_CODE4, ";
            sql += " COUNT(case when ds.CODE LIKE '5%' then 1 else null end) AS KN_CODE5, ";
            sql += " COUNT(case when ds.CODE LIKE '6%' then 1 else null end) AS KN_CODE6, ";
            sql += " COUNT(case when ds.CODE LIKE '8%' then 1 else null end) AS KN_CODE8, ";
            sql += " COUNT(case when ds.CODE LIKE 'M%' then 1 else null end) AS KN_CODEM, ";
            sql += " COUNT(case when ds.CODE LIKE 'N%' then 1 else null end) AS KN_CODEN, ";
            sql += " COUNT(case when ds.CODE LIKE 'Q%' then 1 else null end) AS KN_CODEQ, ";
            sql += " COUNT(case when ds.CODE LIKE 'F%' then 1 else null end) AS KN_CODEF, ";
            sql += " COUNT(case when ds.CODE LIKE 'K%' then 1 else null end) AS KN_CODEK, ";
            sql += " KT_CODE4=0,KT_CODE5=0,KT_CODE6=0,KT_CODE8=0 ,KT_CODEM=0 ,KT_CODEN=0,KT_CODEQ=0,KT_CODEF=0,KT_CODEK=0";
            sql += " FROM DocSo_PHT.dbo.DS" + nam + " ds , DocSo_PHT.dbo.KHACHHANG kh ";
            sql += " WHERE ds.DANHBA=kh.DANHBA AND MAQUAN IS NOT NULL AND ds.KY=" + ky;
            sql += " GROUP BY MAQUAN,MAPHUONG ";
            try
            {
                LinQConnection.ExecuteCommand("DELETE FROM W_BAOCAO_CODE_MAY ");
                int resqult = LinQConnection.ExecuteCommand(sql.Replace(@"\t", " "));

            }
            catch (Exception ex)
            {
                log.Error("CAPNHATSOLIEU_BAOCAO_SANLUONG_KYNAY_MAY " + ex.Message);
            }
        }

        public static void CAPNHATSOLIEU_BAOCAO_CODE_MAY_KYTRUOC(string nam, int ky)
        {
            string sql = "UPDATE W_BAOCAO_CODE_MAY SET ";
            sql += " W_BAOCAO_CODE_MAY.KT_CODE4 = t2.CODE4, W_BAOCAO_CODE_MAY.KT_CODE5= t2.CODE5, ";
            sql += " W_BAOCAO_CODE_MAY.KT_CODE6 = t2.CODE6, W_BAOCAO_CODE_MAY.KT_CODE8= t2.CODE8, ";
            sql += " W_BAOCAO_CODE_MAY.KT_CODEM = t2.CODEM, W_BAOCAO_CODE_MAY.KT_CODEN= t2.CODEN, ";
            sql += " W_BAOCAO_CODE_MAY.KT_CODEQ = t2.CODEQ, W_BAOCAO_CODE_MAY.KT_CODEF= t2.CODEF, ";
            sql += " W_BAOCAO_CODE_MAY.KT_CODEK = t2.CODEK ";
            sql += " FROM W_BAOCAO_CODE_MAY INNER JOIN ";
            sql += " ( ";
            sql += " SELECT MAQUAN,MAPHUONG,";
            sql += " COUNT(case when ds.CODE LIKE '4%' then 1 else null end) AS CODE4,";
            sql += " COUNT(case when ds.CODE LIKE '5%' then 1 else null end) AS CODE5,";
            sql += " COUNT(case when ds.CODE LIKE '6%' then 1 else null end) AS CODE6,";
            sql += " COUNT(case when ds.CODE LIKE '8%' then 1 else null end) AS CODE8,";
            sql += " COUNT(case when ds.CODE LIKE 'M%' then 1 else null end) AS CODEM,";
            sql += " COUNT(case when ds.CODE LIKE 'N%' then 1 else null end) AS CODEN,";
            sql += " COUNT(case when ds.CODE LIKE 'Q%' then 1 else null end) AS CODEQ,";
            sql += " COUNT(case when ds.CODE LIKE 'F%' then 1 else null end) AS CODEF,";
            sql += " COUNT(case when ds.CODE LIKE 'K%' then 1 else null end) AS CODEK";
            sql += " FROM DocSo_PHT.dbo.DS" + nam + " ds , DocSo_PHT.dbo.KHACHHANG kh ";
            sql += " WHERE ds.DANHBA=kh.DANHBA AND MAQUAN IS NOT NULL AND  ds.KY=" + ky;
            sql += " GROUP BY MAQUAN,MAPHUONG ";
            sql += " ) as t2 ";
            sql += " ON	W_BAOCAO_CODE_MAY.TODS = t2.MAQUAN AND W_BAOCAO_CODE_MAY.MAYDS = t2.MAPHUONG";

            try
            {
                int resqult = LinQConnection.ExecuteCommand(sql.Replace(@"\t", " "));

            }
            catch (Exception ex)
            {
                log.Error("CAPNHATSOLIEU_BAOCAO_SANLUONG_KYTRUOC " + ex.Message);
            }
        }

        ///// THEO ĐỢT

        public static void CAPNHATSOLIEU_BAOCAO_CODE_KYNAY_DOT(string nam, int ky, int dot)
        {
            string sql = "UPDATE W_BAOCAO_CODE SET ";
            sql += "  W_BAOCAO_CODE.KN_CODE4 = t2.CODE4, W_BAOCAO_CODE.KN_CODE5= t2.CODE5, ";
            sql += "  W_BAOCAO_CODE.KN_CODE6 = t2.CODE6, W_BAOCAO_CODE.KN_CODE8= t2.CODE8, ";
            sql += "  W_BAOCAO_CODE.KN_CODEM = t2.CODEM, W_BAOCAO_CODE.KN_CODEN= t2.CODEN, ";
            sql += "  W_BAOCAO_CODE.KN_CODEQ = t2.CODEQ, W_BAOCAO_CODE.KN_CODEF= t2.CODEF, ";
            sql += "  W_BAOCAO_CODE.KN_CODEK = t2.CODEK ";
            sql += "FROM W_BAOCAO_CODE INNER JOIN ";
            sql += " ( ";
            sql += " SELECT TODS,";
            sql += " COUNT(case when CODE LIKE '4%' then 1 else null end) AS CODE4,";
            sql += " COUNT(case when CODE LIKE '5%' then 1 else null end) AS CODE5,";
            sql += " COUNT(case when CODE LIKE '6%' then 1 else null end) AS CODE6,";
            sql += " COUNT(case when CODE LIKE '8%' then 1 else null end) AS CODE8,";
            sql += " COUNT(case when CODE LIKE 'M%' then 1 else null end) AS CODEM,";
            sql += " COUNT(case when CODE LIKE 'N%' then 1 else null end) AS CODEN,";
            sql += " COUNT(case when CODE LIKE 'Q%' then 1 else null end) AS CODEQ,";
            sql += " COUNT(case when CODE LIKE 'F%' then 1 else null end) AS CODEF,";
            sql += " COUNT(case when CODE LIKE 'K%' then 1 else null end) AS CODEK";
            sql += " FROM DocSo_PHT.dbo.DS" + nam;
            sql += " WHERE  KY=" + ky + " AND DOT =" + dot;
            sql += " GROUP BY TODS ";
            sql += " ) as t2 ";
            sql += " ON	W_BAOCAO_CODE.TODS = t2.TODS";

            try
            {
                int resqult = LinQConnection.ExecuteCommand(sql.Replace(@"\t", " "));

            }
            catch (Exception ex)
            {
                log.Error("CAPNHATSOLIEU_BAOCAO_CODE_KYNAY_DOT " + ex.Message);
            }
        }

        public static void CAPNHATSOLIEU_BAOCAO_CODE_KYTRUOC_DOT(string nam, int ky, int dot)
        {
            string sql = "UPDATE W_BAOCAO_CODE SET ";
            sql += "  W_BAOCAO_CODE.KT_CODE4 = t2.CODE4, W_BAOCAO_CODE.KT_CODE5= t2.CODE5, ";
            sql += "  W_BAOCAO_CODE.KT_CODE6 = t2.CODE6, W_BAOCAO_CODE.KT_CODE8= t2.CODE8, ";
            sql += "  W_BAOCAO_CODE.KT_CODEM = t2.CODEM, W_BAOCAO_CODE.KT_CODEN= t2.CODEN, ";
            sql += "  W_BAOCAO_CODE.KT_CODEQ = t2.CODEQ, W_BAOCAO_CODE.KT_CODEF= t2.CODEF, ";
            sql += "  W_BAOCAO_CODE.KT_CODEK = t2.CODEK ";
            sql += "FROM W_BAOCAO_CODE INNER JOIN ";
            sql += " ( ";
            sql += " SELECT TODS,";
            sql += " COUNT(case when CODE LIKE '4%' then 1 else null end) AS CODE4,";
            sql += " COUNT(case when CODE LIKE '5%' then 1 else null end) AS CODE5,";
            sql += " COUNT(case when CODE LIKE '6%' then 1 else null end) AS CODE6,";
            sql += " COUNT(case when CODE LIKE '8%' then 1 else null end) AS CODE8,";
            sql += " COUNT(case when CODE LIKE 'M%' then 1 else null end) AS CODEM,";
            sql += " COUNT(case when CODE LIKE 'N%' then 1 else null end) AS CODEN,";
            sql += " COUNT(case when CODE LIKE 'Q%' then 1 else null end) AS CODEQ,";
            sql += " COUNT(case when CODE LIKE 'F%' then 1 else null end) AS CODEF,";
            sql += " COUNT(case when CODE LIKE 'K%' then 1 else null end) AS CODEK";
            sql += " FROM DocSo_PHT.dbo.DS" + nam;
            sql += " WHERE  KY=" + ky + " AND DOT =" + dot;
            sql += " GROUP BY TODS ";
            sql += " ) as t2 ";
            sql += " ON	W_BAOCAO_CODE.TODS = t2.TODS";

            try
            {
                int resqult = LinQConnection.ExecuteCommand(sql.Replace(@"\t", " "));

            }
            catch (Exception ex)
            {
                log.Error("CAPNHATSOLIEU_BAOCAO_CODE_KYTRUOC_DOT " + ex.Message);
            }
        }


        /// chi tiet tung may doc so 
        /// 
        public static DataTable get_BAOCAO_CODE_MAY()
        {
            string sql = "SELECT '    '+(CONVERT(VARCHAR(10),TODS)+' '+CASE WHEN MAYDS<10 THEN '0'+(CONVERT(VARCHAR(10),MAYDS)) ELSE (CONVERT(VARCHAR(10),MAYDS)) END) AS TENTO, KN_CODE4, KN_CODE5, KN_CODE6, KN_CODE8, KN_CODEM, KN_CODEN, KN_CODEQ, KN_CODEF, KN_CODEK, KT_CODE4, KT_CODE5, KT_CODE6, KT_CODE8, KT_CODEM, KT_CODEN, KT_CODEQ, KT_CODEF, KT_CODEK";
            sql += " FROM W_BAOCAO_CODE_MAY  ORDER BY TODS ASC, MAYDS ASC ";
            return Class.LinQConnection.getDataTable(sql.Replace(@"\t", " "));
        }

        public static void CAPNHATSOLIEU_BAOCAO_CODE_KYNAY_MAY_DOT(string nam, int ky, int dot)
        {

            string sql = " INSERT INTO W_BAOCAO_CODE_MAY ";
            sql += " SELECT MAQUAN,MAPHUONG, ";
            sql += " COUNT(case when ds.CODE LIKE '4%' then 1 else null end) AS KN_CODE4, ";
            sql += " COUNT(case when ds.CODE LIKE '5%' then 1 else null end) AS KN_CODE5, ";
            sql += " COUNT(case when ds.CODE LIKE '6%' then 1 else null end) AS KN_CODE6, ";
            sql += " COUNT(case when ds.CODE LIKE '8%' then 1 else null end) AS KN_CODE8, ";
            sql += " COUNT(case when ds.CODE LIKE 'M%' then 1 else null end) AS KN_CODEM, ";
            sql += " COUNT(case when ds.CODE LIKE 'N%' then 1 else null end) AS KN_CODEN, ";
            sql += " COUNT(case when ds.CODE LIKE 'Q%' then 1 else null end) AS KN_CODEQ, ";
            sql += " COUNT(case when ds.CODE LIKE 'F%' then 1 else null end) AS KN_CODEF, ";
            sql += " COUNT(case when ds.CODE LIKE 'K%' then 1 else null end) AS KN_CODEK, ";
            sql += " KT_CODE4=0,KT_CODE5=0,KT_CODE6=0,KT_CODE8=0 ,KT_CODEM=0 ,KT_CODEN=0,KT_CODEQ=0,KT_CODEF=0,KT_CODEK=0";
            sql += " FROM DocSo_PHT.dbo.DS" + nam + " ds , DocSo_PHT.dbo.KHACHHANG kh ";
            sql += " WHERE ds.DANHBA=kh.DANHBA AND MAQUAN IS NOT NULL AND  ds.KY=" + ky + " AND ds.DOT =" + dot;
            sql += " GROUP BY MAQUAN,MAPHUONG ";


            try
            {
                LinQConnection.ExecuteCommand("DELETE FROM W_BAOCAO_CODE_MAY ");
                int resqult = LinQConnection.ExecuteCommand(sql.Replace(@"\t", " "));

            }
            catch (Exception ex)
            {
                log.Error("CAPNHATSOLIEU_BAOCAO_CODE_KYNAY_MAY_DOT " + ex.Message);
            }
        }

        public static void CAPNHATSOLIEU_BAOCAO_CODE_KYTRUOC_MAY_DOT(string nam, int ky, int dot)
        {
            string sql = "UPDATE W_BAOCAO_CODE SET ";
            sql += "  W_BAOCAO_CODE.KT_CODE4 = t2.CODE4, W_BAOCAO_CODE.KT_CODE5= t2.CODE5, ";
            sql += "  W_BAOCAO_CODE.KT_CODE6 = t2.CODE6, W_BAOCAO_CODE.KT_CODE8= t2.CODE8, ";
            sql += "  W_BAOCAO_CODE.KT_CODEM = t2.CODEM, W_BAOCAO_CODE.KT_CODEN= t2.CODEN, ";
            sql += "  W_BAOCAO_CODE.KT_CODEQ = t2.CODEQ, W_BAOCAO_CODE.KT_CODEF= t2.CODEF, ";
            sql += "  W_BAOCAO_CODE.KT_CODEK = t2.CODEK ";
            sql += "FROM W_BAOCAO_CODE INNER JOIN ";
            sql += " ( ";
            sql += " SELECT MAQUAN,MAPHUONG,";
            sql += " COUNT(case when ds.CODE LIKE '4%' then 1 else null end) AS CODE4,";
            sql += " COUNT(case when ds.CODE LIKE '5%' then 1 else null end) AS CODE5,";
            sql += " COUNT(case when ds.CODE LIKE '6%' then 1 else null end) AS CODE6,";
            sql += " COUNT(case when ds.CODE LIKE '8%' then 1 else null end) AS CODE8,";
            sql += " COUNT(case when ds.CODE LIKE 'M%' then 1 else null end) AS CODEM,";
            sql += " COUNT(case when ds.CODE LIKE 'N%' then 1 else null end) AS CODEN,";
            sql += " COUNT(case when ds.CODE LIKE 'Q%' then 1 else null end) AS CODEQ,";
            sql += " COUNT(case when ds.CODE LIKE 'F%' then 1 else null end) AS CODEF,";
            sql += " COUNT(case when ds.CODE LIKE 'K%' then 1 else null end) AS CODEK";
            sql += " FROM DocSo_PHT.dbo.DS" + nam + " ds , DocSo_PHT.dbo.KHACHHANG kh ";
            sql += " WHERE ds.DANHBA=kh.DANHBA AND MAQUAN IS NOT NULL AND  ds.KY=" + ky + " AND ds.DOT =" + dot;
            sql += " GROUP BY MAQUAN,MAPHUONG ";
            sql += " ) as t2 ";
            sql += " ON	W_BAOCAO_CODE_MAY.TODS = t2.MAQUAN AND W_BAOCAO_CODE_MAY.MAYDS = t2.MAPHUONG";

            try
            {
                int resqult = LinQConnection.ExecuteCommand(sql.Replace(@"\t", " "));

            }
            catch (Exception ex)
            {
                log.Error("CAPNHATSOLIEU_BAOCAO_SANLUONG_KYTRUOC_DOT " + ex.Message);
            }
        }
    }
}