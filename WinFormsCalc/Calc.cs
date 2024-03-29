using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
        public double curr_number { get; private set; } = 0;
        public double curr_result { get; private set; } = 0;
        public string error_div_message { get; private set; } = "";

        MathActions action = MathActions.Addition;


        public Calc() { }


        public void Reset()
        {
            curr_result = 0;
            curr_number = 0;
            error_div_message = "";
            action = MathActions.Addition;
        }

        public void SetAction(MathActions action)
        {
            Result();
            this.action = action;
        }

        public void AddNumber(int num)
        {
            curr_number = curr_number * 10 + num;
        }

        public void Result()
        {
            if (action == MathActions.Addition)
                curr_result += curr_number;
            else if (action == MathActions.Subtraction)
                curr_result -= curr_number;
            else if (action == MathActions.Multiplication)
                curr_result *= curr_number;            
            else if (action == MathActions.Division)
                if (curr_number != 0)
                    curr_result /= curr_number;
                else
                    error_div_message = "ERROR";
            curr_number = 0;
        }

    }
}
