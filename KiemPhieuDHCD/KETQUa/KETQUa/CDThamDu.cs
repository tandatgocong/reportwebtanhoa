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
    public partial class CDThamDu : Form
    {
        int _ticks = 0;
        public CDThamDu()
        {
            InitializeComponent();
            FormLoad();
            timer1.Start();
        }
        public void FormLoad()
        {
            lbSL.Text = LinQConnection.ReturnResult("SELECT COUNT(TONGCD) FROM DSCODONG_THAMDU")+"";

            double _cpTC = LinQConnection.ReturnResult("SELECT SUM(TONGCD) FROM DSCODONG_THAMDU");
            lbCP.Text = String.Format("{0:0,0}", _cpTC);

            double tl = _cpTC / LinQConnection.ReturnResult("SELECT SUM(TONGCD) FROM DSCODONG");
            lbTL.Text = String.Format("{0:0.##}", tl * 100) + "%";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;
            if (_ticks % 10 == 0)
                FormLoad();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
