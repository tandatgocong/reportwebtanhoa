using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DHCD_KiemPhieu.DataBase;
using System.Reflection;
using System.Data.SqlClient;

namespace DHCD_KiemPhieu.View
{
    public partial class pBauCuBanKS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["login"] == null)
            //{
            //    Response.Redirect("Login.aspx");
            //}
            MaintainScrollPositionOnPostBack = true;
            if (IsPostBack)
                return;
            Binddata();
          //  this.txtCoDong.Text = "";
         
            // this.tungay.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
        }
        public DataTable LINQToDataTable<T>(IEnumerable<T> varlist)
        {
            DataTable dtReturn = new DataTable();

            // column names 
            PropertyInfo[] oProps = null;

            if (varlist == null) return dtReturn;

            foreach (T rec in varlist)
            {
                // Use reflection to get property names, to create table, Only first time, others will follow 
                if (oProps == null)
                {
                    oProps = ((Type)rec.GetType()).GetProperties();
                    foreach (PropertyInfo pi in oProps)
                    {
                        Type colType = pi.PropertyType;

                        if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition()
                        == typeof(Nullable<>)))
                        {
                            colType = colType.GetGenericArguments()[0];
                        }

                        dtReturn.Columns.Add(new DataColumn(pi.Name, colType));
                    }
                }

                DataRow dr = dtReturn.NewRow();

                foreach (PropertyInfo pi in oProps)
                {
                    dr[pi.Name] = pi.GetValue(rec, null) == null ? DBNull.Value : pi.GetValue
                    (rec, null);
                }

                dtReturn.Rows.Add(dr);
            }
            return dtReturn;
        }

        protected static string _connectionString;  // Chuỗi kết nối
        protected SqlConnection connection;         // Đối tượng kết nối
        protected SqlDataAdapter adapter;           // Đối tượng adapter chứa dữ liệu
        protected SqlCommand command;               // Đối tượng command thực thi truy vấn

        public void Connect()
        {
            _connectionString = db.Connection.ConnectionString;
            connection = new SqlConnection(_connectionString);
            if (connection.State == ConnectionState.Closed)
                connection.Open();
        }

        public void Disconnect()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

        /// <summary>
        /// Thực thi câu truy vấn SQL trả về một đối tượng DataSet chứa kết quả trả về
        /// </summary>
        /// <param name="strSelect">Câu truy vấn cần thực thi lấy dữ liệu</param>
        /// <returns>Đối tượng dataset chứa dữ liệu kết quả câu truy vấn</returns>
        public DataSet ExecuteQuery_SqlDataAdapter_DataSet(string sql)
        {
            try
            {
                Connect();
                DataSet dataset = new DataSet();
                command = new SqlCommand();
                command.Connection = this.connection;
                adapter = new SqlDataAdapter(sql, connection);
                try
                {
                    adapter.Fill(dataset);
                }
                catch (SqlException e)
                {
                    throw e;
                }
                Disconnect();
                return dataset;
            }
            catch (Exception ex)
            {
                Disconnect();
                //MessageBox.Show(ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// Thực thi câu truy vấn SQL trả về một đối tượng DataTable chứa kết quả trả về
        /// </summary>
        /// <param name="strSelect">Câu truy vấn cần thực thi lấy dữ liệu</param>
        /// <returns>Đối tượng datatable chứa dữ liệu kết quả câu truy vấn</returns>
        public DataTable ExecuteQuery_SqlDataAdapter_DataTable(string sql)
        {
            try
            {
                return ExecuteQuery_SqlDataAdapter_DataSet(sql).Tables[0];
            }
            catch (Exception ex)
            {
                Disconnect();
                //MessageBox.Show(ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        TanHoaDataContext db = new TanHoaDataContext();
        int TongUV = 0;
        private void Binddata()
        {
            var query2 = from itemBC in db.KIEMPHIEU_BAUCUs
                         where itemBC.UNGVIEN.LoaiBC == int.Parse(DropDownList1.SelectedValue.ToString())
                         group itemBC by itemBC.ID_UngCu into itemGroup
                         select new
                         {
                             ID = itemGroup.Key,
                             Name = db.UNGVIENs.SingleOrDefault(item => item.ID == itemGroup.Key).Name,
                             SoPhieu = itemGroup.Count(item => item.TONGCD > 0),
                             CoPhan = itemGroup.Sum(item => item.TONGCD.Value),
                             Dat = (double)(itemGroup.Sum(item => item.TONGCD.Value)) / (db.DSCODONG_THAMDUs.Sum(item => item.TONGCD.Value)) * 100,
                         };
           
            
            DataTable tb = LINQToDataTable(query2);


            if (tb.Rows.Count > 0)
            {
                Session["BAUCU"] = tb;
                TongUV = tb.Rows.Count;
                Count();
            }
            else
                Session["BAUCU"] = null;


        }

        public void Count()
        {


            int LoaiBC = DropDownList1.SelectedIndex;
            if (LoaiBC > 0)
            {
                ///
                if (db.DSCODONG_THAMDUs.Count() > 0)
                    txtCDThamDu.Text = String.Format(System.Globalization.CultureInfo.CreateSpecificCulture("vi-VN"), "{0:#,##}", db.DSCODONG_THAMDUs.Count());
                else
                    txtCDThamDu.Text = "0";

                if (db.KIEMPHIEU_BAUCUs.Where(item => item.UNGVIEN.LoaiBC == LoaiBC).Select(item => item.STTCD).Distinct().Count() + db.KHONGHOPLEs.Where(item => item.LoaiBC == LoaiBC).Count() > 0)
                    txtCDBoPhieu.Text = String.Format(System.Globalization.CultureInfo.CreateSpecificCulture("vi-VN"), "{0:#,##}", db.KIEMPHIEU_BAUCUs.Where(item => item.UNGVIEN.LoaiBC == LoaiBC).Select(item => item.STTCD).Distinct().Count() + db.KHONGHOPLEs.Where(item => item.LoaiBC == LoaiBC).Count());
                else
                    txtCDBoPhieu.Text = "0";

                if (db.KIEMPHIEU_BAUCUs.Where(item => item.UNGVIEN.LoaiBC == LoaiBC).Select(item => item.STTCD).Distinct().Count() > 0)
                    txtPhieuHopLe.Text = String.Format(System.Globalization.CultureInfo.CreateSpecificCulture("vi-VN"), "{0:#,##}", db.KIEMPHIEU_BAUCUs.Where(item => item.UNGVIEN.LoaiBC == LoaiBC).Select(item => item.STTCD).Distinct().Count());
                else
                    txtPhieuHopLe.Text = "0";

                if (db.KHONGHOPLEs.Where(item => item.LoaiBC == LoaiBC).Count() > 0)
                    txtPhieuKhongHopLe.Text = String.Format(System.Globalization.CultureInfo.CreateSpecificCulture("vi-VN"), "{0:#,##}", db.KHONGHOPLEs.Where(item => item.LoaiBC == LoaiBC).Count());
                else
                    txtPhieuKhongHopLe.Text = "0";

                if (db.DSCODONG_THAMDUs.Count() - (db.KIEMPHIEU_BAUCUs.Where(item => item.UNGVIEN.LoaiBC == LoaiBC).Select(item => item.STTCD).Distinct().Count() + db.KHONGHOPLEs.Where(item => item.LoaiBC == LoaiBC).Count()) > 0)
                    txtCDKhongBoPhieu.Text = String.Format(System.Globalization.CultureInfo.CreateSpecificCulture("vi-VN"), "{0:#,##}", db.DSCODONG_THAMDUs.Count() - (db.KIEMPHIEU_BAUCUs.Where(item => item.UNGVIEN.LoaiBC == LoaiBC).Select(item => item.STTCD).Distinct().Count() + db.KHONGHOPLEs.Where(item => item.LoaiBC == LoaiBC).Count()));
                else
                    txtCDKhongBoPhieu.Text = "0";
                ///

                if (db.DSCODONG_THAMDUs.Count() > 0)
                    txtCDThamDu_CP.Text = String.Format(System.Globalization.CultureInfo.CreateSpecificCulture("vi-VN"), "{0:#,##}", db.DSCODONG_THAMDUs.Sum(item => item.TONGCD.Value) * TongUV);
                else
                    txtCDThamDu_CP.Text = "0";

                if (db.KIEMPHIEU_BAUCUs.Where(item => item.UNGVIEN.LoaiBC == LoaiBC).Select(item => item.STTCD).Distinct().Count() > 0 && db.KIEMPHIEU_BAUCUs.Where(item => item.UNGVIEN.LoaiBC == LoaiBC).Select(item => item.STTCD).Distinct().Count() + db.KHONGHOPLEs.Where(item => item.LoaiBC == LoaiBC).Count() > 0)
                    txtCDBoPhieu_CP.Text = String.Format(System.Globalization.CultureInfo.CreateSpecificCulture("vi-VN"), "{0:#,##}", db.KIEMPHIEU_BAUCUs.Where(item => item.UNGVIEN.LoaiBC == LoaiBC).Count() > 0 ? db.KIEMPHIEU_BAUCUs.Where(item => item.UNGVIEN.LoaiBC == LoaiBC).Sum(item => item.TONGCD.Value) : 0 + db.KHONGHOPLEs.Where(item => item.LoaiBC == LoaiBC).Count() > 0 ? db.KHONGHOPLEs.Where(item => item.LoaiBC == LoaiBC).Sum(item => item.TONGCD.Value) * TongUV : 0);
                else
                    txtCDBoPhieu_CP.Text = "0";

                if (db.KIEMPHIEU_BAUCUs.Where(item => item.UNGVIEN.LoaiBC == LoaiBC).Select(item => item.STTCD).Distinct().Count() > 0)
                    txtPhieuHopLe_CP.Text = String.Format(System.Globalization.CultureInfo.CreateSpecificCulture("vi-VN"), "{0:#,##}", db.KIEMPHIEU_BAUCUs.Where(item => item.UNGVIEN.LoaiBC == LoaiBC).Sum(item => item.TONGCD.Value));
                else
                    txtPhieuHopLe_CP.Text = "0";

                if (db.KHONGHOPLEs.Where(item => item.LoaiBC == LoaiBC).Count() > 0)
                    txtPhieuKhongHopLe_CP.Text = String.Format(System.Globalization.CultureInfo.CreateSpecificCulture("vi-VN"), "{0:#,##}", db.KHONGHOPLEs.Where(item => item.LoaiBC == LoaiBC).Sum(item => item.TONGCD.Value) * TongUV);
                else
                    txtPhieuKhongHopLe_CP.Text = "0";

                string sql = "select SUM(TONGCD) from DSCODONG_THAMDU where MACD in (select distinct MACD from KIEMPHIEU_BAUCU a,UNGVIEN b where a.ID_UngCu=b.ID and b.LoaiBC=" + LoaiBC + ")";
                if ((db.DSCODONG_THAMDUs.Sum(item => item.TONGCD.Value) - ((db.KIEMPHIEU_BAUCUs.Where(item => item.UNGVIEN.LoaiBC == LoaiBC).Count() > 0 ? int.Parse(ExecuteQuery_SqlDataAdapter_DataTable(sql).Rows[0][0].ToString()) : 0) + (db.KHONGHOPLEs.Where(item => item.LoaiBC == LoaiBC).Count() > 0 ? db.KHONGHOPLEs.Where(item => item.LoaiBC == LoaiBC).Sum(item => item.TONGCD.Value) : 0))) > 0)
                    txtCDKhongBoPhieu_CP.Text = String.Format(System.Globalization.CultureInfo.CreateSpecificCulture("vi-VN"), "{0:#,##}", (db.DSCODONG_THAMDUs.Sum(item => item.TONGCD.Value) - ((db.KIEMPHIEU_BAUCUs.Where(item => item.UNGVIEN.LoaiBC == LoaiBC).Count() > 0 ? int.Parse(ExecuteQuery_SqlDataAdapter_DataTable(sql).Rows[0][0].ToString()) : 0) + (db.KHONGHOPLEs.Where(item => item.LoaiBC == LoaiBC).Count() > 0 ? db.KHONGHOPLEs.Where(item => item.LoaiBC == LoaiBC).Sum(item => item.TONGCD.Value) : 0))) * TongUV);
                else
                    txtCDKhongBoPhieu_CP.Text = "0";
                ///

            }
        }




        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Binddata();
            if (DropDownList1.SelectedIndex == 1)
                title.Text = "..: KẾT QUẢ BẦU CỬ THÀNH VIÊN HỘI ĐỒNG QUẢN TRỊ :..";
            else if (DropDownList1.SelectedIndex == 2)
                title.Text = "..: KẾT QUẢ BẦU CỬ THÀNH VIÊN BAN KIỂM SOÁT:..";
            else
                title.Text = "..: KẾT QUẢ BẦU CỬ  CÔNG TY CP CẤP NƯỚC TÂN HÒA :..";
          
        }

       

      
        protected void btCapNhat2_Click(object sender, EventArgs e)
        {
        }

        protected void G_KDY_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            Class.LinQConnection.ExecuteCommand("DELETE FROM KIEMPHIEU_KS WHERE ID='" + e.CommandArgument.ToString() + "'");
            Binddata();
        }

        

    }
}