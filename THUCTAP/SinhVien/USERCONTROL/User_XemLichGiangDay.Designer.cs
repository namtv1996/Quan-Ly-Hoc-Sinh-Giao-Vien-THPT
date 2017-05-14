namespace SinhVien
{
    partial class User_XemLichGiangDay
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grb_thongtinsv = new System.Windows.Forms.GroupBox();
            this.lbl_timkiemnamhoc = new System.Windows.Forms.Label();
            this.lbl_timkiemhocki = new System.Windows.Forms.Label();
            this.txt_nhapnamhoc = new System.Windows.Forms.TextBox();
            this.txt_nhaphocki = new System.Windows.Forms.TextBox();
            this.lbl_nhapmagv = new System.Windows.Forms.Label();
            this.btn_xem = new System.Windows.Forms.Button();
            this.txt_nhapmagv = new System.Windows.Forms.TextBox();
            this.lbl_lichday = new System.Windows.Forms.Label();
            this.dgr_lichgiangday = new System.Windows.Forms.DataGridView();
            this.lbl_goiynam = new System.Windows.Forms.Label();
            this.lbl_goiyhocki = new System.Windows.Forms.Label();
            this.grb_thongtinsv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_lichgiangday)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_thongtinsv
            // 
            this.grb_thongtinsv.Controls.Add(this.lbl_goiyhocki);
            this.grb_thongtinsv.Controls.Add(this.lbl_goiynam);
            this.grb_thongtinsv.Controls.Add(this.lbl_timkiemnamhoc);
            this.grb_thongtinsv.Controls.Add(this.lbl_timkiemhocki);
            this.grb_thongtinsv.Controls.Add(this.txt_nhapnamhoc);
            this.grb_thongtinsv.Controls.Add(this.txt_nhaphocki);
            this.grb_thongtinsv.Controls.Add(this.lbl_nhapmagv);
            this.grb_thongtinsv.Controls.Add(this.btn_xem);
            this.grb_thongtinsv.Controls.Add(this.txt_nhapmagv);
            this.grb_thongtinsv.Controls.Add(this.lbl_lichday);
            this.grb_thongtinsv.Location = new System.Drawing.Point(19, 3);
            this.grb_thongtinsv.Name = "grb_thongtinsv";
            this.grb_thongtinsv.Size = new System.Drawing.Size(463, 175);
            this.grb_thongtinsv.TabIndex = 12;
            this.grb_thongtinsv.TabStop = false;
            this.grb_thongtinsv.Text = "Thông tin";
            // 
            // lbl_timkiemnamhoc
            // 
            this.lbl_timkiemnamhoc.AutoSize = true;
            this.lbl_timkiemnamhoc.Location = new System.Drawing.Point(157, 65);
            this.lbl_timkiemnamhoc.Name = "lbl_timkiemnamhoc";
            this.lbl_timkiemnamhoc.Size = new System.Drawing.Size(50, 13);
            this.lbl_timkiemnamhoc.TabIndex = 25;
            this.lbl_timkiemnamhoc.Text = "Năm học";
            // 
            // lbl_timkiemhocki
            // 
            this.lbl_timkiemhocki.AutoSize = true;
            this.lbl_timkiemhocki.Location = new System.Drawing.Point(273, 65);
            this.lbl_timkiemhocki.Name = "lbl_timkiemhocki";
            this.lbl_timkiemhocki.Size = new System.Drawing.Size(38, 13);
            this.lbl_timkiemhocki.TabIndex = 24;
            this.lbl_timkiemhocki.Text = "Học kì";
            // 
            // txt_nhapnamhoc
            // 
            this.txt_nhapnamhoc.Location = new System.Drawing.Point(131, 81);
            this.txt_nhapnamhoc.Name = "txt_nhapnamhoc";
            this.txt_nhapnamhoc.Size = new System.Drawing.Size(99, 20);
            this.txt_nhapnamhoc.TabIndex = 19;
            this.txt_nhapnamhoc.TextChanged += new System.EventHandler(this.txt_nhapnamhoc_TextChanged);
            // 
            // txt_nhaphocki
            // 
            this.txt_nhaphocki.Location = new System.Drawing.Point(243, 81);
            this.txt_nhaphocki.Name = "txt_nhaphocki";
            this.txt_nhaphocki.Size = new System.Drawing.Size(99, 20);
            this.txt_nhaphocki.TabIndex = 20;
            this.txt_nhaphocki.TextChanged += new System.EventHandler(this.txt_nhaphocki_TextChanged);
            // 
            // lbl_nhapmagv
            // 
            this.lbl_nhapmagv.AutoSize = true;
            this.lbl_nhapmagv.Location = new System.Drawing.Point(44, 65);
            this.lbl_nhapmagv.Name = "lbl_nhapmagv";
            this.lbl_nhapmagv.Size = new System.Drawing.Size(40, 13);
            this.lbl_nhapmagv.TabIndex = 21;
            this.lbl_nhapmagv.Text = "Mã GV";
            // 
            // btn_xem
            // 
            this.btn_xem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_xem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xem.Location = new System.Drawing.Point(357, 74);
            this.btn_xem.Name = "btn_xem";
            this.btn_xem.Size = new System.Drawing.Size(86, 32);
            this.btn_xem.TabIndex = 20;
            this.btn_xem.Text = "Xem";
            this.btn_xem.UseVisualStyleBackColor = false;
            this.btn_xem.Click += new System.EventHandler(this.btn_xem_Click);
            // 
            // txt_nhapmagv
            // 
            this.txt_nhapmagv.Location = new System.Drawing.Point(16, 81);
            this.txt_nhapmagv.Name = "txt_nhapmagv";
            this.txt_nhapmagv.Size = new System.Drawing.Size(99, 20);
            this.txt_nhapmagv.TabIndex = 18;
            // 
            // lbl_lichday
            // 
            this.lbl_lichday.AutoSize = true;
            this.lbl_lichday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_lichday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lichday.ForeColor = System.Drawing.Color.Black;
            this.lbl_lichday.Location = new System.Drawing.Point(143, 16);
            this.lbl_lichday.Name = "lbl_lichday";
            this.lbl_lichday.Size = new System.Drawing.Size(160, 20);
            this.lbl_lichday.TabIndex = 9;
            this.lbl_lichday.Text = "LỊCH GIẢNG DẠY ";
            // 
            // dgr_lichgiangday
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgr_lichgiangday.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgr_lichgiangday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgr_lichgiangday.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgr_lichgiangday.Location = new System.Drawing.Point(19, 199);
            this.dgr_lichgiangday.Name = "dgr_lichgiangday";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgr_lichgiangday.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgr_lichgiangday.Size = new System.Drawing.Size(463, 198);
            this.dgr_lichgiangday.TabIndex = 11;
            this.dgr_lichgiangday.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgr_lichgiangday_CellContentClick);
            // 
            // lbl_goiynam
            // 
            this.lbl_goiynam.AutoSize = true;
            this.lbl_goiynam.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_goiynam.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_goiynam.Location = new System.Drawing.Point(170, 84);
            this.lbl_goiynam.Name = "lbl_goiynam";
            this.lbl_goiynam.Size = new System.Drawing.Size(56, 13);
            this.lbl_goiynam.TabIndex = 13;
            this.lbl_goiynam.Text = "yyyy - yyyy";
            this.lbl_goiynam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_goiynam.Click += new System.EventHandler(this.lbl_goiynam_Click);
            // 
            // lbl_goiyhocki
            // 
            this.lbl_goiyhocki.AutoSize = true;
            this.lbl_goiyhocki.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_goiyhocki.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_goiyhocki.Location = new System.Drawing.Point(307, 84);
            this.lbl_goiyhocki.Name = "lbl_goiyhocki";
            this.lbl_goiyhocki.Size = new System.Drawing.Size(31, 13);
            this.lbl_goiyhocki.TabIndex = 26;
            this.lbl_goiyhocki.Text = "HK ?";
            this.lbl_goiyhocki.Click += new System.EventHandler(this.lbl_goiyhocki_Click);
            // 
            // User_XemLichGiangDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grb_thongtinsv);
            this.Controls.Add(this.dgr_lichgiangday);
            this.Name = "User_XemLichGiangDay";
            this.Size = new System.Drawing.Size(500, 400);
            this.Load += new System.EventHandler(this.User_XemLichGiangDay_Load);
            this.grb_thongtinsv.ResumeLayout(false);
            this.grb_thongtinsv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_lichgiangday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_thongtinsv;
        private System.Windows.Forms.Label lbl_timkiemnamhoc;
        private System.Windows.Forms.Label lbl_timkiemhocki;
        private System.Windows.Forms.TextBox txt_nhapnamhoc;
        private System.Windows.Forms.TextBox txt_nhaphocki;
        private System.Windows.Forms.Label lbl_nhapmagv;
        private System.Windows.Forms.Button btn_xem;
        private System.Windows.Forms.TextBox txt_nhapmagv;
        private System.Windows.Forms.Label lbl_lichday;
        private System.Windows.Forms.DataGridView dgr_lichgiangday;
        private System.Windows.Forms.Label lbl_goiynam;
        private System.Windows.Forms.Label lbl_goiyhocki;
    }
}
