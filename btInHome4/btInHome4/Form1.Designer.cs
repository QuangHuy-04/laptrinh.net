namespace btInHome4
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.grbDanhSach = new System.Windows.Forms.GroupBox();
            this.lstSo = new System.Windows.Forms.ListBox();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnXoaDC = new System.Windows.Forms.Button();
            this.btnXoaChon = new System.Windows.Forms.Button();
            this.btnTang = new System.Windows.Forms.Button();
            this.btnBP = new System.Windows.Forms.Button();
            this.btnChan = new System.Windows.Forms.Button();
            this.btnLe = new System.Windows.Forms.Button();
            this.grbChucNang.SuspendLayout();
            this.grbDanhSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNhap
            // 
            this.lbNhap.AutoSize = true;
            this.lbNhap.Location = new System.Drawing.Point(40, 24);
            this.lbNhap.Name = "lbNhap";
            this.lbNhap.Size = new System.Drawing.Size(43, 16);
            this.lbNhap.TabIndex = 0;
            this.lbNhap.Text = "nhap :";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(123, 21);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(236, 22);
            this.txtNhap.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(400, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btnLe);
            this.grbChucNang.Controls.Add(this.btnChan);
            this.grbChucNang.Controls.Add(this.btnBP);
            this.grbChucNang.Controls.Add(this.btnTang);
            this.grbChucNang.Controls.Add(this.btnXoaChon);
            this.grbChucNang.Controls.Add(this.btnXoaDC);
            this.grbChucNang.Controls.Add(this.btnTong);
            this.grbChucNang.Location = new System.Drawing.Point(368, 73);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(192, 261);
            this.grbChucNang.TabIndex = 4;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "chuc nang";
            this.grbChucNang.Enter += new System.EventHandler(this.grbChucNang_Enter);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Location = new System.Drawing.Point(43, 361);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(517, 23);
            this.btnKetThuc.TabIndex = 0;
            this.btnKetThuc.Text = "ket thuc";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // grbDanhSach
            // 
            this.grbDanhSach.Controls.Add(this.lstSo);
            this.grbDanhSach.Location = new System.Drawing.Point(43, 73);
            this.grbDanhSach.Name = "grbDanhSach";
            this.grbDanhSach.Size = new System.Drawing.Size(325, 260);
            this.grbDanhSach.TabIndex = 5;
            this.grbDanhSach.TabStop = false;
            this.grbDanhSach.Text = "danh sach so";
            // 
            // lstSo
            // 
            this.lstSo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSo.FormattingEnabled = true;
            this.lstSo.ItemHeight = 16;
            this.lstSo.Location = new System.Drawing.Point(3, 18);
            this.lstSo.Name = "lstSo";
            this.lstSo.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstSo.Size = new System.Drawing.Size(319, 239);
            this.lstSo.TabIndex = 0;
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(7, 31);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(179, 23);
            this.btnTong.TabIndex = 0;
            this.btnTong.Text = "Tổng";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnXoaDC
            // 
            this.btnXoaDC.Location = new System.Drawing.Point(7, 61);
            this.btnXoaDC.Name = "btnXoaDC";
            this.btnXoaDC.Size = new System.Drawing.Size(179, 23);
            this.btnXoaDC.TabIndex = 1;
            this.btnXoaDC.Text = "Xoa phan tu đầu và cuối";
            this.btnXoaDC.UseVisualStyleBackColor = true;
            this.btnXoaDC.Click += new System.EventHandler(this.btnXoaDC_Click);
            // 
            // btnXoaChon
            // 
            this.btnXoaChon.Location = new System.Drawing.Point(7, 91);
            this.btnXoaChon.Name = "btnXoaChon";
            this.btnXoaChon.Size = new System.Drawing.Size(179, 23);
            this.btnXoaChon.TabIndex = 2;
            this.btnXoaChon.Text = "Xóa phan tử đang chọn";
            this.btnXoaChon.UseVisualStyleBackColor = true;
            this.btnXoaChon.Click += new System.EventHandler(this.btnXoaChon_Click);
            // 
            // btnTang
            // 
            this.btnTang.Location = new System.Drawing.Point(7, 121);
            this.btnTang.Name = "btnTang";
            this.btnTang.Size = new System.Drawing.Size(179, 23);
            this.btnTang.TabIndex = 3;
            this.btnTang.Text = "tăng mỗi phần tử lên 2 dv";
            this.btnTang.UseVisualStyleBackColor = true;
            this.btnTang.Click += new System.EventHandler(this.btnTang_Click);
            // 
            // btnBP
            // 
            this.btnBP.Location = new System.Drawing.Point(7, 151);
            this.btnBP.Name = "btnBP";
            this.btnBP.Size = new System.Drawing.Size(179, 23);
            this.btnBP.TabIndex = 4;
            this.btnBP.Text = "binh phương";
            this.btnBP.UseVisualStyleBackColor = true;
            this.btnBP.Click += new System.EventHandler(this.btnBP_Click);
            // 
            // btnChan
            // 
            this.btnChan.Location = new System.Drawing.Point(7, 181);
            this.btnChan.Name = "btnChan";
            this.btnChan.Size = new System.Drawing.Size(179, 23);
            this.btnChan.TabIndex = 5;
            this.btnChan.Text = "chọn số chẵn";
            this.btnChan.UseVisualStyleBackColor = true;
            this.btnChan.Click += new System.EventHandler(this.btnChan_Click);
            // 
            // btnLe
            // 
            this.btnLe.Location = new System.Drawing.Point(7, 211);
            this.btnLe.Name = "btnLe";
            this.btnLe.Size = new System.Drawing.Size(179, 23);
            this.btnLe.TabIndex = 6;
            this.btnLe.Text = "chọn số lẻ";
            this.btnLe.UseVisualStyleBackColor = true;
            this.btnLe.Click += new System.EventHandler(this.btnLe_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 417);
            this.Controls.Add(this.grbDanhSach);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.lbNhap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbChucNang.ResumeLayout(false);
            this.grbDanhSach.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNhap;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.GroupBox grbDanhSach;
        private System.Windows.Forms.ListBox lstSo;
        private System.Windows.Forms.Button btnLe;
        private System.Windows.Forms.Button btnChan;
        private System.Windows.Forms.Button btnBP;
        private System.Windows.Forms.Button btnTang;
        private System.Windows.Forms.Button btnXoaChon;
        private System.Windows.Forms.Button btnXoaDC;
        private System.Windows.Forms.Button btnTong;
    }
}

