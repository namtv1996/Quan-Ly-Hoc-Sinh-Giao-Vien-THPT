namespace SinhVien
{
    partial class GiangVien
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_xemlichday = new System.Windows.Forms.Button();
            this.btn_hosogiangvien = new System.Windows.Forms.Button();
            this.btn_huongdangv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.btn_huongdangv);
            this.splitContainer1.Panel1.Controls.Add(this.btn_xemlichday);
            this.splitContainer1.Panel1.Controls.Add(this.btn_hosogiangvien);
            this.splitContainer1.Size = new System.Drawing.Size(701, 407);
            this.splitContainer1.SplitterDistance = 196;
            this.splitContainer1.TabIndex = 1;
            // 
            // btn_xemlichday
            // 
            this.btn_xemlichday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xemlichday.Location = new System.Drawing.Point(0, 34);
            this.btn_xemlichday.Name = "btn_xemlichday";
            this.btn_xemlichday.Size = new System.Drawing.Size(194, 35);
            this.btn_xemlichday.TabIndex = 1;
            this.btn_xemlichday.Text = ">> Xem lịch giảng dạy";
            this.btn_xemlichday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xemlichday.UseVisualStyleBackColor = true;
            this.btn_xemlichday.Click += new System.EventHandler(this.btn_xemlichday_Click);
            // 
            // btn_hosogiangvien
            // 
            this.btn_hosogiangvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hosogiangvien.Location = new System.Drawing.Point(0, 0);
            this.btn_hosogiangvien.Name = "btn_hosogiangvien";
            this.btn_hosogiangvien.Size = new System.Drawing.Size(194, 35);
            this.btn_hosogiangvien.TabIndex = 0;
            this.btn_hosogiangvien.Text = ">> Hồ sơ giảng viên";
            this.btn_hosogiangvien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hosogiangvien.UseVisualStyleBackColor = true;
            this.btn_hosogiangvien.Click += new System.EventHandler(this.btn_hosogiangvien_Click);
            // 
            // btn_huongdangv
            // 
            this.btn_huongdangv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huongdangv.Location = new System.Drawing.Point(0, 68);
            this.btn_huongdangv.Name = "btn_huongdangv";
            this.btn_huongdangv.Size = new System.Drawing.Size(194, 35);
            this.btn_huongdangv.TabIndex = 2;
            this.btn_huongdangv.Text = ">> Hướng dẫn";
            this.btn_huongdangv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_huongdangv.UseVisualStyleBackColor = true;
            this.btn_huongdangv.Click += new System.EventHandler(this.btn_huongdangv_Click);
            // 
            // GiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 407);
            this.Controls.Add(this.splitContainer1);
            this.Name = "GiangVien";
            this.Text = "GiangVien";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GiangVien_FormClosed);
            this.Load += new System.EventHandler(this.GiangVien_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_xemlichday;
        private System.Windows.Forms.Button btn_hosogiangvien;
        private System.Windows.Forms.Button btn_huongdangv;
    }
}