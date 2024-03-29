using System;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Calc calc = new Calc();


        public Form1()
        {
            InitializeComponent();
        }



        private void btnResult_Click(object sender, EventArgs e)
        {
            calc.Result();
            tbOut.Text = calc.curr_result.ToString();
        }



        private void btnNum1_Click(object sender, EventArgs e)
        {
            calc.AddNumber(1);
            tbOut.Text = calc.curr_number.ToString();
        }

        private void btNum2_Click(object sender, EventArgs e)
        {
            calc.AddNumber(2);
            tbOut.Text = calc.curr_number.ToString();
        }

        private void btNum3_Click(object sender, EventArgs e)
        {
            calc.AddNumber(3);
            tbOut.Text = calc.curr_number.ToString();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            calc.SetAction(MathActions.Addition);
            tbOut.Text = "0";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            calc.SetAction(MathActions.Subtraction);
            tbOut.Text = "0";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            calc.Reset();
            tbOut.Text = "0";
        }
    }
}