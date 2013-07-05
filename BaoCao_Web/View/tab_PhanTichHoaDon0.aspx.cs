using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text.RegularExpressions;

namespace BaoCao_Web.View
{
    public partial class tab_PhanTichHoaDon0 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (IsPostBack)
            //    return;
            this.tungay.Text = "12/2012";
            this.denngay.Text = (DateTime.Now.Date.Month - 1) + "/" + DateTime.Now.Date.Year;
            //ThongKeHoadon();
        }

        public void PhanTichHoaDon()
        {                      
            try
            {
                this.panelAnd.Visible = false;
                this.panelTu.Visible = false;
                string tuky = getFullKY(this.tungay.Text);
                string denky = getFullKY(this.denngay.Text);
                DataTable tableTre = new DataTable();
                tableTre.Columns.Add(tuky, typeof(String));
                tableTre.Columns.Add(denky, typeof(String));
                tableTre.Columns.Add("TĂNG GIẢM", typeof(String));
                tableTre.Columns.Add("=0 2 KỲ", typeof(String));
                tableTre.Columns.Add("SỬ DỤNG LẠI", typeof(String));
                tableTre.Columns.Add("PHÁT SINH", typeof(String));
                tableTre.Columns.Add("SANLUONG", typeof(String));
                tuky = tuky.Replace("/", "_");
                denky = denky.Replace("/", "_");


                if ("and".Equals(this.sosanh.Text)) {
                    this.panelAnd.Visible = true;                  
                    Session["tuky"] = tuky;
                    Session["denky"] = denky;
                    string sql = "SELECT COUNT(*) FROM HOADONTH" + tuky + " WHERE LNCC=0";
                    // log.Error("LinQConnection ExecuteCommand : " + sql);
                    int Tongtuky = Class.LinQConnection.ReturnResult(sql);
                    
                    
                    sql = "SELECT COUNT(*) FROM HOADONTH" + denky + " WHERE LNCC=0";
                    int Tongdenky = Class.LinQConnection.ReturnResult(sql);

                    int tanggiam = Tongdenky - Tongtuky;


                    sql = "SELECT COUNT(*) FROM HOADONTH" + tuky + " K12, HOADONTH" + denky + " K01 WHERE K12.DANHBO= K01.DANHBO AND K12.LNCC =0 AND K01.LNCC = 0";
                    int ca2ky =  Class.LinQConnection.ReturnResult(sql);

                    sql = "SELECT COUNT(*) FROM HOADONTH" + tuky + " K12, HOADONTH" + denky + " K01 WHERE K12.DANHBO= K01.DANHBO AND K12.LNCC =0 AND K01.LNCC <> 0";
                    int sudunglai = Class.LinQConnection.ReturnResult(sql);

                    sql = "SELECT SUM(CONVERT(int,K01.LNCC)) FROM HOADONTH" + tuky + " K12, HOADONTH" + denky + " K01 WHERE K12.DANHBO= K01.DANHBO AND K12.LNCC =0 AND K01.LNCC <> 0";
                    int tongsanluong = Class.LinQConnection.ReturnResult(sql);

                    int phatsinh = Tongtuky - ca2ky + tanggiam; 
                   

                    DataRow row = tableTre.NewRow();
                    row[tuky.Replace("_", "/")] = Tongtuky;
                    row[denky.Replace("_", "/")] = Tongdenky;
                    row["TĂNG GIẢM"] = tanggiam;
                    row["=0 2 KỲ"] = ca2ky;
                    row["SỬ DỤNG LẠI"] = sudunglai;
                    row["PHÁT SINH"] = phatsinh;
                    row["SANLUONG"] = tongsanluong;
                    tableTre.Rows.Add(row);
                    Session["PHANTICH"] = tableTre;


                    Gtuky.DataSource = Class.LinQConnection.getDataTable("SELECT CODE, COUNT(*) AS 'SL' FROM HOADONTH" + tuky + " WHERE LNCC=0 GROUP BY CODE ORDER BY CODE ASC");
                    Gtuky.DataBind();

                    Gdenky.DataSource = Class.LinQConnection.getDataTable("SELECT CODE, COUNT(*) AS 'SL' FROM HOADONTH" + denky + " WHERE LNCC=0 GROUP BY CODE ORDER BY CODE ASC");
                    Gdenky.DataBind();

                    Ghd02.DataSource = Class.LinQConnection.getDataTable("SELECT K01.CODE, COUNT(*) AS 'SL' FROM HOADONTH" + tuky + " K12, HOADONTH" + denky + " K01 WHERE K12.DANHBO= K01.DANHBO AND K12.LNCC =0 AND K01.LNCC = 0 GROUP BY K01.CODE ORDER BY CODE ASC");
                    Ghd02.DataBind();

                    Gphatsinh.DataSource = Class.LinQConnection.getDataTable("SELECT  K01.CODE, COUNT(*) AS 'SL' FROM HOADONTH" + tuky + " K12, HOADONTH" + denky + " K01 WHERE K12.DANHBO= K01.DANHBO AND K12.LNCC <> 0 AND K01.LNCC = 0 GROUP BY K01.CODE ORDER BY CODE ASC");
                    Gphatsinh.DataBind();

                    GridView1.DataSource = Class.LinQConnection.getDataTable("SELECT K01.CODE, COUNT(*) AS 'SL'  FROM HOADONTH" + tuky + " K12, HOADONTH" + denky + " K01 WHERE K12.DANHBO= K01.DANHBO AND K12.LNCC =0 AND K01.LNCC <> 0 GROUP BY K01.CODE ORDER BY CODE ASC");
                    GridView1.DataBind();


                    //////////DOI TUONG/////////

                    Gdoituongtu1.DataSource = Class.LinQConnection.getDataTable("SELECT GIABIEU, COUNT(*) AS 'SL' FROM HOADONTH" + tuky + " WHERE LNCC=0 GROUP BY GIABIEU ORDER BY GIABIEU ASC");
                    Gdoituongtu1.DataBind();

                    Gdoituongden.DataSource = Class.LinQConnection.getDataTable("SELECT GIABIEU, COUNT(*) AS 'SL' FROM HOADONTH" + denky + " WHERE LNCC=0 GROUP BY GIABIEU ORDER BY GIABIEU ASC");
                    Gdoituongden.DataBind();

                    Gdoituong2ky.DataSource = Class.LinQConnection.getDataTable("SELECT K01.GIABIEU, COUNT(*) AS 'SL' FROM HOADONTH" + tuky + " K12, HOADONTH" + denky + " K01 WHERE K12.DANHBO= K01.DANHBO AND K12.LNCC =0 AND K01.LNCC = 0 GROUP BY K01.GIABIEU ORDER BY GIABIEU ASC");
                    Gdoituong2ky.DataBind();

                    SanLuongDT.DataSource = Class.LinQConnection.getDataTable("SELECT K01.GIABIEU, SUM(CONVERT(int,K01.LNCC)) AS 'SL' FROM HOADONTH" + tuky + " K12, HOADONTH" + denky + " K01 WHERE K12.DANHBO= K01.DANHBO AND K12.LNCC =0 AND K01.LNCC <> 0 GROUP BY K01.GIABIEU ORDER BY GIABIEU ASC");
                    SanLuongDT.DataBind();

                    Gdoituongphatsinh.DataSource = Class.LinQConnection.getDataTable("SELECT  K01.GIABIEU, COUNT(*) AS 'SL' FROM HOADONTH" + tuky + " K12, HOADONTH" + denky + " K01 WHERE K12.DANHBO= K01.DANHBO AND K12.LNCC <> 0 AND K01.LNCC = 0 GROUP BY K01.GIABIEU ORDER BY GIABIEU ASC");
                    Gdoituongphatsinh.DataBind();

                    //////////QUAN PHUONG////////////

                    QPTUKY.DataSource = Class.LinQConnection.getDataTable("SELECT (QUAN+'.'+PHUONG) AS QP, COUNT(*) AS 'SL' FROM HOADONTH" + tuky + " WHERE LNCC=0 AND QUAN IS NOT NULL GROUP BY (QUAN+'.'+PHUONG) ORDER BY (QUAN+'.'+PHUONG) ASC");
                    QPTUKY.DataBind();

                    QPDENKY.DataSource = Class.LinQConnection.getDataTable("SELECT (QUAN+'.'+PHUONG) AS QP, COUNT(*) AS 'SL' FROM HOADONTH" + denky + " WHERE LNCC=0 AND QUAN IS NOT NULL GROUP BY (QUAN+'.'+PHUONG) ORDER BY (QUAN+'.'+PHUONG) ASC");
                    QPDENKY.DataBind();

                    QP02KY.DataSource = Class.LinQConnection.getDataTable("SELECT (K01.QUAN+'.'+K01.PHUONG) AS QP, COUNT(*) AS 'SL' FROM HOADONTH" + tuky + " K12, HOADONTH" + denky + " K01 WHERE K12.DANHBO= K01.DANHBO AND K12.LNCC =0 AND K01.LNCC = 0 AND K01.QUAN IS NOT NULL GROUP BY (K01.QUAN+'.'+K01.PHUONG) ORDER BY (K01.QUAN+'.'+K01.PHUONG) ASC");
                    QP02KY.DataBind();

                    QPSANLUONG.DataSource = Class.LinQConnection.getDataTable("SELECT (K01.QUAN+'.'+K01.PHUONG) AS QP,  SUM(CONVERT(int,K01.LNCC)) AS 'SL' FROM HOADONTH" + tuky + " K12, HOADONTH" + denky + " K01 WHERE K12.DANHBO= K01.DANHBO AND K12.LNCC =0 AND K01.LNCC <> 0 AND K01.QUAN IS NOT NULL GROUP BY (K01.QUAN+'.'+K01.PHUONG) ORDER BY (K01.QUAN+'.'+K01.PHUONG) ASC");
                    QPSANLUONG.DataBind();

                    QPPHATSINH.DataSource = Class.LinQConnection.getDataTable("SELECT ( K01.QUAN+'.'+ K01.PHUONG) AS QP, COUNT(*) AS 'SL' FROM HOADONTH" + tuky + " K12, HOADONTH" + denky + " K01 WHERE K12.DANHBO= K01.DANHBO AND K12.LNCC <> 0 AND K01.LNCC = 0 AND K01.QUAN IS NOT NULL GROUP BY (K01.QUAN+'.'+K01.PHUONG) ORDER BY (K01.QUAN+'.'+K01.PHUONG) ASC");
                    QPPHATSINH.DataBind();

                }
                else if ("To".Equals(this.sosanh.Text))
                {
                    this.panelAnd.Visible = true;      
                }

            }
            catch (Exception)
            {
                
            }

        }
        
        protected void btXemBangKe_Click(object sender, EventArgs e)
        {
            PhanTichHoaDon();
           
        }

       
        string FullKy(int n) {
            if (n < 10)
                return "0" + n;
            return n+"";
        }

        string getFullKY(string _ky) { 
            string k="";

            try
            {
                string[] words = Regex.Split(_ky, @"/");
                if (words.Length == 2)
                {
                    return FullKy(int.Parse(words[0].Trim())) + "/" + words[1];
                }
            }
            catch (Exception)
            {
               
            }
            return k;
        }
        //public static string DoiDonViMet(double number)
        //{
        //    //string line = String.Format('{0:0.0}', number);
        //    //string[] words = Regex.Split(line, '\\.');
        //    //if (words.Length == 2)
        //    //{
        //    //    return words[0] + 'm' + words[1];
        //    //}
        //    //return words[0] + 'm';
        //    string line = String.Format("{0:0.0}", number);
        //    string[] words = Regex.Split(line, "\\.");
        //    if (words.Length == 2)
        //    {
        //        if (words[1].Equals('0'))
        //            return words[0];
        //        else
        //            return words[0] + ',' + words[1];
        //    }
        //    return words[0];
        //}
        static log4net.ILog log = log4net.LogManager.GetLogger("File");
        //public DataTable getChart() {
        //  DataTable tableTre = new DataTable();
           
        //    string _tungay = this.tungay.Text.Trim();
        //    int _tuky = int.Parse(_tungay.Substring(3, 2));
        //    int _tunam = int.Parse(_tungay.Substring(6, 4));
       
        //    string _denngay = this.denngay.Text.Trim();
        //    int _denky = int.Parse(_denngay.Substring(3, 2));
        //    int _dennam = int.Parse(_denngay.Substring(6, 4));
            
        //    DateTime tNgay = DateTime.ParseExact(_tungay, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
        //    DateTime dNgay = DateTime.ParseExact(_denngay, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
      
        //    int tongThang=(dNgay.Month - tNgay.Month) + 12 * (dNgay.Year - tNgay.Year)+1;           
        //    string[] arrTitle = new string[tongThang];

        //    for (int i = 0; i < tongThang; i++)
        //    {
        //        string tableName=FullKy(_tuky)+"_"+_tunam;
        //        tableTre.Columns.Add(tableName, typeof(String));
        //        arrTitle[i] = tableName;
        //        _tuky = _tuky + 1;
        //        if (_tuky > 12) {
        //            _tuky = 1;
        //            _tunam = _tunam + 1;
        //        }
        //    }

        //    string title = "['KỲ', 'Số Lượng Hóa Đơn =0']";
            

        //    if (tableTre != null)
        //    {
        //        DataRow row = tableTre.NewRow();
        //        foreach (string s in arrTitle)
        //        {
        //            string sql = "SELECT COUNT(*) FROM HOADONTH"+s+" WHERE LNCC=0";
        //           // log.Error("LinQConnection ExecuteCommand : " + sql);
        //            int soluong = Class.LinQConnection.ReturnResult(sql);
        //            row[s] = soluong;
        //            if (soluong != 0) {
        //                title += ",['" + s.Replace("_", "/") + "', " + soluong + "]";
        //            }
                    

        //        }
        //        tableTre.Rows.Add(row);
        //    }
        //  title =  "[" + title + "]";
        //  Session["hoadon"] = title;
        //    return tableTre;
        //}
        
        
        protected void dataTongBK_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //if ("TONG".Equals(e.CommandName) || "SOLUONGTHAY".Equals(e.CommandName))
            //{
            //    tongBangKe.Visible = true;
            //    danhsachtrongai.Visible = false;
            //    daxuly.Visible = false;
            //    TabContainer1.Visible = false;
            //    this.tongBangKe.DataSource = Class.C_DHN.getThongKeLoaiBaoThay(this.tungay.Text.Trim(), this.denngay.Text.Trim());
            //    this.tongBangKe.DataBind();
            //}
            //if ("TRONGAI".Equals(e.CommandName))
            //{
            //    tongBangKe.Visible = false;
            //    danhsachtrongai.Visible = true;
            //    daxuly.Visible = true;
            //    TabContainer1.Visible = true;
            //    this.danhsachtrongai.DataSource = Class.C_DHN.getTroNgaiThay(this.tungay.Text.Trim(), this.denngay.Text.Trim());
            //    this.danhsachtrongai.DataBind();

            //    this.daxuly.DataSource = Class.C_DHN.getTroNgaiThay_daxuly(this.tungay.Text.Trim(), this.denngay.Text.Trim());
            //    this.daxuly.DataBind();
               
            //}
        }

        protected void danhsachtrongai_RowCreated(object sender, GridViewRowEventArgs e)
        {
            //if (e.Row.RowType == DataControlRowType.DataRow)
            //{
            //    // when mouse is over the row, save original color to new attribute, and change it to highlight yellow color
            //    e.Row.Attributes.Add("onmouseover",
            //  "this.originalstyle=this.style.backgroundColor;this.style.backgroundColor='#EEFF00'");

            //    // when mouse leaves the row, change the bg color to its original value   
            //    e.Row.Attributes.Add("onmouseout",
            //    "this.style.backgroundColor=this.originalstyle;");
            //}
        }

        protected void danhsachtrongai_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == System.Web.UI.WebControls.DataControlRowType.DataRow)
            {

                // when mouse is over the row, save original color to new attribute, and change it to highlight color
                e.Row.Attributes.Add("onmouseover", "this.originalstyle=this.style.backgroundColor;this.style.backgroundColor='#EEFFAA'");

                // when mouse leaves the row, change the bg color to its original value  
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=this.originalstyle;");
            }
        }

        protected void daxuly_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == System.Web.UI.WebControls.DataControlRowType.DataRow)
            {

                // when mouse is over the row, save original color to new attribute, and change it to highlight color
                e.Row.Attributes.Add("onmouseover", "this.originalstyle=this.style.backgroundColor;this.style.backgroundColor='#EEFFAA'");

                // when mouse leaves the row, change the bg color to its original value  
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=this.originalstyle;");
            }
        }

        protected void linkTUKY_Click(object sender, EventArgs e)
        {
            CrystalReportSource1.ReportDocument.ExportToHttpResponse(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Response, false, "SO_LIEU_NAM");
        }
    

          
    }
}