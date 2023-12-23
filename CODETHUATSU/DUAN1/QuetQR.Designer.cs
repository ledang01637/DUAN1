
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
            this.cbbChonCamera = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptbCamera)).BeginInit();
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
            // cbbChonCamera
            // 
            this.cbbChonCamera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbChonCamera.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbChonCamera.FormattingEnabled = true;
            this.cbbChonCamera.Location = new System.Drawing.Point(179, 330);
            this.cbbChonCamera.Name = "cbbChonCamera";
            this.cbbChonCamera.Size = new System.Drawing.Size(200, 27);
            this.cbbChonCamera.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chọn camera:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // QuetQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(582, 403);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbChonCamera);
            this.Controls.Add(this.ptbCamera);
            this.MaximumSize = new System.Drawing.Size(600, 450);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "QuetQR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuetQR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuetQR_FormClosing);
            this.Load += new System.EventHandler(this.QuetQR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbCamera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbCamera;
        private System.Windows.Forms.ComboBox cbbChonCamera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}