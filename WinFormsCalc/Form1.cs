using System;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Calc calc = new Calc();


        public Form1()
        {
            InitializeComponent();

            calc.CurrNumberChange +=
                (number) => tbOut.Text = number.ToString();
        }



        private void btnResult_Click(object sender, EventArgs e)
        {
            calc.Result();
        }



        private void btnNum1_Click(object sender, EventArgs e)
        {
            calc.AddNumber(1);
        }

        private void btNum2_Click(object sender, EventArgs e)
        {
            calc.AddNumber(2);
        }

        private void btNum3_Click(object sender, EventArgs e)
        {
            calc.AddNumber(3);
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            calc.SetAction(MathActions.Addition);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            calc.SetAction(MathActions.Subtraction);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            calc.Reset();
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            calc.AddNumber(4);
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            calc.AddNumber(5);
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            calc.AddNumber(6);
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            calc.AddNumber(7);
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            calc.AddNumber(8);
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            calc.AddNumber(9);
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            calc.AddNumber(0);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            calc.SetAction(MathActions.Division);
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            calc.SetAction(MathActions.Multiplication);
        }

       

        
    }
}