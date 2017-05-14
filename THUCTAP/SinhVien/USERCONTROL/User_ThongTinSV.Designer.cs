namespace SinhVien
{
    partial class User_ThongTinSV
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_timkiemsv = new System.Windows.Forms.TextBox();
            this.grb_nhap = new System.Windows.Forms.GroupBox();
            this.lbl_tim = new System.Windows.Forms.Label();
            this.dgr_thongtinsinhvien = new System.Windows.Forms.DataGridView();
            this.tpa_thongtin = new System.Windows.Forms.TabPage();
            this.lbl_gioitinh1 = new System.Windows.Forms.Label();
            this.lbl_quequan1 = new System.Windows.Forms.Label();
            this.lbl_ngaysinh1 = new System.Windows.Forms.Label();
            this.lbl_lop1 = new System.Windows.Forms.Label();
            this.lbl_ma1 = new System.Windows.Forms.Label();
            this.lbl_ten1 = new System.Windows.Forms.Label();
            this.lbl_ngaysinh = new System.Windows.Forms.Label();
            this.lbl_gioitinh = new System.Windows.Forms.Label();
            this.lbl_quequan = new System.Windows.Forms.Label();
            this.lbl_lop = new System.Windows.Forms.Label();
            this.lbl_ma = new System.Windows.Forms.Label();
            this.lbl_ten = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.grb_nhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_thongtinsinhvien)).BeginInit();
            this.tpa_thongtin.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_timkiemsv
            // 
            this.txt_timkiemsv.Location = new System.Drawing.Point(196, 15);
            this.txt_timkiemsv.Name = "txt_timkiemsv";
            this.txt_timkiemsv.Size = new System.Drawing.Size(241, 20);
            this.txt_timkiemsv.TabIndex = 1;
            this.txt_timkiemsv.TextChanged += new System.EventHandler(this.txt_timkiemsv_TextChanged);
            // 
            // grb_nhap
            // 
            this.grb_nhap.Controls.Add(this.lbl_tim);
            this.grb_nhap.Controls.Add(this.dgr_thongtinsinhvien);
            this.grb_nhap.Controls.Add(this.txt_timkiemsv);
            this.grb_nhap.Location = new System.Drawing.Point(20, 3);
            this.grb_nhap.Name = "grb_nhap";
            this.grb_nhap.Size = new System.Drawing.Size(443, 141);
            this.grb_nhap.TabIndex = 1;
            this.grb_nhap.TabStop = false;
            this.grb_nhap.Text = "Nhập mã sinh viên";
            // 
            // lbl_tim
            // 
            this.lbl_tim.AutoSize = true;
            this.lbl_tim.BackColor = System.Drawing.Color.White;
            this.lbl_tim.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_tim.Location = new System.Drawing.Point(337, 18);
            this.lbl_tim.Name = "lbl_tim";
            this.lbl_tim.Size = new System.Drawing.Size(96, 13);
            this.lbl_tim.TabIndex = 5;
            this.lbl_tim.Text = "Nhập tên sinh viên";
            this.lbl_tim.Click += new System.EventHandler(this.lbl_tim_Click);
            // 
            // dgr_thongtinsinhvien
            // 
            this.dgr_thongtinsinhvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgr_thongtinsinhvien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgr_thongtinsinhvien.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgr_thongtinsinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_thongtinsinhvien.Location = new System.Drawing.Point(0, 43);
            this.dgr_thongtinsinhvien.Name = "dgr_thongtinsinhvien";
            this.dgr_thongtinsinhvien.Size = new System.Drawing.Size(443, 98);
            this.dgr_thongtinsinhvien.TabIndex = 4;
            this.dgr_thongtinsinhvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgr_thongtinsinhvien_CellContentClick);
            // 
            // tpa_thongtin
            // 
            this.tpa_thongtin.BackColor = System.Drawing.Color.MediumAquamarine;
            this.tpa_thongtin.Controls.Add(this.lbl_gioitinh1);
            this.tpa_thongtin.Controls.Add(this.lbl_quequan1);
            this.tpa_thongtin.Controls.Add(this.lbl_ngaysinh1);
            this.tpa_thongtin.Controls.Add(this.lbl_lop1);
            this.tpa_thongtin.Controls.Add(this.lbl_ma1);
            this.tpa_thongtin.Controls.Add(this.lbl_ten1);
            this.tpa_thongtin.Controls.Add(this.lbl_ngaysinh);
            this.tpa_thongtin.Controls.Add(this.lbl_gioitinh);
            this.tpa_thongtin.Controls.Add(this.lbl_quequan);
            this.tpa_thongtin.Controls.Add(this.lbl_lop);
            this.tpa_thongtin.Controls.Add(this.lbl_ma);
            this.tpa_thongtin.Controls.Add(this.lbl_ten);
            this.tpa_thongtin.Controls.Add(this.lbl_title);
            this.tpa_thongtin.Location = new System.Drawing.Point(4, 22);
            this.tpa_thongtin.Name = "tpa_thongtin";
            this.tpa_thongtin.Padding = new System.Windows.Forms.Padding(3);
            this.tpa_thongtin.Size = new System.Drawing.Size(435, 212);
            this.tpa_thongtin.TabIndex = 0;
            this.tpa_thongtin.Text = "Thông Tin";
            // 
            // lbl_gioitinh1
            // 
            this.lbl_gioitinh1.AutoSize = true;
            this.lbl_gioitinh1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_gioitinh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gioitinh1.Location = new System.Drawing.Point(144, 130);
            this.lbl_gioitinh1.Name = "lbl_gioitinh1";
            this.lbl_gioitinh1.Size = new System.Drawing.Size(10, 15);
            this.lbl_gioitinh1.TabIndex = 25;
            this.lbl_gioitinh1.Text = ":";
            // 
            // lbl_quequan1
            // 
            this.lbl_quequan1.AutoSize = true;
            this.lbl_quequan1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_quequan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quequan1.Location = new System.Drawing.Point(144, 151);
            this.lbl_quequan1.Name = "lbl_quequan1";
            this.lbl_quequan1.Size = new System.Drawing.Size(10, 15);
            this.lbl_quequan1.TabIndex = 24;
            this.lbl_quequan1.Text = ":";
            // 
            // lbl_ngaysinh1
            // 
            this.lbl_ngaysinh1.AutoSize = true;
            this.lbl_ngaysinh1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_ngaysinh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngaysinh1.Location = new System.Drawing.Point(144, 109);
            this.lbl_ngaysinh1.Name = "lbl_ngaysinh1";
            this.lbl_ngaysinh1.Size = new System.Drawing.Size(10, 15);
            this.lbl_ngaysinh1.TabIndex = 23;
            this.lbl_ngaysinh1.Text = ":";
            // 
            // lbl_lop1
            // 
            this.lbl_lop1.AutoSize = true;
            this.lbl_lop1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_lop1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lop1.Location = new System.Drawing.Point(144, 173);
            this.lbl_lop1.Name = "lbl_lop1";
            this.lbl_lop1.Size = new System.Drawing.Size(10, 15);
            this.lbl_lop1.TabIndex = 22;
            this.lbl_lop1.Text = ":";
            // 
            // lbl_ma1
            // 
            this.lbl_ma1.AutoSize = true;
            this.lbl_ma1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_ma1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ma1.Location = new System.Drawing.Point(144, 87);
            this.lbl_ma1.Name = "lbl_ma1";
            this.lbl_ma1.Size = new System.Drawing.Size(10, 15);
            this.lbl_ma1.TabIndex = 21;
            this.lbl_ma1.Text = ":";
            // 
            // lbl_ten1
            // 
            this.lbl_ten1.AutoSize = true;
            this.lbl_ten1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_ten1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ten1.Location = new System.Drawing.Point(144, 66);
            this.lbl_ten1.Name = "lbl_ten1";
            this.lbl_ten1.Size = new System.Drawing.Size(10, 15);
            this.lbl_ten1.TabIndex = 20;
            this.lbl_ten1.Text = ":";
            // 
            // lbl_ngaysinh
            // 
            this.lbl_ngaysinh.AutoSize = true;
            this.lbl_ngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngaysinh.Location = new System.Drawing.Point(35, 109);
            this.lbl_ngaysinh.Name = "lbl_ngaysinh";
            this.lbl_ngaysinh.Size = new System.Drawing.Size(79, 16);
            this.lbl_ngaysinh.TabIndex = 19;
            this.lbl_ngaysinh.Text = "Ngày Sinh";
            // 
            // lbl_gioitinh
            // 
            this.lbl_gioitinh.AutoSize = true;
            this.lbl_gioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gioitinh.Location = new System.Drawing.Point(35, 130);
            this.lbl_gioitinh.Name = "lbl_gioitinh";
            this.lbl_gioitinh.Size = new System.Drawing.Size(70, 16);
            this.lbl_gioitinh.TabIndex = 18;
            this.lbl_gioitinh.Text = "Giới Tính";
            // 
            // lbl_quequan
            // 
            this.lbl_quequan.AutoSize = true;
            this.lbl_quequan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quequan.Location = new System.Drawing.Point(35, 151);
            this.lbl_quequan.Name = "lbl_quequan";
            this.lbl_quequan.Size = new System.Drawing.Size(76, 16);
            this.lbl_quequan.TabIndex = 17;
            this.lbl_quequan.Text = "Quê Quán";
            // 
            // lbl_lop
            // 
            this.lbl_lop.AutoSize = true;
            this.lbl_lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lop.Location = new System.Drawing.Point(35, 172);
            this.lbl_lop.Name = "lbl_lop";
            this.lbl_lop.Size = new System.Drawing.Size(34, 16);
            this.lbl_lop.TabIndex = 16;
            this.lbl_lop.Text = "Lớp";
            // 
            // lbl_ma
            // 
            this.lbl_ma.AutoSize = true;
            this.lbl_ma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ma.Location = new System.Drawing.Point(35, 87);
            this.lbl_ma.Name = "lbl_ma";
            this.lbl_ma.Size = new System.Drawing.Size(53, 16);
            this.lbl_ma.TabIndex = 15;
            this.lbl_ma.Text = "Mã SV";
            // 
            // lbl_ten
            // 
            this.lbl_ten.AutoSize = true;
            this.lbl_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ten.Location = new System.Drawing.Point(35, 66);
            this.lbl_ten.Name = "lbl_ten";
            this.lbl_ten.Size = new System.Drawing.Size(59, 16);
            this.lbl_ten.TabIndex = 14;
            this.lbl_ten.Text = "Họ Tên";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Navy;
            this.lbl_title.Location = new System.Drawing.Point(106, 25);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(231, 24);
            this.lbl_title.TabIndex = 13;
            this.lbl_title.Text = "THÔNG TIN SINH VIÊN";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpa_thongtin);
            this.tabControl1.Location = new System.Drawing.Point(20, 150);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(443, 238);
            this.tabControl1.TabIndex = 2;
            // 
            // User_ThongTinSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.grb_nhap);
            this.Name = "User_ThongTinSV";
            this.Size = new System.Drawing.Size(483, 391);
            this.Load += new System.EventHandler(this.User_ThongTinSV_Load);
            this.grb_nhap.ResumeLayout(false);
            this.grb_nhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_thongtinsinhvien)).EndInit();
            this.tpa_thongtin.ResumeLayout(false);
            this.tpa_thongtin.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_timkiemsv;
        private System.Windows.Forms.GroupBox grb_nhap;
        private System.Windows.Forms.DataGridView dgr_thongtinsinhvien;
        private System.Windows.Forms.Label lbl_tim;
        private System.Windows.Forms.TabPage tpa_thongtin;
        private System.Windows.Forms.Label lbl_gioitinh1;
        private System.Windows.Forms.Label lbl_quequan1;
        private System.Windows.Forms.Label lbl_ngaysinh1;
        private System.Windows.Forms.Label lbl_lop1;
        private System.Windows.Forms.Label lbl_ma1;
        private System.Windows.Forms.Label lbl_ten1;
        private System.Windows.Forms.Label lbl_ngaysinh;
        private System.Windows.Forms.Label lbl_gioitinh;
        private System.Windows.Forms.Label lbl_quequan;
        private System.Windows.Forms.Label lbl_lop;
        private System.Windows.Forms.Label lbl_ma;
        private System.Windows.Forms.Label lbl_ten;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TabControl tabControl1;
    }
}
