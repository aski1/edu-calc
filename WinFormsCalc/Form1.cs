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


        int curr_result = 0;
        int curr_number = 0;
        MathActions action = MathActions.Addition;



        public Form1()
        {
            InitializeComponent();
        }



        void AddNumber(int num)
        {
            curr_number = curr_number * 10 + num;
            tbOut.Text = curr_number.ToString();
        }

        void Result()
        {
            if (action == MathActions.Addition)
                curr_result = curr_result + curr_number;
            else if (action == MathActions.Subtraction)
                curr_result = curr_result - curr_number;
            curr_number = 0;
        }




        private void btnResult_Click(object sender, EventArgs e)
        {
            Result();
            tbOut.Text = curr_result.ToString();
        }



        private void btnNum1_Click(object sender, EventArgs e)
        {
            AddNumber(1);
        }

        private void btNum2_Click(object sender, EventArgs e)
        {
            AddNumber(2);
        }

        private void btNum3_Click(object sender, EventArgs e)
        {
            AddNumber(3);
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            Result();
            action = MathActions.Addition;
            tbOut.Text = "";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            Result();
            action = MathActions.Subtraction;
            tbOut.Text = "";
        }
    }
}