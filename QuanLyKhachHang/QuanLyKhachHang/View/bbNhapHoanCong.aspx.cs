﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using QuanLyKhachHang.Class;

namespace QuanLyKhachHang.View
{
    public partial class bbNhapHoanCong : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["page"] = "bbNhapHoanCong.aspx";
            if (Session["login"] == null)
            {
                Response.Redirect(@"Login.aspx");
            }
            else if (("TOCNTT".Contains(Session["phong"].ToString())))
            {

            }
            else if (!("DTCTB,DTCXL".Contains(Session["phong"].ToString())))
            {
                 Response.Redirect(@"zphanquyen.aspx");
            }

            MaintainScrollPositionOnPostBack = true;
            if (IsPostBack)
                return;
            pagLoad();

            if (Request.QueryString["login"] != null)
                Session["login"] = Request.QueryString["login"].ToString();

        }

        public void pagLoad()
        {
            Session["dsBaoBe"] = null;
            //DateTime tNgay = DateTime.ParseExact(tNgay.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            //DateTime dNgay = DateTime.ParseExact(dN.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

            //string sql = " SELECT ID, lat, lng,DiaChi, CONVERT(VARCHAR(20),TuNgay,103) AS TuNgay,CONVERT(VARCHAR(20),DenNgay,103) AS DenNgay , TuGio, DenGio, NoiDung, CreateDate, CreateBy, ModifyDate, ModifyBy from KT_DongNuoc where CAST(GETDATE()as date) between TuNgay and DenNgay ";
            string sql = " SELECT v.*,CASE WHEN v.LoaiThucHien  = 1 THEN N'Hoàn Thiện' ELSE N'' END  AS TenLoai, (CAST( (DATEDIFF(mi,TuGio,DenGio)/60) AS VARCHAR)) AS GIO,   CAST(  (DATEDIFF(mi,TuGio,DenGio)%60) AS VARCHAR) as PHUT, ";
            sql += " (CAST((DATEDIFF(mi,NgayBao,DenGio)/60) AS VARCHAR)) AS HGIO,   CAST((DATEDIFF(mi,NgayBao,DenGio)%60) AS VARCHAR) as HPHUT, ";
            sql += " CASE WHEN DATEDIFF(DD,NgayBao,GETDATE())>3  AND NgayThucHien IS NULL THEN 1 ELSE 0 END  AS BETON,CASE WHEN NgayTiepNhan IS NULL THEN 1 ELSE 2 END AS THUCHIEN  from KT_BaoBe v WHERE DonViSuaBe='" + Session["phong"] + "'";
            Session["dsBaoBe"] = C_KyThuat.getDataTable(sql);

        }
        void search()
        {
            string dc = "";
            string URLString = "https://maps.googleapis.com/maps/api/geocode/xml?address= " + dc + ", Ho Chi Minh City, Ho Chi Minh, Vietnam&key=AIzaSyBnK4XMpV0do1pWTYFGUydQvA_EyMkJ9xU";
            XmlTextReader reader = new XmlTextReader(URLString);
            string geometry = "";
            string lat = "0";
            string lng = "0";
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.
                        //Console.Write("<" + reader.Name);
                        //Console.WriteLine(">");
                        geometry = reader.Name;
                        break;

                    case XmlNodeType.Text: //Display the text in each element.
                        //Console.WriteLine(reader.Value);
                        if (geometry == "lat")
                            lat = reader.Value;
                        else if (geometry == "lng")
                            lng = reader.Value;
                        break;

                    case XmlNodeType.EndElement: //Display the end of the element.
                        //Console.Write("</" + reader.Name);
                        //Console.WriteLine(">");
                        break;
                }
            }

            //  this.Label2.Text = lat + "--" + lng;
            Session["lat"] = lat;
            Session["lng"] = lng;
            //var json = new WebClient().DownloadString(url);
            // this.Label2.Text = json.ToString();

        }
        protected void btTim_Click(object sender, EventArgs e)
        {
            search();

        }
    }
}
