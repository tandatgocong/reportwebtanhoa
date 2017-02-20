using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QuanLyKhachHang.DataBase;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyKhachHang.Class
{
    public class C_CallCenter
    {
        static log4net.ILog log = log4net.LogManager.GetLogger("File");
        static CallCenterDataContext db = new CallCenterDataContext();

        public static DataTable getDataTable(string sql)
        {
            DataTable table = new DataTable();
            try
            {
                db.Connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, db.Connection.ConnectionString);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                log.Error("LinQConnection getDataTable" + ex.Message);
            }
            finally
            {
                db.Connection.Close();
            }
            return table;
        }


        public static KT_DongNuoc finById(int id)
        {
            try
            {
                var query = from q in db.KT_DongNuocs where q.ID == id select q;
                return query.SingleOrDefault();
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }
            return null;
        }

        public static void Insert(KT_DongNuoc tb)
        {
            try
            {
                db.KT_DongNuocs.InsertOnSubmit(tb);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }
        }
        public static void Delete(KT_DongNuoc tb)
        {
            try
            {
                db.KT_DongNuocs.DeleteOnSubmit(tb);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }
        }

        public static bool Update()
        {
            try
            {
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }
            return false;
        }
        public static void ExecuteCommand(string sql)
        {
            int result = 0;
            CallCenterDataContext db = new CallCenterDataContext();
            try
            {
                SqlConnection conn = new SqlConnection(db.Connection.ConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                result = Convert.ToInt32(cmd.ExecuteNonQuery());
                conn.Close();
                db.Connection.Close();
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                log.Error("LinQConnection getDataTable" + ex.Message);
            }
            finally
            {
                db.Connection.Close();
            }
            db.SubmitChanges();
        }


    }
}