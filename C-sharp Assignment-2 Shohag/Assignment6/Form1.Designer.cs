namespace Assignment6
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
            this.PrevElements = new System.Windows.Forms.Label();
            this.lvl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.compare_txt = new System.Windows.Forms.TextBox();
            this.compare_btn = new System.Windows.Forms.Button();
            this.element_after_lvl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PrevElements
            // 
            this.PrevElements.AutoSize = true;
            this.PrevElements.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PrevElements.Location = new System.Drawing.Point(47, 90);
            this.PrevElements.Name = "PrevElements";
            this.PrevElements.Size = new System.Drawing.Size(46, 17);
            this.PrevElements.TabIndex = 0;
            this.PrevElements.Text = "label1";
            // 
            // lvl1
            // 
            this.lvl1.AutoSize = true;
            this.lvl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.lvl1.Location = new System.Drawing.Point(47, 59);
            this.lvl1.Name = "lvl1";
            this.lvl1.Size = new System.Drawing.Size(169, 17);
            this.lvl1.TabIndex = 1;
            this.lvl1.Text = "Content table (before)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(47, 497);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comparison number";
            // 
            // compare_txt
            // 
            this.compare_txt.Location = new System.Drawing.Point(188, 496);
            this.compare_txt.Name = "compare_txt";
            this.compare_txt.Size = new System.Drawing.Size(107, 20);
            this.compare_txt.TabIndex = 2;
            // 
            // compare_btn
            // 
            this.compare_btn.Location = new System.Drawing.Point(320, 494);
            this.compare_btn.Name = "compare_btn";
            this.compare_btn.Size = new System.Drawing.Size(102, 23);
            this.compare_btn.TabIndex = 3;
            this.compare_btn.Text = "Compare";
            this.compare_btn.UseVisualStyleBackColor = true;
            this.compare_btn.Click += new System.EventHandler(this.compare_btn_Click);
            // 
            // element_after_lvl
            // 
            this.element_after_lvl.AutoSize = true;
            this.element_after_lvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.element_after_lvl.Location = new System.Drawing.Point(317, 90);
            this.element_after_lvl.Name = "element_after_lvl";
            this.element_after_lvl.Size = new System.Drawing.Size(20, 17);
            this.element_after_lvl.TabIndex = 0;
            this.element_after_lvl.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(317, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Content table (after)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 587);
            this.Controls.Add(this.compare_btn);
            this.Controls.Add(this.compare_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.element_after_lvl);
            this.Controls.Add(this.PrevElements);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PrevElements;
        private System.Windows.Forms.Label lvl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox compare_txt;
        private System.Windows.Forms.Button compare_btn;
        private System.Windows.Forms.Label element_after_lvl;
        private System.Windows.Forms.Label label3;
    }
}

