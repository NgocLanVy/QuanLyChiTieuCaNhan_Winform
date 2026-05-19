namespace ĐỒ_ÁN_QUẢN_LÝ_CHI_TIÊU_CÁ_NHÂN.GUI
{
    partial class frmGioiThieu
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
            this.lblClick = new System.Windows.Forms.Label();
            this.timerNhapNhay = new System.Windows.Forms.Timer(this.components);
            this.picBanner = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClick
            // 
            this.lblClick.AutoSize = true;
            this.lblClick.BackColor = System.Drawing.Color.Maroon;
            this.lblClick.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClick.ForeColor = System.Drawing.Color.White;
            this.lblClick.Location = new System.Drawing.Point(957, 605);
            this.lblClick.Name = "lblClick";
            this.lblClick.Size = new System.Drawing.Size(269, 38);
            this.lblClick.TabIndex = 1;
            this.lblClick.Text = "Nhấn để tiếp tục ...";
            this.lblClick.Click += new System.EventHandler(this.lblClick_Click);
            // 
            // timerNhapNhay
            // 
            this.timerNhapNhay.Enabled = true;
            this.timerNhapNhay.Interval = 600;
            this.timerNhapNhay.Tick += new System.EventHandler(this.timerNhapNhay_Tick);
            // 
            // picBanner
            // 
            this.picBanner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBanner.Image = global::ĐỒ_ÁN_QUẢN_LÝ_CHI_TIÊU_CÁ_NHÂN.Properties.Resources.banner2;
            this.picBanner.Location = new System.Drawing.Point(0, 0);
            this.picBanner.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBanner.Name = "picBanner";
            this.picBanner.Size = new System.Drawing.Size(1268, 708);
            this.picBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBanner.TabIndex = 0;
            this.picBanner.TabStop = false;
            this.picBanner.Click += new System.EventHandler(this.picBanner_Click);
            // 
            // frmGioiThieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1268, 708);
            this.Controls.Add(this.lblClick);
            this.Controls.Add(this.picBanner);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmGioiThieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGioiThieu";
            this.Load += new System.EventHandler(this.frmGioiThieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBanner;
        private System.Windows.Forms.Label lblClick;
        private System.Windows.Forms.Timer timerNhapNhay;
    }
}