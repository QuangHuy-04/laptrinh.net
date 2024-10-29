namespace InHome2
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
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            splitContainer3 = new SplitContainer();
            grnSoThich = new GroupBox();
            btnCheck = new Button();
            chkNghi = new CheckBox();
            chkNgu = new CheckBox();
            chkAn = new CheckBox();
            button2 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button8 = new Button();
            button7 = new Button();
            panel1 = new Panel();
            button6 = new Button();
            button4 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            grnSoThich.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(800, 451);
            splitContainer1.SplitterDistance = 105;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(splitContainer3);
            splitContainer2.Panel1.Paint += splitContainer2_Panel1_Paint;
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(flowLayoutPanel1);
            splitContainer2.Panel2.Controls.Add(panel1);
            splitContainer2.Panel2.Controls.Add(button4);
            splitContainer2.Panel2.Controls.Add(button3);
            splitContainer2.Size = new Size(690, 451);
            splitContainer2.SplitterDistance = 362;
            splitContainer2.SplitterWidth = 5;
            splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(grnSoThich);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(button2);
            splitContainer3.Size = new Size(362, 451);
            splitContainer3.SplitterDistance = 253;
            splitContainer3.TabIndex = 0;
            // 
            // grnSoThich
            // 
            grnSoThich.BackColor = SystemColors.Highlight;
            grnSoThich.Controls.Add(btnCheck);
            grnSoThich.Controls.Add(chkNghi);
            grnSoThich.Controls.Add(chkNgu);
            grnSoThich.Controls.Add(chkAn);
            grnSoThich.Location = new Point(37, 23);
            grnSoThich.Name = "grnSoThich";
            grnSoThich.Size = new Size(197, 189);
            grnSoThich.TabIndex = 2;
            grnSoThich.TabStop = false;
            grnSoThich.Text = "sở thích";
            grnSoThich.Enter += groupBox1_Enter;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(103, 107);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(94, 29);
            btnCheck.TabIndex = 1;
            btnCheck.Text = "check";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // chkNghi
            // 
            chkNghi.AutoSize = true;
            chkNghi.Location = new Point(30, 91);
            chkNghi.Name = "chkNghi";
            chkNghi.Size = new Size(60, 24);
            chkNghi.TabIndex = 2;
            chkNghi.Text = "nghỉ";
            chkNghi.UseVisualStyleBackColor = true;
            // 
            // chkNgu
            // 
            chkNgu.AutoSize = true;
            chkNgu.Location = new Point(30, 61);
            chkNgu.Name = "chkNgu";
            chkNgu.Size = new Size(56, 24);
            chkNgu.TabIndex = 1;
            chkNgu.Text = "ngủ";
            chkNgu.UseVisualStyleBackColor = true;
            // 
            // chkAn
            // 
            chkAn.AutoSize = true;
            chkAn.Location = new Point(30, 31);
            chkAn.Name = "chkAn";
            chkAn.Size = new Size(47, 24);
            chkAn.TabIndex = 0;
            chkAn.Text = "ăn";
            chkAn.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(259, 40);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 0;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button8);
            flowLayoutPanel1.Controls.Add(button7);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(323, 326);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // button8
            // 
            button8.Location = new Point(3, 3);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 1;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(103, 3);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 0;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(button6);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 326);
            panel1.Name = "panel1";
            panel1.Size = new Size(323, 125);
            panel1.TabIndex = 2;
            // 
            // button6
            // 
            button6.Location = new Point(94, 43);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 0;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(37, 217);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 1;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(101, 113);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 0;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            grnSoThich.ResumeLayout(false);
            grnSoThich.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private Button btnCheck;
        private Button button2;
        private Panel panel1;
        private Button button6;
        private Button button4;
        private Button button3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button8;
        private Button button7;
        private GroupBox grnSoThich;
        private CheckBox chkNghi;
        private CheckBox chkNgu;
        private CheckBox chkAn;
    }
}
