namespace assignment4
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
            this.price_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.calVat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.price_lvl = new System.Windows.Forms.Label();
            this.vat_lvl = new System.Windows.Forms.Label();
            this.total_lvl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // price_box
            // 
            this.price_box.Location = new System.Drawing.Point(127, 55);
            this.price_box.Name = "price_box";
            this.price_box.Size = new System.Drawing.Size(146, 23);
            this.price_box.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter a price:";
            // 
            // calVat
            // 
            this.calVat.Location = new System.Drawing.Point(32, 126);
            this.calVat.Name = "calVat";
            this.calVat.Size = new System.Drawing.Size(241, 23);
            this.calVat.TabIndex = 2;
            this.calVat.Text = "Determine VAT";
            this.calVat.UseVisualStyleBackColor = true;
            this.calVat.Click += new System.EventHandler(this.calVat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "VAT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total:";
            // 
            // price_lvl
            // 
            this.price_lvl.AutoSize = true;
            this.price_lvl.Location = new System.Drawing.Point(228, 198);
            this.price_lvl.Name = "price_lvl";
            this.price_lvl.Size = new System.Drawing.Size(0, 15);
            this.price_lvl.TabIndex = 1;
            // 
            // vat_lvl
            // 
            this.vat_lvl.AutoSize = true;
            this.vat_lvl.Location = new System.Drawing.Point(228, 236);
            this.vat_lvl.Name = "vat_lvl";
            this.vat_lvl.Size = new System.Drawing.Size(0, 15);
            this.vat_lvl.TabIndex = 1;
            // 
            // total_lvl
            // 
            this.total_lvl.AutoSize = true;
            this.total_lvl.Location = new System.Drawing.Point(228, 275);
            this.total_lvl.Name = "total_lvl";
            this.total_lvl.Size = new System.Drawing.Size(0, 15);
            this.total_lvl.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 450);
            this.Controls.Add(this.calVat);
            this.Controls.Add(this.total_lvl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.vat_lvl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.price_lvl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.price_box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox price_box;
        private Label label1;
        private Button calVat;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label price_lvl;
        private Label vat_lvl;
        private Label total_lvl;
    }
}