namespace assignment8
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
            this.tshart_tbox = new System.Windows.Forms.TextBox();
            this.jeans_tbox = new System.Windows.Forms.TextBox();
            this.cal_btn = new System.Windows.Forms.Button();
            this.invoice_grp = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.total_price_lvl = new System.Windows.Forms.Label();
            this.vat_lvl = new System.Windows.Forms.Label();
            this.price_lvl = new System.Windows.Forms.Label();
            this.date_lvl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.invoice_grp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of T-sharts (x  € 30.00 ):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number of jeans (x  € 100.00 ):";
            // 
            // tshart_tbox
            // 
            this.tshart_tbox.Location = new System.Drawing.Point(234, 57);
            this.tshart_tbox.Name = "tshart_tbox";
            this.tshart_tbox.Size = new System.Drawing.Size(157, 23);
            this.tshart_tbox.TabIndex = 1;
            // 
            // jeans_tbox
            // 
            this.jeans_tbox.Location = new System.Drawing.Point(234, 103);
            this.jeans_tbox.Name = "jeans_tbox";
            this.jeans_tbox.Size = new System.Drawing.Size(157, 23);
            this.jeans_tbox.TabIndex = 1;
            // 
            // cal_btn
            // 
            this.cal_btn.Location = new System.Drawing.Point(31, 148);
            this.cal_btn.Name = "cal_btn";
            this.cal_btn.Size = new System.Drawing.Size(360, 43);
            this.cal_btn.TabIndex = 2;
            this.cal_btn.Text = "Calculate";
            this.cal_btn.UseVisualStyleBackColor = true;
            this.cal_btn.Click += new System.EventHandler(this.cal_btn_Click);
            // 
            // invoice_grp
            // 
            this.invoice_grp.Controls.Add(this.label7);
            this.invoice_grp.Controls.Add(this.label5);
            this.invoice_grp.Controls.Add(this.label4);
            this.invoice_grp.Controls.Add(this.total_price_lvl);
            this.invoice_grp.Controls.Add(this.vat_lvl);
            this.invoice_grp.Controls.Add(this.price_lvl);
            this.invoice_grp.Controls.Add(this.date_lvl);
            this.invoice_grp.Controls.Add(this.label3);
            this.invoice_grp.Location = new System.Drawing.Point(31, 224);
            this.invoice_grp.Name = "invoice_grp";
            this.invoice_grp.Size = new System.Drawing.Size(360, 195);
            this.invoice_grp.TabIndex = 3;
            this.invoice_grp.TabStop = false;
            this.invoice_grp.Text = "Invoice";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "VAT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Price:";
            // 
            // total_price_lvl
            // 
            this.total_price_lvl.AutoSize = true;
            this.total_price_lvl.Location = new System.Drawing.Point(238, 145);
            this.total_price_lvl.Name = "total_price_lvl";
            this.total_price_lvl.Size = new System.Drawing.Size(0, 15);
            this.total_price_lvl.TabIndex = 0;
            this.total_price_lvl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // vat_lvl
            // 
            this.vat_lvl.AutoSize = true;
            this.vat_lvl.Location = new System.Drawing.Point(238, 94);
            this.vat_lvl.Name = "vat_lvl";
            this.vat_lvl.Size = new System.Drawing.Size(0, 15);
            this.vat_lvl.TabIndex = 0;
            this.vat_lvl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // price_lvl
            // 
            this.price_lvl.AutoSize = true;
            this.price_lvl.Location = new System.Drawing.Point(238, 63);
            this.price_lvl.Name = "price_lvl";
            this.price_lvl.Size = new System.Drawing.Size(0, 15);
            this.price_lvl.TabIndex = 0;
            this.price_lvl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // date_lvl
            // 
            this.date_lvl.AutoSize = true;
            this.date_lvl.Location = new System.Drawing.Point(238, 36);
            this.date_lvl.Name = "date_lvl";
            this.date_lvl.Size = new System.Drawing.Size(0, 15);
            this.date_lvl.TabIndex = 0;
            this.date_lvl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::assignment8.Properties.Resources.cal;
            this.pictureBox1.Location = new System.Drawing.Point(43, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 431);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.invoice_grp);
            this.Controls.Add(this.cal_btn);
            this.Controls.Add(this.jeans_tbox);
            this.Controls.Add(this.tshart_tbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.invoice_grp.ResumeLayout(false);
            this.invoice_grp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tshart_tbox;
        private TextBox jeans_tbox;
        private Button cal_btn;
        private GroupBox invoice_grp;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label total_price_lvl;
        private Label vat_lvl;
        private Label price_lvl;
        private Label date_lvl;
        private PictureBox pictureBox1;
    }
}