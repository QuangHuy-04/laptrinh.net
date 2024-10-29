using System;

namespace InHome4
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
            this.lstBox = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnIndex = new System.Windows.Forms.Button();
            this.btnRemoveAt = new System.Windows.Forms.Button();
            this.butSelectedIndices = new System.Windows.Forms.Button();
            this.btnGan = new System.Windows.Forms.Button();
            this.btnSelectedIndex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBox
            // 
            this.lstBox.FormattingEnabled = true;
            this.lstBox.ItemHeight = 16;
            this.lstBox.Items.AddRange(new object[] {
            "dsh",
            "dsh272k4",
            "duongsh"});
            this.lstBox.Location = new System.Drawing.Point(65, 79);
            this.lstBox.Name = "lstBox";
            this.lstBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstBox.Size = new System.Drawing.Size(176, 164);
            this.lstBox.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(307, 79);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(307, 123);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 2;
            this.btnCount.Text = "count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIndex
            // 
            this.btnIndex.Location = new System.Drawing.Point(307, 165);
            this.btnIndex.Name = "btnIndex";
            this.btnIndex.Size = new System.Drawing.Size(75, 23);
            this.btnIndex.TabIndex = 3;
            this.btnIndex.Text = "Index";
            this.btnIndex.UseVisualStyleBackColor = true;
            this.btnIndex.Click += new System.EventHandler(this.btnIndex_Click);
            // 
            // btnRemoveAt
            // 
            this.btnRemoveAt.Location = new System.Drawing.Point(307, 209);
            this.btnRemoveAt.Name = "btnRemoveAt";
            this.btnRemoveAt.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveAt.TabIndex = 4;
            this.btnRemoveAt.Text = "RemoveAt";
            this.btnRemoveAt.UseVisualStyleBackColor = true;
            this.btnRemoveAt.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // butSelectedIndices
            // 
            this.butSelectedIndices.Location = new System.Drawing.Point(65, 275);
            this.butSelectedIndices.Name = "butSelectedIndices";
            this.butSelectedIndices.Size = new System.Drawing.Size(160, 23);
            this.butSelectedIndices.TabIndex = 5;
            this.butSelectedIndices.Text = "SelectedIndices";
            this.butSelectedIndices.UseVisualStyleBackColor = true;
            this.butSelectedIndices.Click += new System.EventHandler(this.butSelectedIndices_Click);
            // 
            // btnGan
            // 
            this.btnGan.Location = new System.Drawing.Point(65, 314);
            this.btnGan.Name = "btnGan";
            this.btnGan.Size = new System.Drawing.Size(75, 23);
            this.btnGan.TabIndex = 6;
            this.btnGan.Text = "Gan";
            this.btnGan.UseVisualStyleBackColor = true;
            this.btnGan.Click += new System.EventHandler(this.btnGan_Click);
            // 
            // btnSelectedIndex
            // 
            this.btnSelectedIndex.Location = new System.Drawing.Point(65, 353);
            this.btnSelectedIndex.Name = "btnSelectedIndex";
            this.btnSelectedIndex.Size = new System.Drawing.Size(176, 23);
            this.btnSelectedIndex.TabIndex = 7;
            this.btnSelectedIndex.Text = "SelectedIndex";
            this.btnSelectedIndex.UseVisualStyleBackColor = true;
            this.btnSelectedIndex.Click += new System.EventHandler(this.btnSelectedIndex_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSelectedIndex);
            this.Controls.Add(this.btnGan);
            this.Controls.Add(this.butSelectedIndices);
            this.Controls.Add(this.btnRemoveAt);
            this.Controls.Add(this.btnIndex);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.ListBox lstBox;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnIndex;
        private System.Windows.Forms.Button btnRemoveAt;
        private System.Windows.Forms.Button butSelectedIndices;
        private System.Windows.Forms.Button btnGan;
        private System.Windows.Forms.Button btnSelectedIndex;
    }
}

