using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KETQUa
{
    public partial class slideKiemPhieu : Form
    {
        public slideKiemPhieu()
        {
            InitializeComponent();
            l1.Text = "Thông qua Báo cáo hoạt động của Hội đồng quản trị \n năm 2015 và kế hoạch hoạt động năm 2016";
            l2.Text = "Thông qua Báo cáo hoạt động của Ban kiểm soát\n Công ty CP Cấp nước Tân Hòa năm 2015";
            l3.Text = "Thông qua Báo cáo tổng kết hoạt động sản xuất \n kinh doanh năm 2015 và Phương hướng \nhoạt động  sản xuất kinh doanh năm 2016";
            l4.Text = "Thông qua Báo cáo tài chính tóm tắt năm 2015\n (đã kiểm toán) và Kế hoạch tài chính năm 2016";
            l5.Text = "Thông qua Tờ trình sửa đổi,bổ sung Điều lệ Công ty\n theo Luật doanh nghiệp năm 2014";
            l6.Text = "Thông qua Ủy quyền cho HĐQT\n lựa chọn đơn vị kiểm toán năm 2016";
            l7.Text = "Thông qua Tờ trình phương án phân phối lợi nhuận,\n trích lập các quỹ và chi cổ tức năm 2015";
            l8.Text = "Thông qua Báo cáo  thù lao của HĐQT, BKS, \nThư ký năm 2015 và Kế hoạch thù lao HĐQT, \nBKS, Thư ký năm 2015";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lThamDu_Click(object sender, EventArgs e)
        {
            this.lbThamDu.Visible = true;
        }

        private void slCoDong_Click(object sender, EventArgs e)
        {
            this.lbCoPhieu.Visible = true;
        }

        private void phatra_Click(object sender, EventArgs e)
        {
            this.lbPhatra.Visible = true;
        }

        private void thuvao_Click(object sender, EventArgs e)
        {
            this.lbThuVao.Visible = true;
        }
        private void label7_Click(object sender, EventArgs e)
        {
            this.lbCoPhieu.Visible = true;
        }


        public void LoadForm()
        {
            this.lbThamDu.Text = String.Format("{0:0,0}", LinQConnection.ReturnResult("SELECT COUNT(TONGCD) FROM DSCODONG_THAMDU"));
            this.lbCoPhieu.Text = String.Format("{0:0,0}", LinQConnection.ReturnResult("SELECT SUM(TONGCD) FROM DSCODONG_THAMDU"));
            
            string sql = " SELECT COUNT(*) FROM DSCODONG_THAMDU cd, BIEUQUYET kp  WHERE cd.MACD=kp.MACD AND LANBQ= " + textBox1.Text + " AND CONVERT(VARCHAR(50),NGAYBQ,103)='" + this.dateTimePicker1.Text + "'  ";
            double res=LinQConnection.ReturnResult(sql);
            this.lbPhatra.Text = String.Format("{0:0,0}", res);
            this.lbThuVao.Text = String.Format("{0:0,0}", res);

            DataTable tb = LinQConnection.ExecuteStoredProcedure("p_BIEUQUYET", textBox1.Text, this.dateTimePicker1.Text);
            //try
            //{
                _1T1.Text = tb.Rows[0]["_1T1"].ToString();
                _1C1.Text = tb.Rows[0]["_1C1"].ToString();
                _1C2.Text = tb.Rows[0]["_1C2"].ToString();
                _1S2.Text = String.Format("{0:0,0}",tb.Rows[0]["_1S2"]);
                _1T2.Text = tb.Rows[0]["_1T2"].ToString();
                _1T3.Text = tb.Rows[0]["_1T3"].ToString();
                _1S3.Text = String.Format("{0:0,0}",tb.Rows[0]["_1S3"]);
                _1C3.Text = tb.Rows[0]["_1C3"].ToString();
                _1T4.Text = tb.Rows[0]["_1T4"].ToString();
                _1S4.Text = String.Format("{0:0,0}",tb.Rows[0]["_1S4"]);
                _1C4.Text = tb.Rows[0]["_1C4"].ToString();
                _1S1.Text = String.Format("{0:0,0}",tb.Rows[0]["_1S1"]);
                _8C1.Text = tb.Rows[0]["_8C1"].ToString();
                _8T1.Text = tb.Rows[0]["_8T1"].ToString();
                _8S1.Text = String.Format("{0:0,0}",tb.Rows[0]["_8S1"]);
                _8C2.Text = tb.Rows[0]["_8C2"].ToString();
                _8T4.Text = tb.Rows[0]["_8T4"].ToString();
                _8S2.Text = String.Format("{0:0,0}",tb.Rows[0]["_8S2"]);
                _8S4.Text = String.Format("{0:0,0}",tb.Rows[0]["_8S4"]);
                _8T2.Text = tb.Rows[0]["_8T2"].ToString();
                _8C4.Text = tb.Rows[0]["_8C4"].ToString();
                _8C3.Text = tb.Rows[0]["_8C3"].ToString();
                _8T3.Text = tb.Rows[0]["_8T3"].ToString();
                _8S3.Text = String.Format("{0:0,0}",tb.Rows[0]["_8S3"]);
                _7C1.Text = tb.Rows[0]["_7C1"].ToString();
                _7T1.Text = tb.Rows[0]["_7T1"].ToString();
                _7C2.Text = tb.Rows[0]["_7C2"].ToString();
                _7S2.Text = String.Format("{0:0,0}",tb.Rows[0]["_7S2"]);
                _7T2.Text = tb.Rows[0]["_7T2"].ToString();
                _7C3.Text = tb.Rows[0]["_7C3"].ToString();
                _7S3.Text = String.Format("{0:0,0}",tb.Rows[0]["_7S3"]);
                _7T3.Text = tb.Rows[0]["_7T3"].ToString();
                _7C4.Text = tb.Rows[0]["_7C4"].ToString();
                _7S4.Text = String.Format("{0:0,0}",tb.Rows[0]["_7S4"]);
                _7T4.Text = tb.Rows[0]["_7T4"].ToString();
                _7S1.Text = String.Format("{0:0,0}",tb.Rows[0]["_7S1"]);
                _6C1.Text = tb.Rows[0]["_6C1"].ToString();
                _6T1.Text = tb.Rows[0]["_6T1"].ToString();
                _6S2.Text = String.Format("{0:0,0}",tb.Rows[0]["_6S2"]);
                _6C3.Text = tb.Rows[0]["_6C3"].ToString();
                _6T3.Text = tb.Rows[0]["_6T3"].ToString();
                _6S4.Text = String.Format("{0:0,0}",tb.Rows[0]["_6S4"]);
                _6S1.Text = String.Format("{0:0,0}",tb.Rows[0]["_6S1"]);
                _6T4.Text = tb.Rows[0]["_6T4"].ToString();
                _6C4.Text = tb.Rows[0]["_6C4"].ToString();
                _6S3.Text = String.Format("{0:0,0}",tb.Rows[0]["_6S3"]);
                _6T2.Text = tb.Rows[0]["_6T2"].ToString();
                _6C2.Text = tb.Rows[0]["_6C2"].ToString();
                _5C1.Text = tb.Rows[0]["_5C1"].ToString();
                _5T1.Text = tb.Rows[0]["_5T1"].ToString();
                _5C3.Text = tb.Rows[0]["_5C3"].ToString();
                _5S4.Text = String.Format("{0:0,0}",tb.Rows[0]["_5S4"]);
                _5T4.Text = tb.Rows[0]["_5T4"].ToString();
                _5S3.Text = String.Format("{0:0,0}",tb.Rows[0]["_5S3"]);
                _5C2.Text = tb.Rows[0]["_5C2"].ToString();
                _5T2.Text = tb.Rows[0]["_5T2"].ToString();
                _5C4.Text = tb.Rows[0]["_5C4"].ToString();
                _5S1.Text = String.Format("{0:0,0}",tb.Rows[0]["_5S1"]);
                _5T3.Text = tb.Rows[0]["_5T3"].ToString();
                _5S2.Text = String.Format("{0:0,0}",tb.Rows[0]["_5S2"]);
                _4C1.Text = tb.Rows[0]["_4C1"].ToString();
                _4T1.Text = tb.Rows[0]["_4T1"].ToString();
                _4S4.Text = String.Format("{0:0,0}",tb.Rows[0]["_4S4"]);
                _4S3.Text = String.Format("{0:0,0}",tb.Rows[0]["_4S3"]);
                _4T2.Text = tb.Rows[0]["_4T2"].ToString();
                _4S1.Text = String.Format("{0:0,0}",tb.Rows[0]["_4S1"]);
                _4S2.Text = String.Format("{0:0,0}",tb.Rows[0]["_4S2"]);
                _4T3.Text = tb.Rows[0]["_4T3"].ToString();
                _4C4.Text = tb.Rows[0]["_4C4"].ToString();
                _4C2.Text = tb.Rows[0]["_4C2"].ToString();
                _4T4.Text = tb.Rows[0]["_4T4"].ToString();
                _4C3.Text = tb.Rows[0]["_4C3"].ToString();
                _3C1.Text = tb.Rows[0]["_3C1"].ToString();
                _3T1.Text = tb.Rows[0]["_3T1"].ToString();
                _3S3.Text = String.Format("{0:0,0}",tb.Rows[0]["_3S3"]);
                _3S1.Text = String.Format("{0:0,0}",tb.Rows[0]["_3S1"]);
                _3T3.Text = tb.Rows[0]["_3T3"].ToString();
                _3C2.Text = tb.Rows[0]["_3C2"].ToString();
                _3C3.Text = tb.Rows[0]["_3C3"].ToString();
                _3T4.Text = tb.Rows[0]["_3T4"].ToString();
                _3C4.Text = tb.Rows[0]["_3C4"].ToString();
                _3S2.Text = String.Format("{0:0,0}",tb.Rows[0]["_3S2"]);
                _3T2.Text = tb.Rows[0]["_3T2"].ToString();
                _3S4.Text = String.Format("{0:0,0}",tb.Rows[0]["_3S4"]);
                _2C1.Text = tb.Rows[0]["_2C1"].ToString();
                _2T1.Text = tb.Rows[0]["_2T1"].ToString();
                _2S1.Text = String.Format("{0:0,0}",tb.Rows[0]["_2S1"]);
                _2C2.Text = tb.Rows[0]["_2C2"].ToString();
                _2T4.Text = tb.Rows[0]["_2T4"].ToString();
                _2S2.Text = String.Format("{0:0,0}", tb.Rows[0]["_2S2"]);
                _2S4.Text = String.Format("{0:0,0}", tb.Rows[0]["_2S4"]);
                _2T2.Text = tb.Rows[0]["_2T2"].ToString();
                _2C4.Text = tb.Rows[0]["_2C4"].ToString();
                _2C3.Text = tb.Rows[0]["_2C3"].ToString();
                _2T3.Text = tb.Rows[0]["_2T3"].ToString();
                _2S3.Text = String.Format("{0:0,0}",tb.Rows[0]["_2S3"]);
            //}
            //catch (Exception)
            //{

            //}

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                LoadForm();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            l1.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            l2.Visible = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            l3.Visible = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            l4.Visible = true;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            l5.Visible = true;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            l6.Visible = true;
        }

        private void label14_Click(object sender, EventArgs e)
        {
            l7.Visible = true;
        }

        private void label16_Click(object sender, EventArgs e)
        {
            l8.Visible = true;
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            panel8.Visible = false;
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            panel9.Visible = false;
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            panel10.Visible = false;
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            panel11.Visible = false;
        }

        private void panel12_Click(object sender, EventArgs e)
        {
            panel12.Visible = false;
        }
        private void panel13_Click(object sender, EventArgs e)
        {
            panel13.Visible = false;
        }
        private void panel14_Click(object sender, EventArgs e)
        {
            panel14.Visible = false;
        }
        private void panel15_Click(object sender, EventArgs e)
        {
            panel15.Visible = false;
        }
        private void panel16_Click(object sender, EventArgs e)
        {
            panel16.Visible = false;
        }
        private void panel17_Click(object sender, EventArgs e)
        {
            panel17.Visible = false;
        }
        private void panel18_Click(object sender, EventArgs e)
        {
            panel18.Visible = false;
        }
        private void panel19_Click(object sender, EventArgs e)
        {
            panel19.Visible = false;
        }
        private void panel20_Click(object sender, EventArgs e)
        {
            panel20.Visible = false;
        }
        private void panel21_Click(object sender, EventArgs e)
        {
            panel21.Visible = false;
        }
        private void panel22_Click(object sender, EventArgs e)
        {
            panel22.Visible = false;
        }
        private void panel23_Click(object sender, EventArgs e)
        {
            panel23.Visible = false;
        }
        private void panel24_Click(object sender, EventArgs e)
        {
            panel24.Visible = false;
        }
        private void panel25_Click(object sender, EventArgs e)
        {
            panel25.Visible = false;
        }
        private void panel26_Click(object sender, EventArgs e)
        {
            panel26.Visible = false;
        }
        private void panel27_Click(object sender, EventArgs e)
        {
            panel27.Visible = false;
        }
        private void panel28_Click(object sender, EventArgs e)
        {
            panel28.Visible = false;
        }
        private void panel29_Click(object sender, EventArgs e)
        {
            panel29.Visible = false;
        }

        private void panel30_Click(object sender, EventArgs e)
        {
            panel30.Visible = false;
        }
        private void panel31_Click(object sender, EventArgs e)
        {
            panel31.Visible = false;
        }
        private void panel32_Click(object sender, EventArgs e)
        {
            panel32.Visible = false;
        }
        private void panel33_Click(object sender, EventArgs e)
        {
            panel33.Visible = false;
        }
        private void panel34_Click(object sender, EventArgs e)
        {
            panel34.Visible = false;
        }
        private void panel35_Click(object sender, EventArgs e)
        {
            panel35.Visible = false;
        }
        private void panel36_Click(object sender, EventArgs e)
        {
            panel36.Visible = false;
        }
        private void panel37_Click(object sender, EventArgs e)
        {
            panel37.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void _1C1_Click(object sender, EventArgs e)
        {

        }

        private void _1C3_Click(object sender, EventArgs e)
        {

        }

        private void _1S1_Click(object sender, EventArgs e)
        {

        }

        private void _1T1_Click(object sender, EventArgs e)
        {

        }

        private void slCoDong_Click_1(object sender, EventArgs e)
        {

        }

       
    }
}
