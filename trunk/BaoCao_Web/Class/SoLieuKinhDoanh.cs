using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaoCao_Web.DataBase;
using log4net;
using System.Data;

namespace BaoCao_Web.Class
{
    public class SoLieuKinhDoanh
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(SoLieuKinhDoanh).Name);
        private static TanHoaDataContext db = new TanHoaDataContext();
        
        public static DataTable getSoLieuByYear(string year)
        {
            string query = "SELECT * FROM BAOCAO_KINHDOANH WHERE NAM='"+year+"'  ORDER BY KY ASC ";
            return LinQConnection.getDataTable(query);
        }

        public static bool Update() {

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

        public static bool Insert(BAOCAO_KINHDOANH bc)
        {

            try
            {
                db.BAOCAO_KINHDOANHs.InsertOnSubmit(bc);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }
            return false;
        }

        public static BAOCAO_KINHDOANH findByKy(int ky, int nam) {
            try
            {
                var query = from q in db.BAOCAO_KINHDOANHs where q.KY == ky && q.NAM == nam select q;
                return query.SingleOrDefault();
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);

            }
            return null;
            
        }

    }
}