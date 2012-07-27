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
        log4net.ILog log = log4net.LogManager.GetLogger("File");
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

        public static DataTable getNamGanDHN(string ky, string nam)
        {
            string sql = "SELECT  YEAR(NGAYTHAY) as NGAYTHAY ,COUNT(*) AS SODH ";
            sql += " FROM TB_DULIEUKHACHHANG WHERE NGAYTHAY IS NOT NULL AND KY<= " + ky + " AND NAM <= " + nam;
            sql += " GROUP BY YEAR(NGAYTHAY) ";
            sql += " ORDER BY YEAR(NGAYTHAY) ASC";
            return LinQConnection.getDataTable(sql);
        }

        public static int TongSoDHN(string ky, string nam)
        {
            string sql = "SELECT * ";
            sql += " FROM TB_DULIEUKHACHHANG WHERE KY<= " + ky + " AND NAM <= " + nam;            
            return LinQConnection.getDataTable(sql).Rows.Count;
        }
        public static DataTable getThongKeDHN(int ky, int nam)
        {
            
            string sql = " SELECT hdh.TENDONGHO,";
			sql += " 	COUNT(CASE WHEN CODH=15 THEN 1 ELSE NULL END) AS CO15,";
			sql += " 	COUNT(CASE WHEN CODH=20 THEN 1 ELSE NULL END) AS CO20,";
			sql += " 	COUNT(CASE WHEN CODH=25 THEN 1 ELSE NULL END) AS CO25,";
			sql += " 	COUNT(CASE WHEN CODH=40 THEN 1 ELSE NULL END) AS CO40,";
			sql += " 	COUNT(CASE WHEN CODH=50 THEN 1 ELSE NULL END) AS CO50,";
			sql += " 	COUNT(CASE WHEN (CODH=75 OR  CODH= 80) THEN 1 ELSE NULL END) AS CO80,";
			sql += " 	COUNT(CASE WHEN CODH=100 THEN 1 ELSE NULL END) AS CO100,";
			sql += " 	COUNT(CASE WHEN CODH=150 THEN 1 ELSE NULL END) AS CO150,";
			sql += " 	COUNT(CASE WHEN CODH=200 THEN 1 ELSE NULL END) AS CO200,";
			sql += " 	COUNT(CASE WHEN CODH=15 AND ((YEAR(CURRENT_TIMESTAMP) -YEAR(NGAYTHAY)) < 5) THEN 1 ELSE NULL END) AS NHOCO15,";
			sql += " 	COUNT(CASE WHEN CODH=20 AND ((YEAR(CURRENT_TIMESTAMP) -YEAR(NGAYTHAY)) < 5) THEN 1 ELSE NULL END) AS NHOCO20,";
			sql += " 	COUNT(CASE WHEN CODH=25 AND ((YEAR(CURRENT_TIMESTAMP) -YEAR(NGAYTHAY)) < 5) THEN 1 ELSE NULL END) AS NHOCO25,";
			sql += " 	COUNT(CASE WHEN CODH=40 AND ((YEAR(CURRENT_TIMESTAMP) -YEAR(NGAYTHAY)) < 5) THEN 1 ELSE NULL END) AS NHOCO40,";
			sql += " 	COUNT(CASE WHEN CODH=50 AND ((YEAR(CURRENT_TIMESTAMP) -YEAR(NGAYTHAY)) < 5) THEN 1 ELSE NULL END) AS NHOCO50,";
			sql += " 	COUNT(CASE WHEN (CODH=75 OR  CODH= 80) AND ((YEAR(CURRENT_TIMESTAMP) -YEAR(NGAYTHAY)) < 5)  THEN 1 ELSE NULL END) AS NHOCO80,";
			sql += " 	COUNT(CASE WHEN CODH=100 AND ((YEAR(CURRENT_TIMESTAMP) -YEAR(NGAYTHAY)) < 5) THEN 1 ELSE NULL END) AS NHOCO100,";
			sql += " 	COUNT(CASE WHEN CODH=150 AND ((YEAR(CURRENT_TIMESTAMP) -YEAR(NGAYTHAY)) < 5) THEN 1 ELSE NULL END) AS NHOCO150,";
			sql += " 	COUNT(CASE WHEN CODH=200 AND ((YEAR(CURRENT_TIMESTAMP) -YEAR(NGAYTHAY)) < 5) THEN 1 ELSE NULL END) AS NHOCO200,";
			sql += " 	COUNT(CASE WHEN CODH=15 AND ((YEAR(CURRENT_TIMESTAMP) -YEAR(NGAYTHAY)) >=5) THEN 1 ELSE NULL END) AS LONCO15,";
			sql += " 	COUNT(CASE WHEN CODH=20 AND ((YEAR(CURRENT_TIMESTAMP) -YEAR(NGAYTHAY)) >=5) THEN 1 ELSE NULL END) AS LONCO20,";
			sql += " 	COUNT(CASE WHEN CODH=25 AND ((YEAR(CURRENT_TIMESTAMP) -YEAR(NGAYTHAY)) >=5) THEN 1 ELSE NULL END) AS LONCO25,";
			sql += " 	COUNT(CASE WHEN CODH=40 AND ((YEAR(CURRENT_TIMESTAMP) -YEAR(NGAYTHAY)) >=5) THEN 1 ELSE NULL END) AS LONCO40,";
			sql += " 	COUNT(CASE WHEN CODH=50 AND ((YEAR(CURRENT_TIMESTAMP) -YEAR(NGAYTHAY)) >=5) THEN 1 ELSE NULL END) AS LONCO50,";
			sql += " 	COUNT(CASE WHEN (CODH=75 OR  CODH= 80) AND ((YEAR(CURRENT_TIMESTAMP) -YEAR(NGAYTHAY)) >=5)  THEN 1 ELSE NULL END) AS LONCO80,";
			sql += " 	COUNT(CASE WHEN CODH=100 AND ((YEAR(CURRENT_TIMESTAMP) -YEAR(NGAYTHAY)) >=5) THEN 1 ELSE NULL END) AS LONCO100,";
			sql += " 	COUNT(CASE WHEN CODH=150 AND ((YEAR(CURRENT_TIMESTAMP) -YEAR(NGAYTHAY)) >=5) THEN 1 ELSE NULL END) AS LONCO150,";
			sql += " 	COUNT(CASE WHEN CODH=200 AND ((YEAR(CURRENT_TIMESTAMP) -YEAR(NGAYTHAY)) >=5) THEN 1 ELSE NULL END) AS LONCO200";
			sql += " FROM dbo.TB_DULIEUKHACHHANG kh, TB_HIEUDONGHO hdh";
            sql += " WHERE kh.NAM<=+" + nam + " AND kh.KY<=" + ky + " AND LEFT(kh.HIEUDH,3)=hdh.HIEUDH";
			sql += " GROUP BY   hdh.TENDONGHO";
            return LinQConnection.getDataTable(sql);
        }
        public static DataTable getThongKeThayDHN(string tungay, string denngay)
        {
            string sql = "SELECT COUNT(case when CONVERT(DATETIME,DHN_NGAYBAOTHAY,103) BETWEEN CONVERT(DATETIME,'" + tungay + "',103) AND CONVERT(DATETIME,'" + denngay + "',103) then 1 else null end) AS SOLUONGTHAY ";
            sql += ",COUNT(case when (HCT_TRONGAI ='False' OR HCT_TRONGAI IS NULL) AND  CONVERT(DATETIME,HCT_NGAYGAN,103) BETWEEN CONVERT(DATETIME,'" + tungay + "',103) AND CONVERT(DATETIME,'" + denngay + "',103) then 1 else null end) AS HOANTAT ";
            sql += ",COUNT(case when HCT_TRONGAI ='True' AND  CONVERT(DATETIME,HCT_NGAYGAN,103) BETWEEN CONVERT(DATETIME,'" + tungay + "',103) AND CONVERT(DATETIME,'" + denngay + "',103) then 1 else null end) AS TRONGAI ";
            sql += ", COUNT(case when CONVERT(DATETIME,DHN_NGAYBAOTHAY,103) BETWEEN CONVERT(DATETIME,'" + tungay + "',103) AND CONVERT(DATETIME,'" + denngay + "',103) then 1 else null end) ";
            sql += "-(COUNT(case when (HCT_TRONGAI ='False' OR HCT_NGAYGAN IS NOT NULL) AND  CONVERT(DATETIME,HCT_NGAYGAN,103) BETWEEN CONVERT(DATETIME,'" + tungay + "',103) AND CONVERT(DATETIME,'" + denngay + "',103) then 1 else null end) ";
            sql += " +COUNT(case when HCT_TRONGAI ='True'  AND  CONVERT(DATETIME,HCT_NGAYGAN,103) BETWEEN CONVERT(DATETIME,'" + tungay + "',103) AND CONVERT(DATETIME,'" + denngay + "',103) then 1 else null end)) AS CHUAGAN ";
            sql += " FROM TB_THAYDHN WHERE DHN_DANHBO IS NOT NULL ";

            return LinQConnection.getDataTable(sql);
        }

        public static DataTable getThongKeLoaiBaoThay(string tungay, string denngay)
        {
            string sql = "SELECT REPLACE(TENBANGKE,'THEO','') AS 'BANGKE', COUNT(*) AS 'SOLUONG'";
            sql += " FROM dbo.TB_THAYDHN T , dbo.TB_LOAIBANGKE L WHERE T.DHN_LOAIBANGKE=L.LOAIBK ";
            sql += " AND CONVERT(DATETIME,DHN_NGAYBAOTHAY,103) BETWEEN CONVERT(DATETIME,'" + tungay + "',103) AND CONVERT(DATETIME,'" + denngay + "',103) ";
            sql += " GROUP BY TENBANGKE ";
            return LinQConnection.getDataTable(sql);
        }

        public static DataTable getTroNgaiThay(string tungay, string denngay)
        {
            string sql = "SELECT loai.TENBANGKE,(DHN_TODS+'-'+CONVERT(VARCHAR(20),DHN_SOBANGKE)) as 'SOBANGKE',thay.DHN_DANHBO, kh.HOTEN,(kh.SONHA+' ' +kh.TENDUONG) AS 'DIACHI'  , CONVERT(VARCHAR(20),DHN_NGAYBAOTHAY,103) AS 'NGAYBAO' , HCT_LYDOTRONGAI as 'TRONGAI' ";
            sql += " FROM TB_THAYDHN thay, TB_LOAIBANGKE loai,TB_DULIEUKHACHHANG kh  ";
            sql += " WHERE thay.DHN_DANHBO=kh.DANHBO AND thay.DHN_LOAIBANGKE=loai.LOAIBK  AND HCT_TRONGAI ='1' ";
            sql += " AND CONVERT(DATETIME,HCT_NGAYGAN,103) BETWEEN CONVERT(DATETIME,'" + tungay + "',103) AND CONVERT(DATETIME,'" + denngay + "',103) ";
            sql += " ORDER BY DHN_NGAYBAOTHAY DESC";

            return LinQConnection.getDataTable(sql);
        }
    }
}