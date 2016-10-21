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
using BaoCao_Web.DataBase;

namespace BaoCao_Web.View
{
    public partial class ChamCong : System.Web.UI.Page
    {
        string thang__ = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            MaintainScrollPositionOnPostBack = true;
            if (IsPostBack)
                return;
           // DropDownList1.DataSource = Class.LinQConnection.getDataTable("SELECT * FROM TCHC_PHONGBAN ORDER BY ID ASC ");
           
        }

        public void AddTableTre(DataTable tableTre, string manv, string tennv, string phongban, string ngay, string thu, string giovao, string giora, string tre,string som, string ghichu) {
            if (tableTre != null) {
                DataRow row = tableTre.NewRow();
                row["MANV"] = manv;
                row["TENNV"] = tennv;
                row["PHONGBAN"] = phongban;
                row["NGAY"] = ngay + "/"+ DateTime.Now.Year.ToString();
                row["THU"] = thu;
                row["GIOVAO"] = giovao;
                row["TRE"] = tre;
                row["GIORA"] = giora;                
                row["SOM"] = som;
                row["GHICHU"] = ghichu;  
              

                tableTre.Rows.Add(row);
            }
           
        }
        DataTable _xinve = null;
        int sophutTre = 0;
        int sophuSom = 0;
        string type = "";
        string noidung = "";

        int getThongTin(string manv, DateTime ngay)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["WiseEyeOn39ConnectionString"].ConnectionString;
            ////di ngoai
            _xinve = Class.OledbConnection.getDataTable(connectionString, "SELECT * FROM tblGiayXinVe WHERE LOAIGP='VH' AND  MANV=" + manv);
            if ( _xinve!=null && _xinve.Rows.Count > 0)
            {
                type = "DN";
                noidung = "DI NGOAI";
                return 1;
            }
            ///* Cong Tác */
            ////xin tu ngay den ngay
            string sql = "SELECT * FROM tblGiayXinVe WHERE LOAIGP='CT' AND  MANV='" + manv + "' AND (CDate([TUNGAY]) = '" + ngay.Date.ToShortDateString() + "'  OR '" + ngay.Date.ToShortDateString() + "' between  CDate([TUNGAY]) and CDate([DENNGAY])  ) ";
            _xinve = Class.OledbConnection.getDataTable(connectionString, sql);
            // query = from q in db.TCHC_GIAYXINVEs where q.MANV == manv && q.LOAIGP == "CT" && (q.TUNGAY ==  || (ngay.Date >= q.TUNGAY && ngay.Date <= q.DENNGAY)) orderby q.CREATEDATE descending select q;
            if (_xinve!=null && _xinve.Rows.Count > 0)
            {
                type = "TH";
                noidung = "CONG TAC";
                return 5;
            }
            ////xin trong ngay
            sql = "SELECT * FROM tblGiayXinVe WHERE LOAIGP='TN' AND  MANV='" + manv + "' AND (CDate([TUNGAY]) = '" + ngay.Date.ToShortDateString() + "' ) ";
            _xinve = Class.OledbConnection.getDataTable(connectionString, sql);

            //query = from q in db.TCHC_GIAYXINVEs where q.MANV == manv && q.LOAIGP == "TN" && q.TUNGAY == ngay.Date orderby q.CREATEDATE descending select q;
            if (_xinve!=null && _xinve.Rows.Count > 0)
            {
                type = "TN";
                noidung = "XIN VE SOM";
                return 3;
            }

            ////xin tu ngay den ngay
            sql = "SELECT * FROM tblGiayXinVe WHERE LOAIGP='TH' AND  MANV='" + manv + "' AND ( '" + ngay.Date.ToShortDateString() + "' between  CDate([TUNGAY]) and CDate([DENNGAY]) ) ";
            _xinve = Class.OledbConnection.getDataTable(connectionString, sql);
            //query = from q in db.TCHC_GIAYXINVEs where q.MANV == manv && q.LOAIGP == "TH" && ngay.Date >= q.TUNGAY && ngay.Date <= q.DENNGAY orderby q.CREATEDATE descending select q;
            if (_xinve!=null && _xinve.Rows.Count > 0)
            {
                type = "TH";
                noidung = "XIN VE SOM";
                return 4;
            }

