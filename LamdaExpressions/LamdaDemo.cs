using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LamdaExpressions
{
    public class LamdaDemo
    {
        public static void Demo()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            List<int> OddNumbers = list.FindAll(x => (x%2) != 0);

            foreach (int i in OddNumbers) 
            {
                Console.WriteLine("odd numbers :"+i);
            }
            var Increament = list.Select(x => x + 1 );
            foreach (int i in Increament)
            {
                Console.WriteLine("increment numbers : "+i);
            }
            
            var decendingOrder = list.OrderByDescending(x => x);
            foreach (int i in decendingOrder)   
            {
                if (i == 1)
                    continue;
                Console.WriteLine("decendingOrder : " + i);
                if (i == 2)
                {
                    Console.WriteLine("two : " + i);
                }
            }
        }
    }
}
