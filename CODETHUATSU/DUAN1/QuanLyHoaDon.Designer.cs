
namespace DUAN1
{
    partial class QuanLyHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyHoaDon));
            this.lbhansudung = new System.Windows.Forms.Label();
            this.lbngaysx = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ma_hd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_kh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_nv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay_lap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trang_thai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbmahanghoa = new System.Windows.Forms.Label();
            this.tbmahoadon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpngaylap = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tbtrangthai = new System.Windows.Forms.TextBox();
            this.btninhoadon = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.tbtimkiem = new System.Windows.Forms.TextBox();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.cbbmakhachhang = new System.Windows.Forms.ComboBox();
            this.cbbmanv = new System.Windows.Forms.ComboBox();
            this.dtgv2 = new System.Windows.Forms.DataGridView();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuetMaQR = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmbTrangThai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbtongtien = new System.Windows.Forms.Label();
            this.tbtongtien = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbhansudung
            // 
            this.lbhansudung.AutoSize = true;
            this.lbhansudung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbhansudung.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbhansudung.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhansudung.ForeColor = System.Drawing.SystemColors.Control;
            this.lbhansudung.Location = new System.Drawing.Point(177, 193);
            this.lbhansudung.Name = "lbhansudung";
            this.lbhansudung.Size = new System.Drawing.Size(212, 29);
            this.lbhansudung.TabIndex = 117;
            this.lbhansudung.Text = "Tên khách hàng :";
            // 
            // lbngaysx
            // 
            this.lbngaysx.AutoSize = true;
            this.lbngaysx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbngaysx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbngaysx.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbngaysx.ForeColor = System.Drawing.SystemColors.Control;
            this.lbngaysx.Location = new System.Drawing.Point(177, 251);
            this.lbngaysx.Name = "lbngaysx";
            this.lbngaysx.Size = new System.Drawing.Size(130, 29);
            this.lbngaysx.TabIndex = 116;
            this.lbngaysx.Text = "Ngày lập :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_hd,
            this.ma_kh,
            this.ma_nv,
            this.ngay_lap,
            this.trang_thai,
            this.tongtien});
            this.dataGridView1.Location = new System.Drawing.Point(12, 461);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1715, 467);
            this.dataGridView1.TabIndex = 106;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ma_hd
            // 
            this.ma_hd.HeaderText = "Mã hóa đơn";
            this.ma_hd.MinimumWidth = 6;
            this.ma_hd.Name = "ma_hd";
            this.ma_hd.ReadOnly = true;
            // 
            // ma_kh
            // 
            this.ma_kh.HeaderText = "Tên khách hàng";
            this.ma_kh.MinimumWidth = 6;
            this.ma_kh.Name = "ma_kh";
            this.ma_kh.ReadOnly = true;
            // 
            // ma_nv
            // 
            this.ma_nv.HeaderText = "Tên nhân viên";
            this.ma_nv.MinimumWidth = 6;
            this.ma_nv.Name = "ma_nv";
            this.ma_nv.ReadOnly = true;
            // 
            // ngay_lap
            // 
            this.ngay_lap.HeaderText = "Ngày lập";
            this.ngay_lap.MinimumWidth = 6;
            this.ngay_lap.Name = "ngay_lap";
            this.ngay_lap.ReadOnly = true;
            // 
            // trang_thai
            // 
            this.trang_thai.HeaderText = "Trạng thái";
            this.trang_thai.MinimumWidth = 6;
            this.trang_thai.Name = "trang_thai";
            this.trang_thai.ReadOnly = true;
            // 
            // tongtien
            // 
            this.tongtien.HeaderText = "Tổng tiền";
            this.tongtien.Name = "tongtien";
            this.tongtien.ReadOnly = true;
            // 
            // lbmahanghoa
            // 
            this.lbmahanghoa.AutoSize = true;
            this.lbmahanghoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbmahanghoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbmahanghoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmahanghoa.ForeColor = System.Drawing.SystemColors.Control;
            this.lbmahanghoa.Location = new System.Drawing.Point(177, 77);
            this.lbmahanghoa.Name = "lbmahanghoa";
            this.lbmahanghoa.Size = new System.Drawing.Size(163, 29);
            this.lbmahanghoa.TabIndex = 105;
            this.lbmahanghoa.Text = "Mã hóa đơn :";
            // 
            // tbmahoadon
            // 
            this.tbmahoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmahoadon.Location = new System.Drawing.Point(516, 78);
            this.tbmahoadon.Multiline = true;
            this.tbmahoadon.Name = "tbmahoadon";
            this.tbmahoadon.Size = new System.Drawing.Size(381, 28);
            this.tbmahoadon.TabIndex = 104;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(177, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 29);
            this.label3.TabIndex = 123;
            this.label3.Text = "Tên nhân viên :";
            // 
            // dtpngaylap
            // 
            this.dtpngaylap.CustomFormat = "dd/MM/yyyy";
            this.dtpngaylap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpngaylap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpngaylap.Location = new System.Drawing.Point(516, 251);
            this.dtpngaylap.Name = "dtpngaylap";
            this.dtpngaylap.Size = new System.Drawing.Size(381, 29);
            this.dtpngaylap.TabIndex = 127;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(177, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 29);
            this.label5.TabIndex = 131;
            this.label5.Text = "Trạng thái :";
            // 
            // tbtrangthai
            // 
            this.tbtrangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtrangthai.Location = new System.Drawing.Point(516, 313);
            this.tbtrangthai.Multiline = true;
            this.tbtrangthai.Name = "tbtrangthai";
            this.tbtrangthai.Size = new System.Drawing.Size(381, 28);
            this.tbtrangthai.TabIndex = 130;
            // 
            // btninhoadon
            // 
            this.btninhoadon.BackColor = System.Drawing.SystemColors.Info;
            this.btninhoadon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btninhoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninhoadon.Location = new System.Drawing.Point(1203, 336);
            this.btninhoadon.Name = "btninhoadon";
            this.btninhoadon.Size = new System.Drawing.Size(348, 52);
            this.btninhoadon.TabIndex = 132;
            this.btninhoadon.Text = "In ra hóa đơn";
            this.btninhoadon.UseVisualStyleBackColor = false;
            this.btninhoadon.Click += new System.EventHandler(this.btninhoadon_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnhuy.FlatAppearance.BorderSize = 0;
            this.btnhuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnhuy.Image = ((System.Drawing.Image)(resources.GetObject("btnhuy.Image")));
            this.btnhuy.Location = new System.Drawing.Point(877, 401);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(120, 52);
            this.btnhuy.TabIndex = 139;
            this.toolTip1.SetToolTip(this.btnhuy, "Hủy");
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnxoa.FlatAppearance.BorderSize = 0;
            this.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.Location = new System.Drawing.Point(751, 401);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(120, 52);
            this.btnxoa.TabIndex = 138;
            this.toolTip1.SetToolTip(this.btnxoa, "Xóa");
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnsua.FlatAppearance.BorderSize = 0;
            this.btnsua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsua.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.Image")));
            this.btnsua.Location = new System.Drawing.Point(625, 401);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(120, 52);
            this.btnsua.TabIndex = 137;
            this.toolTip1.SetToolTip(this.btnsua, "Sửa");
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btntimkiem.FlatAppearance.BorderSize = 0;
            this.btntimkiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btntimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btntimkiem.Image")));
            this.btntimkiem.Location = new System.Drawing.Point(1431, 394);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(120, 52);
            this.btntimkiem.TabIndex = 136;
            this.toolTip1.SetToolTip(this.btntimkiem, "Tìm kiếm");
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // tbtimkiem
            // 
            this.tbtimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtimkiem.Location = new System.Drawing.Point(1203, 394);
            this.tbtimkiem.Multiline = true;
            this.tbtimkiem.Name = "tbtimkiem";
            this.tbtimkiem.Size = new System.Drawing.Size(348, 52);
            this.tbtimkiem.TabIndex = 135;
            // 
            // btnluu
            // 
            this.btnluu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnluu.FlatAppearance.BorderSize = 0;
            this.btnluu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnluu.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.Image")));
            this.btnluu.Location = new System.Drawing.Point(499, 401);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(120, 52);
            this.btnluu.TabIndex = 134;
            this.toolTip1.SetToolTip(this.btnluu, "Lưu");
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnthem.FlatAppearance.BorderSize = 0;
            this.btnthem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnthem.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.Image")));
            this.btnthem.Location = new System.Drawing.Point(373, 401);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(120, 52);
            this.btnthem.TabIndex = 133;
            this.toolTip1.SetToolTip(this.btnthem, "Thêm");
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // cbbmakhachhang
            // 
            this.cbbmakhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbmakhachhang.FormattingEnabled = true;
            this.cbbmakhachhang.Location = new System.Drawing.Point(516, 197);
            this.cbbmakhachhang.Name = "cbbmakhachhang";
            this.cbbmakhachhang.Size = new System.Drawing.Size(381, 28);
            this.cbbmakhachhang.TabIndex = 145;
            // 
            // cbbmanv
            // 
            this.cbbmanv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbmanv.FormattingEnabled = true;
            this.cbbmanv.Location = new System.Drawing.Point(516, 137);
            this.cbbmanv.Name = "cbbmanv";
            this.cbbmanv.Size = new System.Drawing.Size(381, 28);
            this.cbbmanv.TabIndex = 146;
            // 
            // dtgv2
            // 
            this.dtgv2.AllowUserToAddRows = false;
            this.dtgv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ten,
            this.Gia,
            this.SL});
            this.dtgv2.Location = new System.Drawing.Point(1203, 77);
            this.dtgv2.Margin = new System.Windows.Forms.Padding(2);
            this.dtgv2.Name = "dtgv2";
            this.dtgv2.RowHeadersWidth = 51;
            this.dtgv2.RowTemplate.Height = 24;
            this.dtgv2.Size = new System.Drawing.Size(347, 253);
            this.dtgv2.TabIndex = 250;
            // 
            // Ten
            // 
            this.Ten.HeaderText = "Tên";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            // 
            // Gia
            // 
            this.Gia.HeaderText = "Giá";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            // 
            // SL
            // 
            this.SL.HeaderText = "Số lượng";
            this.SL.MinimumWidth = 6;
            this.SL.Name = "SL";
            this.SL.ReadOnly = true;
            // 
            // QuetMaQR
            // 
            this.QuetMaQR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.QuetMaQR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuetMaQR.FlatAppearance.BorderSize = 0;
            this.QuetMaQR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.QuetMaQR.Location = new System.Drawing.Point(1009, 301);
            this.QuetMaQR.Name = "QuetMaQR";
            this.QuetMaQR.Size = new System.Drawing.Size(136, 64);
            this.QuetMaQR.TabIndex = 251;
            this.QuetMaQR.Text = "Quét QR";
            this.QuetMaQR.UseVisualStyleBackColor = true;
            this.QuetMaQR.Click += new System.EventHandler(this.QuetMaQR_Click);
            // 
            // cmbTrangThai
            // 
            this.cmbTrangThai.FormattingEnabled = true;
            this.cmbTrangThai.Location = new System.Drawing.Point(1029, 192);
            this.cmbTrangThai.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTrangThai.Name = "cmbTrangThai";
            this.cmbTrangThai.Size = new System.Drawing.Size(92, 21);
            this.cmbTrangThai.TabIndex = 321;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(713, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.MaximumSize = new System.Drawing.Size(1090, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 49);
            this.label1.TabIndex = 333;
            this.label1.Text = "QUẢN LÝ HÓA ĐƠN";
            // 
            // lbtongtien
            // 
            this.lbtongtien.AutoSize = true;
            this.lbtongtien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbtongtien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbtongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtongtien.ForeColor = System.Drawing.SystemColors.Control;
            this.lbtongtien.Location = new System.Drawing.Point(177, 351);
            this.lbtongtien.Name = "lbtongtien";
            this.lbtongtien.Size = new System.Drawing.Size(138, 29);
            this.lbtongtien.TabIndex = 335;
            this.lbtongtien.Text = "Tổng tiền :";
            // 
            // tbtongtien
            // 
            this.tbtongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtongtien.Location = new System.Drawing.Point(516, 360);
            this.tbtongtien.Multiline = true;
            this.tbtongtien.Name = "tbtongtien";
            this.tbtongtien.Size = new System.Drawing.Size(381, 28);
            this.tbtongtien.TabIndex = 334;
            // 
            // QuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1739, 940);
            this.Controls.Add(this.lbtongtien);
            this.Controls.Add(this.tbtongtien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTrangThai);
            this.Controls.Add(this.QuetMaQR);
            this.Controls.Add(this.dtgv2);
            this.Controls.Add(this.cbbmanv);
            this.Controls.Add(this.cbbmakhachhang);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.tbtimkiem);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btninhoadon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbtrangthai);
            this.Controls.Add(this.dtpngaylap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbhansudung);
            this.Controls.Add(this.lbngaysx);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbmahanghoa);
            this.Controls.Add(this.tbmahoadon);
            this.DoubleBuffered = true;
            this.Location = new System.Drawing.Point(175, 65);
            this.Name = "QuanLyHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "QuanLyHoaDon";
            this.Load += new System.EventHandler(this.QuanLyHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbhansudung;
        private System.Windows.Forms.Label lbngaysx;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbmahanghoa;
        private System.Windows.Forms.TextBox tbmahoadon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpngaylap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbtrangthai;
        private System.Windows.Forms.Button btninhoadon;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox tbtimkiem;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.ComboBox cbbmakhachhang;
        private System.Windows.Forms.ComboBox cbbmanv;
        private System.Windows.Forms.DataGridView dtgv2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.Button QuetMaQR;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cmbTrangThai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_hd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_kh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_nv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay_lap;
        private System.Windows.Forms.DataGridViewTextBoxColumn trang_thai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
        private System.Windows.Forms.Label lbtongtien;
        private System.Windows.Forms.TextBox tbtongtien;
    }
}