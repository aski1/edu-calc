using System;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        enum MathActions
        {
            Addition,
            Subtraction,
            Multiplication,
            Division
        }


        int number1 = 0;
        MathActions action;



        public Form1()
        {
            InitializeComponent();
        }



        private void btnResult_Click(object sender, EventArgs e)
        {
            int number2 = int.Parse(tbOut.Text);
            int result = 0;

            if (action == MathActions.Addition)
                result = number1 + number2;
            else if (action == MathActions.Subtraction)
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

        private void btNum3_Click(object sender, EventArgs e)
        {
            tbOut.Text += "3";
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            number1 = int.Parse(tbOut.Text);
            action = MathActions.Addition;
            tbOut.Text = "";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            number1 = int.Parse(tbOut.Text);
            action = MathActions.Subtraction;
            tbOut.Text = "";
        }
    }
}