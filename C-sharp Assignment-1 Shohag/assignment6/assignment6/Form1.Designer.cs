namespace assignment6
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
            this.sec_tbox = new System.Windows.Forms.TextBox();
            this.calcTime = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.hms = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seconds:";
            // 
            // sec_tbox
            // 
            this.sec_tbox.Location = new System.Drawing.Point(132, 60);
            this.sec_tbox.Name = "sec_tbox";
            this.sec_tbox.Size = new System.Drawing.Size(130, 23);
            this.sec_tbox.TabIndex = 1;
            // 
            // calcTime
            // 
            this.calcTime.Location = new System.Drawing.Point(55, 104);
            this.calcTime.Name = "calcTime";
            this.calcTime.Size = new System.Drawing.Size(207, 23);
            this.calcTime.TabIndex = 2;
            this.calcTime.Text = "Calculate time";
            this.calcTime.UseVisualStyleBackColor = true;
            this.calcTime.Click += new System.EventHandler(this.calcTime_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "hours : minute : seconds";
            // 
            // hms
            // 
            this.hms.AutoSize = true;
            this.hms.Location = new System.Drawing.Point(55, 184);
            this.hms.Name = "hms";
            this.hms.Size = new System.Drawing.Size(0, 15);
            this.hms.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 252);
            this.Controls.Add(this.calcTime);
            this.Controls.Add(this.sec_tbox);
            this.Controls.Add(this.hms);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox sec_tbox;
        private Button calcTime;
        private Label label2;
        private Label hms;
    }
}