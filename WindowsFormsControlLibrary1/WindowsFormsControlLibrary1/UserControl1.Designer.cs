namespace WindowsFormsControlLibrary1
{
    partial class UserControl1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkan = new System.Windows.Forms.CheckBox();
            this.chkuong = new System.Windows.Forms.CheckBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCheck);
            this.groupBox1.Controls.Add(this.chkuong);
            this.groupBox1.Controls.Add(this.chkan);
            this.groupBox1.Location = new System.Drawing.Point(231, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // chkan
            // 
            this.chkan.AutoSize = true;
            this.chkan.Location = new System.Drawing.Point(7, 22);
            this.chkan.Name = "chkan";
            this.chkan.Size = new System.Drawing.Size(95, 20);
            this.chkan.TabIndex = 0;
            this.chkan.Text = "checkBox1";
            this.chkan.UseVisualStyleBackColor = true;
            this.chkan.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkuong
            // 
            this.chkuong.AutoSize = true;
            this.chkuong.Location = new System.Drawing.Point(7, 49);
            this.chkuong.Name = "chkuong";
            this.chkuong.Size = new System.Drawing.Size(95, 20);
            this.chkuong.TabIndex = 1;
            this.chkuong.Text = "checkBox2";
            this.chkuong.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(108, 46);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "button1";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(800, 450);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkan;
        private System.Windows.Forms.CheckBox chkuong;
        private System.Windows.Forms.Button btnCheck;
    }
}
