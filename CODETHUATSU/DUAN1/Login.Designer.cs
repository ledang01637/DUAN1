
namespace DUAN1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lbusername = new System.Windows.Forms.Label();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.lbpassword = new System.Windows.Forms.Label();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.cbghinhodn = new System.Windows.Forms.CheckBox();
            this.cbhienmatkhau = new System.Windows.Forms.CheckBox();
            this.quenmatkhau = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbusername
            // 
            this.lbusername.AutoSize = true;
            this.lbusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbusername.Location = new System.Drawing.Point(124, 321);
            this.lbusername.Name = "lbusername";
            this.lbusername.Size = new System.Drawing.Size(235, 37);
            this.lbusername.TabIndex = 4;
            this.lbusername.Text = "Tên đăng nhập";
            // 
            // tbusername
            // 
            this.tbusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbusername.Location = new System.Drawing.Point(131, 368);
            this.tbusername.Multiline = true;
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(342, 48);
            this.tbusername.TabIndex = 5;
            this.tbusername.TextChanged += new System.EventHandler(this.tbusername_TextChanged);
            // 
            // tbpassword
            // 
            this.tbpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpassword.Location = new System.Drawing.Point(131, 466);
            this.tbpassword.Multiline = true;
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.PasswordChar = '*';
            this.tbpassword.Size = new System.Drawing.Size(342, 48);
            this.tbpassword.TabIndex = 7;
            this.tbpassword.TextChanged += new System.EventHandler(this.tbpassword_TextChanged);
            // 
            // lbpassword
            // 
            this.lbpassword.AutoSize = true;
            this.lbpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpassword.Location = new System.Drawing.Point(124, 419);
            this.lbpassword.Name = "lbpassword";
            this.lbpassword.Size = new System.Drawing.Size(149, 37);
            this.lbpassword.TabIndex = 6;
            this.lbpassword.Text = "Mật khẩu";
            // 
            // btnsubmit
            // 
            this.btnsubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnsubmit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnsubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.Location = new System.Drawing.Point(123, 633);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(342, 49);
            this.btnsubmit.TabIndex = 8;
            this.btnsubmit.Text = "Đăng nhập";
            this.btnsubmit.UseVisualStyleBackColor = false;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // cbghinhodn
            // 
            this.cbghinhodn.AutoSize = true;
            this.cbghinhodn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbghinhodn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cbghinhodn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbghinhodn.Location = new System.Drawing.Point(131, 577);
            this.cbghinhodn.Name = "cbghinhodn";
            this.cbghinhodn.Size = new System.Drawing.Size(164, 24);
            this.cbghinhodn.TabIndex = 11;
            this.cbghinhodn.Text = "Ghi nhớ đăng nhập";
            this.cbghinhodn.UseVisualStyleBackColor = false;
            this.cbghinhodn.CheckedChanged += new System.EventHandler(this.cbghinhodn_CheckedChanged);
            // 
            // cbhienmatkhau
            // 
            this.cbhienmatkhau.AutoSize = true;
            this.cbhienmatkhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbhienmatkhau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cbhienmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbhienmatkhau.Location = new System.Drawing.Point(131, 547);
            this.cbhienmatkhau.Name = "cbhienmatkhau";
            this.cbhienmatkhau.Size = new System.Drawing.Size(131, 24);
            this.cbhienmatkhau.TabIndex = 12;
            this.cbhienmatkhau.Text = "Hiện mật khẩu";
            this.cbhienmatkhau.UseVisualStyleBackColor = false;
            this.cbhienmatkhau.CheckedChanged += new System.EventHandler(this.cbhienmatkhau_CheckedChanged);
            // 
            // quenmatkhau
            // 
            this.quenmatkhau.AutoSize = true;
            this.quenmatkhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.quenmatkhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quenmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quenmatkhau.Location = new System.Drawing.Point(411, 726);
            this.quenmatkhau.Name = "quenmatkhau";
            this.quenmatkhau.Size = new System.Drawing.Size(161, 26);
            this.quenmatkhau.TabIndex = 10;
            this.quenmatkhau.Text = "Quên mật khẩu";
            this.quenmatkhau.Click += new System.EventHandler(this.quenmatkhau_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.cbghinhodn);
            this.Controls.Add(this.cbhienmatkhau);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.lbpassword);
            this.Controls.Add(this.tbusername);
            this.Controls.Add(this.lbusername);
            this.Controls.Add(this.quenmatkhau);
            this.Controls.Add(this.btnsubmit);
            this.MaximumSize = new System.Drawing.Size(600, 800);
            this.MinimumSize = new System.Drawing.Size(600, 800);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbusername;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.Label lbpassword;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.CheckBox cbghinhodn;
        private System.Windows.Forms.CheckBox cbhienmatkhau;
        private System.Windows.Forms.Label quenmatkhau;
    }
}