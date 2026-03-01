namespace CurrencyConverter
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.convertCurrency = new System.Windows.Forms.ComboBox();
            this.currentCurrency = new System.Windows.Forms.ComboBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.showConvert = new System.Windows.Forms.Label();
            this.showConvertCurrency = new System.Windows.Forms.Label();
            this.showCurrencyFrom = new System.Windows.Forms.Label();
            this.showAmount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.convertCurrency);
            this.groupBox1.Controls.Add(this.currentCurrency);
            this.groupBox1.Controls.Add(this.amountTextBox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 312);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "input";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // convertCurrency
            // 
            this.convertCurrency.FormattingEnabled = true;
            this.convertCurrency.Items.AddRange(new object[] {
            "PHP",
            "EUR\t",
            "CAD",
            "USD"});
            this.convertCurrency.Location = new System.Drawing.Point(118, 173);
            this.convertCurrency.Name = "convertCurrency";
            this.convertCurrency.Size = new System.Drawing.Size(222, 21);
            this.convertCurrency.TabIndex = 6;
            this.convertCurrency.SelectedIndexChanged += new System.EventHandler(this.convertCurrency_SelectedIndexChanged);
            // 
            // currentCurrency
            // 
            this.currentCurrency.FormattingEnabled = true;
            this.currentCurrency.Items.AddRange(new object[] {
            "PHP",
            "EUR\t",
            "CAD",
            "USD"});
            this.currentCurrency.Location = new System.Drawing.Point(118, 114);
            this.currentCurrency.Name = "currentCurrency";
            this.currentCurrency.Size = new System.Drawing.Size(222, 21);
            this.currentCurrency.TabIndex = 5;
            this.currentCurrency.SelectedIndexChanged += new System.EventHandler(this.currentCurrency_SelectedIndexChanged);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(118, 57);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(222, 20);
            this.amountTextBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(310, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Currency To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Currency From: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.showConvert);
            this.groupBox2.Controls.Add(this.showConvertCurrency);
            this.groupBox2.Controls.Add(this.showCurrencyFrom);
            this.groupBox2.Controls.Add(this.showAmount);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(2, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 326);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "output";
            // 
            // showConvert
            // 
            this.showConvert.AutoSize = true;
            this.showConvert.Location = new System.Drawing.Point(155, 225);
            this.showConvert.Name = "showConvert";
            this.showConvert.Size = new System.Drawing.Size(16, 13);
            this.showConvert.TabIndex = 7;
            this.showConvert.Text = "   ";
            // 
            // showConvertCurrency
            // 
            this.showConvertCurrency.AutoSize = true;
            this.showConvertCurrency.Location = new System.Drawing.Point(155, 174);
            this.showConvertCurrency.Name = "showConvertCurrency";
            this.showConvertCurrency.Size = new System.Drawing.Size(16, 13);
            this.showConvertCurrency.TabIndex = 6;
            this.showConvertCurrency.Text = "   ";
            // 
            // showCurrencyFrom
            // 
            this.showCurrencyFrom.AutoSize = true;
            this.showCurrencyFrom.Location = new System.Drawing.Point(155, 121);
            this.showCurrencyFrom.Name = "showCurrencyFrom";
            this.showCurrencyFrom.Size = new System.Drawing.Size(16, 13);
            this.showCurrencyFrom.TabIndex = 5;
            this.showCurrencyFrom.Text = "   ";
            // 
            // showAmount
            // 
            this.showAmount.AutoSize = true;
            this.showAmount.Location = new System.Drawing.Point(155, 64);
            this.showAmount.Name = "showAmount";
            this.showAmount.Size = new System.Drawing.Size(10, 13);
            this.showAmount.TabIndex = 4;
            this.showAmount.Text = " ";
            this.showAmount.Click += new System.EventHandler(this.showAmount_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Converted Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Currency To:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Currency From:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Amount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 656);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Simple Currency Converter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox currentCurrency;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox convertCurrency;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label showConvert;
        private System.Windows.Forms.Label showConvertCurrency;
        private System.Windows.Forms.Label showCurrencyFrom;
        private System.Windows.Forms.Label showAmount;
    }
}

