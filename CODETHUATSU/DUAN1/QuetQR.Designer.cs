
namespace DUAN1
{
    partial class QuetQR
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
            this.ptbCamera = new System.Windows.Forms.PictureBox();
            this.ptbQR = new System.Windows.Forms.PictureBox();
            this.btnTaoQR = new System.Windows.Forms.Button();
            this.cbbChonCamera = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLuuQR = new System.Windows.Forms.Button();
            this.tbTaoQR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbShowQR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStarQuetQr = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnThoatQR = new System.Windows.Forms.Button();
            this.tbusername = new System.Windows.Forms.Label();
            this.btnThemHang = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbQR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbCamera
            // 
            this.ptbCamera.BackColor = System.Drawing.Color.White;
            this.ptbCamera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbCamera.Location = new System.Drawing.Point(27, 12);
            this.ptbCamera.Name = "ptbCamera";
            this.ptbCamera.Size = new System.Drawing.Size(510, 300);
            this.ptbCamera.TabIndex = 0;
            this.ptbCamera.TabStop = false;
            // 
            // ptbQR
            // 
            this.ptbQR.BackColor = System.Drawing.Color.White;
            this.ptbQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbQR.Location = new System.Drawing.Point(27, 349);
            this.ptbQR.Name = "ptbQR";
            this.ptbQR.Size = new System.Drawing.Size(300, 300);
            this.ptbQR.TabIndex = 1;
            this.ptbQR.TabStop = false;
            // 
            // btnTaoQR
            // 
            this.btnTaoQR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaoQR.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoQR.Location = new System.Drawing.Point(385, 477);
            this.btnTaoQR.Name = "btnTaoQR";
            this.btnTaoQR.Size = new System.Drawing.Size(109, 67);
            this.btnTaoQR.TabIndex = 2;
            this.btnTaoQR.Text = "Tạo QR";
            this.btnTaoQR.UseVisualStyleBackColor = true;
            this.btnTaoQR.Click += new System.EventHandler(this.btnTaoQR_Click);
            // 
            // cbbChonCamera
            // 
            this.cbbChonCamera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbChonCamera.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbChonCamera.FormattingEnabled = true;
            this.cbbChonCamera.Location = new System.Drawing.Point(337, 361);
            this.cbbChonCamera.Name = "cbbChonCamera";
            this.cbbChonCamera.Size = new System.Drawing.Size(200, 27);
            this.cbbChonCamera.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chọn camera:";
            // 
            // btnLuuQR
            // 
            this.btnLuuQR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuuQR.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuQR.Location = new System.Drawing.Point(385, 550);
            this.btnLuuQR.Name = "btnLuuQR";
            this.btnLuuQR.Size = new System.Drawing.Size(109, 67);
            this.btnLuuQR.TabIndex = 5;
            this.btnLuuQR.Text = "Lưu QR";
            this.btnLuuQR.UseVisualStyleBackColor = true;
            this.btnLuuQR.Click += new System.EventHandler(this.btnLuuQR_Click);
            // 
            // tbTaoQR
            // 
            this.tbTaoQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTaoQR.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTaoQR.Location = new System.Drawing.Point(553, 349);
            this.tbTaoQR.Multiline = true;
            this.tbTaoQR.Name = "tbTaoQR";
            this.tbTaoQR.Size = new System.Drawing.Size(305, 91);
            this.tbTaoQR.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(549, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nhập mã:";
            // 
            // tbShowQR
            // 
            this.tbShowQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbShowQR.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbShowQR.Location = new System.Drawing.Point(553, 12);
            this.tbShowQR.Multiline = true;
            this.tbShowQR.Name = "tbShowQR";
            this.tbShowQR.Size = new System.Drawing.Size(305, 223);
            this.tbShowQR.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mã QR";
            // 
            // btnStarQuetQr
            // 
            this.btnStarQuetQr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStarQuetQr.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStarQuetQr.Location = new System.Drawing.Point(385, 404);
            this.btnStarQuetQr.Name = "btnStarQuetQr";
            this.btnStarQuetQr.Size = new System.Drawing.Size(109, 67);
            this.btnStarQuetQr.TabIndex = 10;
            this.btnStarQuetQr.Text = "Bắt đầu quét QR";
            this.btnStarQuetQr.UseVisualStyleBackColor = true;
            this.btnStarQuetQr.Click += new System.EventHandler(this.btnStarQuetQr_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnThoatQR
            // 
            this.btnThoatQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatQR.Location = new System.Drawing.Point(773, 605);
            this.btnThoatQR.Name = "btnThoatQR";
            this.btnThoatQR.Size = new System.Drawing.Size(75, 32);
            this.btnThoatQR.TabIndex = 11;
            this.btnThoatQR.Text = "Thoát";
            this.btnThoatQR.UseVisualStyleBackColor = true;
            this.btnThoatQR.Click += new System.EventHandler(this.btnThoatQR_Click);
            // 
            // tbusername
            // 
            this.tbusername.AutoSize = true;
            this.tbusername.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbusername.Location = new System.Drawing.Point(379, 620);
            this.tbusername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(130, 32);
            this.tbusername.TabIndex = 251;
            this.tbusername.Text = "username";
            // 
            // btnThemHang
            // 
            this.btnThemHang.Location = new System.Drawing.Point(553, 263);
            this.btnThemHang.Name = "btnThemHang";
            this.btnThemHang.Size = new System.Drawing.Size(96, 48);
            this.btnThemHang.TabIndex = 252;
            this.btnThemHang.Text = "Thêm hàng";
            this.btnThemHang.UseVisualStyleBackColor = true;
            this.btnThemHang.Click += new System.EventHandler(this.btnThemHang_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(671, 264);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(102, 48);
            this.btnThanhToan.TabIndex = 253;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ten,
            this.Gia});
            this.dataGridView1.Location = new System.Drawing.Point(553, 459);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(305, 187);
            this.dataGridView1.TabIndex = 254;
            // 
            // Ten
            // 
            this.Ten.HeaderText = "Ten";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            // 
            // Gia
            // 
            this.Gia.HeaderText = "Gia";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            // 
            // QuetQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(882, 658);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnThemHang);
            this.Controls.Add(this.tbusername);
            this.Controls.Add(this.btnThoatQR);
            this.Controls.Add(this.btnStarQuetQr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbShowQR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTaoQR);
            this.Controls.Add(this.btnLuuQR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbChonCamera);
            this.Controls.Add(this.btnTaoQR);
            this.Controls.Add(this.ptbQR);
            this.Controls.Add(this.ptbCamera);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(900, 705);
            this.MinimumSize = new System.Drawing.Size(900, 705);
            this.Name = "QuetQR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuetQR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuetQR_FormClosing);
            this.Load += new System.EventHandler(this.QuetQR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbQR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbCamera;
        private System.Windows.Forms.PictureBox ptbQR;
        private System.Windows.Forms.Button btnTaoQR;
        private System.Windows.Forms.ComboBox cbbChonCamera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLuuQR;
        private System.Windows.Forms.TextBox tbTaoQR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbShowQR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStarQuetQr;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnThoatQR;
        private System.Windows.Forms.Label tbusername;
        private System.Windows.Forms.Button btnThemHang;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
    }
}