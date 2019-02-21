using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyCalc
{
    public class FancyCalcEnguine
    {

        public double Add(double a, double b)
        {
            
            return a + b;
        }

        public int Add(int a, int b)
        {

            return a + b;
        }

        public double Subtract(double a, double b)
        {
            
            return a - b;
        }

        public int Subtract(int a, int b)
        {

           return a - b;
        }

        public double Multiply(double a, double b)
        {
           
            return a * b;
        }

        public int Multiply(int a, int b)
        {

            return a * b;
        }

        //generic calc method. usage: "10 + 20"  => result 30
        public double Culculate(string expression)
        {
            string[] words = expression.Split(' ');
            string n1 = words[0];
            string n2 = words[2];
            string sign = words[1];


            bool success = Double.TryParse(n1, out double no);
            if(!success)
            {
                throw new Exception();
            }
            success = Double.TryParse(n1, out double nt);
            if (!success)
            {
                throw new Exception();
            }

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
            else
            {
                throw new Exception(); 
            }

        }
    }
}
