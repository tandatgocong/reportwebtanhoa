namespace KETQUa
{
    partial class Form1
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox1.Image = global::KETQUa.Properties.Resources.thamdu;
            this.pictureBox1.Location = new System.Drawing.Point(162, 451);
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
            this.lbSL.Font = new System.Drawing.Font("Times New Roman", 27F, System.Drawing.FontStyle.Bold);
            this.lbSL.ForeColor = System.Drawing.Color.Red;
            this.lbSL.Location = new System.Drawing.Point(427, 508);
            this.lbSL.Name = "lbSL";
            this.lbSL.Size = new System.Drawing.Size(216, 41);
            this.lbSL.TabIndex = 1;
            this.lbSL.Text = "00000000000";
            this.lbSL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCP
            // 
            this.lbCP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCP.AutoSize = true;
            this.lbCP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbCP.Font = new System.Drawing.Font("Times New Roman", 27F, System.Drawing.FontStyle.Bold);
            this.lbCP.ForeColor = System.Drawing.Color.Red;
            this.lbCP.Location = new System.Drawing.Point(427, 556);
            this.lbCP.Name = "lbCP";
            this.lbCP.Size = new System.Drawing.Size(216, 41);
            this.lbCP.TabIndex = 2;
            this.lbCP.Text = "00000000000";
            this.lbCP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTL
            // 
            this.lbTL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTL.AutoSize = true;
            this.lbTL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbTL.Font = new System.Drawing.Font("Times New Roman", 27F, System.Drawing.FontStyle.Bold);
            this.lbTL.ForeColor = System.Drawing.Color.Red;
            this.lbTL.Location = new System.Drawing.Point(427, 604);
            this.lbTL.Name = "lbTL";
            this.lbTL.Size = new System.Drawing.Size(216, 41);
            this.lbTL.TabIndex = 3;
            this.lbTL.Text = "00000000000";
            this.lbTL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::KETQUa.Properties.Resources.Untitled;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(683, 656);
            this.ControlBox = false;
            this.Controls.Add(this.lbTL);
            this.Controls.Add(this.lbCP);
            this.Controls.Add(this.lbSL);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
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


    }
}

