using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, bool> f = x => x > 3;
            Func<int, int> f1 = x => x + 3;
            Func<int, int> f2 = x => x * 3;
            Func<int, int> f3 = x => x - 3;
            Func<Func<int, int>, Func<int, int>, int, int> fog = (a1, b1, c) => a1.Invoke(b1.Invoke(c));
            Func<Func<int, int>, Func<int, int>,Func<int, int>, int, int> fogop = (a1, b1, c1,d) => a1.Invoke(b1.Invoke(c1.Invoke(d))) ;
            Console.WriteLine(f1(3).ToString());
            Console.WriteLine(fog(f1, f2, 5).ToString());
            Console.WriteLine(fogop(f1, f2, f3, 4).ToString());
            Console.ReadLine();
        }
    }
}
