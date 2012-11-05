using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Globalization;
using ExcelCOM = Microsoft.Office.Interop.Excel;
using System.IO;

namespace BaoCao_Web.View
{
    public partial class ChamCong : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MaintainScrollPositionOnPostBack = true;
            if (IsPostBack)
                return;
            DropDownList1.DataSource = Class.LinQConnection.getDataTable("SELECT * FROM TCHC_PHONGBAN ORDER BY ID ASC ");
            DropDownList1.DataTextField = "TENPHONG";
            DropDownList1.DataValueField = "ID";
            DropDownList1.DataBind();
        }

        public void AddTableTre(DataTable tableTre, string manv, string tennv, string phongban, string ngay, string thu, string giovao, string giora, string tre,string som) {
            if (tableTre != null) {
                DataRow row = tableTre.NewRow();
                row["MANV"] = manv;
                row["TENNV"] = tennv;
                row["PHONGBAN"] = phongban;
                row["NGAY"] = ngay;
                row["THU"] = thu;
                row["GIOVAO"] = giovao;
                row["GIORA"] = giora;
                row["TRE"] = tre;
                row["SOM"] = som;
                tableTre.Rows.Add(row);
            }
           
        }
        
        public void LoadData()
        {
            DataTable tableTre = new DataTable();
            tableTre.Columns.Add("MANV", typeof(String));
            tableTre.Columns.Add("TENNV", typeof(String));
            tableTre.Columns.Add("PHONGBAN", typeof(String));
            tableTre.Columns.Add("NGAY", typeof(String));
            tableTre.Columns.Add("THU", typeof(String));
            tableTre.Columns.Add("GIOVAO", typeof(String));
            tableTre.Columns.Add("GIORA", typeof(String));
            tableTre.Columns.Add("TRE", typeof(String));
            tableTre.Columns.Add("SOM", typeof(String));

            string connectionString = ConfigurationManager.ConnectionStrings["CAPNUOCTANHOA.Properties.Settings.AccessFile"].ConnectionString;
            string sql = " SELECT info.UserFullCode, info.UserFullName, dt.Dept";
            sql += " FROM UserInfo info,Dept dt WHERE info.IDD=dt.IDD ";
            if (!"1".Equals(DropDownList1.SelectedValue))
            {
                sql += " AND info.IDD=" + DropDownList1.SelectedValue;
            }
            if (ckNV.Checked)
            {
                sql += " AND info.UserLoaiNV='VP' ";
            }
            if (ckCN.Checked)
            {
                sql += " AND info.UserLoaiNV='CN' ";
            }
            sql += " ORDER BY info.IDD ASC, info.UserFullCode ASC ";
            string dateformat = ConfigurationManager.AppSettings["dateformat"].ToString();
            DataTable workTable = new DataTable("NHANSU");
            DataColumn workCol = workTable.Columns.Add("MANV", typeof(String));
            workTable.Columns.Add("TENNV", typeof(String));
            DateTime tNgay = DateTime.ParseExact(tungay.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            DateTime dNgay = DateTime.ParseExact(denngay.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            TimeSpan Time = dNgay - tNgay;
            int TongSoNgay = Time.Days + 3;
            Panel2.Width = TongSoNgay * 150;
            string[] arrTitle = new string[TongSoNgay];
            int numTitle = 0;
            arrTitle[numTitle++] = "NGÀY CÔNG";
            arrTitle[numTitle++] = "TRỂ";
            int flag = 2;
            while (tNgay <= dNgay)
            {
                workTable.Columns.Add(Class.Format.NgayVNVN(tNgay), typeof(String));
                arrTitle[numTitle++] = Class.Format.NgayVNVN(tNgay);
                workTable.Columns.Add(Class.Format.NgayVNVN(tNgay) + "TRE", typeof(String));              
                workTable.Columns.Add(Class.Format.NgayVNVN(tNgay) + "RA", typeof(String));
                workTable.Columns.Add(Class.Format.NgayVNVN(tNgay) + "SOM", typeof(String));
                tNgay = tNgay.AddDays(1.0);
                flag = flag + 3;
            }
            workTable.Columns.Add("NGÀY CÔNG", typeof(String));
            workTable.Columns.Add("TRỂ", typeof(String));
            flag = flag + 2;

            DataTable tb = Class.OledbConnection.getDataTable(connectionString, sql);
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                int tongngaycong = 0;
                int tongtre = 0;
                string manv = tb.Rows[i]["UserFullCode"].ToString();
                string tennv = tb.Rows[i]["UserFullName"].ToString();
                string phongban = tb.Rows[i]["Dept"].ToString();
                string ngay = "";
                string thu = "";
                string giovao = "";
                string giora = "";
                string tre = "";
                string som = "";
                DataRow row = workTable.NewRow();
                row["MANV"] = manv;
                row["TENNV"] = tennv;
                tNgay = DateTime.ParseExact(tungay.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                while (tNgay <= dNgay)
                {
                    string sql_ck = " SELECT ior.TimeStr FROM CheckInOut AS ior WHERE (((ior.UserFullCode)='" + manv + "') AND ((CDate([TimeDate]))='" + tNgay.ToShortDateString() + "')) ORDER BY TimeStr ASC";
                    DataTable t1 = Class.OledbConnection.getDataTable(connectionString, sql_ck);
                    int flag_ = t1.Rows.Count;
                    bool boolTre = false;
                    if (flag_ > 0)
                    {
                        string gVao = t1.Rows[0]["TimeStr"].ToString().Replace(" ", "");
                        if (!"".Equals(gVao))
                        {
                            string tmp = t1.Rows[0]["TimeStr"].ToString();
                            try
                            {
                                ngay = Class.Format.NgayVNVN(tNgay);
                                DateTime tm1 = DateTime.ParseExact(t1.Rows[0]["TimeStr"].ToString(), dateformat, CultureInfo.CreateSpecificCulture("en-US"));
                                row[ngay] = tm1.ToString("H:mm");
                                tongngaycong++;
                                thu = tm1.Date.DayOfWeek.ToString();
                                giovao = tm1.ToString("H:mm");

                                if (tm1.Hour == 7 && tm1.Minute > 40)
                                {
                                    row[Class.Format.NgayVNVN(tNgay) + "TRE"] = "1";
                                    tongtre++;
                                    boolTre = true;
                                    int tr = (tm1.Hour * 60 + tm1.Minute) - (7 * 60 + 40);
                                    tre = tr + "";
                                }
                                else if (tm1.Hour > 7)
                                {
                                    row[Class.Format.NgayVNVN(tNgay) + "TRE"] = "1";
                                    tongtre++;
                                    boolTre = true;
                                    int tr = (tm1.Hour * 60 + tm1.Minute) - (7 * 60 + 40);
                                    tre = tr + "";
                                }
                                
                            }
                            catch (Exception)
                            {
                                row[Class.Format.NgayVNVN(tNgay)] = "-";
                            }
                        }
                        else
                        {
                            row[Class.Format.NgayVNVN(tNgay)] = "-";

                        }

                        string gRa = t1.Rows[flag_ - 1]["TimeStr"].ToString().Replace(" ", "");
                        if (!gVao.Equals(gRa))
                        {
                            try
                            {
                                DateTime tm2 = DateTime.ParseExact(t1.Rows[flag_ - 1]["TimeStr"].ToString(), dateformat, CultureInfo.CreateSpecificCulture("en-US"));
                                row[Class.Format.NgayVNVN(tNgay) + "RA"] = tm2.ToString("HH:mm");
                                giora = tm2.ToString("HH:mm");

                                if (tm2.Hour == 16 && tm2.Minute < 50)
                                {
                                    row[Class.Format.NgayVNVN(tNgay) + "SOM"] = "1";
                                    tongtre++;
                                    boolTre = true;
                                    int tr = (16 * 60 + 50) - (tm2.Hour * 60 + tm2.Minute);
                                    som = tr + "";
                                }
                                else if (tm2.Hour < 16)
                                {
                                    row[Class.Format.NgayVNVN(tNgay) + "SOM"] = "1";
                                    tongtre++;
                                    boolTre = true;
                                    int tr = (16 * 60 + 50) - (tm2.Hour * 60 + tm2.Minute);
                                    som = tr + "";
                                }
                               

                            }
                            catch (Exception)
                            {
                                row[Class.Format.NgayVNVN(tNgay) + "RA"] = "-";
                            }

                        }
                        else
                        {
                            row[Class.Format.NgayVNVN(tNgay) + "RA"] = "-";
                        }
                    }
                    if (boolTre) {
                        AddTableTre(tableTre,manv, tennv, phongban, ngay, thu, giovao, giora, tre,som);
                    }
                    tNgay = tNgay.AddDays(1.0);
                }
                row["NGÀY CÔNG"] = tongngaycong;
                row["TRỂ"] = tongtre;
                workTable.Rows.Add(row);
            }
            Session["chamcong"] = workTable;
            Session["col"] = flag;
            Session["arrTitle"] = arrTitle;
            Session["tableTre"] = tableTre;
        }
        protected void btXemBangKe_Click(object sender, EventArgs e)
        {
            LoadData();
           
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Clear();
            Response.Charset = "";
            Response.Buffer = true;
            Response.ContentType = "application/vnd.ms-excel";
            Response.AddHeader("content-disposition", "attachment;filename=CHAMCONG.xls");
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("UTF-8");
            using (StringWriter sw = new StringWriter())
            using (HtmlTextWriter htw = new HtmlTextWriter(sw))
            {
                Table table = new Table();
                table.GridLines = System.Web.UI.WebControls.GridLines.Both;
                TableRow tRow = new TableRow();
                tRow.Cells.Add(new TableCell() { Width = 100, HorizontalAlign = HorizontalAlign.Center, Text = "MA NV" });
                tRow.Cells.Add(new TableCell() { Width = 300, HorizontalAlign = HorizontalAlign.Center, Text = "TEN NHAN VIEN" });
                tRow.Cells.Add(new TableCell() { Width = 100, HorizontalAlign = HorizontalAlign.Center, Text = "PHONG BAN" });
                tRow.Cells.Add(new TableCell() { Width = 100, HorizontalAlign = HorizontalAlign.Center, Text = "NGAY" });
                tRow.Cells.Add(new TableCell() { Width = 100, HorizontalAlign = HorizontalAlign.Center, Text = "THU " });
                tRow.Cells.Add(new TableCell() { Width = 100, HorizontalAlign = HorizontalAlign.Center, Text = "GIO VAO" });
                tRow.Cells.Add(new TableCell() { Width = 100, HorizontalAlign = HorizontalAlign.Center, Text = "GIO RA" });
                tRow.Cells.Add(new TableCell() { Width = 100, HorizontalAlign = HorizontalAlign.Center, Text = "TRE" });
                tRow.Cells.Add(new TableCell() { Width = 100, HorizontalAlign = HorizontalAlign.Center, Text = "SOM" });
                table.Rows.Add(tRow); // Done! Header row added.


                // Note TableCell has a property BackColor. Once can set the
                // that within the cell such as BackColor = System.Drawing.Color.Blue
                // and that will carry into the Excel Document!

                // UserData is our Linq entity list and we will enumerate it to fill the into cells of the row
                // and subsequently into the table.
                DataTable  tableTre = (DataTable)Session["tableTre"];
                foreach (DataRow item in tableTre.Rows)
                {
                    tRow = new TableRow();
                    tRow.Cells.Add(new TableCell() { Width = 100, HorizontalAlign = HorizontalAlign.Center, Text = item[0].ToString() });
                    tRow.Cells.Add(new TableCell() { Width = 300, HorizontalAlign = HorizontalAlign.Center, Text = item[1].ToString() });
                    tRow.Cells.Add(new TableCell() { Width = 100, HorizontalAlign = HorizontalAlign.Center, Text = item[2].ToString() });
                    tRow.Cells.Add(new TableCell() { Width = 100, HorizontalAlign = HorizontalAlign.Center, Text = item[3].ToString() });
                    tRow.Cells.Add(new TableCell() { Width = 100, HorizontalAlign = HorizontalAlign.Center, Text = item[4].ToString() });
                    tRow.Cells.Add(new TableCell() { Width = 100, HorizontalAlign = HorizontalAlign.Center, Text = item[5].ToString() });
                    tRow.Cells.Add(new TableCell() { Width = 100, HorizontalAlign = HorizontalAlign.Center, Text = item[6].ToString() });
                    tRow.Cells.Add(new TableCell() { Width = 100, HorizontalAlign = HorizontalAlign.Center, Text = item[7].ToString() });
                    tRow.Cells.Add(new TableCell() { Width = 100, HorizontalAlign = HorizontalAlign.Center, Text = item[8].ToString() });
                    table.Rows.Add(tRow);
                }

                table.RenderControl(htw);
                Response.Output.Write(sw.ToString());
                Response.End();

                Response.Clear();

            }
        }
    }
}