using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using CalcLibrary;

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
    }
}