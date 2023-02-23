namespace ATMMachine
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
            this.txtBox1Account = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.txt2BoxMoneyWithdraw = new System.Windows.Forms.TextBox();
            this.txtBox3TopUpmoney = new System.Windows.Forms.TextBox();
            this.txtBox4MoneyExchange = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtBox1Account
            // 
            this.txtBox1Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox1Account.Location = new System.Drawing.Point(46, 40);
            this.txtBox1Account.Name = "txtBox1Account";
            this.txtBox1Account.Size = new System.Drawing.Size(259, 19);
            this.txtBox1Account.TabIndex = 0;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(47, 235);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "submit";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txt2BoxMoneyWithdraw
            // 
            this.txt2BoxMoneyWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2BoxMoneyWithdraw.Location = new System.Drawing.Point(47, 82);
            this.txt2BoxMoneyWithdraw.Name = "txt2BoxMoneyWithdraw";
            this.txt2BoxMoneyWithdraw.Size = new System.Drawing.Size(258, 19);
            this.txt2BoxMoneyWithdraw.TabIndex = 2;
            // 
            // txtBox3TopUpmoney
            // 
            this.txtBox3TopUpmoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox3TopUpmoney.Location = new System.Drawing.Point(47, 137);
            this.txtBox3TopUpmoney.Name = "txtBox3TopUpmoney";
            this.txtBox3TopUpmoney.Size = new System.Drawing.Size(258, 19);
            this.txtBox3TopUpmoney.TabIndex = 4;
            // 
            // txtBox4MoneyExchange
            // 
            this.txtBox4MoneyExchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox4MoneyExchange.Location = new System.Drawing.Point(47, 193);
            this.txtBox4MoneyExchange.Name = "txtBox4MoneyExchange";
            this.txtBox4MoneyExchange.Size = new System.Drawing.Size(258, 19);
            this.txtBox4MoneyExchange.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter number of your bank account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter Withdraw money";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Enter TopUp Money";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Exchange Currency";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(47, 264);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(214, 160);
            this.listBox1.TabIndex = 12;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(312, 264);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(149, 160);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(500, 466);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox4MoneyExchange);
            this.Controls.Add(this.txtBox3TopUpmoney);
            this.Controls.Add(this.txt2BoxMoneyWithdraw);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtBox1Account);
            this.Name = "Form1";
            this.Text = "ATM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox1Account;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txt2BoxMoneyWithdraw;
        private System.Windows.Forms.TextBox txtBox3TopUpmoney;
        private System.Windows.Forms.TextBox txtBox4MoneyExchange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

