namespace Assignment5
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
            this.label1 = new System.Windows.Forms.Label();
            this.Rdo_2nd_class = new System.Windows.Forms.RadioButton();
            this.Rdo_1st_class = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ticket_box = new System.Windows.Forms.TextBox();
            this.runner_box = new System.Windows.Forms.TextBox();
            this.calculate_btn = new System.Windows.Forms.Button();
            this.price_lvl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(35, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class:";
            // 
            // Rdo_2nd_class
            // 
            this.Rdo_2nd_class.AutoSize = true;
            this.Rdo_2nd_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Rdo_2nd_class.Location = new System.Drawing.Point(176, 44);
            this.Rdo_2nd_class.Name = "Rdo_2nd_class";
            this.Rdo_2nd_class.Size = new System.Drawing.Size(94, 24);
            this.Rdo_2nd_class.TabIndex = 1;
            this.Rdo_2nd_class.TabStop = true;
            this.Rdo_2nd_class.Text = "2nd class";
            this.Rdo_2nd_class.UseVisualStyleBackColor = true;
            // 
            // Rdo_1st_class
            // 
            this.Rdo_1st_class.AutoSize = true;
            this.Rdo_1st_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Rdo_1st_class.Location = new System.Drawing.Point(309, 44);
            this.Rdo_1st_class.Name = "Rdo_1st_class";
            this.Rdo_1st_class.Size = new System.Drawing.Size(89, 24);
            this.Rdo_1st_class.TabIndex = 1;
            this.Rdo_1st_class.TabStop = true;
            this.Rdo_1st_class.Text = "1st class";
            this.Rdo_1st_class.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(35, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nr of tickets:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(35, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Railrunner";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(35, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Price:";
            // 
            // ticket_box
            // 
            this.ticket_box.Location = new System.Drawing.Point(167, 100);
            this.ticket_box.Name = "ticket_box";
            this.ticket_box.Size = new System.Drawing.Size(103, 20);
            this.ticket_box.TabIndex = 2;
            // 
            // runner_box
            // 
            this.runner_box.Location = new System.Drawing.Point(167, 146);
            this.runner_box.Name = "runner_box";
            this.runner_box.Size = new System.Drawing.Size(103, 20);
            this.runner_box.TabIndex = 2;
            // 
            // calculate_btn
            // 
            this.calculate_btn.Location = new System.Drawing.Point(167, 209);
            this.calculate_btn.Name = "calculate_btn";
            this.calculate_btn.Size = new System.Drawing.Size(103, 23);
            this.calculate_btn.TabIndex = 3;
            this.calculate_btn.Text = "Calculate";
            this.calculate_btn.UseVisualStyleBackColor = true;
            this.calculate_btn.Click += new System.EventHandler(this.calculate_btn_Click);
            // 
            // price_lvl
            // 
            this.price_lvl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.price_lvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.price_lvl.Location = new System.Drawing.Point(167, 236);
            this.price_lvl.Name = "price_lvl";
            this.price_lvl.Size = new System.Drawing.Size(103, 22);
            this.price_lvl.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 450);
            this.Controls.Add(this.calculate_btn);
            this.Controls.Add(this.runner_box);
            this.Controls.Add(this.ticket_box);
            this.Controls.Add(this.Rdo_1st_class);
            this.Controls.Add(this.Rdo_2nd_class);
            this.Controls.Add(this.price_lvl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Train - Day ticktes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Rdo_2nd_class;
        private System.Windows.Forms.RadioButton Rdo_1st_class;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ticket_box;
        private System.Windows.Forms.TextBox runner_box;
        private System.Windows.Forms.Button calculate_btn;
        private System.Windows.Forms.Label price_lvl;
    }
}

