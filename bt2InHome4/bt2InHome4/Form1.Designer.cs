namespace bt2InHome4
{
    partial class Form1
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
            this.lbMa = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lstDanhSach = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbMa
            // 
            this.lbMa.AutoSize = true;
            this.lbMa.Location = new System.Drawing.Point(53, 29);
            this.lbMa.Name = "lbMa";
            this.lbMa.Size = new System.Drawing.Size(32, 16);
            this.lbMa.TabIndex = 0;
            this.lbMa.Text = "Ma :";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(53, 73);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(31, 16);
            this.lbTen.TabIndex = 1;
            this.lbTen.Text = "Ten";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(140, 26);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(294, 22);
            this.txtMa.TabIndex = 2;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(140, 70);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(294, 22);
            this.txtTen.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(176, 117);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 35);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(303, 117);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 35);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lstDanhSach
            // 
            this.lstDanhSach.FormattingEnabled = true;
            this.lstDanhSach.ItemHeight = 16;
            this.lstDanhSach.Location = new System.Drawing.Point(56, 179);
            this.lstDanhSach.Name = "lstDanhSach";
            this.lstDanhSach.Size = new System.Drawing.Size(378, 212);
            this.lstDanhSach.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 429);
            this.Controls.Add(this.lstDanhSach);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.lbMa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMa;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ListBox lstDanhSach;
    }
}

