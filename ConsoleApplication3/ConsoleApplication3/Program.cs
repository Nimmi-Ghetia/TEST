using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public static class MyExtension
    {
        public static int CountWord(this string st)
        {
            int Count=0;
            for (int i = 0; i < st.Length; i++)
            {
                if (st[i] == ' ')
                {
                    Count++;
                }
            }
            return Count;
        }
        public static int CountCharacter(this string st)
        {
  //          int Count = 0;
           return st.Length;
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter statement:");
            string st = Console.ReadLine();
            int words = st.CountWord();
            int characters = st.CountCharacter();
            Console.WriteLine("words:" + words);
            Console.WriteLine("characters:" + characters);
            Console.ReadLine();
        }
    }
}
