namespace SinhVien
{
    partial class User_thoikhoabieu
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
            this.grb_nhap = new System.Windows.Forms.GroupBox();
            this.lbl_tensv1 = new System.Windows.Forms.Label();
            this.lbl_tensv = new System.Windows.Forms.Label();
            this.btn_xem = new System.Windows.Forms.Button();
            this.lbl_tim = new System.Windows.Forms.Label();
            this.txt_timkiemsv = new System.Windows.Forms.TextBox();
            this.dgr_thoikhoabieu = new System.Windows.Forms.DataGridView();
            this.grb_nhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_thoikhoabieu)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_nhap
            // 
            this.grb_nhap.Controls.Add(this.dgr_thoikhoabieu);
            this.grb_nhap.Controls.Add(this.lbl_tensv1);
            this.grb_nhap.Controls.Add(this.lbl_tensv);
            this.grb_nhap.Controls.Add(this.btn_xem);
            this.grb_nhap.Controls.Add(this.lbl_tim);
            this.grb_nhap.Controls.Add(this.txt_timkiemsv);
            this.grb_nhap.Location = new System.Drawing.Point(24, 3);
            this.grb_nhap.Name = "grb_nhap";
            this.grb_nhap.Size = new System.Drawing.Size(443, 384);
            this.grb_nhap.TabIndex = 2;
            this.grb_nhap.TabStop = false;
            this.grb_nhap.Text = "Nhập mã sinh viên";
            // 
            // lbl_tensv1
            // 
            this.lbl_tensv1.AutoSize = true;
            this.lbl_tensv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tensv1.Location = new System.Drawing.Point(153, 78);
            this.lbl_tensv1.Name = "lbl_tensv1";
            this.lbl_tensv1.Size = new System.Drawing.Size(11, 16);
            this.lbl_tensv1.TabIndex = 8;
            this.lbl_tensv1.Text = ":";
            // 
            // lbl_tensv
            // 
            this.lbl_tensv.AutoSize = true;
            this.lbl_tensv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tensv.Location = new System.Drawing.Point(74, 78);
            this.lbl_tensv.Name = "lbl_tensv";
            this.lbl_tensv.Size = new System.Drawing.Size(62, 16);
            this.lbl_tensv.TabIndex = 7;
            this.lbl_tensv.Text = "Sinh viên";
            // 
            // btn_xem
            // 
            this.btn_xem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_xem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xem.Location = new System.Drawing.Point(338, 25);
            this.btn_xem.Name = "btn_xem";
            this.btn_xem.Size = new System.Drawing.Size(86, 32);
            this.btn_xem.TabIndex = 6;
            this.btn_xem.Text = "Xem";
            this.btn_xem.UseVisualStyleBackColor = false;
            this.btn_xem.Click += new System.EventHandler(this.btn_xem_Click);
            // 
            // lbl_tim
            // 
            this.lbl_tim.AutoSize = true;
            this.lbl_tim.BackColor = System.Drawing.Color.White;
            this.lbl_tim.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_tim.Location = new System.Drawing.Point(220, 35);
            this.lbl_tim.Name = "lbl_tim";
            this.lbl_tim.Size = new System.Drawing.Size(95, 13);
            this.lbl_tim.TabIndex = 5;
            this.lbl_tim.Text = "Nhập mã sinh viên";
            this.lbl_tim.Click += new System.EventHandler(this.lbl_tim_Click);
            // 
            // txt_timkiemsv
            // 
            this.txt_timkiemsv.Location = new System.Drawing.Point(77, 32);
            this.txt_timkiemsv.Name = "txt_timkiemsv";
            this.txt_timkiemsv.Size = new System.Drawing.Size(241, 20);
            this.txt_timkiemsv.TabIndex = 1;
            this.txt_timkiemsv.TextChanged += new System.EventHandler(this.txt_timkiemsv_TextChanged);
            // 
            // dgr_thoikhoabieu
            // 
            this.dgr_thoikhoabieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_thoikhoabieu.Location = new System.Drawing.Point(0, 131);
            this.dgr_thoikhoabieu.Name = "dgr_thoikhoabieu";
            this.dgr_thoikhoabieu.Size = new System.Drawing.Size(443, 253);
            this.dgr_thoikhoabieu.TabIndex = 9;
 
            // 
            // User_thoikhoabieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grb_nhap);
            this.Name = "User_thoikhoabieu";
            this.Size = new System.Drawing.Size(500, 400);
            this.Load += new System.EventHandler(this.User_thoikhoabieu_Load);
            this.grb_nhap.ResumeLayout(false);
            this.grb_nhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_thoikhoabieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_nhap;
        private System.Windows.Forms.Label lbl_tim;
        private System.Windows.Forms.TextBox txt_timkiemsv;
        private System.Windows.Forms.Button btn_xem;
        private System.Windows.Forms.Label lbl_tensv1;
        private System.Windows.Forms.Label lbl_tensv;
        private System.Windows.Forms.DataGridView dgr_thoikhoabieu;
    }
}
