namespace test2
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
            this.lbNhap = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.radVang = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkchan = new System.Windows.Forms.CheckBox();
            this.chkNghieng = new System.Windows.Forms.CheckBox();
            this.chkDam = new System.Windows.Forms.CheckBox();
            this.lbHienThi = new System.Windows.Forms.Label();
            this.lbKQ = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNhap
            // 
            this.lbNhap.AutoSize = true;
            this.lbNhap.Location = new System.Drawing.Point(52, 44);
            this.lbNhap.Name = "lbNhap";
            this.lbNhap.Size = new System.Drawing.Size(40, 16);
            this.lbNhap.TabIndex = 0;
            this.lbNhap.Text = "Nhap";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(176, 37);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(295, 22);
            this.txtNhap.TabIndex = 1;
            this.txtNhap.TextChanged += new System.EventHandler(this.txtNhap_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.radBlue);
            this.groupBox1.Controls.Add(this.radRed);
            this.groupBox1.Controls.Add(this.radVang);
            this.groupBox1.Location = new System.Drawing.Point(55, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "color";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.ForeColor = System.Drawing.Color.Blue;
            this.radBlue.Location = new System.Drawing.Point(7, 74);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(56, 20);
            this.radBlue.TabIndex = 2;
            this.radBlue.TabStop = true;
            this.radBlue.Text = "xanh";
            this.radBlue.UseVisualStyleBackColor = true;
            this.radBlue.CheckedChanged += new System.EventHandler(this.radBlue_CheckedChanged);
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.ForeColor = System.Drawing.Color.Red;
            this.radRed.Location = new System.Drawing.Point(7, 49);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(44, 20);
            this.radRed.TabIndex = 1;
            this.radRed.TabStop = true;
            this.radRed.Text = "do";
            this.radRed.UseVisualStyleBackColor = true;
            this.radRed.CheckedChanged += new System.EventHandler(this.radRed_CheckedChanged);
            // 
            // radVang
            // 
            this.radVang.AutoSize = true;
            this.radVang.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radVang.ForeColor = System.Drawing.Color.Yellow;
            this.radVang.Location = new System.Drawing.Point(7, 22);
            this.radVang.Name = "radVang";
            this.radVang.Size = new System.Drawing.Size(58, 20);
            this.radVang.TabIndex = 0;
            this.radVang.TabStop = true;
            this.radVang.Text = "vang";
            this.radVang.UseVisualStyleBackColor = true;
            this.radVang.CheckedChanged += new System.EventHandler(this.radVang_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkchan);
            this.groupBox2.Controls.Add(this.chkNghieng);
            this.groupBox2.Controls.Add(this.chkDam);
            this.groupBox2.Location = new System.Drawing.Point(271, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "font";
            // 
            // chkchan
            // 
            this.chkchan.AutoSize = true;
            this.chkchan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkchan.Location = new System.Drawing.Point(7, 75);
            this.chkchan.Name = "chkchan";
            this.chkchan.Size = new System.Drawing.Size(91, 20);
            this.chkchan.TabIndex = 2;
            this.chkchan.Text = "gach chan";
            this.chkchan.UseVisualStyleBackColor = true;
            this.chkchan.CheckedChanged += new System.EventHandler(this.chkchan_CheckedChanged);
            // 
            // chkNghieng
            // 
            this.chkNghieng.AutoSize = true;
            this.chkNghieng.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNghieng.Location = new System.Drawing.Point(6, 48);
            this.chkNghieng.Name = "chkNghieng";
            this.chkNghieng.Size = new System.Drawing.Size(82, 20);
            this.chkNghieng.TabIndex = 1;
            this.chkNghieng.Text = "in nghien";
            this.chkNghieng.UseVisualStyleBackColor = true;
            this.chkNghieng.CheckedChanged += new System.EventHandler(this.chkNghieng_CheckedChanged);
            // 
            // chkDam
            // 
            this.chkDam.AutoSize = true;
            this.chkDam.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDam.Location = new System.Drawing.Point(7, 22);
            this.chkDam.Name = "chkDam";
            this.chkDam.Size = new System.Drawing.Size(75, 20);
            this.chkDam.TabIndex = 0;
            this.chkDam.Text = "in dam";
            this.chkDam.UseVisualStyleBackColor = true;
            this.chkDam.CheckedChanged += new System.EventHandler(this.chkDam_CheckedChanged);
            // 
            // lbHienThi
            // 
            this.lbHienThi.AutoSize = true;
            this.lbHienThi.Location = new System.Drawing.Point(52, 327);
            this.lbHienThi.Name = "lbHienThi";
            this.lbHienThi.Size = new System.Drawing.Size(54, 16);
            this.lbHienThi.TabIndex = 4;
            this.lbHienThi.Text = "HienThi";
            // 
            // lbKQ
            // 
            this.lbKQ.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbKQ.Location = new System.Drawing.Point(121, 324);
            this.lbKQ.Name = "lbKQ";
            this.lbKQ.Size = new System.Drawing.Size(238, 23);
            this.lbKQ.TabIndex = 5;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(396, 324);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(55, 100);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(240, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 381);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lbKQ);
            this.Controls.Add(this.lbHienThi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.lbNhap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNhap;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.RadioButton radVang;
        private System.Windows.Forms.CheckBox chkchan;
        private System.Windows.Forms.CheckBox chkNghieng;
        private System.Windows.Forms.CheckBox chkDam;
        private System.Windows.Forms.Label lbHienThi;
        private System.Windows.Forms.Label lbKQ;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

