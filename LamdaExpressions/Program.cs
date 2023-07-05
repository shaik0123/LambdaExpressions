
using System;
using System.Collections.Generic;
using System.Linq;
using static LamdaExpressions.Details;

namespace LamdaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LamdaDemo.Demo();



            int Square(int x)
            {
                return x * x;
            }
            Console.WriteLine(Square(10));


            int Add (int x,int b,int c) 
            {
                return x + b + c;
            }
            Console.WriteLine(Add(1,2,3));
    




            List<int> numbers = new List<int>() {36, 71, 12,
                             15, 29, 18, 27, 17, 9, 34};

            // foreach loop to display the list
            Console.Write("The list : ");
            foreach (var value in numbers)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();

            // Using lambda expression
            // to calculate square of
            // each value in the list
            var square = numbers.Select(x => x * x);

            // foreach loop to display squares
            Console.Write("Squares : ");
            foreach (var value in square)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();

            //Student.Demo();
            Demo();

        }
        public static void Demo()
        {
            List<Details> list = new List<Details>()
            {
                new Details{name ="mohan",id =101,age = 20,address = "hyd",ssn = 201},
                new Details{name ="ram",id =102,age = 24,address = "knl",ssn = 202},
                new Details{name ="rakesh",id =103,age = 26,address = "ndl",ssn = 203},
                new Details{name ="pavan",id =104,age = 28,address = "hyd",ssn = 204}

            };


            foreach (var i in list)
            {
                Console.WriteLine(i.name, i.id, i.age, i.address, i.ssn);
            }


        }
        /* public static void Demo()
         {
             var Square = (int n) => n * n;
             Console.WriteLine(Square(2));

         var ResultingSum = (int a, int b) =>
         {
             int calculatedSum = a + b;
             return calculatedSum;
         };
         Console.WriteLine("Total sum: " + ResultingSum(4, 8));
         }*/


    }
}
