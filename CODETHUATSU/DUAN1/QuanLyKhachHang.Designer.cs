
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
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Ma,
            this.Ten,
            this.SDT});
            this.dataGridView1.Location = new System.Drawing.Point(169, 466);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1100, 214);
            this.dataGridView1.TabIndex = 132;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Ma
            // 
            this.Ma.HeaderText = "Mã KH";
            this.Ma.MinimumWidth = 6;
            this.Ma.Name = "Ma";
            this.Ma.ReadOnly = true;
            // 
            // Ten
            // 
            this.Ten.HeaderText = "Tên KH";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // lbsdt
            // 
            this.lbsdt.AutoSize = true;
            this.lbsdt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbsdt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbsdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsdt.ForeColor = System.Drawing.SystemColors.Control;
            this.lbsdt.Location = new System.Drawing.Point(466, 284);
            this.lbsdt.Name = "lbsdt";
            this.lbsdt.Size = new System.Drawing.Size(181, 29);
            this.lbsdt.TabIndex = 131;
            this.lbsdt.Text = "Số điện thoại :";
            // 
            // tbsdt
            // 
            this.tbsdt.Location = new System.Drawing.Point(686, 284);
            this.tbsdt.Multiline = true;
            this.tbsdt.Name = "tbsdt";
            this.tbsdt.Size = new System.Drawing.Size(342, 29);
            this.tbsdt.TabIndex = 130;
            // 
            // lbtenkhachhang
            // 
            this.lbtenkhachhang.AutoSize = true;
            this.lbtenkhachhang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbtenkhachhang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbtenkhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtenkhachhang.ForeColor = System.Drawing.SystemColors.Control;
            this.lbtenkhachhang.Location = new System.Drawing.Point(466, 227);
            this.lbtenkhachhang.Name = "lbtenkhachhang";
            this.lbtenkhachhang.Size = new System.Drawing.Size(212, 29);
            this.lbtenkhachhang.TabIndex = 129;
            this.lbtenkhachhang.Text = "Tên khách hàng :";
            // 
            // tbtenkhachhang
            // 
            this.tbtenkhachhang.Location = new System.Drawing.Point(686, 227);
            this.tbtenkhachhang.Multiline = true;
            this.tbtenkhachhang.Name = "tbtenkhachhang";
            this.tbtenkhachhang.Size = new System.Drawing.Size(342, 29);
            this.tbtenkhachhang.TabIndex = 128;
            // 
            // lbmakhachhang
            // 
            this.lbmakhachhang.AutoSize = true;
            this.lbmakhachhang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbmakhachhang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbmakhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmakhachhang.ForeColor = System.Drawing.SystemColors.Control;
            this.lbmakhachhang.Location = new System.Drawing.Point(466, 169);
            this.lbmakhachhang.Name = "lbmakhachhang";
            this.lbmakhachhang.Size = new System.Drawing.Size(201, 29);
            this.lbmakhachhang.TabIndex = 127;
            this.lbmakhachhang.Text = "Mã khách hàng :";
            // 
            // tbmakhachhang
            // 
            this.tbmakhachhang.Location = new System.Drawing.Point(686, 169);
            this.tbmakhachhang.Multiline = true;
            this.tbmakhachhang.Name = "tbmakhachhang";
            this.tbmakhachhang.ReadOnly = true;
            this.tbmakhachhang.Size = new System.Drawing.Size(342, 29);
            this.tbmakhachhang.TabIndex = 126;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(169, 84);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1099, 596);
            this.pictureBox2.TabIndex = 117;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(202, 140);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(208, 197);
            this.pictureBox3.TabIndex = 159;
            this.pictureBox3.TabStop = false;
            // 
            // btnhuy
            // 
            this.btnhuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnhuy.FlatAppearance.BorderSize = 0;
            this.btnhuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnhuy.Image = ((System.Drawing.Image)(resources.GetObject("btnhuy.Image")));
            this.btnhuy.Location = new System.Drawing.Point(696, 399);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(120, 52);
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
            this.btnxoa.Location = new System.Drawing.Point(570, 399);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(120, 52);
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
            this.btnsua.Location = new System.Drawing.Point(444, 399);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(120, 52);
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
            this.btntimkiem.Location = new System.Drawing.Point(1119, 401);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(120, 52);
            this.btntimkiem.TabIndex = 169;
            this.toolTip1.SetToolTip(this.btntimkiem, "Tìm kiếm");
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // tbtimkiem
            // 
            this.tbtimkiem.Location = new System.Drawing.Point(822, 401);
            this.tbtimkiem.Multiline = true;
            this.tbtimkiem.Name = "tbtimkiem";
            this.tbtimkiem.Size = new System.Drawing.Size(418, 52);
            this.tbtimkiem.TabIndex = 168;
            // 
            // btnluu
            // 
            this.btnluu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnluu.FlatAppearance.BorderSize = 0;
            this.btnluu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnluu.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.Image")));
            this.btnluu.Location = new System.Drawing.Point(318, 399);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(120, 52);
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
            this.btnthem.Location = new System.Drawing.Point(192, 401);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(120, 52);
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
            this.btnthongtinnv.Location = new System.Drawing.Point(-3, 84);
            this.btnthongtinnv.Name = "btnthongtinnv";
            this.btnthongtinnv.Size = new System.Drawing.Size(172, 50);
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
            this.qlkh.Location = new System.Drawing.Point(169, -6);
            this.qlkh.Name = "qlkh";
            this.qlkh.Size = new System.Drawing.Size(1099, 91);
            this.qlkh.TabIndex = 356;
            this.qlkh.Text = "QUẢN LÝ KHÁCH HÀNG";
            this.qlkh.UseVisualStyleBackColor = false;
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
            this.btnChiTietHoaDon.Location = new System.Drawing.Point(-3, 308);
            this.btnChiTietHoaDon.Name = "btnChiTietHoaDon";
            this.btnChiTietHoaDon.Size = new System.Drawing.Size(172, 50);
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
            this.btnthongke.Location = new System.Drawing.Point(-3, 475);
            this.btnthongke.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(172, 50);
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
            this.btnkhachhang.Location = new System.Drawing.Point(-3, 420);
            this.btnkhachhang.Name = "btnkhachhang";
            this.btnkhachhang.Size = new System.Drawing.Size(172, 50);
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
            this.btnnhanvien.Location = new System.Drawing.Point(-3, 364);
            this.btnnhanvien.Name = "btnnhanvien";
            this.btnnhanvien.Size = new System.Drawing.Size(172, 50);
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
            this.btnkhohang.Location = new System.Drawing.Point(-3, 196);
            this.btnkhohang.Name = "btnkhohang";
            this.btnkhohang.Size = new System.Drawing.Size(172, 50);
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
            this.btnhanghoa.Location = new System.Drawing.Point(-3, 140);
            this.btnhanghoa.Name = "btnhanghoa";
            this.btnhanghoa.Size = new System.Drawing.Size(172, 50);
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
            this.btnthoat.Location = new System.Drawing.Point(-3, 601);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(172, 70);
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
            this.btnhoadon.Location = new System.Drawing.Point(-3, 252);
            this.btnhoadon.Name = "btnhoadon";
            this.btnhoadon.Size = new System.Drawing.Size(172, 50);
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
            this.tbusername.Location = new System.Drawing.Point(35, 31);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(103, 25);
            this.tbusername.TabIndex = 345;
            this.tbusername.Text = "username";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(-3, -6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(172, 686);
            this.pictureBox4.TabIndex = 355;
            this.pictureBox4.TabStop = false;
            // 
            // QuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
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
    }
}