namespace QuanLyNhanVien
{
    partial class frm_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_admin));
            this.sideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.btn_qlnv = new System.Windows.Forms.Button();
            this.btn_qlcv = new System.Windows.Forms.Button();
            this.btn_qlpb = new System.Windows.Forms.Button();
            this.btn_chamcong = new System.Windows.Forms.Button();
            this.btn_qlluong = new System.Windows.Forms.Button();
            this.btn_thongke = new System.Windows.Forms.Button();
            this.siteBarTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sideBar.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.Orange;
            this.sideBar.Controls.Add(this.panel4);
            this.sideBar.Controls.Add(this.btn_qlnv);
            this.sideBar.Controls.Add(this.btn_qlcv);
            this.sideBar.Controls.Add(this.btn_qlpb);
            this.sideBar.Controls.Add(this.btn_chamcong);
            this.sideBar.Controls.Add(this.btn_qlluong);
            this.sideBar.Controls.Add(this.btn_thongke);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.MaximumSize = new System.Drawing.Size(320, 1033);
            this.sideBar.MinimumSize = new System.Drawing.Size(83, 1033);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(83, 1033);
            this.sideBar.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.menuButton);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(317, 146);
            this.panel4.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(103, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(102, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOME";
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.Location = new System.Drawing.Point(3, 35);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(74, 76);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            this.menuButton.Paint += new System.Windows.Forms.PaintEventHandler(this.menuButton_Paint);
            // 
            // btn_qlnv
            // 
            this.btn_qlnv.FlatAppearance.BorderSize = 0;
            this.btn_qlnv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_qlnv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_qlnv.ForeColor = System.Drawing.Color.White;
            this.btn_qlnv.Image = global::QuanLyNhanVien.Properties.Resources.workforce_16864433;
            this.btn_qlnv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_qlnv.Location = new System.Drawing.Point(3, 155);
            this.btn_qlnv.Name = "btn_qlnv";
            this.btn_qlnv.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_qlnv.Size = new System.Drawing.Size(323, 91);
            this.btn_qlnv.TabIndex = 4;
            this.btn_qlnv.Text = "           Nhân viên";
            this.btn_qlnv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_qlnv.UseVisualStyleBackColor = true;
            this.btn_qlnv.Click += new System.EventHandler(this.btn_qlnv_Click);
            // 
            // btn_qlcv
            // 
            this.btn_qlcv.FlatAppearance.BorderSize = 0;
            this.btn_qlcv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_qlcv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_qlcv.ForeColor = System.Drawing.Color.White;
            this.btn_qlcv.Image = global::QuanLyNhanVien.Properties.Resources.portfolio_7980633;
            this.btn_qlcv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_qlcv.Location = new System.Drawing.Point(3, 252);
            this.btn_qlcv.Name = "btn_qlcv";
            this.btn_qlcv.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_qlcv.Size = new System.Drawing.Size(323, 91);
            this.btn_qlcv.TabIndex = 5;
            this.btn_qlcv.Text = "           Chức vụ";
            this.btn_qlcv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_qlcv.UseVisualStyleBackColor = true;
            this.btn_qlcv.Click += new System.EventHandler(this.btn_qlcv_Click);
            // 
            // btn_qlpb
            // 
            this.btn_qlpb.FlatAppearance.BorderSize = 0;
            this.btn_qlpb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_qlpb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_qlpb.ForeColor = System.Drawing.Color.White;
            this.btn_qlpb.Image = global::QuanLyNhanVien.Properties.Resources.s;
            this.btn_qlpb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_qlpb.Location = new System.Drawing.Point(3, 349);
            this.btn_qlpb.Name = "btn_qlpb";
            this.btn_qlpb.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_qlpb.Size = new System.Drawing.Size(323, 91);
            this.btn_qlpb.TabIndex = 6;
            this.btn_qlpb.Text = "           Phòng ban";
            this.btn_qlpb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_qlpb.UseVisualStyleBackColor = true;
            this.btn_qlpb.Click += new System.EventHandler(this.btn_qlpb_Click);
            // 
            // btn_chamcong
            // 
            this.btn_chamcong.FlatAppearance.BorderSize = 0;
            this.btn_chamcong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chamcong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chamcong.ForeColor = System.Drawing.Color.White;
            this.btn_chamcong.Image = global::QuanLyNhanVien.Properties.Resources.time_limit_4903969;
            this.btn_chamcong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_chamcong.Location = new System.Drawing.Point(3, 446);
            this.btn_chamcong.Name = "btn_chamcong";
            this.btn_chamcong.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_chamcong.Size = new System.Drawing.Size(323, 91);
            this.btn_chamcong.TabIndex = 9;
            this.btn_chamcong.Text = "           Chấm công";
            this.btn_chamcong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_chamcong.UseVisualStyleBackColor = true;
            this.btn_chamcong.Click += new System.EventHandler(this.btn_chamcong_Click);
            // 
            // btn_qlluong
            // 
            this.btn_qlluong.FlatAppearance.BorderSize = 0;
            this.btn_qlluong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_qlluong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_qlluong.ForeColor = System.Drawing.Color.White;
            this.btn_qlluong.Image = global::QuanLyNhanVien.Properties.Resources.salary_3135673;
            this.btn_qlluong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_qlluong.Location = new System.Drawing.Point(3, 543);
            this.btn_qlluong.Name = "btn_qlluong";
            this.btn_qlluong.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_qlluong.Size = new System.Drawing.Size(323, 91);
            this.btn_qlluong.TabIndex = 7;
            this.btn_qlluong.Text = "           Quản lý lương";
            this.btn_qlluong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_qlluong.UseVisualStyleBackColor = true;
            this.btn_qlluong.Click += new System.EventHandler(this.btn_qlluong_Click);
            // 
            // btn_thongke
            // 
            this.btn_thongke.FlatAppearance.BorderSize = 0;
            this.btn_thongke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thongke.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thongke.ForeColor = System.Drawing.Color.White;
            this.btn_thongke.Image = global::QuanLyNhanVien.Properties.Resources.analytics_921540;
            this.btn_thongke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thongke.Location = new System.Drawing.Point(3, 640);
            this.btn_thongke.Name = "btn_thongke";
            this.btn_thongke.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_thongke.Size = new System.Drawing.Size(323, 91);
            this.btn_thongke.TabIndex = 8;
            this.btn_thongke.Text = "           Thống kê";
            this.btn_thongke.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thongke.UseVisualStyleBackColor = true;
            this.btn_thongke.Click += new System.EventHandler(this.btn_thongke_Click);
            // 
            // siteBarTimer
            // 
            this.siteBarTimer.Interval = 10;
            this.siteBarTimer.Tick += new System.EventHandler(this.siteBarTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(83, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1819, 1033);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(27, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1384, 491);
            this.panel2.TabIndex = 0;
            // 
            // frm_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sideBar);
            this.Name = "frm_admin";
            this.Text = "frm_admin";
            this.Load += new System.EventHandler(this.frm_admin_Load);
            this.sideBar.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sideBar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_qlnv;
        private System.Windows.Forms.Button btn_qlcv;
        private System.Windows.Forms.Button btn_qlpb;
        private System.Windows.Forms.Button btn_qlluong;
        private System.Windows.Forms.Button btn_thongke;
        private System.Windows.Forms.Timer siteBarTimer;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_chamcong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}