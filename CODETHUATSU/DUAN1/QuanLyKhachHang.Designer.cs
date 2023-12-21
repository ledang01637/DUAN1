
namespace DUAN1
{
    partial class QuanLyKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyKhachHang));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ma_kh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_kh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbsdt = new System.Windows.Forms.Label();
            this.tbsdt = new System.Windows.Forms.TextBox();
            this.lbtenkhachhang = new System.Windows.Forms.Label();
            this.tbtenkhachhang = new System.Windows.Forms.TextBox();
            this.lbmakhachhang = new System.Windows.Forms.Label();
            this.tbmakhachhang = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.tbtimkiem = new System.Windows.Forms.TextBox();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnthongtinnv = new System.Windows.Forms.Button();
            this.qlkh = new System.Windows.Forms.Button();
            this.btnChiTietHoaDon = new System.Windows.Forms.Button();
            this.btnthongke = new System.Windows.Forms.Button();
            this.btnkhachhang = new System.Windows.Forms.Button();
            this.btnnhanvien = new System.Windows.Forms.Button();
            this.btnkhohang = new System.Windows.Forms.Button();
            this.btnhanghoa = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnhoadon = new System.Windows.Forms.Button();
            this.tbusername = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_kh,
            this.ten_kh,
            this.sdt});
            this.dataGridView1.Location = new System.Drawing.Point(253, 718);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1649, 329);
            this.dataGridView1.TabIndex = 132;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ma_kh
            // 
            this.ma_kh.HeaderText = "Mã KH";
            this.ma_kh.MinimumWidth = 6;
            this.ma_kh.Name = "ma_kh";
            this.ma_kh.ReadOnly = true;
            // 
            // ten_kh
            // 
            this.ten_kh.HeaderText = "Tên KH";
            this.ten_kh.MinimumWidth = 6;
            this.ten_kh.Name = "ten_kh";
            this.ten_kh.ReadOnly = true;
            // 
            // sdt
            // 
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.MinimumWidth = 8;
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            // 
            // lbsdt
            // 
            this.lbsdt.AutoSize = true;
            this.lbsdt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbsdt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbsdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsdt.ForeColor = System.Drawing.SystemColors.Control;
            this.lbsdt.Location = new System.Drawing.Point(699, 438);
            this.lbsdt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbsdt.Name = "lbsdt";
            this.lbsdt.Size = new System.Drawing.Size(262, 40);
            this.lbsdt.TabIndex = 131;
            this.lbsdt.Text = "Số điện thoại :";
            // 
            // tbsdt
            // 
            this.tbsdt.Location = new System.Drawing.Point(1029, 438);
            this.tbsdt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbsdt.Multiline = true;
            this.tbsdt.Name = "tbsdt";
            this.tbsdt.Size = new System.Drawing.Size(511, 43);
            this.tbsdt.TabIndex = 130;
            // 
            // lbtenkhachhang
            // 
            this.lbtenkhachhang.AutoSize = true;
            this.lbtenkhachhang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbtenkhachhang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbtenkhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtenkhachhang.ForeColor = System.Drawing.SystemColors.Control;
            this.lbtenkhachhang.Location = new System.Drawing.Point(699, 349);
            this.lbtenkhachhang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtenkhachhang.Name = "lbtenkhachhang";
            this.lbtenkhachhang.Size = new System.Drawing.Size(311, 40);
            this.lbtenkhachhang.TabIndex = 129;
            this.lbtenkhachhang.Text = "Tên khách hàng :";
            // 
            // tbtenkhachhang
            // 
            this.tbtenkhachhang.Location = new System.Drawing.Point(1029, 349);
            this.tbtenkhachhang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbtenkhachhang.Multiline = true;
            this.tbtenkhachhang.Name = "tbtenkhachhang";
            this.tbtenkhachhang.Size = new System.Drawing.Size(511, 43);
            this.tbtenkhachhang.TabIndex = 128;
            // 
            // lbmakhachhang
            // 
            this.lbmakhachhang.AutoSize = true;
            this.lbmakhachhang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbmakhachhang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbmakhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmakhachhang.ForeColor = System.Drawing.SystemColors.Control;
            this.lbmakhachhang.Location = new System.Drawing.Point(699, 260);
            this.lbmakhachhang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbmakhachhang.Name = "lbmakhachhang";
            this.lbmakhachhang.Size = new System.Drawing.Size(298, 40);
            this.lbmakhachhang.TabIndex = 127;
            this.lbmakhachhang.Text = "Mã khách hàng :";
            // 
            // tbmakhachhang
            // 
            this.tbmakhachhang.Location = new System.Drawing.Point(1029, 260);
            this.tbmakhachhang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbmakhachhang.Multiline = true;
            this.tbmakhachhang.Name = "tbmakhachhang";
            this.tbmakhachhang.ReadOnly = true;
            this.tbmakhachhang.Size = new System.Drawing.Size(511, 43);
            this.tbmakhachhang.TabIndex = 126;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(253, 129);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1648, 916);
            this.pictureBox2.TabIndex = 117;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(303, 215);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(312, 302);
            this.pictureBox3.TabIndex = 159;
            this.pictureBox3.TabStop = false;
            // 
            // btnhuy
            // 
            this.btnhuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnhuy.FlatAppearance.BorderSize = 0;
            this.btnhuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnhuy.Image = ((System.Drawing.Image)(resources.GetObject("btnhuy.Image")));
            this.btnhuy.Location = new System.Drawing.Point(1044, 618);
            this.btnhuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(180, 80);
            this.btnhuy.TabIndex = 172;
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
            this.btnxoa.Location = new System.Drawing.Point(855, 618);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(180, 80);
            this.btnxoa.TabIndex = 171;
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
            this.btnsua.Location = new System.Drawing.Point(666, 618);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(180, 80);
            this.btnsua.TabIndex = 170;
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
            this.btntimkiem.Location = new System.Drawing.Point(1678, 616);
            this.btntimkiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(180, 80);
            this.btntimkiem.TabIndex = 169;
            this.toolTip1.SetToolTip(this.btntimkiem, "Tìm kiếm");
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // tbtimkiem
            // 
            this.tbtimkiem.Location = new System.Drawing.Point(1233, 618);
            this.tbtimkiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbtimkiem.Multiline = true;
            this.tbtimkiem.Name = "tbtimkiem";
            this.tbtimkiem.Size = new System.Drawing.Size(625, 78);
            this.tbtimkiem.TabIndex = 168;
            // 
            // btnluu
            // 
            this.btnluu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnluu.FlatAppearance.BorderSize = 0;
            this.btnluu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnluu.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.Image")));
            this.btnluu.Location = new System.Drawing.Point(477, 618);
            this.btnluu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(180, 80);
            this.btnluu.TabIndex = 167;
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
            this.btnthem.Location = new System.Drawing.Point(288, 618);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(180, 80);
            this.btnthem.TabIndex = 166;
            this.toolTip1.SetToolTip(this.btnthem, "Thêm");
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnthongtinnv
            // 
            this.btnthongtinnv.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnthongtinnv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnthongtinnv.BackgroundImage")));
            this.btnthongtinnv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnthongtinnv.FlatAppearance.BorderSize = 0;
            this.btnthongtinnv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthongtinnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthongtinnv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthongtinnv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthongtinnv.Location = new System.Drawing.Point(-4, 129);
            this.btnthongtinnv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnthongtinnv.Name = "btnthongtinnv";
            this.btnthongtinnv.Size = new System.Drawing.Size(258, 78);
            this.btnthongtinnv.TabIndex = 348;
            this.btnthongtinnv.Text = "Trang Chủ";
            this.toolTip1.SetToolTip(this.btnthongtinnv, "Thông tin nhân viên");
            this.btnthongtinnv.UseVisualStyleBackColor = false;
            this.btnthongtinnv.Click += new System.EventHandler(this.btnthongtinnv_Click);
            // 
            // qlkh
            // 
            this.qlkh.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.qlkh.Enabled = false;
            this.qlkh.FlatAppearance.BorderSize = 0;
            this.qlkh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.qlkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qlkh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.qlkh.Location = new System.Drawing.Point(253, -9);
            this.qlkh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.qlkh.Name = "qlkh";
            this.qlkh.Size = new System.Drawing.Size(1648, 140);
            this.qlkh.TabIndex = 356;
            this.qlkh.Text = "QUẢN LÝ KHÁCH HÀNG";
            this.qlkh.UseVisualStyleBackColor = false;
            this.qlkh.Click += new System.EventHandler(this.qlkh_Click);
            // 
            // btnChiTietHoaDon
            // 
            this.btnChiTietHoaDon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChiTietHoaDon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChiTietHoaDon.BackgroundImage")));
            this.btnChiTietHoaDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnChiTietHoaDon.FlatAppearance.BorderSize = 0;
            this.btnChiTietHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiTietHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTietHoaDon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChiTietHoaDon.Location = new System.Drawing.Point(-4, 474);
            this.btnChiTietHoaDon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChiTietHoaDon.Name = "btnChiTietHoaDon";
            this.btnChiTietHoaDon.Size = new System.Drawing.Size(258, 78);
            this.btnChiTietHoaDon.TabIndex = 354;
            this.btnChiTietHoaDon.Text = "Chi Tiết HD";
            this.btnChiTietHoaDon.UseVisualStyleBackColor = false;
            this.btnChiTietHoaDon.Click += new System.EventHandler(this.btnChiTietHoaDon_Click);
            // 
            // btnthongke
            // 
            this.btnthongke.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnthongke.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnthongke.BackgroundImage")));
            this.btnthongke.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnthongke.FlatAppearance.BorderSize = 0;
            this.btnthongke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthongke.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthongke.Location = new System.Drawing.Point(-4, 731);
            this.btnthongke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(258, 78);
            this.btnthongke.TabIndex = 353;
            this.btnthongke.Text = "Thống Kê";
            this.btnthongke.UseVisualStyleBackColor = false;
            this.btnthongke.Click += new System.EventHandler(this.btnthongke_Click);
            // 
            // btnkhachhang
            // 
            this.btnkhachhang.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnkhachhang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnkhachhang.BackgroundImage")));
            this.btnkhachhang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnkhachhang.FlatAppearance.BorderSize = 0;
            this.btnkhachhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkhachhang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnkhachhang.Location = new System.Drawing.Point(-4, 646);
            this.btnkhachhang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnkhachhang.Name = "btnkhachhang";
            this.btnkhachhang.Size = new System.Drawing.Size(258, 78);
            this.btnkhachhang.TabIndex = 352;
            this.btnkhachhang.Text = "Khách Hàng";
            this.btnkhachhang.UseVisualStyleBackColor = false;
            // 
            // btnnhanvien
            // 
            this.btnnhanvien.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnnhanvien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnnhanvien.BackgroundImage")));
            this.btnnhanvien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnnhanvien.FlatAppearance.BorderSize = 0;
            this.btnnhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnhanvien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnnhanvien.Location = new System.Drawing.Point(-4, 560);
            this.btnnhanvien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnnhanvien.Name = "btnnhanvien";
            this.btnnhanvien.Size = new System.Drawing.Size(258, 78);
            this.btnnhanvien.TabIndex = 351;
            this.btnnhanvien.Text = "Nhân Viên";
            this.btnnhanvien.UseVisualStyleBackColor = false;
            this.btnnhanvien.Click += new System.EventHandler(this.btnnhanvien_Click);
            // 
            // btnkhohang
            // 
            this.btnkhohang.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnkhohang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnkhohang.BackgroundImage")));
            this.btnkhohang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnkhohang.FlatAppearance.BorderSize = 0;
            this.btnkhohang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkhohang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkhohang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnkhohang.Location = new System.Drawing.Point(-4, 301);
            this.btnkhohang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnkhohang.Name = "btnkhohang";
            this.btnkhohang.Size = new System.Drawing.Size(258, 78);
            this.btnkhohang.TabIndex = 350;
            this.btnkhohang.Text = "Kho Hàng";
            this.btnkhohang.UseVisualStyleBackColor = false;
            this.btnkhohang.Click += new System.EventHandler(this.btnkhohang_Click);
            // 
            // btnhanghoa
            // 
            this.btnhanghoa.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnhanghoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnhanghoa.BackgroundImage")));
            this.btnhanghoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnhanghoa.FlatAppearance.BorderSize = 0;
            this.btnhanghoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhanghoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhanghoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnhanghoa.Location = new System.Drawing.Point(-4, 215);
            this.btnhanghoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnhanghoa.Name = "btnhanghoa";
            this.btnhanghoa.Size = new System.Drawing.Size(258, 78);
            this.btnhanghoa.TabIndex = 349;
            this.btnhanghoa.Text = "Hàng Hóa";
            this.btnhanghoa.UseVisualStyleBackColor = false;
            this.btnhanghoa.Click += new System.EventHandler(this.btnhanghoa_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnthoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnthoat.BackgroundImage")));
            this.btnthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnthoat.FlatAppearance.BorderSize = 0;
            this.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthoat.Location = new System.Drawing.Point(-4, 925);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(258, 108);
            this.btnthoat.TabIndex = 347;
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnhoadon
            // 
            this.btnhoadon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnhoadon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnhoadon.BackgroundImage")));
            this.btnhoadon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnhoadon.FlatAppearance.BorderSize = 0;
            this.btnhoadon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhoadon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnhoadon.Location = new System.Drawing.Point(-4, 388);
            this.btnhoadon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnhoadon.Name = "btnhoadon";
            this.btnhoadon.Size = new System.Drawing.Size(258, 78);
            this.btnhoadon.TabIndex = 346;
            this.btnhoadon.Text = "Hóa Đơn";
            this.btnhoadon.UseVisualStyleBackColor = false;
            this.btnhoadon.Click += new System.EventHandler(this.btnhoadon_Click);
            // 
            // tbusername
            // 
            this.tbusername.AutoSize = true;
            this.tbusername.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbusername.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbusername.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbusername.Location = new System.Drawing.Point(53, 48);
            this.tbusername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(154, 37);
            this.tbusername.TabIndex = 345;
            this.tbusername.Text = "username";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(-4, -9);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(257, 1054);
            this.pictureBox4.TabIndex = 355;
            this.pictureBox4.TabStop = false;
            // 
            // QuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1896, 1048);
            this.Controls.Add(this.qlkh);
            this.Controls.Add(this.btnChiTietHoaDon);
            this.Controls.Add(this.btnthongke);
            this.Controls.Add(this.btnkhachhang);
            this.Controls.Add(this.btnnhanvien);
            this.Controls.Add(this.btnkhohang);
            this.Controls.Add(this.btnhanghoa);
            this.Controls.Add(this.btnthongtinnv);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnhoadon);
            this.Controls.Add(this.tbusername);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.tbtimkiem);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbsdt);
            this.Controls.Add(this.tbsdt);
            this.Controls.Add(this.lbtenkhachhang);
            this.Controls.Add(this.tbtenkhachhang);
            this.Controls.Add(this.lbmakhachhang);
            this.Controls.Add(this.tbmakhachhang);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "QuanLyKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyKhachHang";
            this.Load += new System.EventHandler(this.QuanLyKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbsdt;
        private System.Windows.Forms.TextBox tbsdt;
        private System.Windows.Forms.Label lbtenkhachhang;
        private System.Windows.Forms.TextBox tbtenkhachhang;
        private System.Windows.Forms.Label lbmakhachhang;
        private System.Windows.Forms.TextBox tbmakhachhang;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox tbtimkiem;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button qlkh;
        private System.Windows.Forms.Button btnChiTietHoaDon;
        private System.Windows.Forms.Button btnthongke;
        private System.Windows.Forms.Button btnkhachhang;
        private System.Windows.Forms.Button btnnhanvien;
        private System.Windows.Forms.Button btnkhohang;
        private System.Windows.Forms.Button btnhanghoa;
        private System.Windows.Forms.Button btnthongtinnv;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnhoadon;
        private System.Windows.Forms.Label tbusername;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_kh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_kh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
    }
}