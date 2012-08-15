using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaoCao_Web.Class
{
    public class Format
    {
        public static string NumberFormat(object num1) {         
            if (num1 != null)
            {
                string num = num1.ToString();
                num = num.Replace(" ", "");
                if (!"".Equals(num) && !"NULL".Equals(num.ToUpper()))
                {
                    return String.Format("{0:0,0}", double.Parse(num)).Replace(",", ".");
                }
            }
            return "";        
        }
        public static double ConvertDouble(object num1)
        {
            if (num1 != null)
            {
                string num = num1.ToString();
                num = num.Replace(" ", "");
                if (!"".Equals(num) && !"NULL".Equals(num.ToUpper()))
                {
                    return double.Parse(num);
                }
            }
            return 0;
        }
        public static string PhanTram(object num1)
        {
            if (num1 != null)
            {
                string num = num1.ToString();
                num = num.Replace(" ", "");
                if (!"".Equals(num) && !"NULL".Equals(num.ToUpper()))
                {
                    return (String.Format("{0:0.00}", (double.Parse(num) / 100)) + "%").Replace(".", ",");
                }
            }
            return "";
        }

    }
}