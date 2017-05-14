namespace SinhVien
{
    partial class portalsinhvien
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
            this.btn_huogndansv = new System.Windows.Forms.Button();
            this.btn_ketquahoctap = new System.Windows.Forms.Button();
            this.btn_xemthoikhoabieu = new System.Windows.Forms.Button();
            this.btn_hososinhvien = new System.Windows.Forms.Button();
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
            this.splitContainer1.Panel1.Controls.Add(this.btn_huogndansv);
            this.splitContainer1.Panel1.Controls.Add(this.btn_ketquahoctap);
            this.splitContainer1.Panel1.Controls.Add(this.btn_xemthoikhoabieu);
            this.splitContainer1.Panel1.Controls.Add(this.btn_hososinhvien);
            this.splitContainer1.Size = new System.Drawing.Size(721, 407);
            this.splitContainer1.SplitterDistance = 215;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_huogndansv
            // 
            this.btn_huogndansv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huogndansv.Location = new System.Drawing.Point(2, 102);
            this.btn_huogndansv.Name = "btn_huogndansv";
            this.btn_huogndansv.Size = new System.Drawing.Size(210, 35);
            this.btn_huogndansv.TabIndex = 5;
            this.btn_huogndansv.Text = ">> Hướng dẫn";
            this.btn_huogndansv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_huogndansv.UseVisualStyleBackColor = true;
            this.btn_huogndansv.Click += new System.EventHandler(this.btn_huogndansv_Click);
            // 
            // btn_ketquahoctap
            // 
            this.btn_ketquahoctap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ketquahoctap.Location = new System.Drawing.Point(2, 68);
            this.btn_ketquahoctap.Name = "btn_ketquahoctap";
            this.btn_ketquahoctap.Size = new System.Drawing.Size(210, 35);
            this.btn_ketquahoctap.TabIndex = 4;
            this.btn_ketquahoctap.Text = ">> Kết quả học tập";
            this.btn_ketquahoctap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ketquahoctap.UseVisualStyleBackColor = true;
            this.btn_ketquahoctap.Click += new System.EventHandler(this.btn_ketquahoctap_Click);
            // 
            // btn_xemthoikhoabieu
            // 
            this.btn_xemthoikhoabieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xemthoikhoabieu.Location = new System.Drawing.Point(2, 34);
            this.btn_xemthoikhoabieu.Name = "btn_xemthoikhoabieu";
            this.btn_xemthoikhoabieu.Size = new System.Drawing.Size(210, 35);
            this.btn_xemthoikhoabieu.TabIndex = 1;
            this.btn_xemthoikhoabieu.Text = ">> Xem thời khóa biểu";
            this.btn_xemthoikhoabieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xemthoikhoabieu.UseVisualStyleBackColor = true;
            this.btn_xemthoikhoabieu.Click += new System.EventHandler(this.btn_xemthoikhoabieu_Click);
            // 
            // btn_hososinhvien
            // 
            this.btn_hososinhvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hososinhvien.Location = new System.Drawing.Point(2, 0);
            this.btn_hososinhvien.Name = "btn_hososinhvien";
            this.btn_hososinhvien.Size = new System.Drawing.Size(210, 35);
            this.btn_hososinhvien.TabIndex = 0;
            this.btn_hososinhvien.Text = ">> Hồ sơ sinh viên";
            this.btn_hososinhvien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hososinhvien.UseVisualStyleBackColor = true;
            this.btn_hososinhvien.Click += new System.EventHandler(this.btn_hososinhvien_Click);
            // 
            // portalsinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 407);
            this.Controls.Add(this.splitContainer1);
            this.Name = "portalsinhvien";
            this.Text = "PORTAL SINH VIÊN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.portalsinhvien_FormClosing);
            this.Load += new System.EventHandler(this.portalsinhvien_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_xemthoikhoabieu;
        private System.Windows.Forms.Button btn_hososinhvien;
        private System.Windows.Forms.Button btn_huogndansv;
        private System.Windows.Forms.Button btn_ketquahoctap;
    }
}