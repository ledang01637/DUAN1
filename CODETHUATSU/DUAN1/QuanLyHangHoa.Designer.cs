﻿
namespace DUAN1
{
    partial class QuanLyHangHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyHangHoa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbmahanghoa = new System.Windows.Forms.Label();
            this.tbmahanghoa = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button15 = new System.Windows.Forms.Button();
            this.lbtenhanghoa = new System.Windows.Forms.Label();
            this.tbtenhanghoa = new System.Windows.Forms.TextBox();
            this.lbngaysx = new System.Windows.Forms.Label();
            this.lbhansudung = new System.Windows.Forms.Label();
            this.dtpngaysanxuat = new System.Windows.Forms.DateTimePicker();
            this.hinhanh = new System.Windows.Forms.PictureBox();
            this.lbgia = new System.Windows.Forms.Label();
            this.tbgia = new System.Windows.Forms.TextBox();
            this.btnkhachhang = new System.Windows.Forms.Button();
            this.btnnhanvien = new System.Windows.Forms.Button();
            this.btnkhohang = new System.Windows.Forms.Button();
            this.btnhanghoa = new System.Windows.Forms.Button();
            this.btnthongtinnv = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnhoadon = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.tbtimkiem = new System.Windows.Forms.TextBox();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.dtphansudung = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tbgianhap = new System.Windows.Forms.TextBox();
            this.btnthongke = new System.Windows.Forms.Button();
            this.tbusername = new System.Windows.Forms.Label();
            this.btnLuuQR = new System.Windows.Forms.Button();
            this.btnTaoQR = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip7 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip8 = new System.Windows.Forms.ToolTip(this.components);
            this.btnChiTietHoaDon = new System.Windows.Forms.Button();
            this.toolTip9 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbmahanghoa
            // 
            this.lbmahanghoa.AutoSize = true;
            this.lbmahanghoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbmahanghoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbmahanghoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmahanghoa.Location = new System.Drawing.Point(151, 142);
            this.lbmahanghoa.Name = "lbmahanghoa";
            this.lbmahanghoa.Size = new System.Drawing.Size(150, 25);
            this.lbmahanghoa.TabIndex = 38;
            this.lbmahanghoa.Text = "Mã hàng hóa :";
            // 
            // tbmahanghoa
            // 
            this.tbmahanghoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbmahanghoa.Enabled = false;
            this.tbmahanghoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmahanghoa.Location = new System.Drawing.Point(305, 142);
            this.tbmahanghoa.Multiline = true;
            this.tbmahanghoa.Name = "tbmahanghoa";
            this.tbmahanghoa.Size = new System.Drawing.Size(96, 28);
            this.tbmahanghoa.TabIndex = 37;
            this.tbmahanghoa.TextChanged += new System.EventHandler(this.tbmahanghoa_TextChanged);
            this.tbmahanghoa.Enter += new System.EventHandler(this.tbmahanghoa_Enter);
            this.tbmahanghoa.Leave += new System.EventHandler(this.tbmahanghoa_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(138, 111);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1114, 558);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button15.Enabled = false;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(138, 12);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(1114, 93);
            this.button15.TabIndex = 50;
            this.button15.Text = "QUẢN LÝ HÀNG HÓA";
            this.button15.UseVisualStyleBackColor = false;
            // 
            // lbtenhanghoa
            // 
            this.lbtenhanghoa.AutoSize = true;
            this.lbtenhanghoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbtenhanghoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbtenhanghoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtenhanghoa.Location = new System.Drawing.Point(150, 201);
            this.lbtenhanghoa.Name = "lbtenhanghoa";
            this.lbtenhanghoa.Size = new System.Drawing.Size(157, 25);
            this.lbtenhanghoa.TabIndex = 52;
            this.lbtenhanghoa.Text = "Tên hàng hóa :";
            // 
            // tbtenhanghoa
            // 
            this.tbtenhanghoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbtenhanghoa.Enabled = false;
            this.tbtenhanghoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtenhanghoa.Location = new System.Drawing.Point(305, 201);
            this.tbtenhanghoa.Multiline = true;
            this.tbtenhanghoa.Name = "tbtenhanghoa";
            this.tbtenhanghoa.Size = new System.Drawing.Size(460, 26);
            this.tbtenhanghoa.TabIndex = 51;
            this.tbtenhanghoa.TextChanged += new System.EventHandler(this.tbtenhanghoa_TextChanged);
            this.tbtenhanghoa.Enter += new System.EventHandler(this.tbtenhanghoa_Enter);
            this.tbtenhanghoa.Leave += new System.EventHandler(this.tbtenhanghoa_Leave);
            // 
            // lbngaysx
            // 
            this.lbngaysx.AutoSize = true;
            this.lbngaysx.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbngaysx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbngaysx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbngaysx.Location = new System.Drawing.Point(151, 258);
            this.lbngaysx.Name = "lbngaysx";
            this.lbngaysx.Size = new System.Drawing.Size(162, 25);
            this.lbngaysx.TabIndex = 54;
            this.lbngaysx.Text = "Ngày sản xuất :";
            // 
            // lbhansudung
            // 
            this.lbhansudung.AutoSize = true;
            this.lbhansudung.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbhansudung.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbhansudung.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhansudung.Location = new System.Drawing.Point(421, 142);
            this.lbhansudung.Name = "lbhansudung";
            this.lbhansudung.Size = new System.Drawing.Size(146, 25);
            this.lbhansudung.TabIndex = 56;
            this.lbhansudung.Text = "Hạn sử dụng :";
            // 
            // dtpngaysanxuat
            // 
            this.dtpngaysanxuat.CustomFormat = "dd/M/yyyy";
            this.dtpngaysanxuat.Enabled = false;
            this.dtpngaysanxuat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpngaysanxuat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaysanxuat.Location = new System.Drawing.Point(305, 256);
            this.dtpngaysanxuat.Name = "dtpngaysanxuat";
            this.dtpngaysanxuat.Size = new System.Drawing.Size(460, 29);
            this.dtpngaysanxuat.TabIndex = 57;
            this.dtpngaysanxuat.ValueChanged += new System.EventHandler(this.dtpngaysanxuat_ValueChanged);
            this.dtpngaysanxuat.Enter += new System.EventHandler(this.dtpngaysanxuat_Enter);
            this.dtpngaysanxuat.Leave += new System.EventHandler(this.dtpngaysanxuat_Leave);
            // 
            // hinhanh
            // 
            this.hinhanh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hinhanh.BackgroundImage")));
            this.hinhanh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.hinhanh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hinhanh.Enabled = false;
            this.hinhanh.Location = new System.Drawing.Point(872, 136);
            this.hinhanh.Name = "hinhanh";
            this.hinhanh.Size = new System.Drawing.Size(250, 271);
            this.hinhanh.TabIndex = 59;
            this.hinhanh.TabStop = false;
            this.hinhanh.Click += new System.EventHandler(this.hinhanh_Click);
            // 
            // lbgia
            // 
            this.lbgia.AutoSize = true;
            this.lbgia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbgia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgia.Location = new System.Drawing.Point(150, 314);
            this.lbgia.Name = "lbgia";
            this.lbgia.Size = new System.Drawing.Size(99, 25);
            this.lbgia.TabIndex = 61;
            this.lbgia.Text = "Giá bán :";
            // 
            // tbgia
            // 
            this.tbgia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbgia.Enabled = false;
            this.tbgia.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbgia.Location = new System.Drawing.Point(305, 311);
            this.tbgia.Multiline = true;
            this.tbgia.Name = "tbgia";
            this.tbgia.Size = new System.Drawing.Size(222, 28);
            this.tbgia.TabIndex = 60;
            this.tbgia.TextChanged += new System.EventHandler(this.tbgia_TextChanged);
            this.tbgia.Enter += new System.EventHandler(this.tbgia_Enter);
            this.tbgia.Leave += new System.EventHandler(this.tbgia_Leave);
            // 
            // btnkhachhang
            // 
            this.btnkhachhang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnkhachhang.BackgroundImage")));
            this.btnkhachhang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnkhachhang.FlatAppearance.BorderSize = 0;
            this.btnkhachhang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnkhachhang.Location = new System.Drawing.Point(13, 457);
            this.btnkhachhang.Name = "btnkhachhang";
            this.btnkhachhang.Size = new System.Drawing.Size(119, 52);
            this.btnkhachhang.TabIndex = 151;
            this.toolTip6.SetToolTip(this.btnkhachhang, "Quản lý khách hàng");
            this.btnkhachhang.UseVisualStyleBackColor = true;
            this.btnkhachhang.Click += new System.EventHandler(this.btnkhachhang_Click);
            // 
            // btnnhanvien
            // 
            this.btnnhanvien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnnhanvien.BackgroundImage")));
            this.btnnhanvien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnnhanvien.FlatAppearance.BorderSize = 0;
            this.btnnhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnnhanvien.Location = new System.Drawing.Point(13, 398);
            this.btnnhanvien.Name = "btnnhanvien";
            this.btnnhanvien.Size = new System.Drawing.Size(119, 52);
            this.btnnhanvien.TabIndex = 150;
            this.toolTip5.SetToolTip(this.btnnhanvien, "Quản lý nhân viên");
            this.btnnhanvien.UseVisualStyleBackColor = true;
            this.btnnhanvien.Click += new System.EventHandler(this.btnnhanvien_Click);
            // 
            // btnkhohang
            // 
            this.btnkhohang.BackColor = System.Drawing.SystemColors.Control;
            this.btnkhohang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnkhohang.BackgroundImage")));
            this.btnkhohang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnkhohang.FlatAppearance.BorderSize = 0;
            this.btnkhohang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnkhohang.Location = new System.Drawing.Point(12, 224);
            this.btnkhohang.Name = "btnkhohang";
            this.btnkhohang.Size = new System.Drawing.Size(119, 52);
            this.btnkhohang.TabIndex = 149;
            this.toolTip3.SetToolTip(this.btnkhohang, "Quản lý kho hàng");
            this.btnkhohang.UseVisualStyleBackColor = false;
            this.btnkhohang.Click += new System.EventHandler(this.btnkhohang_Click);
            // 
            // btnhanghoa
            // 
            this.btnhanghoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnhanghoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnhanghoa.BackgroundImage")));
            this.btnhanghoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnhanghoa.FlatAppearance.BorderSize = 0;
            this.btnhanghoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnhanghoa.Location = new System.Drawing.Point(12, 166);
            this.btnhanghoa.Name = "btnhanghoa";
            this.btnhanghoa.Size = new System.Drawing.Size(119, 52);
            this.btnhanghoa.TabIndex = 148;
            this.toolTip2.SetToolTip(this.btnhanghoa, "Quản lý hàng hóa");
            this.btnhanghoa.UseVisualStyleBackColor = false;
            // 
            // btnthongtinnv
            // 
            this.btnthongtinnv.BackColor = System.Drawing.SystemColors.Control;
            this.btnthongtinnv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnthongtinnv.BackgroundImage")));
            this.btnthongtinnv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnthongtinnv.FlatAppearance.BorderSize = 0;
            this.btnthongtinnv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnthongtinnv.Location = new System.Drawing.Point(12, 108);
            this.btnthongtinnv.Name = "btnthongtinnv";
            this.btnthongtinnv.Size = new System.Drawing.Size(119, 52);
            this.btnthongtinnv.TabIndex = 147;
            this.toolTip1.SetToolTip(this.btnthongtinnv, "Thông tin nhân viên");
            this.btnthongtinnv.UseVisualStyleBackColor = false;
            this.btnthongtinnv.Click += new System.EventHandler(this.btnthongtinnv_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnthoat.BackgroundImage")));
            this.btnthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnthoat.FlatAppearance.BorderSize = 0;
            this.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnthoat.Location = new System.Drawing.Point(12, 601);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(119, 52);
            this.btnthoat.TabIndex = 146;
            this.toolTip8.SetToolTip(this.btnthoat, "Thoát ");
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnhoadon
            // 
            this.btnhoadon.BackColor = System.Drawing.SystemColors.Control;
            this.btnhoadon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnhoadon.BackgroundImage")));
            this.btnhoadon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnhoadon.FlatAppearance.BorderSize = 0;
            this.btnhoadon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnhoadon.Location = new System.Drawing.Point(12, 282);
            this.btnhoadon.Name = "btnhoadon";
            this.btnhoadon.Size = new System.Drawing.Size(119, 52);
            this.btnhoadon.TabIndex = 145;
            this.toolTip4.SetToolTip(this.btnhoadon, "Quản lý hóa đơn");
            this.btnhoadon.UseVisualStyleBackColor = false;
            this.btnhoadon.Click += new System.EventHandler(this.btnhoadon_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnhuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhuy.FlatAppearance.BorderSize = 0;
            this.btnhuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnhuy.Image = ((System.Drawing.Image)(resources.GetObject("btnhuy.Image")));
            this.btnhuy.Location = new System.Drawing.Point(654, 409);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(120, 41);
            this.btnhuy.TabIndex = 158;
            this.toolTip5.SetToolTip(this.btnhuy, "Hủy");
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnxoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnxoa.FlatAppearance.BorderSize = 0;
            this.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.Location = new System.Drawing.Point(528, 409);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(120, 41);
            this.btnxoa.TabIndex = 157;
            this.toolTip4.SetToolTip(this.btnxoa, "Xóa");
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnsua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsua.FlatAppearance.BorderSize = 0;
            this.btnsua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsua.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.Image")));
            this.btnsua.Location = new System.Drawing.Point(402, 409);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(120, 43);
            this.btnsua.TabIndex = 156;
            this.toolTip3.SetToolTip(this.btnsua, "Sửa");
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btntimkiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntimkiem.FlatAppearance.BorderSize = 0;
            this.btntimkiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btntimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btntimkiem.Image")));
            this.btntimkiem.Location = new System.Drawing.Point(1120, 409);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(120, 41);
            this.btntimkiem.TabIndex = 155;
            this.toolTip6.SetToolTip(this.btntimkiem, "Tìm kiếm");
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // tbtimkiem
            // 
            this.tbtimkiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbtimkiem.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtimkiem.Location = new System.Drawing.Point(780, 409);
            this.tbtimkiem.Multiline = true;
            this.tbtimkiem.Name = "tbtimkiem";
            this.tbtimkiem.Size = new System.Drawing.Size(334, 42);
            this.tbtimkiem.TabIndex = 154;
            // 
            // btnluu
            // 
            this.btnluu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnluu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnluu.FlatAppearance.BorderSize = 0;
            this.btnluu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnluu.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.Image")));
            this.btnluu.Location = new System.Drawing.Point(276, 409);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(120, 43);
            this.btnluu.TabIndex = 153;
            this.toolTip2.SetToolTip(this.btnluu, "Lưu");
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnthem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthem.FlatAppearance.BorderSize = 0;
            this.btnthem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnthem.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.Image")));
            this.btnthem.Location = new System.Drawing.Point(150, 409);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(120, 43);
            this.btnthem.TabIndex = 152;
            this.toolTip1.SetToolTip(this.btnthem, "Thêm");
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dtphansudung
            // 
            this.dtphansudung.Enabled = false;
            this.dtphansudung.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtphansudung.Location = new System.Drawing.Point(563, 138);
            this.dtphansudung.Name = "dtphansudung";
            this.dtphansudung.Size = new System.Drawing.Size(305, 29);
            this.dtphansudung.TabIndex = 159;
            this.dtphansudung.ValueChanged += new System.EventHandler(this.dtphansudung_ValueChanged);
            this.dtphansudung.Enter += new System.EventHandler(this.dtphansudung_Enter);
            this.dtphansudung.Leave += new System.EventHandler(this.dtphansudung_Leave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHH,
            this.Ten,
            this.NgaySX,
            this.HSD,
            this.Gia,
            this.Hinh,
            this.GiaNhap});
            this.dataGridView1.Location = new System.Drawing.Point(150, 477);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1090, 176);
            this.dataGridView1.TabIndex = 160;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MaHH
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaHH.DefaultCellStyle = dataGridViewCellStyle1;
            this.MaHH.HeaderText = "Mã hàng hóa";
            this.MaHH.MinimumWidth = 6;
            this.MaHH.Name = "MaHH";
            this.MaHH.ReadOnly = true;
            this.MaHH.Width = 200;
            // 
            // Ten
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ten.DefaultCellStyle = dataGridViewCellStyle2;
            this.Ten.HeaderText = "Tên hàng hóa";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            this.Ten.Width = 200;
            // 
            // NgaySX
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgaySX.DefaultCellStyle = dataGridViewCellStyle3;
            this.NgaySX.HeaderText = "Ngày sản xuất";
            this.NgaySX.MinimumWidth = 6;
            this.NgaySX.Name = "NgaySX";
            this.NgaySX.ReadOnly = true;
            this.NgaySX.Width = 200;
            // 
            // HSD
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HSD.DefaultCellStyle = dataGridViewCellStyle4;
            this.HSD.HeaderText = "Hạn sử dụng";
            this.HSD.MinimumWidth = 6;
            this.HSD.Name = "HSD";
            this.HSD.ReadOnly = true;
            this.HSD.Width = 200;
            // 
            // Gia
            // 
            this.Gia.HeaderText = "Giá bán";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            this.Gia.Width = 175;
            // 
            // Hinh
            // 
            this.Hinh.HeaderText = "Hình";
            this.Hinh.MinimumWidth = 6;
            this.Hinh.Name = "Hinh";
            this.Hinh.ReadOnly = true;
            this.Hinh.Width = 250;
            // 
            // GiaNhap
            // 
            this.GiaNhap.HeaderText = "Giá nhập";
            this.GiaNhap.MinimumWidth = 6;
            this.GiaNhap.Name = "GiaNhap";
            this.GiaNhap.ReadOnly = true;
            this.GiaNhap.Width = 175;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 162;
            this.label1.Text = "Giá nhập :";
            // 
            // tbgianhap
            // 
            this.tbgianhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbgianhap.Enabled = false;
            this.tbgianhap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbgianhap.Location = new System.Drawing.Point(306, 364);
            this.tbgianhap.Multiline = true;
            this.tbgianhap.Name = "tbgianhap";
            this.tbgianhap.Size = new System.Drawing.Size(222, 28);
            this.tbgianhap.TabIndex = 161;
            this.tbgianhap.TextChanged += new System.EventHandler(this.tbgianhap_TextChanged);
            this.tbgianhap.Enter += new System.EventHandler(this.tbgianhap_Enter);
            this.tbgianhap.Leave += new System.EventHandler(this.tbgianhap_Leave);
            // 
            // btnthongke
            // 
            this.btnthongke.BackColor = System.Drawing.SystemColors.Control;
            this.btnthongke.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnthongke.BackgroundImage")));
            this.btnthongke.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnthongke.FlatAppearance.BorderSize = 0;
            this.btnthongke.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnthongke.Location = new System.Drawing.Point(13, 514);
            this.btnthongke.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(119, 52);
            this.btnthongke.TabIndex = 192;
            this.toolTip7.SetToolTip(this.btnthongke, "Thống kê");
            this.btnthongke.UseVisualStyleBackColor = false;
            this.btnthongke.Click += new System.EventHandler(this.btnthongke_Click);
            // 
            // tbusername
            // 
            this.tbusername.AutoSize = true;
            this.tbusername.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbusername.Location = new System.Drawing.Point(22, 54);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(103, 25);
            this.tbusername.TabIndex = 250;
            this.tbusername.Text = "username";
            // 
            // btnLuuQR
            // 
            this.btnLuuQR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuuQR.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuQR.Location = new System.Drawing.Point(668, 349);
            this.btnLuuQR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLuuQR.Name = "btnLuuQR";
            this.btnLuuQR.Size = new System.Drawing.Size(82, 54);
            this.btnLuuQR.TabIndex = 252;
            this.btnLuuQR.Text = "Lưu QR";
            this.btnLuuQR.UseVisualStyleBackColor = true;
            this.btnLuuQR.Click += new System.EventHandler(this.btnLuuQR_Click);
            // 
            // btnTaoQR
            // 
            this.btnTaoQR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaoQR.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoQR.Location = new System.Drawing.Point(754, 349);
            this.btnTaoQR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTaoQR.Name = "btnTaoQR";
            this.btnTaoQR.Size = new System.Drawing.Size(82, 54);
            this.btnTaoQR.TabIndex = 251;
            this.btnTaoQR.Text = "Tạo QR";
            this.btnTaoQR.UseVisualStyleBackColor = true;
            this.btnTaoQR.Click += new System.EventHandler(this.btnTaoQR_Click);
            // 
            // btnChiTietHoaDon
            // 
            this.btnChiTietHoaDon.BackColor = System.Drawing.SystemColors.Control;
            this.btnChiTietHoaDon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChiTietHoaDon.BackgroundImage")));
            this.btnChiTietHoaDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChiTietHoaDon.FlatAppearance.BorderSize = 0;
            this.btnChiTietHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChiTietHoaDon.Location = new System.Drawing.Point(12, 340);
            this.btnChiTietHoaDon.Name = "btnChiTietHoaDon";
            this.btnChiTietHoaDon.Size = new System.Drawing.Size(120, 52);
            this.btnChiTietHoaDon.TabIndex = 297;
            this.toolTip9.SetToolTip(this.btnChiTietHoaDon, "Chi tiết hóa đơn");
            this.btnChiTietHoaDon.UseVisualStyleBackColor = false;
            this.btnChiTietHoaDon.Click += new System.EventHandler(this.btnChiTietHoaDon_Click);
            // 
            // QuanLyHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 677);
            this.Controls.Add(this.btnChiTietHoaDon);
            this.Controls.Add(this.btnLuuQR);
            this.Controls.Add(this.btnTaoQR);
            this.Controls.Add(this.tbusername);
            this.Controls.Add(this.btnthongke);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbgianhap);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtphansudung);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.tbtimkiem);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnkhachhang);
            this.Controls.Add(this.btnnhanvien);
            this.Controls.Add(this.btnkhohang);
            this.Controls.Add(this.btnhanghoa);
            this.Controls.Add(this.btnthongtinnv);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnhoadon);
            this.Controls.Add(this.lbgia);
            this.Controls.Add(this.tbgia);
            this.Controls.Add(this.hinhanh);
            this.Controls.Add(this.dtpngaysanxuat);
            this.Controls.Add(this.lbhansudung);
            this.Controls.Add(this.lbngaysx);
            this.Controls.Add(this.lbtenhanghoa);
            this.Controls.Add(this.tbtenhanghoa);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.lbmahanghoa);
            this.Controls.Add(this.tbmahanghoa);
            this.Controls.Add(this.pictureBox2);
            this.MaximumSize = new System.Drawing.Size(1280, 716);
            this.MinimumSize = new System.Drawing.Size(1280, 716);
            this.Name = "QuanLyHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyHangHoa";
            this.Load += new System.EventHandler(this.QuanLyHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbmahanghoa;
        private System.Windows.Forms.TextBox tbmahanghoa;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Label lbtenhanghoa;
        private System.Windows.Forms.TextBox tbtenhanghoa;
        private System.Windows.Forms.Label lbngaysx;
        private System.Windows.Forms.Label lbhansudung;
        private System.Windows.Forms.DateTimePicker dtpngaysanxuat;
        private System.Windows.Forms.PictureBox hinhanh;
        private System.Windows.Forms.Label lbgia;
        private System.Windows.Forms.TextBox tbgia;
        private System.Windows.Forms.Button btnkhachhang;
        private System.Windows.Forms.Button btnnhanvien;
        private System.Windows.Forms.Button btnkhohang;
        private System.Windows.Forms.Button btnhanghoa;
        private System.Windows.Forms.Button btnthongtinnv;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnhoadon;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox tbtimkiem;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DateTimePicker dtphansudung;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbgianhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySX;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.Button btnthongke;
        private System.Windows.Forms.Label tbusername;
        private System.Windows.Forms.Button btnLuuQR;
        private System.Windows.Forms.Button btnTaoQR;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip8;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip7;
        private System.Windows.Forms.Button btnChiTietHoaDon;
        private System.Windows.Forms.ToolTip toolTip9;
    }
}