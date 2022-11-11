namespace assignment7
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
            this.erase_btn = new System.Windows.Forms.Button();
            this.startkm_tbox = new System.Windows.Forms.TextBox();
            this.endkm_tbox = new System.Windows.Forms.TextBox();
            this.pricePerkm_tbox = new System.Windows.Forms.TextBox();
            this.cal_btn = new System.Windows.Forms.Button();
            this.hr = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.priceExcVat = new System.Windows.Forms.Label();
            this.vat_lvl = new System.Windows.Forms.Label();
            this.priceIncVat_lvl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start km";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "End km";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Price / km";
            // 
            // erase_btn
            // 
            this.erase_btn.Location = new System.Drawing.Point(421, 85);
            this.erase_btn.Name = "erase_btn";
            this.erase_btn.Size = new System.Drawing.Size(75, 23);
            this.erase_btn.TabIndex = 1;
            this.erase_btn.Text = "Erase";
            this.erase_btn.UseVisualStyleBackColor = true;
            this.erase_btn.Click += new System.EventHandler(this.erase_btn_Click);
            // 
            // startkm_tbox
            // 
            this.startkm_tbox.Location = new System.Drawing.Point(144, 86);
            this.startkm_tbox.Name = "startkm_tbox";
            this.startkm_tbox.Size = new System.Drawing.Size(177, 23);
            this.startkm_tbox.TabIndex = 2;
            // 
            // endkm_tbox
            // 
            this.endkm_tbox.Location = new System.Drawing.Point(144, 120);
            this.endkm_tbox.Name = "endkm_tbox";
            this.endkm_tbox.Size = new System.Drawing.Size(177, 23);
            this.endkm_tbox.TabIndex = 2;
            // 
            // pricePerkm_tbox
            // 
            this.pricePerkm_tbox.Location = new System.Drawing.Point(144, 159);
            this.pricePerkm_tbox.Name = "pricePerkm_tbox";
            this.pricePerkm_tbox.Size = new System.Drawing.Size(177, 23);
            this.pricePerkm_tbox.TabIndex = 2;
            // 
            // cal_btn
            // 
            this.cal_btn.Location = new System.Drawing.Point(421, 159);
            this.cal_btn.Name = "cal_btn";
            this.cal_btn.Size = new System.Drawing.Size(75, 23);
            this.cal_btn.TabIndex = 1;
            this.cal_btn.Text = "Calculate";
            this.cal_btn.UseVisualStyleBackColor = true;
            this.cal_btn.Click += new System.EventHandler(this.cal_btn_Click);
            // 
            // hr
            // 
            this.hr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hr.Location = new System.Drawing.Point(50, 248);
            this.hr.Name = "hr";
            this.hr.Size = new System.Drawing.Size(452, 3);
            this.hr.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Price excl VAT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "VAT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(421, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Price incl VAT";
            // 
            // priceExcVat
            // 
            this.priceExcVat.AutoSize = true;
            this.priceExcVat.Location = new System.Drawing.Point(65, 267);
            this.priceExcVat.Name = "priceExcVat";
            this.priceExcVat.Size = new System.Drawing.Size(0, 15);
            this.priceExcVat.TabIndex = 0;
            // 
            // vat_lvl
            // 
            this.vat_lvl.AutoSize = true;
            this.vat_lvl.Location = new System.Drawing.Point(178, 267);
            this.vat_lvl.Name = "vat_lvl";
            this.vat_lvl.Size = new System.Drawing.Size(0, 15);
            this.vat_lvl.TabIndex = 0;
            // 
            // priceIncVat_lvl
            // 
            this.priceIncVat_lvl.AutoSize = true;
            this.priceIncVat_lvl.Location = new System.Drawing.Point(421, 267);
            this.priceIncVat_lvl.Name = "priceIncVat_lvl";
            this.priceIncVat_lvl.Size = new System.Drawing.Size(0, 15);
            this.priceIncVat_lvl.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 317);
            this.Controls.Add(this.hr);
            this.Controls.Add(this.pricePerkm_tbox);
            this.Controls.Add(this.endkm_tbox);
            this.Controls.Add(this.startkm_tbox);
            this.Controls.Add(this.cal_btn);
            this.Controls.Add(this.erase_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.priceIncVat_lvl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.vat_lvl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.priceExcVat);
            this.Controls.Add(this.label4);
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
        private Button erase_btn;
        private TextBox startkm_tbox;
        private TextBox endkm_tbox;
        private TextBox pricePerkm_tbox;
        private Button cal_btn;
        private Label hr;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label priceExcVat;
        private Label vat_lvl;
        private Label priceIncVat_lvl;
    }
}