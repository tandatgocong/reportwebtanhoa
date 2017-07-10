using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuanLyKhachHang.Class;
using QuanLyKhachHang.DataBase;
using System.Drawing;

namespace QuanLyKhachHang
{
    public partial class mHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        TB_DULIEUKHACHHANG khachhang = null;
        void LoadThongTinDB(string sodanhbo)
        {
            if (sodanhbo.Length == 11)
            {
                khachhang = C_DuLieuKhachHang.finByDanhBo(sodanhbo);
                if (khachhang != null)
                {
                    lotrinh.Text = khachhang.LOTRINH;
                    ////   DOT.Text = khachhang.LOTRINH.Substring(1, 2);
                    //HOPDONG.Text = khachhang.HOPDONG;
                    lbTenKh.Text = khachhang.HOTEN;
                    diachi.Text = khachhang.SONHA + ' ' + khachhang.TENDUONG;
                    //txtDienThoai.Text = khachhang.DIENTHOAI;
                    //QUAN.Text = khachhang.QUAN + "." + khachhang.PHUONG;
                    hieuluc.Text = String.Format("{0:00}", khachhang.KY) + "/" + khachhang.NAM;
                    giabieu.Text = khachhang.GIABIEU;
                    dinhmuc.Text = khachhang.DINHMUC;
                    ngaygan.Text = Format.NgayVNVN(khachhang.NGAYTHAY.Value);
                    ngaykiemdinh.Text = Format.NgayVNVN(khachhang.NGAYKIEMDINH.Value);
                    hieudhn.Text = khachhang.HIEUDH + "  - " + khachhang.CODH + "  - " + khachhang.SOTHANDH + " - " +  khachhang.VITRIDHN;
                    //txtDMA.Text = khachhang.MADMA;
                    //txtApluc.Text = CKhachHang.getApLuc(khachhang.MADMA.Replace("TH-", ""));
                    nvds.Text = C_DuLieuKhachHang.getNVDS(khachhang.LOTRINH.Substring(2, 2));
                    nvtt.Text = C_DuLieuKhachHang.getNVThuTien(khachhang.DANHBO);

                }
                else
                {
                    TB_DULIEUKHACHHANG_HUYDB khachhanghuy = C_DuLieuKhachHang.finByDanhBoHuy(sodanhbo);
                    if (khachhanghuy != null)
                    {
                        try
                        {
                            //rDanhBo.Text = khachhanghuy.DANHBO;
                            lotrinh.Text = khachhang.LOTRINH;
                            ////    DOT.Text = khachhanghuy.DOT;
                            //HOPDONG.Text = khachhanghuy.HOPDONG;
                            lbTenKh.Text = khachhang.HOTEN;
                            diachi.Text = khachhang.SONHA + ' ' + khachhang.TENDUONG;
                            //QUAN.Text = khachhanghuy.QUAN + "  " + khachhanghuy.PHUONG;
                            hieuluc.Text = "Hết HL " + khachhanghuy.HIEULUCHUY;
                            giabieu.Text = khachhanghuy.GIABIEU;
                            dinhmuc.Text = khachhanghuy.DINHMUC;
                            ngaygan.Text = Format.NgayVNVN(khachhanghuy.NGAYTHAY.Value);
                            ngaykiemdinh.Text = Format.NgayVNVN(khachhanghuy.NGAYKIEMDINH.Value);
                            hieudhn.Text = khachhanghuy.HIEUDH + "  - " + khachhanghuy.CODH + "  - " + khachhanghuy.SOTHANDH + " - " + khachhanghuy.VITRIDHN;
                            nvds.Text = C_DuLieuKhachHang.getNVDS(khachhanghuy.LOTRINH.Substring(2, 2));
                            nvtt.Text = C_DuLieuKhachHang.getNVThuTien(khachhanghuy.DANHBO);
                        }
                        catch (Exception)
                        {
                            
                        }
                        
                    }
                    else
                    {

                        lbTenKh.Text = "Không Tìm Thấy Khách Hàng";
                        lbTenKh.ForeColor = Color.Red;
                        //Refesh();
                    }

                }
            }
        }
        protected void txtDB_TextChanged(object sender, EventArgs e)
        {
            LoadThongTinDB(this.txtDB.Text);
        }
    }
}