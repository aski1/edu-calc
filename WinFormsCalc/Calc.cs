using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public enum MathActions
    {
        Addition,
        Subtraction,
        Multiplication,
        Division
    }

    internal class Calc
    {
        //public delegate void CurrNumberChangeHandler(int number);
        //public event CurrNumberChangeHandler CurrNumberChange;
        public event Action<double> CurrNumberChange;

        public int curr_result { get; private set; } = 0;
        public int curr_number { get; private set; } = 0;
        MathActions action = MathActions.Addition;


        public Calc() { }


        public void Reset()
        {
            curr_result = 0;
            curr_number = 0;
            action = MathActions.Addition;

            CurrNumberChangeRun(curr_number);
        }

        public void SetAction(MathActions action)
        {
            Result();
            this.action = action;
        }

        public void AddNumber(int num)
        {
            curr_number = curr_number * 10 + num;

            CurrNumberChangeRun(curr_number);
        }

        public void Result()
        {
            if (action == MathActions.Addition)
                curr_result = curr_result + curr_number;
            else if (action == MathActions.Subtraction)
                curr_result = curr_result - curr_number;

            else if (action == MathActions.Division)
                if (curr_number != 0)
                    curr_result = curr_result / curr_number;
                else
                    MessageBox.Show("Введите не 0");
            
             else if (action == MathActions.Multiplication)
                curr_result = curr_result * curr_number;
            
            curr_number = 0;
            



            CurrNumberChangeRun(curr_result);
        }

        void CurrNumberChangeRun(int number)
        {
            if (CurrNumberChange != null)
                CurrNumberChange(number);
        }
    }
}
