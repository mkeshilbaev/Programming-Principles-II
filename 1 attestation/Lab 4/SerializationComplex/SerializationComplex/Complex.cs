using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationComplex
{
    [Serializable]
    public class Complex
    {
        public int a;
        public int b;
        public Complex() { }
        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int Gcd(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            return Gcd(b, a % b);
        }

        public void Simplify()
        {
            int a1 = a;
            int b1 = b;
            int div = Gcd(a1, b1);
            this.a = a / div;
            this.b = b / div;
        }

        public static int Lcm(int a, int b)
        {
            for (int i = Math.Max(a, b); i < a * b; i++)
            {
                if (i % a == 0 && i % b == 0)
                {
                    return i;
                    //break;
                }
            }
            return a * b;
        }

        public static Complex operator *(Complex x, Complex y)
        {
            Complex res1 = new Complex(x.a * y.a, x.b * y.b);
            res1.Simplify();
            if (res1.b < 0)
            {
                res1.a = res1.a * (-1);
                res1.b = res1.b * (-1);
            }
            return res1;
        }

        public static Complex operator /(Complex x, Complex y)
        {
            Complex res2 = new Complex(x.a * y.b, x.b * y.a);
            res2.Simplify();
            if (res2.b < 0)
            {
                res2.a = res2.a * (-1);
                res2.b = res2.b * (-1);
            }
            return res2;
        }

        public static Complex operator +(Complex x, Complex y)
        {
            int l = Lcm(x.b, y.b);
            int Num = (l / x.b) * x.a + (l / y.b) * y.a;
            Complex res3 = new Complex(Num, l);
            res3.Simplify();
            if (res3.b < 0)
            {
                res3.a = res3.a * (-1);
                res3.b = res3.b * (-1);
            }
            return res3;
        }

        public static Complex operator -(Complex x, Complex y)
        {
            int l = Lcm(x.b, y.b);
            int Num = (l / x.b) * x.a - (l / y.b) * y.a;
            Complex res4 = new Complex(Num, l);
            res4.Simplify();
            if (res4.b < 0)
            {
                res4.a = res4.a * (-1);
                res4.b = res4.b * (-1);
            }
            return res4;
        }

        public override string ToString()
        {
            return a + "/" + b;
        }
    }
}
