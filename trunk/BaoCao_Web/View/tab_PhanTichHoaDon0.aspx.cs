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
        log4net.ILog log = log4net.LogManager.GetLogger("File");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
            this.tungay.Text = "12/2012";
            this.denngay.Text = (DateTime.Now.Date.Month - 1) + "/" + DateTime.Now.Date.Year;
            //ThongKeHoadon();
        }

        public void PhanTichHoaDon()
        {
            try
            {
                //this.panelAnd.Visible = false;
                //this.panelTu.Visible = false;
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
                tableTre.Columns.Add("SANLUONGGIAM", typeof(String));
                
                tuky = tuky.Replace("/", "_");
                denky = denky.Replace("/", "_");


                if ("and".Equals(this.sosanh.Text))
                {
                    this.panelAnd.Visible = true;
                    this.panelTu.Visible = false;
                    Session["tuky"] = tuky;
                    Session["denky"] = denky;
                    string sql = "SELECT COUNT(*) FROM HOADONTH" + tuky + " WHERE LNCC=0";
                    // log.Error("LinQConnection ExecuteCommand : " + sql);
                    int Tongtuky = Class.LinQConnection.ReturnResult(sql);


                    sql = "SELECT COUNT(*) FROM HOADONTH" + denky + " WHERE LNCC=0";
                    int Tongdenky = Class.LinQConnection.ReturnResult(sql);

                    int tanggiam = Tongdenky - Tongtuky;


                    sql = "SELECT COUNT(*) FROM HOADONTH" + tuky + " K12, HOADONTH" + denky + " K01 WHERE K12.DANHBO= K01.DANHBO AND K12.LNCC =0 AND K01.LNCC = 0";
                    int ca2ky = Class.LinQConnection.ReturnResult(sql);

                    sql = "SELECT COUNT(*) FROM HOADONTH" + tuky + " K12, HOADONTH" + denky + " K01 WHERE K12.DANHBO= K01.DANHBO AND K12.LNCC =0 AND K01.LNCC <> 0";
                    int sudunglai = Class.LinQConnection.ReturnResult(sql);

                    sql = "SELECT SUM(CONVERT(int,K01.LNCC)) FROM HOADONTH" + tuky + " K12, HOADONTH" + denky + " K01 WHERE K12.DANHBO= K01.DANHBO AND K12.LNCC =0 AND K01.LNCC <> 0";
                    int tongsanluong = Class.LinQConnection.ReturnResult(sql);

                    sql = "SELECT SUM(CONVERT(int,K12.LNCC)) FROM HOADONTH" + tuky + " K12, HOADONTH" + denky + " K01 WHERE K12.DANHBO= K01.DANHBO AND K12.LNCC <> 0 AND K01.LNCC = 0";
                    int tongsanluonggiam = Class.LinQConnection.ReturnResult(sql); 
                    int phatsinh = Tongtuky - ca2ky + tanggiam;


                    DataRow row = tableTre.NewRow();
                    row[tuky.Replace("_", "/")] = Tongtuky;
                    row[denky.Replace("_", "/")] = Tongdenky;
                    row["TĂNG GIẢM"] = tanggiam;
                    row["=0 2 KỲ"] = ca2ky;
                    row["SỬ DỤNG LẠI"] = sudunglai;
                    row["PHÁT SINH"] = phatsinh;
                    row["SANLUONG"] = tongsanluong;
                    row["SANLUONGGIAM"] = tongsanluonggiam;
                    

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

                    /// PHAN TICH THEO NHAN VIEN DS

                    DataTable t1 = Class.LinQConnection.getDataTable("SELECT  nv.MAYDS, nv.FULLNAME,COUNT(*) AS SOLUONG FROM TB_NHANVIENDOCSO nv, HOADONTH" + tuky + "  ds  WHERE nv.MAYDS  = CONVERT(int,SUBSTRING(Khu,3,2)) AND LNCC=0 GROUP BY nv.MAYDS, nv.FULLNAME ORDER BY nv.MAYDS ASC");
                    HDONHANVIENTU.DataSource = t1;
                    HDONHANVIENTU.DataBind();

                    DataTable t2 = Class.LinQConnection.getDataTable("SELECT  nv.MAYDS, nv.FULLNAME,COUNT(*) AS SOLUONG FROM TB_NHANVIENDOCSO nv, HOADONTH" + denky + "  ds  WHERE nv.MAYDS  = CONVERT(int,SUBSTRING(Khu,3,2)) AND LNCC=0 GROUP BY nv.MAYDS, nv.FULLNAME ORDER BY nv.MAYDS ASC");
                    HDONHANVIENDEN.DataSource = t2;
                    HDONHANVIENDEN.DataBind();

                    for (int i = 0; i < t1.Rows.Count; i++) {
                        t1.Rows[i]["SOLUONG"] = int.Parse(t2.Rows[i]["SOLUONG"].ToString()) - int.Parse(t1.Rows[i]["SOLUONG"].ToString());
                    }

                    sosanhnv.DataSource = t1;
                    sosanhnv.DataBind();
                    

                }
                else if ("To".Equals(this.sosanh.Text))
                {
                    this.panelAnd.Visible = false;
                    this.panelTu.Visible = true;
                    getChart();
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


        string FullKy(int n)
        {
            if (n < 10)
                return "0" + n;
            return n + "";
        }

        string getFullKY(string _ky)
        {
            string k = "";

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

        public DataTable getChart()
        {
            DataTable tableTre = new DataTable();

           

            string _tungay = "01/"+getFullKY(this.tungay.Text);
            int _tuky = int.Parse(_tungay.Substring(3, 2));
            int _tunam = int.Parse(_tungay.Substring(6, 4));

            string _denngay = "01/" + getFullKY(this.denngay.Text);
            int _denky = int.Parse(_denngay.Substring(3, 2));
            int _dennam = int.Parse(_denngay.Substring(6, 4));

            DateTime tNgay = DateTime.ParseExact(_tungay, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            DateTime dNgay = DateTime.ParseExact(_denngay, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

            int tongThang = (dNgay.Month - tNgay.Month) + 12 * (dNgay.Year - tNgay.Year) + 1;
            string[] arrTitle = new string[tongThang];

            for (int i = 0; i < tongThang; i++)
            {
                string tableName = FullKy(_tuky) + "_" + _tunam;
                tableTre.Columns.Add(tableName, typeof(String));
                arrTitle[i] = tableName;
                _tuky = _tuky + 1;
                if (_tuky > 12)
                {
                    _tuky = 1;
                    _tunam = _tunam + 1;
                }
            }

            string title = " ['Kỳ', 'Tổng HĐ=0', 'Tăng/Giảm', 'KH Không Sử Dụng', 'KH Sử Dụng Lại', 'KH Phát Sinh']";

            string minKy="";
            string maxky = "";
            if (tableTre != null)
            {
                minKy = arrTitle[0].ToString();
                DataRow row = tableTre.NewRow();
                bool flag = false;
                int Tongtuky = 0;
                string tongdanhsach = "SELECT K01.KHU as LOTRINH,K01.DANHBO,K01.HOPDONG,K01.TENKH as HOTEN,K01.SONHA, K01.DUONG as TENDUONG,K01.HIEUDH as HIEU,K01.CODH  as CO,K01.NAMLD as NAM,K01.CODE,K01.LNCC as 'TIEUTHU',K01.NHANVIEN,K01.QUAN,K01.PHUONG   FROM  HOADONTH" + minKy + " K01 WHERE LNCC=0 ";

                string phantichCode = "SELECT K01.CODE, COUNT(*) AS SL   FROM  HOADONTH" + minKy + " K01 WHERE K01.LNCC=0 ";
                string phantichQP = "SELECT (K01.QUAN+'.'+K01.PHUONG ) AS QP, COUNT(*) AS SL    FROM  HOADONTH" + minKy + " K01 WHERE K01.LNCC=0 ";
                
                foreach (string s in arrTitle)
                {

                    string sql = "SELECT COUNT(*) FROM HOADONTH" + s + " WHERE LNCC=0";
                    // log.Error("LinQConnection ExecuteCommand : " + sql);
                    int soluong = Class.LinQConnection.ReturnResult(sql);
                    row[s] = soluong;
                    if (soluong != 0)
                    {
                        if (flag == false)
                        {
                            title += ",['" + s.Replace("_", "/") + "'," + soluong + ",0,0,0,0]";
                            Tongtuky = soluong;
                            flag = true;
                        }
                        else {
                            maxky = s;
                            tongdanhsach += " AND DANHBO IN (SELECT DANHBO FROM HOADONTH" + s + " WHERE LNCC=0 )";
                            phantichCode += " AND DANHBO IN (SELECT DANHBO FROM HOADONTH" + s + " WHERE LNCC=0 )";
                            phantichQP += " AND DANHBO IN (SELECT DANHBO FROM HOADONTH" + s + " WHERE LNCC=0 )";
                            int tanggiam = soluong - Tongtuky;
                            sql = "SELECT COUNT(*) FROM HOADONTH" + minKy + " K12, HOADONTH" + s + " K01 WHERE K12.DANHBO= K01.DANHBO AND K12.LNCC =0 AND K01.LNCC = 0";
                            int ca2ky = Class.LinQConnection.ReturnResult(sql);

                            sql = "SELECT COUNT(*) FROM HOADONTH" + minKy + " K12, HOADONTH" + s + " K01 WHERE K12.DANHBO= K01.DANHBO AND K12.LNCC =0 AND K01.LNCC <> 0";
                            int sudunglai = Class.LinQConnection.ReturnResult(sql);

                            sql = "SELECT SUM(CONVERT(int,K01.LNCC)) FROM HOADONTH" + minKy + " K12, HOADONTH" + s + " K01 WHERE K12.DANHBO= K01.DANHBO AND K12.LNCC =0 AND K01.LNCC <> 0";
                            int tongsanluong = Class.LinQConnection.ReturnResult(sql);

                            int phatsinh = Tongtuky - ca2ky + tanggiam;

                            title += ",['" + s.Replace("_", "/") + "'," + soluong + "," + tanggiam + "," + ca2ky + "," + sudunglai + "," + phatsinh + "]";
                        }
                    }
                }


                phantichCode += " GROUP BY CODE ORDER BY CODE ASC ";
                phantichQP += " GROUP BY K01.QUAN+'.'+K01.PHUONG ORDER BY K01.QUAN+'.'+K01.PHUONG ASC ";



                tongdanhsach = tongdanhsach.Replace(minKy, "MIN");
                tongdanhsach = tongdanhsach.Replace(maxky, "MAX");

                phantichCode = phantichCode.Replace(minKy, "MIN");
                phantichCode = phantichCode.Replace(maxky, "MAX");

                phantichQP = phantichQP.Replace(minKy, "MIN");
                phantichQP = phantichQP.Replace(maxky, "MAX");


                tongdanhsach = tongdanhsach.Replace("MIN", maxky);
                tongdanhsach = tongdanhsach.Replace("MAX", minKy);

                phantichCode = phantichCode.Replace("MIN", maxky);
                phantichCode = phantichCode.Replace("MAX", minKy);

                phantichQP = phantichQP.Replace("MIN", maxky);
                phantichQP = phantichQP.Replace("MAX", minKy);


                GridViewTuCode.DataSource = Class.LinQConnection.getDataTable(phantichCode); ;
                GridViewTuCode.DataBind();
                GridViewTuQP.DataSource = Class.LinQConnection.getDataTable(phantichQP); ;
                GridViewTuQP.DataBind();

                Session["SQL"] = tongdanhsach;
                tongdanhsach += "ORDER BY K01.KHU  ASC";
                DataTable TongDS = Class.LinQConnection.getDataTable(tongdanhsach);
                Session["TongDS"] = TongDS;
                lbTongCong.Text = "TỔNG SỐ HÓA ĐƠN = 0M3 " + tongThang + " KỲ LIÊN TIẾP  : " + Class.Format.NumberFormat(TongDS.Rows.Count);
                Session["treport"] = "DANH SÁCH HÓA ĐƠN = 0M3 " + tongThang + " KỲ LIÊN TIẾP TỪ KỲ " + getFullKY(this.tungay.Text) + " ĐẾN " + getFullKY(this.denngay.Text);
                ///tableTre.Rows.Add(row);
            }

            title = "[" + title + "]";
            Session["hoadon"] = title;
            return tableTre;
        }
        
        

    }

}