using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
   public  class myclass
    {
        private int age;
        private string name;
        private string id;
        

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Id { get => id; }
        public int mycount { get; internal set; }

        public void student()
        {
            id = "20181cse0571";
        }
    }
  public   class Program
    {
        static void Main(string[] args)
        {
            myclass sc = new myclass();
            sc.student();
            sc.Name = "avinash";
            sc.Age = 21;
            Console.WriteLine("student details :");
            Console.WriteLine(sc.Name);
            Console.WriteLine(sc.Age);
            Console.WriteLine(sc.Id);
            Console.WriteLine(sc.mycount);
            sc.mycount = 5;
            Console.WriteLine(sc.mycount);
            Console.ReadLine();

        }
    }
}
