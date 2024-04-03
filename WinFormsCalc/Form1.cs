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
            if (calc.error_div_message == "ERROR")
                tbOut.Text = "На ноль делить нельзя!";
            else
                tbOut.Text = calc.curr_result.ToString();
            btnNum0.Enabled = false; btnNum1.Enabled = false; btNum2.Enabled = false; btNum3.Enabled = false;
            btnNum4.Enabled = false; btnNum5.Enabled = false; btnNum6.Enabled = false; btnNum7.Enabled = false;
            btnNum8.Enabled = false; btnNum9.Enabled = false; btnResult.Enabled = false; btnAdd.Enabled = false;
            btnSub.Enabled = false; btnMult.Enabled = false; btnDiv.Enabled = false;
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            calc.Reset();
            tbOut.Text = "";
            btnNum0.Enabled = true; btnNum1.Enabled = true; btNum2.Enabled = true; btNum3.Enabled = true;
            btnNum4.Enabled = true; btnNum5.Enabled = true; btnNum6.Enabled = true; btnNum7.Enabled = true;
            btnNum8.Enabled = true; btnNum9.Enabled = true; btnResult.Enabled = true; btnAdd.Enabled = true;
            btnSub.Enabled = true; btnMult.Enabled = true; btnDiv.Enabled = true;
        }


        private void btnNum1_Click(object sender, EventArgs e)
        {
            calc.AddNumber(1);
            tbOut.Text += "1";
        }

        private void btNum2_Click(object sender, EventArgs e)
        {
            calc.AddNumber(2);
            tbOut.Text += "2";
        }

        private void btNum3_Click(object sender, EventArgs e)
        {
            calc.AddNumber(3);
            tbOut.Text += "3";
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            calc.AddNumber(4);
            tbOut.Text += "4";
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            calc.AddNumber(5);
            tbOut.Text += "5";
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            calc.AddNumber(6);
            tbOut.Text += "6";
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            calc.AddNumber(7);
            tbOut.Text += "7";
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            calc.AddNumber(8);
            tbOut.Text += "8";
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            calc.AddNumber(9);
            tbOut.Text += "9";
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            calc.AddNumber(0);
            tbOut.Text += "0";
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbOut.Text += $"+";
            calc.SetAction(MathActions.Addition);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            tbOut.Text += $"-";
            calc.SetAction(MathActions.Subtraction);
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            tbOut.Text += $"*";
            calc.SetAction(MathActions.Multiplication);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            tbOut.Text += $"/";
            calc.SetAction(MathActions.Division);
        }
    }
}