using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using System.Data;
using System.Data.SqlClient;
using BaoCao_Web.DataBase;

namespace BaoCao_Web.Class
{
    public static class LinQConnection
    {
        static log4net.ILog log = log4net.LogManager.GetLogger("File");

        public static int ExecuteCommand(string sql)
        {
            int result = 0;
            TanHoaDataContext db = new TanHoaDataContext();
            try
            {
                SqlConnection conn = new SqlConnection(db.Connection.ConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                result = Convert.ToInt32(cmd.ExecuteNonQuery());
                conn.Close();
                db.Connection.Close();
                db.SubmitChanges();
                return result;
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
            return result;
        }


        public static DataTable getDataTable(string sql)
        {
            DataTable table = new DataTable();
            TanHoaDataContext db = new TanHoaDataContext();
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

        public static DataTable getDataTable(string sql, int FirstRow, int pageSize)
        {
            TanHoaDataContext db = new TanHoaDataContext();
            try
            {
                db.Connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, db.Connection.ConnectionString);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset, FirstRow, pageSize, "TABLE");
                db.Connection.Close();
                return dataset.Tables[0];
            }
            catch (Exception ex)
            {
                log.Error("LinQConnection getDataTable" + ex.Message);
            }
            finally
            {
                db.Connection.Close();
            }
            return null;
        }
        
            //TanHoaDataContext db = new TanHoaDataContext();
            //SqlConnection conn = new SqlConnection(db.Connection.ConnectionString);

            //conn.Open();
            //SqlCommand cmd = new SqlCommand("DELETEDATABG", conn);
            //cmd.CommandType = CommandType.StoredProcedure;

            //SqlParameter inparm = cmd.Parameters.Add("@shs", SqlDbType.VarChar);
            //inparm.Direction = ParameterDirection.Input;
            //inparm.Value = shs;
            //cmd.ExecuteNonQuery();
            //conn.Close();
    }
}