            ////khong thoi han
            sql = "SELECT * FROM tblGiayXinVe WHERE LOAIGP='TH' AND  MANV='" + manv + "' AND ( '" + ngay.Date.ToShortDateString() + "' between  CDate([TUNGAY]) and CDate([DENNGAY]) ) ";
            _xinve = Class.OledbConnection.getDataTable(connectionString, sql);
            //query = from q in db.TCHC_GIAYXINVEs where q.MANV == manv && q.LOAIGP == "KT" orderby q.CREATEDATE descending select q;
            if (_xinve!=null && _xinve.Rows.Count > 0)
            {
                type = "KT";
                noidung = "XIN VE SOM";
                return 2;
            }

            sql = "SELECT * FROM tblGiayXinVe WHERE LOAIGP='NP' AND  MANV='" + manv + "' AND (CDate([TUNGAY]) = '" + ngay.Date.ToShortDateString() + "' ) ";
            _xinve = Class.OledbConnection.getDataTable(connectionString, sql);
            //query = from q in db.TCHC_GIAYXINVEs where q.MANV == manv && q.LOAIGP == "KT" orderby q.CREATEDATE descending select q;
            if (_xinve!=null && _xinve.Rows.Count > 0)
            {
                type = "KT";
                noidung = "NP";
                return 7;
            }

