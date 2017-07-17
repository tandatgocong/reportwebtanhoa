using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuanLyKhachHang.Class;
using QuanLyKhachHang.DataBase;
using System.Drawing;
using System.IO;

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
                    lbDanhBo.Text = khachhang.DANHBO;
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
                    loadHoaDon(khachhang.DANHBO);
                    loadGhiChu(khachhang.DANHBO);
                }
                else
                {
                    TB_DULIEUKHACHHANG_HUYDB khachhanghuy = C_DuLieuKhachHang.finByDanhBoHuy(sodanhbo);
                    if (khachhanghuy != null)
                    {
                        try
                        {

                            lbDanhBo.Text = khachhanghuy.DANHBO;
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

                            loadHoaDon(khachhanghuy.DANHBO);
                            loadGhiChu(khachhanghuy.DANHBO);
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
        public void loadHoaDon(string db)
        {
            GridView1.DataSource = Class.C_DuLieuKhachHang.getListHoaDonReport(db);
            GridView1.DataBind();
        }
        public void loadGhiChu(string db)
        {
            GridView2.DataSource = Class.C_DuLieuKhachHang.lisGhiChu(db);
            GridView2.DataBind();
        }
        protected void txtDB_TextChanged(object sender, EventArgs e)
        {
            LoadThongTinDB(this.txtDB.Text);

        }
 

        protected void btUploag_Click(object sender, EventArgs e)
        {
            if (FileUpload2.HasFile)
                try
                {
                    if (Request.Files[0].InputStream.Length > Int32.MaxValue)
                        return;
                    int dataLen = (int)Request.Files[0].InputStream.Length;
                    byte[] _byteArr = new byte[dataLen];
                    Request.Files[0].InputStream.Read(_byteArr, 0, dataLen);
                    TB_DULIEUKHACHHANG_IMG img = new TB_DULIEUKHACHHANG_IMG();
                    img.DANHBO = lbDanhBo.Text;
                    img.NGAYUP = DateTime.Now;
                    img.IMG = _byteArr;
                    C_DuLieuKhachHang.InsertImg(img);
                    //MemoryStream f = new MemoryStream(_byteArr);
                    //System.Drawing.Image _img = System.Drawing.Image.FromStream(f);
                    //Image1.ImageUrl =  Path.GetFileName(FileUpload2.FileName);



                    this.upload.Text = "OK";
                    this.upload.BackColor = Color.Blue;
                }
                catch (Exception ex)
                {
                    this.upload.BackColor = Color.Red;
                    this.upload.Text = "Lỗi" + ex.ToString(); ;
                }
        }
        public void loadAnh()
        {
            try
            {

            }
            catch (Exception)
            {
                
            }
        }
    }
}