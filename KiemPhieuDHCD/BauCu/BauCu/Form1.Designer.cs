namespace BauCu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.radQuanTri = new System.Windows.Forms.RadioButton();
            this.radKiemSoat = new System.Windows.Forms.RadioButton();
            this.dgvUngVien = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Name_UngVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkKhongHopLe = new System.Windows.Forms.CheckBox();
            this.txtTongSoPhieuBau = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTongSoCoPhan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoTenCD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSTTCD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLan = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvBauCu = new System.Windows.Forms.DataGridView();
            this.ID_BC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STTCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenUV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoPhieu_BC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtCDThamDu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCDBoPhieu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhieuHopLe = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhieuKhongHopLe = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCDKhongBoPhieu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCDKhongBoPhieu_CP = new System.Windows.Forms.TextBox();
            this.txtPhieuKhongHopLe_CP = new System.Windows.Forms.TextBox();
            this.txtPhieuHopLe_CP = new System.Windows.Forms.TextBox();
            this.txtCDBoPhieu_CP = new System.Windows.Forms.TextBox();
            this.txtCDThamDu_CP = new System.Windows.Forms.TextBox();
            this.dgvUngVien_KQ = new System.Windows.Forms.DataGridView();
            this.dgvKhongHopLe = new System.Windows.Forms.DataGridView();
            this.STTCD_KHL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoaKhongHopLe = new System.Windows.Forms.Button();
            this.ID_KQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_KQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoPhieu_KQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoPhan_KQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dat_KQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUngVien)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBauCu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUngVien_KQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhongHopLe)).BeginInit();
            this.SuspendLayout();
            // 
            // radQuanTri
            // 
            this.radQuanTri.AutoSize = true;
            this.radQuanTri.Location = new System.Drawing.Point(350, 12);
            this.radQuanTri.Name = "radQuanTri";
            this.radQuanTri.Size = new System.Drawing.Size(114, 17);
            this.radQuanTri.TabIndex = 0;
            this.radQuanTri.TabStop = true;
            this.radQuanTri.Text = "Hội Đồng Quản Trị";
            this.radQuanTri.UseVisualStyleBackColor = true;
            this.radQuanTri.CheckedChanged += new System.EventHandler(this.radQuanTri_CheckedChanged);
            // 
            // radKiemSoat
            // 
            this.radKiemSoat.AutoSize = true;
            this.radKiemSoat.Location = new System.Drawing.Point(350, 35);
            this.radKiemSoat.Name = "radKiemSoat";
            this.radKiemSoat.Size = new System.Drawing.Size(95, 17);
            this.radKiemSoat.TabIndex = 1;
            this.radKiemSoat.TabStop = true;
            this.radKiemSoat.Text = "Ban Kiểm Soát";
            this.radKiemSoat.UseVisualStyleBackColor = true;
            this.radKiemSoat.CheckedChanged += new System.EventHandler(this.radKiemSoat_CheckedChanged);
            // 
            // dgvUngVien
            // 
            this.dgvUngVien.AllowUserToAddRows = false;
            this.dgvUngVien.AllowUserToDeleteRows = false;
            this.dgvUngVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUngVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Chon,
            this.Name_UngVien,
            this.SoPhieu});
            this.dgvUngVien.Location = new System.Drawing.Point(350, 58);
            this.dgvUngVien.Name = "dgvUngVien";
            this.dgvUngVien.Size = new System.Drawing.Size(326, 100);
            this.dgvUngVien.TabIndex = 9;
            this.dgvUngVien.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUngVien_CellValueChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Chon
            // 
            this.Chon.HeaderText = "Chọn";
            this.Chon.Name = "Chon";
            this.Chon.Width = 50;
            // 
            // Name_UngVien
            // 
            this.Name_UngVien.DataPropertyName = "Name";
            this.Name_UngVien.HeaderText = "Ứng Viên";
            this.Name_UngVien.Name = "Name_UngVien";
            this.Name_UngVien.Width = 150;
            // 
            // SoPhieu
            // 
            this.SoPhieu.HeaderText = "Số Phiếu";
            this.SoPhieu.Name = "SoPhieu";
            this.SoPhieu.Width = 80;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkKhongHopLe);
            this.groupBox3.Controls.Add(this.txtTongSoPhieuBau);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtTongSoCoPhan);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtHoTenCD);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtSTTCD);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(332, 130);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Cổ Đông";
            // 
            // chkKhongHopLe
            // 
            this.chkKhongHopLe.AutoSize = true;
            this.chkKhongHopLe.Location = new System.Drawing.Point(227, 103);
            this.chkKhongHopLe.Name = "chkKhongHopLe";
            this.chkKhongHopLe.Size = new System.Drawing.Size(95, 17);
            this.chkKhongHopLe.TabIndex = 8;
            this.chkKhongHopLe.Text = "Không Hợp Lệ";
            this.chkKhongHopLe.UseVisualStyleBackColor = true;
            this.chkKhongHopLe.CheckedChanged += new System.EventHandler(this.chkKhongHopLe_CheckedChanged);
            // 
            // txtTongSoPhieuBau
            // 
            this.txtTongSoPhieuBau.Location = new System.Drawing.Point(121, 100);
            this.txtTongSoPhieuBau.Name = "txtTongSoPhieuBau";
            this.txtTongSoPhieuBau.Size = new System.Drawing.Size(100, 20);
            this.txtTongSoPhieuBau.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tổng Số Phiếu Bầu:";
            // 
            // txtTongSoCoPhan
            // 
            this.txtTongSoCoPhan.Location = new System.Drawing.Point(121, 74);
            this.txtTongSoCoPhan.Name = "txtTongSoCoPhan";
            this.txtTongSoCoPhan.Size = new System.Drawing.Size(100, 20);
            this.txtTongSoCoPhan.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng Số Cổ Phần:";
            // 
            // txtHoTenCD
            // 
            this.txtHoTenCD.Location = new System.Drawing.Point(121, 48);
            this.txtHoTenCD.Name = "txtHoTenCD";
            this.txtHoTenCD.Size = new System.Drawing.Size(200, 20);
            this.txtHoTenCD.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ Tên Cổ Đông:";
            // 
            // txtSTTCD
            // 
            this.txtSTTCD.Location = new System.Drawing.Point(121, 22);
            this.txtSTTCD.Name = "txtSTTCD";
            this.txtSTTCD.Size = new System.Drawing.Size(100, 20);
            this.txtSTTCD.TabIndex = 1;
            this.txtSTTCD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSTTCD_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "STT Cổ Đông:";
            // 
            // cmbLan
            // 
            this.cmbLan.FormattingEnabled = true;
            this.cmbLan.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbLan.Location = new System.Drawing.Point(639, 8);
            this.cmbLan.Name = "cmbLan";
            this.cmbLan.Size = new System.Drawing.Size(50, 21);
            this.cmbLan.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(559, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Lần Bỏ Phiếu:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(350, 164);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvBauCu
            // 
            this.dgvBauCu.AllowUserToAddRows = false;
            this.dgvBauCu.AllowUserToDeleteRows = false;
            this.dgvBauCu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBauCu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_BC,
            this.STTCD,
            this.TenCD,
            this.TenUV,
            this.SoPhieu_BC});
            this.dgvBauCu.Location = new System.Drawing.Point(350, 193);
            this.dgvBauCu.Name = "dgvBauCu";
            this.dgvBauCu.Size = new System.Drawing.Size(493, 504);
            this.dgvBauCu.TabIndex = 14;
            // 
            // ID_BC
            // 
            this.ID_BC.DataPropertyName = "ID";
            this.ID_BC.HeaderText = "ID";
            this.ID_BC.Name = "ID_BC";
            this.ID_BC.Visible = false;
            // 
            // STTCD
            // 
            this.STTCD.DataPropertyName = "STTCD";
            this.STTCD.HeaderText = "STTCD";
            this.STTCD.Name = "STTCD";
            this.STTCD.Width = 50;
            // 
            // TenCD
            // 
            this.TenCD.DataPropertyName = "TenCD";
            this.TenCD.HeaderText = "Người Bầu";
            this.TenCD.Name = "TenCD";
            this.TenCD.Width = 150;
            // 
            // TenUV
            // 
            this.TenUV.DataPropertyName = "TenUV";
            this.TenUV.HeaderText = "Ứng Viên";
            this.TenUV.Name = "TenUV";
            this.TenUV.Width = 150;
            // 
            // SoPhieu_BC
            // 
            this.SoPhieu_BC.DataPropertyName = "SoPhieu";
            this.SoPhieu_BC.HeaderText = "Số Phiếu";
            this.SoPhieu_BC.Name = "SoPhieu_BC";
            this.SoPhieu_BC.Width = 80;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(768, 164);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtCDThamDu
            // 
            this.txtCDThamDu.Location = new System.Drawing.Point(169, 166);
            this.txtCDThamDu.Name = "txtCDThamDu";
            this.txtCDThamDu.Size = new System.Drawing.Size(50, 20);
            this.txtCDThamDu.TabIndex = 17;
            this.txtCDThamDu.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tổng Số CĐ Tham Dự:";
            // 
            // txtCDBoPhieu
            // 
            this.txtCDBoPhieu.Location = new System.Drawing.Point(169, 192);
            this.txtCDBoPhieu.Name = "txtCDBoPhieu";
            this.txtCDBoPhieu.Size = new System.Drawing.Size(50, 20);
            this.txtCDBoPhieu.TabIndex = 19;
            this.txtCDBoPhieu.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tổng Số CĐ Bỏ Phiếu:";
            // 
            // txtPhieuHopLe
            // 
            this.txtPhieuHopLe.Location = new System.Drawing.Point(169, 218);
            this.txtPhieuHopLe.Name = "txtPhieuHopLe";
            this.txtPhieuHopLe.Size = new System.Drawing.Size(50, 20);
            this.txtPhieuHopLe.TabIndex = 21;
            this.txtPhieuHopLe.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Tổng Số Phiếu Hợp Lệ:";
            // 
            // txtPhieuKhongHopLe
            // 
            this.txtPhieuKhongHopLe.Location = new System.Drawing.Point(169, 244);
            this.txtPhieuKhongHopLe.Name = "txtPhieuKhongHopLe";
            this.txtPhieuKhongHopLe.Size = new System.Drawing.Size(50, 20);
            this.txtPhieuKhongHopLe.TabIndex = 23;
            this.txtPhieuKhongHopLe.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Tổng Số Phiếu Không Hợp Lệ:";
            // 
            // txtCDKhongBoPhieu
            // 
            this.txtCDKhongBoPhieu.Location = new System.Drawing.Point(169, 270);
            this.txtCDKhongBoPhieu.Name = "txtCDKhongBoPhieu";
            this.txtCDKhongBoPhieu.Size = new System.Drawing.Size(50, 20);
            this.txtCDKhongBoPhieu.TabIndex = 25;
            this.txtCDKhongBoPhieu.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Tổng Số CĐ Không Bỏ Phiếu:";
            // 
            // txtCDKhongBoPhieu_CP
            // 
            this.txtCDKhongBoPhieu_CP.Location = new System.Drawing.Point(225, 270);
            this.txtCDKhongBoPhieu_CP.Name = "txtCDKhongBoPhieu_CP";
            this.txtCDKhongBoPhieu_CP.Size = new System.Drawing.Size(108, 20);
            this.txtCDKhongBoPhieu_CP.TabIndex = 30;
            this.txtCDKhongBoPhieu_CP.Text = "0";
            // 
            // txtPhieuKhongHopLe_CP
            // 
            this.txtPhieuKhongHopLe_CP.Location = new System.Drawing.Point(225, 244);
            this.txtPhieuKhongHopLe_CP.Name = "txtPhieuKhongHopLe_CP";
            this.txtPhieuKhongHopLe_CP.Size = new System.Drawing.Size(108, 20);
            this.txtPhieuKhongHopLe_CP.TabIndex = 29;
            this.txtPhieuKhongHopLe_CP.Text = "0";
            // 
            // txtPhieuHopLe_CP
            // 
            this.txtPhieuHopLe_CP.Location = new System.Drawing.Point(225, 218);
            this.txtPhieuHopLe_CP.Name = "txtPhieuHopLe_CP";
            this.txtPhieuHopLe_CP.Size = new System.Drawing.Size(108, 20);
            this.txtPhieuHopLe_CP.TabIndex = 28;
            this.txtPhieuHopLe_CP.Text = "0";
            // 
            // txtCDBoPhieu_CP
            // 
            this.txtCDBoPhieu_CP.Location = new System.Drawing.Point(225, 192);
            this.txtCDBoPhieu_CP.Name = "txtCDBoPhieu_CP";
            this.txtCDBoPhieu_CP.Size = new System.Drawing.Size(108, 20);
            this.txtCDBoPhieu_CP.TabIndex = 27;
            this.txtCDBoPhieu_CP.Text = "0";
            // 
            // txtCDThamDu_CP
            // 
            this.txtCDThamDu_CP.Location = new System.Drawing.Point(225, 166);
            this.txtCDThamDu_CP.Name = "txtCDThamDu_CP";
            this.txtCDThamDu_CP.Size = new System.Drawing.Size(108, 20);
            this.txtCDThamDu_CP.TabIndex = 26;
            this.txtCDThamDu_CP.Text = "0";
            // 
            // dgvUngVien_KQ
            // 
            this.dgvUngVien_KQ.AllowUserToAddRows = false;
            this.dgvUngVien_KQ.AllowUserToDeleteRows = false;
            this.dgvUngVien_KQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUngVien_KQ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_KQ,
            this.Name_KQ,
            this.SoPhieu_KQ,
            this.CoPhan_KQ,
            this.Dat_KQ});
            this.dgvUngVien_KQ.Location = new System.Drawing.Point(682, 58);
            this.dgvUngVien_KQ.Name = "dgvUngVien_KQ";
            this.dgvUngVien_KQ.Size = new System.Drawing.Size(437, 100);
            this.dgvUngVien_KQ.TabIndex = 31;
            this.dgvUngVien_KQ.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvUngVien_KQ_CellFormatting);
            // 
            // dgvKhongHopLe
            // 
            this.dgvKhongHopLe.AllowUserToAddRows = false;
            this.dgvKhongHopLe.AllowUserToDeleteRows = false;
            this.dgvKhongHopLe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhongHopLe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STTCD_KHL,
            this.LoaiBC,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.dgvKhongHopLe.Location = new System.Drawing.Point(849, 193);
            this.dgvKhongHopLe.Name = "dgvKhongHopLe";
            this.dgvKhongHopLe.Size = new System.Drawing.Size(339, 504);
            this.dgvKhongHopLe.TabIndex = 32;
            // 
            // STTCD_KHL
            // 
            this.STTCD_KHL.DataPropertyName = "STTCD";
            this.STTCD_KHL.HeaderText = "STTCD";
            this.STTCD_KHL.Name = "STTCD_KHL";
            this.STTCD_KHL.Width = 50;
            // 
            // LoaiBC
            // 
            this.LoaiBC.DataPropertyName = "LoaiBC";
            this.LoaiBC.HeaderText = "LoaiBC";
            this.LoaiBC.Name = "LoaiBC";
            this.LoaiBC.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TenCD";
            this.dataGridViewTextBoxColumn3.HeaderText = "Người Bầu";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SoPhieu";
            this.dataGridViewTextBoxColumn5.HeaderText = "Số Phiếu";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // btnXoaKhongHopLe
            // 
            this.btnXoaKhongHopLe.Location = new System.Drawing.Point(1113, 164);
            this.btnXoaKhongHopLe.Name = "btnXoaKhongHopLe";
            this.btnXoaKhongHopLe.Size = new System.Drawing.Size(75, 23);
            this.btnXoaKhongHopLe.TabIndex = 33;
            this.btnXoaKhongHopLe.Text = "Xóa";
            this.btnXoaKhongHopLe.UseVisualStyleBackColor = true;
            this.btnXoaKhongHopLe.Click += new System.EventHandler(this.btnXoaKhongHopLe_Click);
            // 
            // ID_KQ
            // 
            this.ID_KQ.DataPropertyName = "ID";
            this.ID_KQ.HeaderText = "ID";
            this.ID_KQ.Name = "ID_KQ";
            this.ID_KQ.Visible = false;
            // 
            // Name_KQ
            // 
            this.Name_KQ.DataPropertyName = "Name";
            this.Name_KQ.HeaderText = "Ứng Viên";
            this.Name_KQ.Name = "Name_KQ";
            this.Name_KQ.Width = 150;
            // 
            // SoPhieu_KQ
            // 
            this.SoPhieu_KQ.DataPropertyName = "SoPhieu";
            this.SoPhieu_KQ.HeaderText = "Số Phiếu Đồng Ý";
            this.SoPhieu_KQ.Name = "SoPhieu_KQ";
            this.SoPhieu_KQ.Width = 80;
            // 
            // CoPhan_KQ
            // 
            this.CoPhan_KQ.DataPropertyName = "CoPhan";
            this.CoPhan_KQ.HeaderText = "Cổ Phần";
            this.CoPhan_KQ.Name = "CoPhan_KQ";
            this.CoPhan_KQ.Width = 80;
            // 
            // Dat_KQ
            // 
            this.Dat_KQ.DataPropertyName = "Dat";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.Dat_KQ.DefaultCellStyle = dataGridViewCellStyle1;
            this.Dat_KQ.HeaderText = "Đạt";
            this.Dat_KQ.Name = "Dat_KQ";
            this.Dat_KQ.Width = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 707);
            this.Controls.Add(this.btnXoaKhongHopLe);
            this.Controls.Add(this.dgvKhongHopLe);
            this.Controls.Add(this.dgvUngVien_KQ);
            this.Controls.Add(this.txtCDKhongBoPhieu_CP);
            this.Controls.Add(this.txtPhieuKhongHopLe_CP);
            this.Controls.Add(this.txtPhieuHopLe_CP);
            this.Controls.Add(this.txtCDBoPhieu_CP);
            this.Controls.Add(this.txtCDThamDu_CP);
            this.Controls.Add(this.txtCDKhongBoPhieu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPhieuKhongHopLe);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPhieuHopLe);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCDBoPhieu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCDThamDu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dgvBauCu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbLan);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvUngVien);
            this.Controls.Add(this.radKiemSoat);
            this.Controls.Add(this.radQuanTri);
            this.Name = "Form1";
            this.Text = "Phần mềm Bầu Cử";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUngVien)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBauCu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUngVien_KQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhongHopLe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radQuanTri;
        private System.Windows.Forms.RadioButton radKiemSoat;
        private System.Windows.Forms.DataGridView dgvUngVien;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTongSoPhieuBau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTongSoCoPhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoTenCD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSTTCD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvBauCu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtCDThamDu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_BC;
        private System.Windows.Forms.DataGridViewTextBoxColumn STTCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenUV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhieu_BC;
        private System.Windows.Forms.TextBox txtCDBoPhieu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhieuHopLe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPhieuKhongHopLe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCDKhongBoPhieu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkKhongHopLe;
        private System.Windows.Forms.TextBox txtCDKhongBoPhieu_CP;
        private System.Windows.Forms.TextBox txtPhieuKhongHopLe_CP;
        private System.Windows.Forms.TextBox txtPhieuHopLe_CP;
        private System.Windows.Forms.TextBox txtCDBoPhieu_CP;
        private System.Windows.Forms.TextBox txtCDThamDu_CP;
        private System.Windows.Forms.DataGridView dgvUngVien_KQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_UngVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhieu;
        private System.Windows.Forms.DataGridView dgvKhongHopLe;
        private System.Windows.Forms.Button btnXoaKhongHopLe;
        private System.Windows.Forms.DataGridViewTextBoxColumn STTCD_KHL;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_KQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_KQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhieu_KQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoPhan_KQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dat_KQ;
    }
}

