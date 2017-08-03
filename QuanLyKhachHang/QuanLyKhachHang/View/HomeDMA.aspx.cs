using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using QuanLyKhachHang.Class;

namespace QuanLyKhachHang.View
{
    public partial class HomeDMA : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MaintainScrollPositionOnPostBack = true;
            if (IsPostBack)
                return;
            pagLoad();
        }
        public void pagLoad()
        {
             
            Session["dsDongnuoc"] = null;
            //DateTime tNgay = DateTime.ParseExact(tNgay.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            //DateTime dNgay = DateTime.ParseExact(dN.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

            //string sql = " SELECT ID, lat, lng,DiaChi, CONVERT(VARCHAR(20),TuNgay,103) AS TuNgay,CONVERT(VARCHAR(20),DenNgay,103) AS DenNgay , TuGio, DenGio, NoiDung, CreateDate, CreateBy, ModifyDate, ModifyBy from KT_DongNuoc where CAST(GETDATE()as date) between TuNgay and DenNgay ";
            string sql = " SELECT CASE WHEN Loai ='True' THEN N'ĐÓNG NƯỚC ' ELSE  N'GIẢM ÁP' END AS F, Loai, ID, lat, lng,DiaChi, CONVERT(VARCHAR(20),TuNgay,103) AS TuNgay,CONVERT(VARCHAR(20),DenNgay,103) AS DenNgay , TuGio, DenGio, NoiDung, CreateDate, CreateBy, ModifyDate, ModifyBy from KT_DongNuoc where  DongMo='True' ";
            Session["dsDongnuoc"] = C_KyThuat.getDataTable(sql);

            // update cs 
            C_KyThuat.ExecuteStoredProcedure("CAPNHAT_APLUC");
            //

            Session["dsDHTong"] = null;
            string sql2 = " SELECT *,CASE WHEN ApLuc IS NULL THEN '1' ELSE CASE WHEN ApLuc ='0' or ApLuc like '-%'  THEN  '0' ELSE '2'  END END AS F from THONGTINDMA where  Lat is not null ";
            DataTable dhTong = C_KyThuat.getDataTable(sql2);
            Session["dsDHTong"] = dhTong;

            //for (int i = 0; i < dhTong.Rows.Count; i++)
            //{
            //    string dma= dhTong.Rows[i]["MaDma"].ToString();
            //    string sq = "SELECT *  FROM [t_Channel_Configurations]  where LEFT([Description],5)='" + dma.Replace("TH-", "") + "' AND ChannelName='Pressure'";
            //    string sqLL = "SELECT *  FROM [t_Channel_Configurations]  where LEFT([Description],5)='" + dma.Replace("TH-", "") + "' AND ChannelName='Flow'";
            //    string sqTB = "SELECT *  FROM [DATALOGGER]  where MaDMA='" + dma.Replace("TH-", "").Replace("-", ".") + "' ";
                
            //    DataTable t2 = QuanLyKhachHang.Class.LinQConnectionGis.getDataTable(sqTB);

            //}
            

            // xả nước


            Session["dsXaNuoc"] = null;
            string sql3 = " SELECT * from KT_Van   where  XaCan='True' AND NgayXaCan= " + DateTime.Now.Date.Day;
            Session["dsXaNuoc"] = C_KyThuat.getDataTable(sql3); ;


            // HỆ THỐNG VAN


            //Session["dsVAN"] = null;
            //sql3 = " SELECT * from HeThongVan   where  LoaiVan=1";
            //Session["dsVAN"] = C_KyThuat.getDataTable(sql3); ;

        }
    }
}