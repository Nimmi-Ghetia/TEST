using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//create student class with id and name as automatic propeties
//create list of students with 5 student objects
//retrieve students from list based on certain criteria using linq to object(write query usin qury expression syntax and method based queries syntax
//display them on console
namespace ConsoleApplication2
{
    public class Student{
        public string name
        {
            get;
            set;
        }
        public int id
        {
            get;
            set;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Student[] s = new Student[5];
            //int j;
            //for (j = 0; j < 5; j++ )
              //  s[j] = new Student();
            /*s[0].id = 1;
            s[0].name = "kdj";
            s[1].id = 2;
            s[1].name = "kdsd";
            s[2].id = 3;
            s[2].name = "jksj";
            s[3].id = 4;
            s[3].name = "djhfkj";
            s[4].id = 5;
            s[4].name = "fjd";*/
            List<Student> s = new List<Student>
            {
                new Student(){id=1,name="hsg"},
                new Student(){id=2,name="hhjd"},
                new Student(){id=3,name="jdshj"},
                new Student(){id=4,name="fjdh"},
                new Student(){id=5,name="dkjas"}
            };
            //using query method 
            var query = from i in s where i.id > 2 select i;
            foreach(var a in query)
            {
                Console.WriteLine(a.id.ToString()+" "+ a.name.ToString());
            }
            //using extension method
            var query1=s.Where<Student>(i => i.id>2).Select(i=>i) ;
            foreach (var a in query1)
            {
                Console.WriteLine(a.id.ToString() + " " + a.name.ToString());
            }
            Console.ReadLine();
        }
    }
}
