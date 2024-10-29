namespace buoi10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbA = new Label();
            lbB = new Label();
            lbC = new Label();
            txtA = new TextBox();
            txtC = new TextBox();
            txtB = new TextBox();
            btbTong = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            btnMes = new Button();
            SuspendLayout();
            // 
            // lbA
            // 
            lbA.AutoSize = true;
            lbA.Location = new Point(74, 50);
            lbA.Name = "lbA";
            lbA.Size = new Size(63, 20);
            lbA.TabIndex = 0;
            lbA.Text = "nhap A :";
            lbA.Click += lbA_Click;
            // 
            // lbB
            // 
            lbB.AutoSize = true;
            lbB.Location = new Point(74, 98);
            lbB.Name = "lbB";
            lbB.Size = new Size(62, 20);
            lbB.TabIndex = 1;
            lbB.Text = "nhap B :";
            // 
            // lbC
            // 
            lbC.AutoSize = true;
            lbC.Location = new Point(74, 151);
            lbC.Name = "lbC";
            lbC.Size = new Size(58, 20);
            lbC.TabIndex = 2;
            lbC.Text = "ket qua";
            lbC.Click += lbC_Click;
            // 
            // txtA
            // 
            txtA.Location = new Point(172, 50);
            txtA.Multiline = true;
            txtA.Name = "txtA";
            txtA.Size = new Size(125, 34);
            txtA.TabIndex = 0;
            // 
            // txtC
            // 
            txtC.Location = new Point(172, 144);
            txtC.Multiline = true;
            txtC.Name = "txtC";
            txtC.Size = new Size(125, 27);
            txtC.TabIndex = 2;
            // 
            // txtB
            // 
            txtB.Location = new Point(172, 98);
            txtB.Multiline = true;
            txtB.Name = "txtB";
            txtB.Size = new Size(125, 27);
            txtB.TabIndex = 1;
            txtB.TextChanged += textBox3_TextChanged;
            // 
            // btbTong
            // 
            btbTong.Location = new Point(43, 217);
            btbTong.Name = "btbTong";
            btbTong.Size = new Size(94, 29);
            btbTong.TabIndex = 3;
            btbTong.Text = "&Tong";
            btbTong.UseVisualStyleBackColor = true;
            btbTong.Click += button1_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(184, 217);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(311, 217);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Th&oat";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnMes
            // 
            btnMes.Location = new Point(43, 283);
            btnMes.Name = "btnMes";
            btnMes.Size = new Size(164, 29);
            btnMes.TabIndex = 6;
            btnMes.Text = "testBtnMessageBox";
            btnMes.UseVisualStyleBackColor = true;
            btnMes.Click += btnMes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnThoat;
            ClientSize = new Size(434, 404);
            Controls.Add(btnMes);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btbTong);
            Controls.Add(txtB);
            Controls.Add(txtC);
            Controls.Add(txtA);
            Controls.Add(lbC);
            Controls.Add(lbB);
            Controls.Add(lbA);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbA;
        private Label lbB;
        private Label lbC;
        private TextBox txtA;
        private TextBox txtC;
        private TextBox txtB;
        private Button btbTong;
        private Button btnXoa;
        private Button btnThoat;
        private Button btnMes;
    }
}
