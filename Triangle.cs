using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle

{
    class Triangle

    {
        private double a;
        private double b;
        private double c;

        public double A
        {
            get { return a;}
            set { a = value; }
        }
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public double C
        {
            get { return c; }
            set { c = value; }
        }
        public Triangle()
        {
            A = 0;
            B = 0;
            C = 0;
        }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public double P()
        {
            return a+b+c;
        }
        public double S()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt((p-a)*(p-b)*(p-c));
        }

    }
}
