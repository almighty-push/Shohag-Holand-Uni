namespace assignment5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.num1_tbox = new System.Windows.Forms.TextBox();
            this.num2_tbox = new System.Windows.Forms.TextBox();
            this.num3_tbox = new System.Windows.Forms.TextBox();
            this.calAvg = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.avg_lvl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Number 3:";
            // 
            // num1_tbox
            // 
            this.num1_tbox.Location = new System.Drawing.Point(123, 37);
            this.num1_tbox.Name = "num1_tbox";
            this.num1_tbox.Size = new System.Drawing.Size(145, 23);
            this.num1_tbox.TabIndex = 1;
            // 
            // num2_tbox
            // 
            this.num2_tbox.Location = new System.Drawing.Point(123, 76);
            this.num2_tbox.Name = "num2_tbox";
            this.num2_tbox.Size = new System.Drawing.Size(145, 23);
            this.num2_tbox.TabIndex = 1;
            // 
            // num3_tbox
            // 
            this.num3_tbox.Location = new System.Drawing.Point(123, 120);
            this.num3_tbox.Name = "num3_tbox";
            this.num3_tbox.Size = new System.Drawing.Size(145, 23);
            this.num3_tbox.TabIndex = 1;
            // 
            // calAvg
            // 
            this.calAvg.Location = new System.Drawing.Point(33, 174);
            this.calAvg.Name = "calAvg";
            this.calAvg.Size = new System.Drawing.Size(235, 23);
            this.calAvg.TabIndex = 2;
            this.calAvg.Text = "Calculate average";
            this.calAvg.UseVisualStyleBackColor = true;
            this.calAvg.Click += new System.EventHandler(this.calAvg_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Average:";
            // 
            // avg_lvl
            // 
            this.avg_lvl.AutoSize = true;
            this.avg_lvl.Location = new System.Drawing.Point(123, 240);
            this.avg_lvl.Name = "avg_lvl";
            this.avg_lvl.Size = new System.Drawing.Size(0, 15);
            this.avg_lvl.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 303);
            this.Controls.Add(this.calAvg);
            this.Controls.Add(this.num3_tbox);
            this.Controls.Add(this.num2_tbox);
            this.Controls.Add(this.num1_tbox);
            this.Controls.Add(this.avg_lvl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox num1_tbox;
        private TextBox num2_tbox;
        private TextBox num3_tbox;
        private Button calAvg;
        private Label label4;
        private Label avg_lvl;
    }
}