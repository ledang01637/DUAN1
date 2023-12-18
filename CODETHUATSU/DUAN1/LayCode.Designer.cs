
namespace DUAN1
{
    partial class LayCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LayCode));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btngui = new System.Windows.Forms.Button();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.lbemail = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.btnthoat);
            this.groupBox1.Controls.Add(this.btngui);
            this.groupBox1.Controls.Add(this.tbemail);
            this.groupBox1.Controls.Add(this.lbemail);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(525, 188);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lấy OTP";
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnthoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnthoat.BackgroundImage")));
            this.btnthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnthoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthoat.FlatAppearance.BorderSize = 0;
            this.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnthoat.Location = new System.Drawing.Point(339, 114);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(160, 55);
            this.btnthoat.TabIndex = 154;
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btngui
            // 
            this.btngui.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btngui.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btngui.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngui.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngui.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngui.ForeColor = System.Drawing.Color.Black;
            this.btngui.Location = new System.Drawing.Point(32, 114);
            this.btngui.Margin = new System.Windows.Forms.Padding(4);
            this.btngui.Name = "btngui";
            this.btngui.Size = new System.Drawing.Size(155, 55);
            this.btngui.TabIndex = 27;
            this.btngui.Text = "Gửi";
            this.btngui.UseMnemonic = false;
            this.btngui.UseVisualStyleBackColor = false;
            this.btngui.Click += new System.EventHandler(this.btngui_Click);
            this.btngui.MouseLeave += new System.EventHandler(this.btngui_MouseLeave);
            this.btngui.MouseHover += new System.EventHandler(this.btngui_MouseHover);
            this.btngui.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btngui_MouseMove);
            // 
            // tbemail
            // 
            this.tbemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbemail.Location = new System.Drawing.Point(32, 70);
            this.tbemail.Margin = new System.Windows.Forms.Padding(4);
            this.tbemail.Multiline = true;
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(466, 36);
            this.tbemail.TabIndex = 25;
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbemail.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbemail.Location = new System.Drawing.Point(24, 22);
            this.lbemail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(115, 46);
            this.lbemail.TabIndex = 24;
            this.lbemail.Text = "Email";
            // 
            // LayCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 260);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(616, 307);
            this.MinimumSize = new System.Drawing.Size(616, 307);
            this.Name = "LayCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LayOTP";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btngui;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.Label lbemail;
    }
}