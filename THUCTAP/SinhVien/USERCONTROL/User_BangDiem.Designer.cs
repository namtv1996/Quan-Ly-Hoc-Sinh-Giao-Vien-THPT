namespace SinhVien
{
    partial class User_BangDiem
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
            this.dgr_bangdiem = new System.Windows.Forms.DataGridView();
            this.grb_thongtinsv = new System.Windows.Forms.GroupBox();
            this.btn_xem = new System.Windows.Forms.Button();
            this.lbl_tim = new System.Windows.Forms.Label();
            this.txt_timkiemsv = new System.Windows.Forms.TextBox();
            this.lbl_masv1 = new System.Windows.Forms.Label();
            this.lbl_namhoc1 = new System.Windows.Forms.Label();
            this.lbl_sinhvien1 = new System.Windows.Forms.Label();
            this.lbl_diemtichluy = new System.Windows.Forms.Label();
            this.lbl_masv = new System.Windows.Forms.Label();
            this.lbl_sinhvien = new System.Windows.Forms.Label();
            this.lbl_ketquahoctap = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_bangdiem)).BeginInit();
            this.grb_thongtinsv.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgr_bangdiem
            // 
            this.dgr_bangdiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_bangdiem.Location = new System.Drawing.Point(19, 199);
            this.dgr_bangdiem.Name = "dgr_bangdiem";
            this.dgr_bangdiem.Size = new System.Drawing.Size(463, 198);
            this.dgr_bangdiem.TabIndex = 9;
            this.dgr_bangdiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgr_bangdiem_CellContentClick);
            // 
            // grb_thongtinsv
            // 
            this.grb_thongtinsv.Controls.Add(this.btn_xem);
            this.grb_thongtinsv.Controls.Add(this.lbl_tim);
            this.grb_thongtinsv.Controls.Add(this.txt_timkiemsv);
            this.grb_thongtinsv.Controls.Add(this.lbl_masv1);
            this.grb_thongtinsv.Controls.Add(this.lbl_namhoc1);
            this.grb_thongtinsv.Controls.Add(this.lbl_sinhvien1);
            this.grb_thongtinsv.Controls.Add(this.lbl_diemtichluy);
            this.grb_thongtinsv.Controls.Add(this.lbl_masv);
            this.grb_thongtinsv.Controls.Add(this.lbl_sinhvien);
            this.grb_thongtinsv.Controls.Add(this.lbl_ketquahoctap);
            this.grb_thongtinsv.Location = new System.Drawing.Point(19, 3);
            this.grb_thongtinsv.Name = "grb_thongtinsv";
            this.grb_thongtinsv.Size = new System.Drawing.Size(463, 175);
            this.grb_thongtinsv.TabIndex = 10;
            this.grb_thongtinsv.TabStop = false;
            this.grb_thongtinsv.Text = "Thông tin";
            // 
            // btn_xem
            // 
            this.btn_xem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_xem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xem.Location = new System.Drawing.Point(357, 47);
            this.btn_xem.Name = "btn_xem";
            this.btn_xem.Size = new System.Drawing.Size(86, 32);
            this.btn_xem.TabIndex = 20;
            this.btn_xem.Text = "Xem";
            this.btn_xem.UseVisualStyleBackColor = false;
            this.btn_xem.Click += new System.EventHandler(this.btn_xem_Click);
            // 
            // lbl_tim
            // 
            this.lbl_tim.AutoSize = true;
            this.lbl_tim.BackColor = System.Drawing.Color.White;
            this.lbl_tim.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_tim.Location = new System.Drawing.Point(239, 57);
            this.lbl_tim.Name = "lbl_tim";
            this.lbl_tim.Size = new System.Drawing.Size(95, 13);
            this.lbl_tim.TabIndex = 19;
            this.lbl_tim.Text = "Nhập mã sinh viên";
            this.lbl_tim.Click += new System.EventHandler(this.lbl_tim_Click);
            // 
            // txt_timkiemsv
            // 
            this.txt_timkiemsv.Location = new System.Drawing.Point(141, 54);
            this.txt_timkiemsv.Name = "txt_timkiemsv";
            this.txt_timkiemsv.Size = new System.Drawing.Size(196, 20);
            this.txt_timkiemsv.TabIndex = 18;
            this.txt_timkiemsv.TextChanged += new System.EventHandler(this.txt_timkiemsv_TextChanged);
            // 
            // lbl_masv1
            // 
            this.lbl_masv1.AutoSize = true;
            this.lbl_masv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_masv1.ForeColor = System.Drawing.Color.Black;
            this.lbl_masv1.Location = new System.Drawing.Point(132, 136);
            this.lbl_masv1.Name = "lbl_masv1";
            this.lbl_masv1.Size = new System.Drawing.Size(11, 16);
            this.lbl_masv1.TabIndex = 16;
            this.lbl_masv1.Text = ":";
            // 
            // lbl_namhoc1
            // 
            this.lbl_namhoc1.AutoSize = true;
            this.lbl_namhoc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_namhoc1.ForeColor = System.Drawing.Color.Black;
            this.lbl_namhoc1.Location = new System.Drawing.Point(354, 136);
            this.lbl_namhoc1.Name = "lbl_namhoc1";
            this.lbl_namhoc1.Size = new System.Drawing.Size(11, 16);
            this.lbl_namhoc1.TabIndex = 15;
            this.lbl_namhoc1.Text = ":";
            // 
            // lbl_sinhvien1
            // 
            this.lbl_sinhvien1.AutoSize = true;
            this.lbl_sinhvien1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sinhvien1.ForeColor = System.Drawing.Color.Black;
            this.lbl_sinhvien1.Location = new System.Drawing.Point(132, 100);
            this.lbl_sinhvien1.Name = "lbl_sinhvien1";
            this.lbl_sinhvien1.Size = new System.Drawing.Size(11, 16);
            this.lbl_sinhvien1.TabIndex = 14;
            this.lbl_sinhvien1.Text = ":";
            // 
            // lbl_diemtichluy
            // 
            this.lbl_diemtichluy.AutoSize = true;
            this.lbl_diemtichluy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_diemtichluy.ForeColor = System.Drawing.Color.Black;
            this.lbl_diemtichluy.Location = new System.Drawing.Point(260, 136);
            this.lbl_diemtichluy.Name = "lbl_diemtichluy";
            this.lbl_diemtichluy.Size = new System.Drawing.Size(82, 16);
            this.lbl_diemtichluy.TabIndex = 13;
            this.lbl_diemtichluy.Text = "Điểm tích lũy";
            // 
            // lbl_masv
            // 
            this.lbl_masv.AutoSize = true;
            this.lbl_masv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_masv.ForeColor = System.Drawing.Color.Black;
            this.lbl_masv.Location = new System.Drawing.Point(23, 136);
            this.lbl_masv.Name = "lbl_masv";
            this.lbl_masv.Size = new System.Drawing.Size(82, 16);
            this.lbl_masv.TabIndex = 11;
            this.lbl_masv.Text = "Mã sinh viên";
            // 
            // lbl_sinhvien
            // 
            this.lbl_sinhvien.AutoSize = true;
            this.lbl_sinhvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sinhvien.ForeColor = System.Drawing.Color.Black;
            this.lbl_sinhvien.Location = new System.Drawing.Point(23, 100);
            this.lbl_sinhvien.Name = "lbl_sinhvien";
            this.lbl_sinhvien.Size = new System.Drawing.Size(64, 16);
            this.lbl_sinhvien.TabIndex = 10;
            this.lbl_sinhvien.Text = "Sinh Viên";
            // 
            // lbl_ketquahoctap
            // 
            this.lbl_ketquahoctap.AutoSize = true;
            this.lbl_ketquahoctap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_ketquahoctap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ketquahoctap.ForeColor = System.Drawing.Color.Black;
            this.lbl_ketquahoctap.Location = new System.Drawing.Point(137, 16);
            this.lbl_ketquahoctap.Name = "lbl_ketquahoctap";
            this.lbl_ketquahoctap.Size = new System.Drawing.Size(166, 20);
            this.lbl_ketquahoctap.TabIndex = 9;
            this.lbl_ketquahoctap.Text = "KẾT QUẢ HỌC TẬP";
            // 
            // User_BangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.grb_thongtinsv);
            this.Controls.Add(this.dgr_bangdiem);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "User_BangDiem";
            this.Size = new System.Drawing.Size(500, 400);
            this.Load += new System.EventHandler(this.User_BangDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgr_bangdiem)).EndInit();
            this.grb_thongtinsv.ResumeLayout(false);
            this.grb_thongtinsv.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgr_bangdiem;
        private System.Windows.Forms.GroupBox grb_thongtinsv;
        private System.Windows.Forms.Label lbl_masv1;
        private System.Windows.Forms.Label lbl_namhoc1;
        private System.Windows.Forms.Label lbl_sinhvien1;
        private System.Windows.Forms.Label lbl_diemtichluy;
        private System.Windows.Forms.Label lbl_masv;
        private System.Windows.Forms.Label lbl_sinhvien;
        private System.Windows.Forms.Label lbl_ketquahoctap;
        private System.Windows.Forms.Button btn_xem;
        private System.Windows.Forms.Label lbl_tim;
        private System.Windows.Forms.TextBox txt_timkiemsv;
    }
}
