using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_class_parameter
{
  //  public class Generic
    public class Generic<T>
    {
        public void Add<T>(T a,T b)
        {
           dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1+d2);
        }
        public void subs<T>(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 - d2);
        }
        public void mult<T>(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1*d2);
        }
        public void divi<T>(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 / d2);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Generic<int> gen = new Generic<int>();
            gen.Add(2, 2);
            gen.subs(4, 2);
            gen.mult(2, 2);
            gen.divi(4, 2);
           /* gen.Add<int>(2, 2);
            gen.subs<int>(4, 2);
            gen.mult<int>(2, 2);
            gen.divi<int>(4, 2);*/

        }
    }
}
