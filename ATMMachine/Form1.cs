using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMMachine
{
    public partial class Form1 : Form
    {
        ATM atmMachine = null;
        public Form1()
        {
            InitializeComponent();
            atmMachine = new ATM();
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ATM aTM = new ATM();
            listBox1.Items.Add(atmMachine.EmployeeName);
            listBox1.Items.Add(atmMachine.Address);
            listBox1.Items.Add(atmMachine.SomoniAccountMoney);
            listBox1.Items.Add(atmMachine.YuanAccount);
            listBox1.Items.Add(atmMachine.CurrencyExchange);

            
            // displaying code...
            listBox1.Items.Add(atmMachine.CardNumber(txtBox1Account.Text));
            listBox1.Items.Add(atmMachine.MoneyWithdraw(double.Parse(txt2BoxMoneyWithdraw.Text)));
            listBox1.Items.Add(atmMachine.MoneyTopUp(double.Parse(txtBox3TopUpmoney.Text)));
            listBox1.Items.Add(atmMachine.CurrencyExchag(double.Parse(txtBox4MoneyExchange.Text)));

            























        }
    }
}
