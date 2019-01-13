using System;
using System.Windows.Forms;

namespace Analizator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            label3.Text = "";
            string str = textBox1.Text.ToUpper();
            Result r = Analizator.Result(str);
            
            if (r.ErrPosition == -1)
            {
                richTextBox1.Text = "Введенная строка соответствует синтаксису языка Turbo Pascal\r\n";
                foreach (string item in Analizator.L)
                {
                    richTextBox1.Text += item + "\r\n";
                }
                foreach (string item in Analizator.LL)
                {
                    richTextBox1.Text += item + "\r\n";
                }
            }
            else
            {
                string strs = r.ErrPosition.ToString() + "\n" + r.ErrMessage;
                richTextBox1.Text = strs;
            }
        }
    }
}
