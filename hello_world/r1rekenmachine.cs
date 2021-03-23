using System;

namespace My_story{
    class Program{
        static void Main(String[]args){
            System.Console.WriteLine("enter first digit");
            var xb=Console.ReadLine();
            int x=Int32.Parse(xb);
            System.Console.WriteLine("enter the second digit");
            var yb=Console.ReadLine();
              int y=Int32.Parse(yb);
            System.Console.WriteLine("plus");
            System.Console.WriteLine(x+y);
            System.Console.WriteLine("minus");
             System.Console.WriteLine(x-y);
              System.Console.WriteLine("multilpication:");
               System.Console.WriteLine(x*y);
        



        }
    }
} 