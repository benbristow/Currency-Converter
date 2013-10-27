using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Set numeric up down maximum value.
            numericUpDown1.Maximum = decimal.MaxValue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Please select currencies to convert to and from.");
            }
            else
            {
                doConvert();
            }
        }

        private void doConvert()
        {
            CurrencyConverter cc = new CurrencyConverter();
            cc.inputCurrency = comboBox1.Text;
            cc.outputCurrency = comboBox2.Text;
            cc.inputMoney = Convert.ToSingle(numericUpDown1.Value);

            try
            {
                string o = cc.convert();
                textBox1.Text = o;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
