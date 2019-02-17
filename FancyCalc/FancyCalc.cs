using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyCalc
{
    public class FancyCalcEnguine
    {

        public int Add(int a, int b)
        {
            //throw new NotImplementedException();
            return a + b;
        }


        public double Subtract(double a, double b)
        {
            //throw new NotImplementedException();
            return a - b;
        }


        public double Multiply(double a, double b)
        {
            return a * b;
        }

        //generic calc method. usage: "10 + 20"  => result 30
        public double Culculate(string expression)
        {
            string n1 = expression[0].ToString() + expression[1].ToString();
            string n2 = expression[5].ToString() + expression[6].ToString();
            string sign = expression[3].ToString();

            double no = Convert.ToDouble(n1);
            double nt = Convert.ToDouble(n2);

            if (sign == "+")
            {
                return no + nt;
            }
            else if (sign == "-")
            {
                return no - nt;
            }
            else if ((sign == "/") && (nt.ToString() != "0"))
            {
                return no / nt;
            }
            else if (sign == "*")
            {
                return no * nt;
            }


            return 0;
        }
    }
}
