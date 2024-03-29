using System;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int number1 = 0;
        int action = 0; // 1 +, 2 -, ...

        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            int number2 = int.Parse(tbOut.Text);
            int result = 0;
            
            if(action == 1)
                result = number1 + number2;
            else if(action == 2)
                result = number1 - number2;

            tbOut.Text = result.ToString();
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            tbOut.Text += "1";
        }

        private void btNum2_Click(object sender, EventArgs e)
        {
            tbOut.Text += "2";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            number1 = int.Parse(tbOut.Text);
            action = 1; 
            tbOut.Text = "";
        }

        private void btNum3_Click(object sender, EventArgs e)
        {
            tbOut.Text += "3";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            number1 = int.Parse(tbOut.Text);
            action = 2;
            tbOut.Text = "";
        }
    }
}