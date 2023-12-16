
namespace DUAN1
{
    partial class ThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKe));
            this.btnhuy = new System.Windows.Forms.Button();
            this.dtpdenngay = new System.Windows.Forms.DateTimePicker();
            this.lbdenngay = new System.Windows.Forms.Label();
            this.dtptungay = new System.Windows.Forms.DateTimePicker();
            this.lbtungay = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.tbtimkiem = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mahoadon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giasanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongdaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongcontrongkho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.qlkh = new System.Windows.Forms.Button();
            this.btnChiTietHoaDon = new System.Windows.Forms.Button();
            this.btnthongke = new System.Windows.Forms.Button();
            this.btnkhachhang = new System.Windows.Forms.Button();
            this.btnnhanvien = new System.Windows.Forms.Button();
            this.btnkhohang = new System.Windows.Forms.Button();
            this.btnhanghoa = new System.Windows.Forms.Button();
            this.btnthongtinnv = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnhoadon = new System.Windows.Forms.Button();
            this.usernamenv = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnhuy
            // 
            this.btnhuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnhuy.FlatAppearance.BorderSize = 0;
            this.btnhuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnhuy.Image = ((System.Drawing.Image)(resources.GetObject("btnhuy.Image")));
            this.btnhuy.Location = new System.Drawing.Point(1132, 613);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(120, 52);
            this.btnhuy.TabIndex = 247;
            this.toolTip1.SetToolTip(this.btnhuy, "Hủy");
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // dtpdenngay
            // 
            this.dtpdenngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdenngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdenngay.Location = new System.Drawing.Point(394, 198);
            this.dtpdenngay.Name = "dtpdenngay";
            this.dtpdenngay.Size = new System.Drawing.Size(328, 38);
            this.dtpdenngay.TabIndex = 245;
            // 
            // lbdenngay
            // 
            this.lbdenngay.AutoSize = true;
            this.lbdenngay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbdenngay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbdenngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdenngay.Location = new System.Drawing.Point(207, 198);
            this.lbdenngay.Name = "lbdenngay";
            this.lbdenngay.Size = new System.Drawing.Size(145, 31);
            this.lbdenngay.TabIndex = 244;
            this.lbdenngay.Text = "Đến ngày :";
            // 
            // dtptungay
            // 
            this.dtptungay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtptungay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtptungay.Location = new System.Drawing.Point(394, 126);
            this.dtptungay.Name = "dtptungay";
            this.dtptungay.Size = new System.Drawing.Size(328, 38);
            this.dtptungay.TabIndex = 243;
            // 
            // lbtungay
            // 
            this.lbtungay.AutoSize = true;
            this.lbtungay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbtungay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbtungay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtungay.Location = new System.Drawing.Point(207, 126);
            this.lbtungay.Name = "lbtungay";
            this.lbtungay.Size = new System.Drawing.Size(127, 31);
            this.lbtungay.TabIndex = 242;
            this.lbtungay.Text = "Từ ngày :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(528, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 25);
            this.label9.TabIndex = 236;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(522, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 25);
            this.label7.TabIndex = 235;
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btntimkiem.FlatAppearance.BorderSize = 0;
            this.btntimkiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btntimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btntimkiem.Image")));
            this.btntimkiem.Location = new System.Drawing.Point(602, 250);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(120, 52);
            this.btntimkiem.TabIndex = 221;
            this.toolTip1.SetToolTip(this.btntimkiem, "Tìm kiếm");
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // tbtimkiem
            // 
            this.tbtimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtimkiem.Location = new System.Drawing.Point(213, 250);
            this.tbtimkiem.Multiline = true;
            this.tbtimkiem.Name = "tbtimkiem";
            this.tbtimkiem.Size = new System.Drawing.Size(509, 52);
            this.tbtimkiem.TabIndex = 220;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahoadon,
            this.ngaylap,
            this.giasanpham,
            this.soluongdaban,
            this.soluongcontrongkho});
            this.dataGridView1.Location = new System.Drawing.Point(213, 308);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(509, 363);
            this.dataGridView1.TabIndex = 217;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // mahoadon
            // 
            this.mahoadon.HeaderText = "Mã kho hàng chi tiết";
            this.mahoadon.MinimumWidth = 6;
            this.mahoadon.Name = "mahoadon";
            this.mahoadon.ReadOnly = true;
            // 
            // ngaylap
            // 
            this.ngaylap.HeaderText = "Ngày lập";
            this.ngaylap.MinimumWidth = 6;
            this.ngaylap.Name = "ngaylap";
            this.ngaylap.ReadOnly = true;
            // 
            // giasanpham
            // 
            this.giasanpham.HeaderText = "Tổng giá";
            this.giasanpham.MinimumWidth = 6;
            this.giasanpham.Name = "giasanpham";
            this.giasanpham.ReadOnly = true;
            // 
            // soluongdaban
            // 
            this.soluongdaban.HeaderText = "Số lượng đã bán";
            this.soluongdaban.MinimumWidth = 6;
            this.soluongdaban.Name = "soluongdaban";
            this.soluongdaban.ReadOnly = true;
            // 
            // soluongcontrongkho
            // 
            this.soluongcontrongkho.HeaderText = "Số lượng còn trong kho";
            this.soluongcontrongkho.MinimumWidth = 6;
            this.soluongcontrongkho.Name = "soluongcontrongkho";
            this.soluongcontrongkho.ReadOnly = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(161, 84);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1107, 596);
            this.pictureBox2.TabIndex = 213;
            this.pictureBox2.TabStop = false;
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
            this.qlkh.TabIndex = 368;
            this.qlkh.Text = "THỐNG KÊ";
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
            this.btnChiTietHoaDon.TabIndex = 366;
            this.btnChiTietHoaDon.Text = "Chi Tiết HD";
            this.btnChiTietHoaDon.UseVisualStyleBackColor = false;
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
            this.btnthongke.Margin = new System.Windows.Forms.Padding(2);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(172, 50);
            this.btnthongke.TabIndex = 365;
            this.btnthongke.Text = "Thống Kê";
            this.btnthongke.UseVisualStyleBackColor = false;
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
            this.btnkhachhang.TabIndex = 364;
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
            this.btnnhanvien.TabIndex = 363;
            this.btnnhanvien.Text = "Nhân Viên";
            this.btnnhanvien.UseVisualStyleBackColor = false;
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
            this.btnkhohang.TabIndex = 362;
            this.btnkhohang.Text = "Kho Hàng";
            this.btnkhohang.UseVisualStyleBackColor = false;
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
            this.btnhanghoa.TabIndex = 361;
            this.btnhanghoa.Text = "Hàng Hóa";
            this.btnhanghoa.UseVisualStyleBackColor = false;
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
            this.btnthongtinnv.TabIndex = 360;
            this.btnthongtinnv.Text = "Trang Chủ";
            this.toolTip1.SetToolTip(this.btnthongtinnv, "Thông tin nhân viên");
            this.btnthongtinnv.UseVisualStyleBackColor = false;
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
            this.btnthoat.TabIndex = 359;
            this.btnthoat.UseVisualStyleBackColor = false;
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
            this.btnhoadon.TabIndex = 358;
            this.btnhoadon.Text = "Hóa Đơn";
            this.btnhoadon.UseVisualStyleBackColor = false;
            // 
            // usernamenv
            // 
            this.usernamenv.AutoSize = true;
            this.usernamenv.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usernamenv.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamenv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usernamenv.Location = new System.Drawing.Point(35, 31);
            this.usernamenv.Name = "usernamenv";
            this.usernamenv.Size = new System.Drawing.Size(103, 25);
            this.usernamenv.TabIndex = 357;
            this.usernamenv.Text = "username";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(-3, -6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(172, 686);
            this.pictureBox4.TabIndex = 367;
            this.pictureBox4.TabStop = false;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 677);
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
            this.Controls.Add(this.usernamenv);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.dtpdenngay);
            this.Controls.Add(this.lbdenngay);
            this.Controls.Add(this.dtptungay);
            this.Controls.Add(this.lbtungay);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.tbtimkiem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1280, 716);
            this.MinimumSize = new System.Drawing.Size(1280, 716);
            this.Name = "ThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLThongKe";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.DateTimePicker dtpdenngay;
        private System.Windows.Forms.Label lbdenngay;
        private System.Windows.Forms.DateTimePicker dtptungay;
        private System.Windows.Forms.Label lbtungay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox tbtimkiem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylap;
        private System.Windows.Forms.DataGridViewTextBoxColumn giasanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongdaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongcontrongkho;
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
        private System.Windows.Forms.Label usernamenv;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}