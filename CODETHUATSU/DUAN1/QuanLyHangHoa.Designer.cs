
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbmahanghoa = new System.Windows.Forms.Label();
            this.tbmahanghoa = new System.Windows.Forms.TextBox();
            this.lbtenhanghoa = new System.Windows.Forms.Label();
            this.tbtenhanghoa = new System.Windows.Forms.TextBox();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip7 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip8 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip9 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbnsx = new System.Windows.Forms.TextBox();
            this.tbmota = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbTenHH = new System.Windows.Forms.ComboBox();
            this.cbbNsx = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbmahanghoa
            // 
            this.lbmahanghoa.AutoSize = true;
            this.lbmahanghoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbmahanghoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbmahanghoa.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmahanghoa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbmahanghoa.Location = new System.Drawing.Point(461, 77);
            this.lbmahanghoa.Name = "lbmahanghoa";
            this.lbmahanghoa.Size = new System.Drawing.Size(215, 36);
            this.lbmahanghoa.TabIndex = 38;
            this.lbmahanghoa.Text = "Mã hàng hóa :";
            // 
            // tbmahanghoa
            // 
            this.tbmahanghoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbmahanghoa.Enabled = false;
            this.tbmahanghoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmahanghoa.Location = new System.Drawing.Point(684, 77);
            this.tbmahanghoa.Multiline = true;
            this.tbmahanghoa.Name = "tbmahanghoa";
            this.tbmahanghoa.Size = new System.Drawing.Size(443, 45);
            this.tbmahanghoa.TabIndex = 37;
            this.tbmahanghoa.TextChanged += new System.EventHandler(this.tbmahanghoa_TextChanged);
            this.tbmahanghoa.Enter += new System.EventHandler(this.tbmahanghoa_Enter);
            this.tbmahanghoa.Leave += new System.EventHandler(this.tbmahanghoa_Leave);
            // 
            // lbtenhanghoa
            // 
            this.lbtenhanghoa.AutoSize = true;
            this.lbtenhanghoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbtenhanghoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbtenhanghoa.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtenhanghoa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbtenhanghoa.Location = new System.Drawing.Point(461, 140);
            this.lbtenhanghoa.Name = "lbtenhanghoa";
            this.lbtenhanghoa.Size = new System.Drawing.Size(221, 36);
            this.lbtenhanghoa.TabIndex = 52;
            this.lbtenhanghoa.Text = "Tên hàng hóa :";
            // 
            // tbtenhanghoa
            // 
            this.tbtenhanghoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbtenhanghoa.Enabled = false;
            this.tbtenhanghoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtenhanghoa.Location = new System.Drawing.Point(684, 140);
            this.tbtenhanghoa.Multiline = true;
            this.tbtenhanghoa.Name = "tbtenhanghoa";
            this.tbtenhanghoa.Size = new System.Drawing.Size(443, 45);
            this.tbtenhanghoa.TabIndex = 51;
            this.tbtenhanghoa.TextChanged += new System.EventHandler(this.tbtenhanghoa_TextChanged);
            this.tbtenhanghoa.Enter += new System.EventHandler(this.tbtenhanghoa_Enter);
            this.tbtenhanghoa.Leave += new System.EventHandler(this.tbtenhanghoa_Leave);
            // 
            // btnhuy
            // 
            this.btnhuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnhuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhuy.FlatAppearance.BorderSize = 0;
            this.btnhuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnhuy.Image = ((System.Drawing.Image)(resources.GetObject("btnhuy.Image")));
            this.btnhuy.Location = new System.Drawing.Point(995, 403);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(120, 70);
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
            this.btnxoa.Location = new System.Drawing.Point(869, 403);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(120, 70);
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
            this.btnsua.Location = new System.Drawing.Point(743, 403);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(120, 70);
            this.btnsua.TabIndex = 156;
            this.toolTip3.SetToolTip(this.btnsua, "Sửa");
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnluu
            // 
            this.btnluu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnluu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnluu.FlatAppearance.BorderSize = 0;
            this.btnluu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnluu.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.Image")));
            this.btnluu.Location = new System.Drawing.Point(617, 403);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(120, 70);
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
            this.btnthem.Location = new System.Drawing.Point(491, 403);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(120, 70);
            this.btnthem.TabIndex = 152;
            this.toolTip1.SetToolTip(this.btnthem, "Thêm");
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHH,
            this.Ten,
            this.NgaySX,
            this.HSD});
            this.dataGridView1.Location = new System.Drawing.Point(11, 478);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1717, 451);
            this.dataGridView1.TabIndex = 160;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MaHH
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaHH.DefaultCellStyle = dataGridViewCellStyle9;
            this.MaHH.HeaderText = "Mã hàng hóa";
            this.MaHH.MinimumWidth = 6;
            this.MaHH.Name = "MaHH";
            this.MaHH.ReadOnly = true;
            // 
            // Ten
            // 
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ten.DefaultCellStyle = dataGridViewCellStyle10;
            this.Ten.HeaderText = "Tên hàng hóa";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            // 
            // NgaySX
            // 
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgaySX.DefaultCellStyle = dataGridViewCellStyle11;
            this.NgaySX.HeaderText = "Mô tả";
            this.NgaySX.MinimumWidth = 6;
            this.NgaySX.Name = "NgaySX";
            this.NgaySX.ReadOnly = true;
            // 
            // HSD
            // 
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HSD.DefaultCellStyle = dataGridViewCellStyle12;
            this.HSD.HeaderText = "Nơi sản xuất";
            this.HSD.MinimumWidth = 6;
            this.HSD.Name = "HSD";
            this.HSD.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(461, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 36);
            this.label1.TabIndex = 313;
            this.label1.Text = "Nơi sản xuất:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(462, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 36);
            this.label2.TabIndex = 312;
            this.label2.Text = "Mô tả:";
            // 
            // tbnsx
            // 
            this.tbnsx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbnsx.Enabled = false;
            this.tbnsx.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnsx.Location = new System.Drawing.Point(684, 323);
            this.tbnsx.Multiline = true;
            this.tbnsx.Name = "tbnsx";
            this.tbnsx.Size = new System.Drawing.Size(443, 45);
            this.tbnsx.TabIndex = 315;
            // 
            // tbmota
            // 
            this.tbmota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbmota.Enabled = false;
            this.tbmota.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmota.Location = new System.Drawing.Point(683, 260);
            this.tbmota.Multiline = true;
            this.tbmota.Name = "tbmota";
            this.tbmota.Size = new System.Drawing.Size(443, 45);
            this.tbmota.TabIndex = 314;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(581, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.MaximumSize = new System.Drawing.Size(1090, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(467, 49);
            this.label3.TabIndex = 317;
            this.label3.Text = "QUẢN LÝ HÀNG HÓA";
            // 
            // cbbTenHH
            // 
            this.cbbTenHH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenHH.FormattingEnabled = true;
            this.cbbTenHH.Location = new System.Drawing.Point(683, 206);
            this.cbbTenHH.Margin = new System.Windows.Forms.Padding(2);
            this.cbbTenHH.Name = "cbbTenHH";
            this.cbbTenHH.Size = new System.Drawing.Size(203, 28);
            this.cbbTenHH.TabIndex = 318;
            this.cbbTenHH.SelectedValueChanged += new System.EventHandler(this.cbbTenHH_SelectedValueChanged);
            // 
            // cbbNsx
            // 
            this.cbbNsx.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNsx.FormattingEnabled = true;
            this.cbbNsx.Location = new System.Drawing.Point(917, 206);
            this.cbbNsx.Margin = new System.Windows.Forms.Padding(2);
            this.cbbNsx.Name = "cbbNsx";
            this.cbbNsx.Size = new System.Drawing.Size(209, 28);
            this.cbbNsx.TabIndex = 319;
            this.cbbNsx.SelectedValueChanged += new System.EventHandler(this.cbbNsx_SelectedValueChanged);
            // 
            // QuanLyHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1739, 940);
            this.Controls.Add(this.cbbNsx);
            this.Controls.Add(this.cbbTenHH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbnsx);
            this.Controls.Add(this.tbmota);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.lbtenhanghoa);
            this.Controls.Add(this.tbtenhanghoa);
            this.Controls.Add(this.lbmahanghoa);
            this.Controls.Add(this.tbmahanghoa);
            this.DoubleBuffered = true;
            this.Location = new System.Drawing.Point(175, 65);
            this.Name = "QuanLyHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Quản lý hàng hóa";
            this.Load += new System.EventHandler(this.QuanLyHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbmahanghoa;
        private System.Windows.Forms.TextBox tbmahanghoa;
        private System.Windows.Forms.Label lbtenhanghoa;
        private System.Windows.Forms.TextBox tbtenhanghoa;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip8;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip7;
        private System.Windows.Forms.ToolTip toolTip9;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySX;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbnsx;
        private System.Windows.Forms.TextBox tbmota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbTenHH;
        private System.Windows.Forms.ComboBox cbbNsx;
    }
}