
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
            this.quenmatkhau = new System.Windows.Forms.Label();
            this.btnViewPass = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbusername
            // 
            this.lbusername.AutoSize = true;
            this.lbusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbusername.Location = new System.Drawing.Point(126, 318);
            this.lbusername.Name = "lbusername";
            this.lbusername.Size = new System.Drawing.Size(216, 36);
            this.lbusername.TabIndex = 4;
            this.lbusername.Text = "Tên đăng nhập";
            // 
            // tbusername
            // 
            this.tbusername.BackColor = System.Drawing.Color.White;
            this.tbusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbusername.Location = new System.Drawing.Point(10, 5);
            this.tbusername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(321, 31);
            this.tbusername.TabIndex = 5;
            this.tbusername.TextChanged += new System.EventHandler(this.tbusername_TextChanged);
            // 
            // tbpassword
            // 
            this.tbpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpassword.Location = new System.Drawing.Point(10, 5);
            this.tbpassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.PasswordChar = '*';
            this.tbpassword.Size = new System.Drawing.Size(280, 31);
            this.tbpassword.TabIndex = 7;
            this.tbpassword.TextChanged += new System.EventHandler(this.tbpassword_TextChanged);
            // 
            // lbpassword
            // 
            this.lbpassword.AutoSize = true;
            this.lbpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpassword.Location = new System.Drawing.Point(126, 438);
            this.lbpassword.Name = "lbpassword";
            this.lbpassword.Size = new System.Drawing.Size(137, 36);
            this.lbpassword.TabIndex = 6;
            this.lbpassword.Text = "Mật khẩu";
            // 
            // btnsubmit
            // 
            this.btnsubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnsubmit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnsubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.Location = new System.Drawing.Point(131, 595);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(341, 49);
            this.btnsubmit.TabIndex = 8;
            this.btnsubmit.Text = "Đăng nhập";
            this.btnsubmit.UseVisualStyleBackColor = false;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            this.btnsubmit.MouseLeave += new System.EventHandler(this.btnsubmit_MouseLeave);
            this.btnsubmit.MouseHover += new System.EventHandler(this.btnsubmit_MouseHover);
            this.btnsubmit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnsubmit_MouseMove);
            // 
            // cbghinhodn
            // 
            this.cbghinhodn.AutoSize = true;
            this.cbghinhodn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbghinhodn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cbghinhodn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbghinhodn.Location = new System.Drawing.Point(131, 541);
            this.cbghinhodn.Name = "cbghinhodn";
            this.cbghinhodn.Size = new System.Drawing.Size(164, 24);
            this.cbghinhodn.TabIndex = 11;
            this.cbghinhodn.Text = "Ghi nhớ đăng nhập";
            this.cbghinhodn.UseVisualStyleBackColor = false;
            this.cbghinhodn.CheckedChanged += new System.EventHandler(this.cbghinhodn_CheckedChanged);
            // 
            // quenmatkhau
            // 
            this.quenmatkhau.AutoSize = true;
            this.quenmatkhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.quenmatkhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quenmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quenmatkhau.Location = new System.Drawing.Point(411, 698);
            this.quenmatkhau.Name = "quenmatkhau";
            this.quenmatkhau.Size = new System.Drawing.Size(161, 26);
            this.quenmatkhau.TabIndex = 10;
            this.quenmatkhau.Text = "Quên mật khẩu";
            this.quenmatkhau.Click += new System.EventHandler(this.quenmatkhau_Click);
            // 
            // btnViewPass
            // 
            this.btnViewPass.BackColor = System.Drawing.Color.White;
            this.btnViewPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewPass.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnViewPass.FlatAppearance.BorderSize = 0;
            this.btnViewPass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnViewPass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnViewPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewPass.Image = global::DUAN1.Properties.Resources.icons8_eyeclose_24;
            this.btnViewPass.Location = new System.Drawing.Point(296, 3);
            this.btnViewPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewPass.Name = "btnViewPass";
            this.btnViewPass.Size = new System.Drawing.Size(45, 38);
            this.btnViewPass.TabIndex = 13;
            this.btnViewPass.UseVisualStyleBackColor = false;
            this.btnViewPass.Click += new System.EventHandler(this.btnViewPass_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbusername);
            this.panel1.Location = new System.Drawing.Point(131, 364);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 47);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tbpassword);
            this.panel2.Controls.Add(this.btnViewPass);
            this.panel2.Location = new System.Drawing.Point(131, 482);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 47);
            this.panel2.TabIndex = 15;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 760);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbghinhodn);
            this.Controls.Add(this.lbpassword);
            this.Controls.Add(this.lbusername);
            this.Controls.Add(this.quenmatkhau);
            this.Controls.Add(this.btnsubmit);
            this.MaximumSize = new System.Drawing.Size(600, 799);
            this.MinimumSize = new System.Drawing.Size(600, 799);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Label quenmatkhau;
        private System.Windows.Forms.Button btnViewPass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}