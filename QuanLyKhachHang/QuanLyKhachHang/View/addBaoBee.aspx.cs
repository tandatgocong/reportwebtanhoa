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
using System.Xml;
using QuanLyKhachHang.Class;

namespace QuanLyKhachHang.View
{
    public partial class addBaoBee : System.Web.UI.Page
    {

        protected HtmlInputFile filMyFile;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login"] == null)
            {
                Response.Redirect(@"Login.aspx");
            }
            MaintainScrollPositionOnPostBack = true;
            if (IsPostBack)
                return;
            pLoad();

        }
        KT_BaoBe kt = null;
        public void pLoad()
        {
            lbID.Text = Request.QueryString["id"].ToString();

            checkNVSua.DataSource = C_KyThuat.getDataTable("SELECT * FROM KT_NhanVienSuaBe ");
            checkNVSua.DataTextField = "TenNV";
            checkNVSua.DataValueField = "TenNV";
            checkNVSua.DataBind();

            checkNVGS.DataSource = C_KyThuat.getDataTable("SELECT * FROM KT_NhanVienGiamSat ");
            checkNVGS.DataTextField = "TenNV";
            checkNVGS.DataValueField = "TenNV";
            checkNVGS.DataBind();
            kt = C_KyThuat.finByIdB(int.Parse(lbID.Text));
            if (kt != null)
            {
                lbDiaChi.Text = kt.SoNha +"  " + kt.TenDuong;
                lbNgayBaoBe.Text = Class.Format.NgayVNVN(kt.NgayBao.Value);
                lbGhiChuBB.Text = kt.GhiChu;
            }

        }

