﻿namespace BauCu
{
    partial class CDThamDu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbSL = new System.Windows.Forms.Label();
            this.lbCP = new System.Windows.Forms.Label();
            this.lbTL = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox1.Image = global::BauCu.Properties.Resources.thamdu;
            this.pictureBox1.Location = new System.Drawing.Point(145, 452);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(515, 202);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbSL
            // 
            this.lbSL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSL.AutoSize = true;
            this.lbSL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbSL.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold);
            this.lbSL.ForeColor = System.Drawing.Color.Red;
            this.lbSL.Location = new System.Drawing.Point(401, 504);
            this.lbSL.Name = "lbSL";
            this.lbSL.Size = new System.Drawing.Size(240, 45);
            this.lbSL.TabIndex = 1;
            this.lbSL.Text = "00000000000";
            this.lbSL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCP
            // 
            this.lbCP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCP.AutoSize = true;
            this.lbCP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbCP.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold);
            this.lbCP.ForeColor = System.Drawing.Color.Red;
            this.lbCP.Location = new System.Drawing.Point(401, 555);
            this.lbCP.Name = "lbCP";
            this.lbCP.Size = new System.Drawing.Size(240, 45);
            this.lbCP.TabIndex = 2;
            this.lbCP.Text = "00000000000";
            this.lbCP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTL
            // 
            this.lbTL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTL.AutoSize = true;
            this.lbTL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbTL.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold);
            this.lbTL.ForeColor = System.Drawing.Color.Red;
            this.lbTL.Location = new System.Drawing.Point(401, 602);
            this.lbTL.Name = "lbTL";
            this.lbTL.Size = new System.Drawing.Size(240, 45);
            this.lbTL.TabIndex = 3;
            this.lbTL.Text = "00000000000";
            this.lbTL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exit.Image = global::BauCu.Properties.Resources.Cancel;
            this.exit.Location = new System.Drawing.Point(-2, 633);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(27, 23);
            this.exit.TabIndex = 4;
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(21, 633);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "KP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CDThamDu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::BauCu.Properties.Resources._CB6B79F2F54793C667A2ADC36CD7097486B08FAE353A205052_pimgpsh_fullsize_distr;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(683, 656);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.lbTL);
            this.Controls.Add(this.lbCP);
            this.Controls.Add(this.lbSL);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CDThamDu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbSL;
        private System.Windows.Forms.Label lbCP;
        private System.Windows.Forms.Label lbTL;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button button1;


    }
}

