namespace empcal
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtsal = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chketf = new System.Windows.Forms.CheckBox();
            this.chkepf = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtetf = new System.Windows.Forms.TextBox();
            this.txtepf = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtgsal = new System.Windows.Forms.TextBox();
            this.txtallo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnsal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Salary Calculation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salary";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(151, 113);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(190, 20);
            this.txtname.TabIndex = 3;
            // 
            // txtsal
            // 
            this.txtsal.Location = new System.Drawing.Point(151, 154);
            this.txtsal.Name = "txtsal";
            this.txtsal.Size = new System.Drawing.Size(190, 20);
            this.txtsal.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtnsal);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtallo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtgsal);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtepf);
            this.groupBox1.Controls.Add(this.txtetf);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.chkepf);
            this.groupBox1.Controls.Add(this.chketf);
            this.groupBox1.Location = new System.Drawing.Point(25, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 279);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculation";
            // 
            // chketf
            // 
            this.chketf.AutoSize = true;
            this.chketf.Location = new System.Drawing.Point(24, 45);
            this.chketf.Name = "chketf";
            this.chketf.Size = new System.Drawing.Size(46, 17);
            this.chketf.TabIndex = 0;
            this.chketf.Text = "ETF";
            this.chketf.UseVisualStyleBackColor = true;
            // 
            // chkepf
            // 
            this.chkepf.AutoSize = true;
            this.chkepf.Location = new System.Drawing.Point(24, 90);
            this.chkepf.Name = "chkepf";
            this.chkepf.Size = new System.Drawing.Size(46, 17);
            this.chkepf.TabIndex = 1;
            this.chkepf.Text = "EPF";
            this.chkepf.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ETF Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "EPF Amount";
            // 
            // txtetf
            // 
            this.txtetf.Location = new System.Drawing.Point(203, 42);
            this.txtetf.Name = "txtetf";
            this.txtetf.Size = new System.Drawing.Size(164, 20);
            this.txtetf.TabIndex = 6;
            // 
            // txtepf
            // 
            this.txtepf.Location = new System.Drawing.Point(203, 91);
            this.txtepf.Name = "txtepf";
            this.txtepf.Size = new System.Drawing.Size(164, 20);
            this.txtepf.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Gross Salary";
            // 
            // txtgsal
            // 
            this.txtgsal.Location = new System.Drawing.Point(106, 149);
            this.txtgsal.Name = "txtgsal";
            this.txtgsal.Size = new System.Drawing.Size(164, 20);
            this.txtgsal.TabIndex = 9;
            // 
            // txtallo
            // 
            this.txtallo.Location = new System.Drawing.Point(355, 149);
            this.txtallo.Name = "txtallo";
            this.txtallo.Size = new System.Drawing.Size(164, 20);
            this.txtallo.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Allowance";
            // 
            // txtnsal
            // 
            this.txtnsal.Location = new System.Drawing.Point(355, 194);
            this.txtnsal.Name = "txtnsal";
            this.txtnsal.Size = new System.Drawing.Size(164, 20);
            this.txtnsal.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(293, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "NetSalary";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(442, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 42);
            this.button1.TabIndex = 14;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 506);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtsal);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Salary";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtsal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtnsal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtallo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtgsal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtepf;
        private System.Windows.Forms.TextBox txtetf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkepf;
        private System.Windows.Forms.CheckBox chketf;
    }
}

