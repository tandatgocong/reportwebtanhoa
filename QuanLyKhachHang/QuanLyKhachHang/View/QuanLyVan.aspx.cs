using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using QuanLyKhachHang.Class;

namespace QuanLyKhachHang.View
{
    public partial class QuanLyVan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login"] == null)
            {
                Response.Redirect(@"Login.aspx");
            }
            MaintainScrollPositionOnPostBack = true;
            if (IsPostBack)
                return;
            pagLoad();
        }

        public void pagLoad()
        {
            Session["dsVan"] = null;
            string sql = "SELECT  v.*,CASE WHEN v.ChanTuyen = 1 THEN N'Chặn Tuyến' ELSE  ";
            sql += "    CASE WHEN v.XaCan = 1 THEN N'Xã Cặn' ELSE  ";
            sql += "        CASE WHEN v.TCH=1 THEN N'TCH' ELSE  ";
            sql += "      CASE WHEN v.VanBien=1 THEN  N'Van Biên' ELSE '' END END END END AS TenLoai  ";
            sql += "    FROM  [KT_Van] v  ";
            sql += "     WHERE Xoa='false' ";
            Session["dsVan"] = C_KyThuat.getDataTable(sql);

        }
        void search()
        {
            string dc = "";
            //string URLString = "https://maps.googleapis.com/maps/api/geocode/xml?address= " + dc + ", Ho Chi Minh City, Ho Chi Minh, Vietnam&key=AIzaSyBnK4XMpV0do1pWTYFGUydQvA_EyMkJ9xU";
            string URLString = " http://maps.google.com/maps/api/geocode/xml?latlng=10.7684380,106.6306070&sensor=false ";
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

            //this.Label2.Text = lat + "--" + lng;
            Session["lat"] = lat;
            Session["lng"] = lng;
            //var json = new WebClient().DownloadString(url);
            // this.Label2.Text = json.ToString();

        }
        //protected void btTim_Click(object sender, EventArgs e)
        //{
        //    search();

        //}
    }
}