            return 0;
        }

        public int parseInt(object o) {
            try
            {
                return int.Parse(o.ToString());
            }
            catch (Exception)
            {
            }
            return 0; 
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
            tableTre.Columns.Add("TRE", typeof(String));
            tableTre.Columns.Add("GIORA", typeof(String));
            tableTre.Columns.Add("SOM", typeof(String));
            tableTre.Columns.Add("GHICHU", typeof(String));

            string connectionString = ConfigurationManager.ConnectionStrings["WiseEyeOn39ConnectionString"].ConnectionString;
            string sql = " SELECT info.UserEnrollNumber, info.UserFullName FROM UserInfo info order by UserFullCode asc ";
           
            string dateformat = ConfigurationManager.AppSettings["dateformat"].ToString();
            DataTable workTable = new DataTable("NHANSU");
            DataColumn workCol = workTable.Columns.Add("MANV", typeof(String));
            workTable.Columns.Add("TENNV", typeof(String));
            workTable.Columns.Add("SỐ PHÚT", typeof(String));
            DateTime tNgay = DateTime.ParseExact(tungay.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            DateTime dNgay = DateTime.ParseExact(denngay.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            thang__ = dNgay.Month.ToString();
            TimeSpan Time = dNgay - tNgay;
            int TongSoNgay = Time.Days + 4;
            Panel2.Width = TongSoNgay * 150;
            string[] arrTitle = new string[TongSoNgay];
            int numTitle = 0;
            arrTitle[numTitle++] = "NGÀY CÔNG";
            arrTitle[numTitle++] = "TRỂ";
            arrTitle[numTitle++] = "SỐ PHÚT";
            int flag = 2;
            while (tNgay <= dNgay)
            {
                workTable.Columns.Add(Class.Format.NgayVNVN(tNgay), typeof(String));
                arrTitle[numTitle++] = Class.Format.NgayVNVN(tNgay);
                workTable.Columns.Add(Class.Format.NgayVNVN(tNgay) + "TRE", typeof(String));              
                workTable.Columns.Add(Class.Format.NgayVNVN(tNgay) + "RA", typeof(String));
                workTable.Columns.Add(Class.Format.NgayVNVN(tNgay) + "SOM", typeof(String));
                workTable.Columns.Add(Class.Format.NgayVNVN(tNgay) + "TYPE", typeof(String));
                tNgay = tNgay.AddDays(1.0);
                flag = flag + 3;
            }
            workTable.Columns.Add("NGÀY CÔNG", typeof(String));
            workTable.Columns.Add("TRỂ", typeof(String));
            flag = flag + 2;

            DataTable tb = Class.OledbConnection.getDataTable(connectionString, sql);
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                int tongphuttre = 0;
                int tongngaycong = 0;
                int tongtre = 0;
                string manv = tb.Rows[i]["UserEnrollNumber"].ToString();
                string tennv = tb.Rows[i]["UserFullName"].ToString();
                string phongban = "";
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
                int phutSomThem = 0;
                int phutTreThem = 0;
                int flagLoai = getThongTin(manv, tNgay);
                if (flagLoai == 2)
                {
                    flagLoai = 2;
                    try
                    {
                        phutTreThem = parseInt(_xinve.Rows[0]["PHUTVAO"]);
                    }
                    catch (Exception)
                    {
                    }

                    try
                    {
                        phutSomThem = parseInt(_xinve.Rows[0]["PHUTRA"]);
                    }
                    catch (Exception)
                    {
                    }

                }
                while (tNgay <= dNgay)
                {
                  
                    tre = "";
                    som = "";
                    string sql_ck = " SELECT ior.TimeStr FROM CheckInOut AS ior WHERE (((ior.UserEnrollNumber)=" + manv + ") AND ((CDate([TimeDate]))='" + tNgay.ToShortDateString() + "')) ORDER BY TimeStr ASC";
                    DataTable t1 = Class.OledbConnection.getDataTable(connectionString, sql_ck);
                    int flag_ = t1.Rows.Count;
                    bool boolTre = false;
                    if (flag_ > 0)
                    {
                        if (flagLoai == 1)
                        {
                            string gVao = t1.Rows[0]["TimeStr"].ToString().Replace(" ", "");
                            if (!"".Equals(gVao))
                            {
                                string tmp = t1.Rows[0]["TimeStr"].ToString();
                                try
                                {
                                    ngay = Class.Format.NgayVNVN(tNgay);
                                 //   DateTime tm1 = DateTime.ParseExact(t1.Rows[0]["TimeStr"].ToString(), dateformat, CultureInfo.CreateSpecificCulture("en-US"));
                                    DateTime tm1 = DateTime.Parse(t1.Rows[0]["TimeStr"].ToString());
                                    row[Class.Format.NgayVNVN(tNgay)] = tm1.ToString("H:mm");
                                    tongngaycong++;
                                    thu = tm1.Date.DayOfWeek.ToString();
                                    giovao = tm1.ToString("H:mm");
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

                            // Gi? Ra
                            string gRa = t1.Rows[flag_ - 1]["TimeStr"].ToString().Replace(" ", "");

                            try
                            {
                          //      DateTime tm2 = DateTime.ParseExact(t1.Rows[flag_ - 1]["TimeStr"].ToString(), dateformat, CultureInfo.CreateSpecificCulture("en-US"));
                                DateTime tm2 = DateTime.Parse(t1.Rows[flag_ - 1]["TimeStr"].ToString());
                                row[Class.Format.NgayVNVN(tNgay) + "RA"] = tm2.ToString("HH:mm");
                                giora = tm2.ToString("HH:mm");

                            }
                            catch (Exception)
                            {
                                row[Class.Format.NgayVNVN(tNgay) + "RA"] = "-";
                            }
                        }else if(flagLoai!=2){
                            //if ("00120".Equals(manv))
                            //{
                            //    flagLoai = getThongTin(manv, tNgay);
                            //}
                            type = "";
                            flagLoai = getThongTin(manv, tNgay);
                            if (flagLoai == 3 || flagLoai == 4) // đi công tác
                            {
                                try
                                {
                                    phutTreThem = parseInt(_xinve.Rows[0]["PHUTVAO"]);
                                }
                                catch (Exception)
                                {
                                }

                                try
                                {
                                    phutSomThem = parseInt(_xinve.Rows[0]["PHUTRA"]);
                                }
                                catch (Exception)
                                {
                                }


                                //phutTreThem = parseInt(_xinve.PHUTVAO);
                                //phutSomThem = parseInt(_xinve.PHUTRA);
                                
                            }
                            else if (flagLoai == 5) // đi công tác
                            {
                                row[Class.Format.NgayVNVN(tNgay)] = "CT";
                                row[Class.Format.NgayVNVN(tNgay) + "TYPE"] = "CT";
                                ngay = Class.Format.NgayVNVN(tNgay);
                                tongngaycong++;
                                thu = tNgay.Date.DayOfWeek.ToString();
                                if (_xinve!=null && _xinve.Rows[0]["BUOICT"].ToString() == "S")
                                {
                                    int id = 0;
                                    ////////////////////
                                    if (t1.Rows.Count > 1)
                                    {
                                        id=flag_ - 1;
                                    }
                                    
                                        try
                                        {
                                           // DateTime tm2 = DateTime.ParseExact(t1.Rows[id]["TimeStr"].ToString(), dateformat, CultureInfo.CreateSpecificCulture("en-US"));
                                            DateTime tm2 = DateTime.Parse(t1.Rows[flag_ - 1]["TimeStr"].ToString());
                                            row[Class.Format.NgayVNVN(tNgay) + "RA"] = tm2.ToString("HH:mm");
                                            giora = tm2.ToString("HH:mm");

                                            if (tm2.Hour == 16 && tm2.Minute < 59)
                                            {
                                                row[Class.Format.NgayVNVN(tNgay) + "SOM"] = "1";
                                                tongtre++;
                                                boolTre = true;
                                                int tr = (16 * 60 + 59) - (tm2.Hour * 60 + tm2.Minute);
                                                som = tr + "";
                                                tongphuttre += tr;
                                            }
                                            else 
                                            if (tm2.Hour < 17)
                                            {
                                                row[Class.Format.NgayVNVN(tNgay) + "SOM"] = "1";
                                                tongtre++;
                                                boolTre = true;
                                                int tr = (17*60) - (tm2.Hour * 60 + tm2.Minute);
                                                som = tr + "";
                                                tongphuttre += tr;
                                            }

                                        }
                                        catch (Exception)
                                        {
                                            row[Class.Format.NgayVNVN(tNgay) + "RA"] = "-";
                                        }
                                    ///////

                                }
                                else if (_xinve!=null && _xinve.Rows[0]["BUOICT"].ToString() == "C")
                                {
                                    ////////////////////
                                    string gVao = t1.Rows[0]["TimeStr"].ToString().Replace(" ", "");
                                    if (!"".Equals(gVao))
                                    {
                                        string tmp = t1.Rows[0]["TimeStr"].ToString();
                                        try
                                        {
                                            ngay = Class.Format.NgayVNVN(tNgay);
                                       //     DateTime tm1 = DateTime.ParseExact(t1.Rows[0]["TimeStr"].ToString(), dateformat, CultureInfo.CreateSpecificCulture("en-US"));
                                            DateTime tm1 = DateTime.Parse(t1.Rows[0]["TimeStr"].ToString());
                                            row[Class.Format.NgayVNVN(tNgay)] = tm1.ToString("H:mm");
                                            giovao = tm1.ToString("H:mm");

                                            if (tm1.Hour == 7 && tm1.Minute > 30)
                                            {
                                                row[Class.Format.NgayVNVN(tNgay) + "TRE"] = "1";
                                                tongtre++;
                                                boolTre = true;
                                                int tr = (tm1.Hour * 60 + tm1.Minute) - (7 * 60 + 30);
                                                tre = tr + "";
                                                tongphuttre += tr;
                                            }
                                            else if (tm1.Hour > 7)
                                            {
                                                row[Class.Format.NgayVNVN(tNgay) + "TRE"] = "1";
                                                tongtre++;
                                                boolTre = true;
                                                int tr = (tm1.Hour * 60 + tm1.Minute) - (7 * 60 + 30);
                                                tre = tr + "";
                                                tongphuttre += tr;
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
                                  
                                    row[Class.Format.NgayVNVN(tNgay) + "RA"] = "CT";                                   
                                }
                                else {
                                    ngay = Class.Format.NgayVNVN(tNgay);
                                    row[Class.Format.NgayVNVN(tNgay)] = "CT";
                                    row[Class.Format.NgayVNVN(tNgay) + "TYPE"] = "CT";
                                    tongngaycong++;
                                    thu = tNgay.Date.DayOfWeek.ToString();
                                    giovao = "CT";
                                    row[Class.Format.NgayVNVN(tNgay) + "TYPE"] = "CT";

                                    row[Class.Format.NgayVNVN(tNgay) + "RA"] = "CT";
                                    giora = "CT";
                                }
                            }
                            else if (flagLoai == 6) // nghỉ phép
                            {
                                row[Class.Format.NgayVNVN(tNgay)] = "NP";
                                row[Class.Format.NgayVNVN(tNgay) + "TYPE"] = "NP";
                                ngay = Class.Format.NgayVNVN(tNgay);
                                tongngaycong++;
                                thu = tNgay.Date.DayOfWeek.ToString();

                                ngay = Class.Format.NgayVNVN(tNgay);
                                row[Class.Format.NgayVNVN(tNgay)] = "NP";
                                row[Class.Format.NgayVNVN(tNgay) + "TYPE"] = "NP";
                                tongngaycong++;
                                thu = tNgay.Date.DayOfWeek.ToString();
                                giovao = "NP";
                                row[Class.Format.NgayVNVN(tNgay) + "TYPE"] = "NP";

                                row[Class.Format.NgayVNVN(tNgay) + "RA"] = "NP";
                                giora = "NP";

                            }

                        }

                        ////////////////////// TÍNH GIỜ THEO ĐIỀU KIỆN //////////////////////////////////////
                        if (flagLoai == 2 || flagLoai == 3 || flagLoai == 4 || flagLoai==0)
                        {
                           
                            // Gi? Vào
                            string gVao = t1.Rows[0]["TimeStr"].ToString().Replace(" ", "");
                            if (!"".Equals(gVao))
                            {
                                string tmp = t1.Rows[0]["TimeStr"].ToString();
                                try
                                {
                                    ngay = Class.Format.NgayVNVN(tNgay);
                                    //fix bug DateTime tm1 = DateTime.ParseExact(t1.Rows[0]["TimeStr"].ToString(), dateformat, CultureInfo.CreateSpecificCulture("en-US"));
                                    DateTime tm1 = DateTime.Parse(t1.Rows[0]["TimeStr"].ToString());
                                    row[Class.Format.NgayVNVN(tNgay)] = tm1.ToString("H:mm");
                                    tongngaycong++;
                                    thu = tm1.Date.DayOfWeek.ToString();
                                    giovao = tm1.ToString("H:mm");
                                    tm1 = tm1.AddMinutes(phutTreThem * -1); 
                                    if (tm1.Hour == 7 && tm1.Minute > 30)
                                    {
                                        row[Class.Format.NgayVNVN(tNgay) + "TRE"] = "1";
                                        tongtre++;
                                        boolTre = true;
                                        int tr = (tm1.Hour * 60 + tm1.Minute) - (7 * 60 + 30);
                                        tre = tr + "";
                                        tongphuttre += tr;
                                    }
                                    else if (tm1.Hour > 7)
                                    {
                                        row[Class.Format.NgayVNVN(tNgay) + "TRE"] = "1";
                                        tongtre++;
                                        boolTre = true;
                                        int tr = (tm1.Hour * 60 + tm1.Minute) - (7 * 60 + 30);
                                        tre = tr + "";
                                        tongphuttre += tr;
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

                            // Gi? Ra
                            string gRa = t1.Rows[flag_ - 1]["TimeStr"].ToString().Replace(" ", "");

                            if (gVao.Equals(gRa))
                            {
                                AddTableTre(tableTre, manv, tennv, phongban, ngay, thu, giovao, "-", tre, "-", "KHONG QUET");
                                row[Class.Format.NgayVNVN(tNgay) + "RA"] = "KQ";

                            }
                            else {
                                try
                                {
                                    
                                    //fix bug DateTime tm2 = DateTime.ParseExact(t1.Rows[flag_ - 1]["TimeStr"].ToString(), dateformat, CultureInfo.CreateSpecificCulture("en-US"));
                                    DateTime tm2 = DateTime.Parse(t1.Rows[flag_ - 1]["TimeStr"].ToString());
                                    row[Class.Format.NgayVNVN(tNgay) + "RA"] = tm2.ToString("HH:mm");
                                    giora = tm2.ToString("HH:mm");
                                    tm2 = tm2.AddMinutes(phutSomThem);
                                    if (tm2.Hour == 16 && tm2.Minute < 59)
                                    {
                                        row[Class.Format.NgayVNVN(tNgay) + "SOM"] = "1";
                                        tongtre++;
                                        boolTre = true;
                                        int tr = (17 * 60) - (tm2.Hour * 60 + tm2.Minute);
                                        som = tr + "";
                                        tongphuttre += tr;
                                    }
                                    else 
                                    if (tm2.Hour < 17)
                                    {
                                        row[Class.Format.NgayVNVN(tNgay) + "SOM"] = "1";
                                        tongtre++;
                                        boolTre = true;
                                        int tr = (17 * 60 ) - (tm2.Hour * 60 + tm2.Minute);
                                        som = tr + "";
                                        tongphuttre += tr;
                                    }


                                }
                                catch (Exception)
                                {
                                    row[Class.Format.NgayVNVN(tNgay) + "RA"] = "-";
                                }
                            }
                            
                                                    
                        }

                    }
                    else {

                        // không quét đi công tác
                        if (getThongTin(manv, tNgay) == 5) // đi công tác
                        {
                            if (_xinve!=null && _xinve.Rows[0]["BUOICT"].ToString() == "N")
                            {
                                ngay = Class.Format.NgayVNVN(tNgay);
                                row[Class.Format.NgayVNVN(tNgay)] = "CT";
                                row[Class.Format.NgayVNVN(tNgay) + "TYPE"] = "CT";
                                tongngaycong++;
                                thu = tNgay.Date.DayOfWeek.ToString();
                                giovao = "CT";
                                row[Class.Format.NgayVNVN(tNgay) + "TYPE"] = "CT";

                                row[Class.Format.NgayVNVN(tNgay) + "RA"] = "CT";
                                giora = "CT";

                            }
                            else if (_xinve!=null && _xinve.Rows[0]["BUOICT"].ToString() == "S")
                            {
                                ngay = Class.Format.NgayVNVN(tNgay);
                                row[Class.Format.NgayVNVN(tNgay)] = "CT";
                                row[Class.Format.NgayVNVN(tNgay) + "TYPE"] = "CT";
                                tongngaycong++;
                                thu = tNgay.Date.DayOfWeek.ToString();
                                giovao = "CT";
                                row[Class.Format.NgayVNVN(tNgay) + "TYPE"] = "CT";

                                AddTableTre(tableTre, manv, tennv, phongban, Class.Format.NgayVNVN(tNgay), tNgay.DayOfWeek.ToString(), "", "", "", "", "KHONG QUET");
                                row[Class.Format.NgayVNVN(tNgay) + "RA"] = "KQ";

                            }
                            else if (_xinve!=null && _xinve.Rows[0]["BUOICT"].ToString() == "C")
                            {

                                ngay = Class.Format.NgayVNVN(tNgay);
                                row[Class.Format.NgayVNVN(tNgay)] = "KQ";
                                AddTableTre(tableTre, manv, tennv, phongban, Class.Format.NgayVNVN(tNgay), tNgay.DayOfWeek.ToString(), "", "", "", "", "KHONG QUET");
                                tongngaycong++;
                                thu = tNgay.Date.DayOfWeek.ToString();
                                giovao = "CT";
                                row[Class.Format.NgayVNVN(tNgay) + "TYPE"] = "CT";

                                row[Class.Format.NgayVNVN(tNgay) + "RA"] = "CT";
                                giora = "CT";

                            }
                        }
                        else { // không quét
                            if (tNgay.DayOfWeek != DayOfWeek.Saturday && tNgay.DayOfWeek != DayOfWeek.Sunday) {
                                AddTableTre(tableTre, manv, tennv, phongban, Class.Format.NgayVNVN(tNgay), tNgay.DayOfWeek.ToString(), "", "", "", "", "KHONG QUET");
                                row[Class.Format.NgayVNVN(tNgay)] = "KQ";
                                row[Class.Format.NgayVNVN(tNgay) + "RA"] = "KQ";
                            }
                            
                        }
                        
                    
                    }
                    if (boolTre) {
                        AddTableTre(tableTre,manv, tennv, phongban, ngay, thu, giovao, giora, tre,som,"");
                    }

                    tNgay = tNgay.AddDays(1.0);
                    if (flagLoai != 2 && flagLoai != 0)
                    {
                        phutTreThem = 0;
                        phutSomThem = 0;
                    }
                   
                }
                row["SỐ PHÚT"] = tongphuttre;
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

            string title = "DI TRE THANG " + tungay.Text.Substring(3,2) + ".xls";
            HttpContext.Current.Response.Clear();
            HttpContext.Current.Response.AddHeader("content-disposition", string.Format("attachment;filename={0}", title));
            HttpContext.Current.Response.ContentType = "application/ms-excel";
            HttpContext.Current.Response.Charset = "UTF-8";
            using (StringWriter sw = new StringWriter())
            using (HtmlTextWriter htw = new HtmlTextWriter(sw))
            {
                Table table = new Table();
                table.GridLines = System.Web.UI.WebControls.GridLines.Both;
                TableRow tRow = new TableRow();
                TableCell Cell = new TableCell();
                Cell.BorderColor = System.Drawing.Color.Black;
                Cell.Text = "DANH SACH NHAN VIEN TRE THANG " + tungay.Text.Substring(3, 2) + " ( TU " + tungay.Text + " DEN " + denngay.Text + ")";
                Cell.BorderStyle = BorderStyle.Solid;
                Cell.HorizontalAlign = HorizontalAlign.Center;
                Cell.VerticalAlign = VerticalAlign.Middle;
                Cell.Font.Bold = true;
                Cell.Font.Size = 15;
                Cell.Height = 30; 
                Cell.ColumnSpan = 10;
                tRow.Cells.Add(Cell);
                table.Rows.Add(tRow);

                tRow = new TableRow();
                tRow.Cells.Add(new TableCell() { Width = 100, HorizontalAlign = HorizontalAlign.Center, Text = "MA NV" });
                tRow.Cells.Add(new TableCell() { Width = 300, HorizontalAlign = HorizontalAlign.Center, Text = "TEN NHAN VIEN" });
                tRow.Cells.Add(new TableCell() { Width = 100, HorizontalAlign = HorizontalAlign.Center, Text = "PHONG BAN" });
                tRow.Cells.Add(new TableCell() { Width = 100, HorizontalAlign = HorizontalAlign.Center, Text = "NGAY" });
                tRow.Cells.Add(new TableCell() { Width = 100, HorizontalAlign = HorizontalAlign.Center, Text = "THU " });
                tRow.Cells.Add(new TableCell() { Width = 100, HorizontalAlign = HorizontalAlign.Center, Text = "GIO VAO" });
                tRow.Cells.Add(new TableCell() { Width = 100, HorizontalAlign = HorizontalAlign.Center, Text = "VAO TRE" });
                tRow.Cells.Add(new TableCell() { Width = 100, HorizontalAlign = HorizontalAlign.Center, Text = "GIO VE" });
                tRow.Cells.Add(new TableCell() { Width = 100, HorizontalAlign = HorizontalAlign.Center, Text = "VE SOM" });
                tRow.Cells.Add(new TableCell() { Width = 200, HorizontalAlign = HorizontalAlign.Center, Text = "GHI CHU " });
                table.Rows.Add(tRow); // Done! Header row added.
                
                DataTable  tableTre = (DataTable)Session["tableTre"];
                foreach (DataRow item in tableTre.Rows)
                {
                    tRow = new TableRow();
                    tRow.Cells.Add(new TableCell() { Width = 100, HorizontalAlign = HorizontalAlign.Center, Text = item[0].ToString() });
                    tRow.Cells.Add(new TableCell() { Width = 300, HorizontalAlign = HorizontalAlign.Left, Text = item[1].ToString() });
                    tRow.Cells.Add(new TableCell() { Width = 100, HorizontalAlign = HorizontalAlign.Center, Text = item[2].ToString() });
                    tRow.Cells.Add(new TableCell() { Width = 100, HorizontalAlign = HorizontalAlign.Center, Text = item[3].ToString() });
                    tRow.Cells.Add(new TableCell() { Width = 100, HorizontalAlign = HorizontalAlign.Center, Text = item[4].ToString() });
                    tRow.Cells.Add(new TableCell() { Width = 100, HorizontalAlign = HorizontalAlign.Center, Text = item[5].ToString() });
                    tRow.Cells.Add(new TableCell() { Width = 100, HorizontalAlign = HorizontalAlign.Center, Text = item[6].ToString() });
                    tRow.Cells.Add(new TableCell() { Width = 100, HorizontalAlign = HorizontalAlign.Center, Text = item[7].ToString() });
                    tRow.Cells.Add(new TableCell() { Width = 100, HorizontalAlign = HorizontalAlign.Center, Text = item[8].ToString() });
                    tRow.Cells.Add(new TableCell() { Width = 100, HorizontalAlign = HorizontalAlign.Center, Text = item[9].ToString() });
                    table.Rows.Add(tRow);
                }

                table.RenderControl(htw);
                HttpContext.Current.Response.Output.Write(sw.ToString());
                HttpContext.Current.Response.End();
                HttpContext.Current.Response.Clear();

            }
        }
    }
}