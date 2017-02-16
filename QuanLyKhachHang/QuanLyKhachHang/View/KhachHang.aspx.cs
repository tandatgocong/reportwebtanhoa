using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing;
using QuanLyKhachHang.Class;
using QuanLyKhachHang.DataBase;

namespace QuanLyKhachHang.View
{
    public partial class KhachHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                pSearch.Visible = false;
                pResult.Visible = false;


                if (!txtDiaChi.Text.Trim().Equals(""))
                { txtDiaChi.Focus(); }
                else if (!txtDienthoai.Text.Trim().Equals(""))
                { txtDienthoai.Focus(); }
                else if (!txtDanhBo.Text.Trim().Equals(""))
                { txtDanhBo.Focus(); }
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "View")
            {

                string db = e.CommandArgument.ToString();
                pSearch.Visible = false;
                pResult.Visible = true;
                Result(db);
            }
        }
        protected void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            search();
        }
        protected void txtDienthoai_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        protected void txtDanhBo_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        protected void GridView1_RowCreated(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("onmouseover", "this.className='onmouseoverrow'");
                e.Row.Attributes.Add("onmouseout", "this.className='normalrow'");
            }
        }

        public static DataTable lisGhiChu(string danhbo)
        {
            string sql = "SELECT  NOIDUNG,DONVI, CREATEDATE FROM TB_GHICHU WHERE DANHBO='" + danhbo + "'  ORDER BY CREATEDATE DESC";
            return LinQConnection.getDataTable(sql);
        }

        void search()
        {

            if (!txtDanhBo.Text.Trim().Equals(""))
            {
                Result(txtDanhBo.Text);
            }
            else
            {

                DataTable tb = new DataTable();
                string sql = "SELECT DANHBO,HOTEN, (SONHA+' '+ TENDUONG) as DIACHI,DIENTHOAI FROM TB_DULIEUKHACHHANG ";
                if (!txtDiaChi.Text.Trim().Equals(""))
                {
                    sql += " WHERE (SONHA+' '+ TENDUONG) LIKE '" + txtDiaChi.Text.Replace("*", "%") + "' ORDER BY LOTRINH ASC ";
                }
                else if (!txtDienthoai.Text.Trim().Equals(""))
                {
                    sql += " WHERE DIENTHOAI LIKE '" + txtDienthoai.Text.Replace("*", "%") + "' ORDER BY LOTRINH ASC ";
                }

                tb = Class.LinQConnection.getDataTable(sql);
                GridView1.DataSource = tb;
                GridView1.DataBind();
                pSearch.Visible = true;
                pResult.Visible = false;
            }
        }
        TB_DULIEUKHACHHANG khachhang = null;
        void LoadThongTinDB(string db)
        {
            if (db.Length == 11)
            {

                khachhang = Class.C_DuLieuKhachHang.finByDanhBo(db);
                if (khachhang != null)
                {
                    lbDanhBo.Text = Format.sodanhbo(khachhang.DANHBO);
                    lbLotrinh.Text = khachhang.LOTRINH;
                    lbDot.Text = khachhang.DOT;
                    lbHopDong.Text = khachhang.HOPDONG;
                    lbHoTen.Text = khachhang.HOTEN;
                    lbDiaChi.Text = khachhang.SONHA + " " + khachhang.TENDUONG;
                    lbDienthoai.Text = khachhang.DIENTHOAI;
                    lbQuanPhuong.Text = khachhang.PHUONG + "." + khachhang.QUAN;

                    lbHieuLuc.Text = String.Format("{0:00}", khachhang.KY) + "/" + khachhang.NAM;
                    lbGiaBieu.Text = khachhang.GIABIEU;
                    lbDinhMuc.Text = khachhang.DINHMUC;
                    lbNgayGan.Text = Class.Format.NgayVNVN(khachhang.NGAYTHAY.Value);
                    lbKiemDinh.Text = Class.Format.NgayVNVN(khachhang.NGAYKIEMDINH.Value);
                    lbHieu.Text = khachhang.HIEUDH;
                    lbCo.Text = khachhang.CODH;
                    lbSoThan.Text = khachhang.SOTHANDH;
                    lbViTri.Text = khachhang.VITRIDHN;
                    lbCap.Text = khachhang.CAP;
                    pSearch.Visible = false;
                    pResult.Visible = true;
                    Session["MADMA"] = khachhang.MADMA;
                }
                else
                {
                    TB_DULIEUKHACHHANG_HUYDB khachhanghuy = Class.C_DuLieuKhachHang.finByDanhBoHuy(db);
                    if (khachhanghuy != null)
                    {
                        lbLotrinh.Text = khachhanghuy.LOTRINH;
                        lbDot.Text = khachhanghuy.DOT;
                        lbHopDong.Text = khachhanghuy.HOPDONG;
                        lbHoTen.Text = khachhanghuy.HOTEN;
                        lbDiaChi.Text = khachhanghuy.SONHA + " " + khachhanghuy.TENDUONG;
                        lbQuanPhuong.Text = khachhanghuy.PHUONG + "." + khachhanghuy.QUAN;

                        lbHieuLuc.Text = "Hết HL " + khachhanghuy.HIEULUCHUY;
                        lbGiaBieu.Text = khachhanghuy.GIABIEU;
                        lbDinhMuc.Text = khachhanghuy.DINHMUC;
                        lbNgayGan.Text = Class.Format.NgayVNVN(khachhanghuy.NGAYTHAY.Value);
                        lbKiemDinh.Text = Class.Format.NgayVNVN(khachhanghuy.NGAYKIEMDINH.Value);
                        lbHieu.Text = khachhanghuy.HIEUDH;
                        lbCo.Text = khachhanghuy.CODH;
                        lbSoThan.Text = khachhanghuy.SOTHANDH;
                        lbViTri.Text = khachhanghuy.VITRIDHN;
                        pSearch.Visible = false;
                        pResult.Visible = true;
                        Session["MADMA"] = khachhanghuy.MADMA;
                    }
                    else
                    {
                        Class.Format.MessageBox(this, "Không tìm thấy thông tin Khách hàng ");
                    }
                }
            }
            else
            {
                Class.Format.MessageBox(this, "Không tìm thấy thông tin Khách hàng ");
            }
        }


        void Result(string db)
        {

            //thong tin dhn
            LoadThongTinDB(db);
            //ghichu
            gGhiChu.DataSource = lisGhiChu(db);
            gGhiChu.DataBind();
             Session["HoaDon"]= Class.C_DuLieuKhachHang.getListHoaDonReport(db);
            //
             GridView2.DataSource = Class.C_DuLieuKhachHang.getDongMoiNuoc(db);
             GridView2.DataBind();

        }
    }
}