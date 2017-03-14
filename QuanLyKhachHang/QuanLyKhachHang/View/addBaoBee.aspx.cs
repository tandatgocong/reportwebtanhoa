using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Drawing;
using QuanLyKhachHang.DataBase;
using System.Text.RegularExpressions;

namespace QuanLyKhachHang.View
{
    public partial class addBaoBee : System.Web.UI.Page
    {
        protected HtmlInputFile filMyFile;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        string imgpath = "";
        protected void Button1_Click(object sender, EventArgs e)
        {
           
            if (FileUpload1.HasFile)
                try
                {
                    string fileName = txtMaChiNhanh.Text + DateTime.Now.ToString("ddMMyyyyhhmmss") + FileUpload1.FileName.Substring(FileUpload1.FileName.LastIndexOf(".")); ;
                    string SaveLocation = Server.MapPath("~/Image2/") + fileName;
                    FileUpload1.SaveAs(SaveLocation);
                    upload.Visible = true;
                    imgpath = @"/Image2/" + fileName;
                    imgFile.ImageUrl = imgpath;
                    this.imagePath.Value = this.imagePath.Value + imgpath + ",";
                    Session["imgfile"] = this.imagePath.Value;
                    imgFile.ToolTip = "This file was stored to as file.";
                }
                catch (Exception)
                {
                    this.upload.Text = "Lỗi Không Upload Ảnh Về Server";
                }
        }
        private void WriteToFile(string strPath, ref byte[] Buffer)
        {
            FileStream newFile = new FileStream(strPath, FileMode.Create);
            newFile.Write(Buffer, 0, Buffer.Length);
            newFile.Close();
        }

        protected void btSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string lat = Request.QueryString["lat"].ToString();
                string lng = Request.QueryString["lng"].ToString();
                //string phuong = Request.QueryString["phuong"].ToString();
                //string quan = Request.QueryString["quan"].ToString();

                KT_BaoBe kt = new KT_BaoBe();
                //kt.TinhTrang = 1;
                //kt.Lat = lat;
                //kt.Lng = lng;
                //kt.SoDT = dienthoai;
                //kt.LoaiBao = type;
                //kt.DiaChi = diachi;
                //kt.Phuong = phuong;
                //kt.Quan = quan;
                //kt.NgayBao = DateTime.Now;
                //kt.GhiChu = ghichu;
                kt.Img= this.imagePath.Value;
                kt.CreateDate = DateTime.Now;
                kt.CreateBy = Session["login"].ToString();
                Class.C_CallCenter.Insert(kt);

                lbThanhCong.ForeColor = Color.Blue;
                this.lbThanhCong.Text = "Thêm Mới Địa Điểm Thành Công.";
            }
            catch (Exception)
            {
                lbThanhCong.ForeColor = Color.Red;
                this.lbThanhCong.Text = "Thêm Mới Địa Điểm Thất Bại.";

            }
        }
 
        protected void Button2_Click1(object sender, EventArgs e)
        {
          
            string filelis = Session["imgfile"].ToString();
            string[] words = Regex.Split(filelis, ",");
            string SaveLocation = Server.MapPath("~");
            for (int i = 0; i < words.Length; i++)
            {
                if (!words[i].Equals(""))
                {
                    System.IO.File.Delete(SaveLocation+words[i]);  
                }

            }
            Session["imgfile"] = "";
        }
    }
}