        string imgpath = "";
        protected void Button1_Click(object sender, EventArgs e)
        {

            if (FileUpload1.HasFile)
                try
                {
                    string fileName =   DateTime.Now.ToString("ddMMyyyyhhmmss") + FileUpload1.FileName.Substring(FileUpload1.FileName.LastIndexOf(".")); ;

                    string SaveLocation = Server.MapPath("~/FileUpload/");

                    try
                    {
                        System.IO.Directory.CreateDirectory(SaveLocation + @"/" + lbID.Text);
                    }
                    catch (Exception)
                    {
                       
                    }


                    SaveLocation = SaveLocation + @"/" + lbID.Text + @"/" + fileName;

                    FileUpload1.SaveAs(SaveLocation);

                    upload.Visible = true;

                    imgpath = @"/FileUpload" + @"/" + lbID.Text + @"/" + fileName;

                    imgFile.ImageUrl = imgpath;
                    this.imagePath.Value = this.imagePath.Value + imgpath + ",";
                    Session["imgfile"] = this.imagePath.Value.Remove(imagePath.Value.Length - 1, 1); 
                    imgFile.ToolTip = "This file was stored to as file.";
                }
                catch (Exception ex)
                {
                    this.upload.Text = "Lỗi Không Upload Ảnh Về Server" + ex.ToString();
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

                //string phuong = Request.QueryString["phuong"].ToString();
                //string quan = Request.QueryString["quan"].ToString();

                KT_BaoBe kt = C_KyThuat.finByIdB(int.Parse(lbID.Text));
                if (kt != null)
                {
                    kt.NgayTiepNhan = DateTime.Parse(this.txtDate.Text);
                    //  kt.LoaiThucHien = int.Parse(this.cbLoaiSB.SelectedValue.ToString());

                    try
                    {
                        kt.NgayThucHien = DateTime.Parse(this.dateTNden.Text);
                        kt.TuGio = DateTime.Parse(this.dataThucHienTN.Text);
                        kt.DenGio = DateTime.Parse(this.dateTNden.Text);
                    }
                    catch (Exception) { }



                    kt.KetQua = this.txtGhiChuSuaBe.Text;
                    kt.NVGiamSat = this.txtNVGS.Text;
                    kt.NVSuaBe = this.txtNVSua.Text;

                    try
                    {
                        kt.Img = this.imagePath.Value.Remove(imagePath.Value.Length - 1, 1);
                    }
                    catch (Exception) { }

                    try
                    {
                        kt.FilePdf = this.FilePath.Value;
                    }
                    catch (Exception) { }
                }


                kt.ModifyDate = DateTime.Now;
                kt.ModifyBy = Session["login"].ToString();
               
                if (C_KyThuat.Update())
                {
                    lbThanhCong.ForeColor = Color.Blue;
                    this.lbThanhCong.Text = "Cập Nhật Hoàn Công Thành Công.";

                    try
                    {
                        string sql = "UPDATE TTKH_TiepNhan SET NgayXuLy='" + DateTime.Parse(this.dateTNden.Text) + "',KetQuaXuLy=N'Hoàn Tất Sửa Bể',NhanVienXuLy=N'" + Session["login"].ToString() + "'  WHERE SoHoSo='" + kt.SoHoSo + "'";
                        C_TrungTamKhachHang.ExecuteCommand_(sql);
                    }
                    catch (Exception)
                    {
                    }
                }
                else
                {
                    lbThanhCong.ForeColor = Color.Red;
                    this.lbThanhCong.Text = "Cập Nhật Hoàn Công Thất Bại.";
                }

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

            }
            catch (Exception)
            {
                lbThanhCong.ForeColor = Color.Red;
                this.lbThanhCong.Text = "Cập Nhật Hoàn Công Thất Bại.";

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
                    System.IO.File.Delete(SaveLocation + words[i]);
                }

            }
            Session["imgfile"] = "";
        }

        protected void checkNVSua_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string name = "";
                for (int i = 0; i < checkNVSua.Items.Count; i++)
                {
                    if (checkNVSua.Items[i].Selected)
                    {
                        name += checkNVSua.Items[i].Text + ",";
                    }
                }
                this.txtNVSua.Text = name.Remove(name.Length - 1, 1);
            }
            catch (Exception)
            {

            }

        }

        protected void checkNVGS_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string name = "";
                for (int i = 0; i < checkNVGS.Items.Count; i++)
                {
                    if (checkNVGS.Items[i].Selected)
                    {
                        name += checkNVGS.Items[i].Text + ",";
                    }
                }
                this.txtNVGS.Text = name.Remove(name.Length - 1, 1);
            }
            catch (Exception)
            {

            }

        }

        protected void btUploag(object sender, EventArgs e)
        {
            if (FileUpload2.HasFile)
                try
                {
                    string fileName = DateTime.Now.ToString("ddMMyyyyhhmmss") + FileUpload2.FileName.Substring(FileUpload2.FileName.LastIndexOf("."));  
                    
                    string SaveLocation = Server.MapPath("~/FileUpload/");

                    System.IO.Directory.CreateDirectory(SaveLocation + @"/" + lbID.Text);

                    SaveLocation = SaveLocation + @"/" + lbID.Text + @"/" + fileName;

                    FileUpload2.SaveAs(SaveLocation);
                    upload.Visible = true;
                   
                    imgpath = @"/FileUpload" +  @"/" + lbID.Text + @"/" + fileName;

                    this.FilePath.Value = imgpath;

                    this.uploadfile.Text = "Upload Thành Công";
                    this.uploadfile.BackColor = Color.Blue;
                }
                catch (Exception ex)
                {
                    this.uploadfile.BackColor = Color.Red;
                    this.uploadfile.Text = "Lỗi Không Upload Về Server" + ex.ToString(); ;
                }

        }

        protected void btTrolai(object sender, EventArgs e)
        {
            Response.Redirect(@"bbNhapHoanCong.aspx");
        }














        /*
        public void Load()
        {
            string lat = Request.QueryString["lat"].ToString();
            string lng = Request.QueryString["lng"].ToString();

            string sonha = "";
            string duong = "";
            string phuong = "";
            string quan = "";
            int f = 1;
            string URLString = " http://maps.google.com/maps/api/geocode/xml?latlng=10.7684380,106.6306070&sensor=false ";
            XmlTextReader reader = new XmlTextReader(URLString);
            string geometry = "";

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
                        if (f == 1 && geometry == "long_name")
                        {
                            sonha = reader.Value; f++;
                        }
                        else if (f == 2 && geometry == "long_name")
                        {
                            duong = reader.Value; f++;
                        }
                        else if (f == 3 && geometry == "long_name")
                        {
                            phuong = reader.Value; f++;
                        }
                        else if (f == 4 && geometry == "long_name")
                        {
                            quan = reader.Value; f++;
                        }

                        break;

                    case XmlNodeType.EndElement: //Display the end of the element.
                        //Console.Write("</" + reader.Name);
                        //Console.WriteLine(">");
                        break;
                }
            }
        
        }
        */
    }
}