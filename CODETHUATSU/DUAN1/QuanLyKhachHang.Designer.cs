﻿
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
            this.button15 = new System.Windows.Forms.Button();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnkhachhang = new System.Windows.Forms.Button();
            this.btnnhanvien = new System.Windows.Forms.Button();
            this.btnkhohang = new System.Windows.Forms.Button();
            this.btnhanghoa = new System.Windows.Forms.Button();
            this.btnthongtinnv = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnhoadon = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.tbtimkiem = new System.Windows.Forms.TextBox();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnthongke = new System.Windows.Forms.Button();
            this.tbusername = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(138, 11);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(1114, 93);
            this.button15.TabIndex = 133;
            this.button15.Text = "QUẢN LÝ KHÁCH HÀNG";
            this.button15.UseVisualStyleBackColor = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(149, 466);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1090, 190);
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
            this.lbsdt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbsdt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbsdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsdt.Location = new System.Drawing.Point(466, 284);
            this.lbsdt.Name = "lbsdt";
            this.lbsdt.Size = new System.Drawing.Size(131, 24);
            this.lbsdt.TabIndex = 131;
            this.lbsdt.Text = "Số điện thoại :";
            // 
            // tbsdt
            // 
            this.tbsdt.Location = new System.Drawing.Point(636, 284);
            this.tbsdt.Multiline = true;
            this.tbsdt.Name = "tbsdt";
            this.tbsdt.Size = new System.Drawing.Size(342, 24);
            this.tbsdt.TabIndex = 130;
            // 
            // lbtenkhachhang
            // 
            this.lbtenkhachhang.AutoSize = true;
            this.lbtenkhachhang.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbtenkhachhang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbtenkhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtenkhachhang.Location = new System.Drawing.Point(466, 227);
            this.lbtenkhachhang.Name = "lbtenkhachhang";
            this.lbtenkhachhang.Size = new System.Drawing.Size(158, 24);
            this.lbtenkhachhang.TabIndex = 129;
            this.lbtenkhachhang.Text = "Tên khách hàng :";
            // 
            // tbtenkhachhang
            // 
            this.tbtenkhachhang.Location = new System.Drawing.Point(636, 227);
            this.tbtenkhachhang.Multiline = true;
            this.tbtenkhachhang.Name = "tbtenkhachhang";
            this.tbtenkhachhang.Size = new System.Drawing.Size(342, 24);
            this.tbtenkhachhang.TabIndex = 128;
            // 
            // lbmakhachhang
            // 
            this.lbmakhachhang.AutoSize = true;
            this.lbmakhachhang.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbmakhachhang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbmakhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmakhachhang.Location = new System.Drawing.Point(466, 169);
            this.lbmakhachhang.Name = "lbmakhachhang";
            this.lbmakhachhang.Size = new System.Drawing.Size(150, 24);
            this.lbmakhachhang.TabIndex = 127;
            this.lbmakhachhang.Text = "Mã khách hàng :";
            // 
            // tbmakhachhang
            // 
            this.tbmakhachhang.Location = new System.Drawing.Point(636, 169);
            this.tbmakhachhang.Multiline = true;
            this.tbmakhachhang.Name = "tbmakhachhang";
            this.tbmakhachhang.ReadOnly = true;
            this.tbmakhachhang.Size = new System.Drawing.Size(342, 24);
            this.tbmakhachhang.TabIndex = 126;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(138, 111);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1114, 558);
            this.pictureBox2.TabIndex = 117;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 657);
            this.pictureBox1.TabIndex = 116;
            this.pictureBox1.TabStop = false;
            // 
            // btnkhachhang
            // 
            this.btnkhachhang.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnkhachhang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnkhachhang.BackgroundImage")));
            this.btnkhachhang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnkhachhang.FlatAppearance.BorderSize = 0;
            this.btnkhachhang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnkhachhang.Location = new System.Drawing.Point(12, 401);
            this.btnkhachhang.Name = "btnkhachhang";
            this.btnkhachhang.Size = new System.Drawing.Size(120, 52);
            this.btnkhachhang.TabIndex = 158;
            this.toolTip1.SetToolTip(this.btnkhachhang, "Quản lý khách hàng");
            this.btnkhachhang.UseVisualStyleBackColor = false;
            // 
            // btnnhanvien
            // 
            this.btnnhanvien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnnhanvien.BackgroundImage")));
            this.btnnhanvien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnnhanvien.FlatAppearance.BorderSize = 0;
            this.btnnhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnnhanvien.Location = new System.Drawing.Point(12, 343);
            this.btnnhanvien.Name = "btnnhanvien";
            this.btnnhanvien.Size = new System.Drawing.Size(120, 52);
            this.btnnhanvien.TabIndex = 157;
            this.toolTip1.SetToolTip(this.btnnhanvien, "Quản lý nhân viên");
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
            this.btnkhohang.Location = new System.Drawing.Point(12, 227);
            this.btnkhohang.Name = "btnkhohang";
            this.btnkhohang.Size = new System.Drawing.Size(120, 52);
            this.btnkhohang.TabIndex = 156;
            this.toolTip1.SetToolTip(this.btnkhohang, "Quản lý kho hàng");
            this.btnkhohang.UseVisualStyleBackColor = false;
            this.btnkhohang.Click += new System.EventHandler(this.btnkhohang_Click);
            // 
            // btnhanghoa
            // 
            this.btnhanghoa.BackColor = System.Drawing.SystemColors.Control;
            this.btnhanghoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnhanghoa.BackgroundImage")));
            this.btnhanghoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnhanghoa.FlatAppearance.BorderSize = 0;
            this.btnhanghoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnhanghoa.Location = new System.Drawing.Point(12, 169);
            this.btnhanghoa.Name = "btnhanghoa";
            this.btnhanghoa.Size = new System.Drawing.Size(120, 52);
            this.btnhanghoa.TabIndex = 155;
            this.toolTip1.SetToolTip(this.btnhanghoa, "Quản lý hàng hóa");
            this.btnhanghoa.UseVisualStyleBackColor = false;
            this.btnhanghoa.Click += new System.EventHandler(this.btnhanghoa_Click);
            // 
            // btnthongtinnv
            // 
            this.btnthongtinnv.BackColor = System.Drawing.SystemColors.Control;
            this.btnthongtinnv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnthongtinnv.BackgroundImage")));
            this.btnthongtinnv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnthongtinnv.FlatAppearance.BorderSize = 0;
            this.btnthongtinnv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnthongtinnv.Location = new System.Drawing.Point(12, 111);
            this.btnthongtinnv.Name = "btnthongtinnv";
            this.btnthongtinnv.Size = new System.Drawing.Size(120, 52);
            this.btnthongtinnv.TabIndex = 154;
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
            this.btnthoat.Location = new System.Drawing.Point(12, 604);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(120, 52);
            this.btnthoat.TabIndex = 153;
            this.toolTip1.SetToolTip(this.btnthoat, "Thoát ");
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
            this.btnhoadon.Location = new System.Drawing.Point(12, 284);
            this.btnhoadon.Name = "btnhoadon";
            this.btnhoadon.Size = new System.Drawing.Size(120, 52);
            this.btnhoadon.TabIndex = 152;
            this.toolTip1.SetToolTip(this.btnhoadon, "Quản lý hóa đơn");
            this.btnhoadon.UseVisualStyleBackColor = false;
            this.btnhoadon.Click += new System.EventHandler(this.btnhoadon_Click);
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
            this.btnhuy.Location = new System.Drawing.Point(652, 399);
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
            this.btnxoa.Location = new System.Drawing.Point(526, 399);
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
            this.btnsua.Location = new System.Drawing.Point(400, 399);
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
            this.tbtimkiem.Location = new System.Drawing.Point(778, 401);
            this.tbtimkiem.Multiline = true;
            this.tbtimkiem.Name = "tbtimkiem";
            this.tbtimkiem.Size = new System.Drawing.Size(462, 52);
            this.tbtimkiem.TabIndex = 168;
            // 
            // btnluu
            // 
            this.btnluu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnluu.FlatAppearance.BorderSize = 0;
            this.btnluu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnluu.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.Image")));
            this.btnluu.Location = new System.Drawing.Point(274, 399);
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
            this.btnthem.Location = new System.Drawing.Point(148, 401);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(120, 52);
            this.btnthem.TabIndex = 166;
            this.toolTip1.SetToolTip(this.btnthem, "Thêm");
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnthongke
            // 
            this.btnthongke.BackColor = System.Drawing.SystemColors.Control;
            this.btnthongke.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnthongke.BackgroundImage")));
            this.btnthongke.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnthongke.FlatAppearance.BorderSize = 0;
            this.btnthongke.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnthongke.Location = new System.Drawing.Point(12, 458);
            this.btnthongke.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(119, 48);
            this.btnthongke.TabIndex = 191;
            this.toolTip1.SetToolTip(this.btnthongke, "Thống kê");
            this.btnthongke.UseVisualStyleBackColor = false;
            this.btnthongke.Click += new System.EventHandler(this.btnthongke_Click);
            // 
            // tbusername
            // 
            this.tbusername.AutoSize = true;
            this.tbusername.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbusername.Location = new System.Drawing.Point(22, 51);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(103, 25);
            this.tbusername.TabIndex = 251;
            this.tbusername.Text = "username";
            // 
            // QuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tbusername);
            this.Controls.Add(this.btnthongke);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.tbtimkiem);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnkhachhang);
            this.Controls.Add(this.btnnhanvien);
            this.Controls.Add(this.btnkhohang);
            this.Controls.Add(this.btnhanghoa);
            this.Controls.Add(this.btnthongtinnv);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnhoadon);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbsdt);
            this.Controls.Add(this.tbsdt);
            this.Controls.Add(this.lbtenkhachhang);
            this.Controls.Add(this.tbtenkhachhang);
            this.Controls.Add(this.lbmakhachhang);
            this.Controls.Add(this.tbmakhachhang);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "QuanLyKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyKhachHang";
            this.Load += new System.EventHandler(this.QuanLyKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbsdt;
        private System.Windows.Forms.TextBox tbsdt;
        private System.Windows.Forms.Label lbtenkhachhang;
        private System.Windows.Forms.TextBox tbtenkhachhang;
        private System.Windows.Forms.Label lbmakhachhang;
        private System.Windows.Forms.TextBox tbmakhachhang;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnkhachhang;
        private System.Windows.Forms.Button btnnhanvien;
        private System.Windows.Forms.Button btnkhohang;
        private System.Windows.Forms.Button btnhanghoa;
        private System.Windows.Forms.Button btnthongtinnv;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnhoadon;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox tbtimkiem;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnthongke;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.Label tbusername;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}