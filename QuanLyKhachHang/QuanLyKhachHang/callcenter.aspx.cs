using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using QuanLyKhachHang.Class;


namespace QuanLyKhachHang
{
    public partial class callcenter : System.Web.UI.Page
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
            string sql = " SELECT ID, lat, lng,DiaChi, CONVERT(VARCHAR(20),TuNgay,103) AS TuNgay,CONVERT(VARCHAR(20),DenNgay,103) AS DenNgay , TuGio, DenGio, NoiDung, CreateDate, CreateBy, ModifyDate, ModifyBy from KT_DongNuoc where  DongMo='True' ";
            Session["dsDongnuoc"] = C_CallCenter.getDataTable(sql);

        }
        void search()
        {
            string dc = this.TextBox1.Text;
            string URLString = "https://maps.googleapis.com/maps/api/geocode/xml?address= " + dc + ", Ho Chi Minh City, Ho Chi Minh, Vietnam&key=AIzaSyBnK4XMpV0do1pWTYFGUydQvA_EyMkJ9xU";
            XmlTextReader reader = new XmlTextReader(URLString);
            string geometry = "";
            string lat = "0";
            string lng = "0";
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: 
                        geometry = reader.Name;
                        break;

                    case XmlNodeType.Text: 
                        if (geometry == "lat")
                            lat = reader.Value;
                        else if (geometry == "lng")
                            lng = reader.Value;
                        break;

                    case XmlNodeType.EndElement: 
                        break;
                }
            }

            Session["lat"] = lat;
            Session["lng"] = lng;
            //var json = new WebClient().DownloadString(url);
            // this.Label2.Text = json.ToString();

        }
        protected void btTim_Click(object sender, EventArgs e)
        {
            search();

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            search();
        }

    }
}