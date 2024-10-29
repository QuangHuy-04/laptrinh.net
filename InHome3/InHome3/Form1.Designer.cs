namespace InHome3
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
            this.components = new System.ComponentModel.Container();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtTuoi = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbTuoi = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.dtpDate);
            this.grbThongTin.Controls.Add(this.txtTuoi);
            this.grbThongTin.Controls.Add(this.txtPhone);
            this.grbThongTin.Controls.Add(this.lbDate);
            this.grbThongTin.Controls.Add(this.lbTuoi);
            this.grbThongTin.Controls.Add(this.lbPhone);
            this.grbThongTin.Location = new System.Drawing.Point(48, 61);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(362, 171);
            this.grbThongTin.TabIndex = 0;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "thong tin";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(123, 106);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(192, 22);
            this.dtpDate.TabIndex = 5;
            this.dtpDate.Value = new System.DateTime(2024, 10, 24, 9, 44, 15, 0);
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // txtTuoi
            // 
            this.txtTuoi.Location = new System.Drawing.Point(123, 71);
            this.txtTuoi.Name = "txtTuoi";
            this.txtTuoi.Size = new System.Drawing.Size(192, 22);
            this.txtTuoi.TabIndex = 4;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(123, 31);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(192, 22);
            this.txtPhone.TabIndex = 3;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(21, 106);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(74, 16);
            this.lbDate.TabIndex = 2;
            this.lbDate.Text = "Ngay xem :";
            // 
            // lbTuoi
            // 
            this.lbTuoi.AutoSize = true;
            this.lbTuoi.Location = new System.Drawing.Point(21, 71);
            this.lbTuoi.Name = "lbTuoi";
            this.lbTuoi.Size = new System.Drawing.Size(34, 16);
            this.lbTuoi.TabIndex = 1;
            this.lbTuoi.Text = "tuoi :";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(21, 37);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(51, 16);
            this.lbPhone.TabIndex = 0;
            this.lbPhone.Text = "phone :";
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(210, 263);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(91, 35);
            this.btnDangKy.TabIndex = 1;
            this.btnDangKy.Text = "Dang ky";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 351);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.grbThongTin);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtTuoi;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbTuoi;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

