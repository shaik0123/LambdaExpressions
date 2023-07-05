using System;
using System.Collections.Generic;
using System.Linq;

namespace LamdaExpressionUserManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            List<Person> list = new List<Person>();
            Demo(list);
            Console.WriteLine("/////////////");
            // SearchName(list,"ram");
            // DeleteName(list,"ram");
            Age(list);
            Console.WriteLine("/////////////");
             AgeRange(list);
            Average(list);
            // list = list.Where(e => e.age > 20).ToList;
        }
        public static void Demo(List<Person> list)
        {

            list.Add(new Person() { name = "mohan", id = 101, age = 20, address = "hyd", ssn = 201 });
            list.Add(new Person() { name = "ram", id = 102, age = 24, address = "knl", ssn = 202 });
            list.Add(new Person () { name = "rakesh", id = 103, age = 26, address = "ndl", ssn = 203 });
            list.Add(new Person () { name = "pavan", id = 104, age = 28, address = "hyd", ssn = 204 });
                
            
            DisplayData(list);

        }

        public static void DisplayData(List<Person> list)
        {


            foreach (var i in list)
            {
                Console.WriteLine("name = {0} \t id = {1} \t age = {2} \t address = {3} \t ssn ={4}", i.name, i.id, i.age, i.address, i.ssn);
            }
        }

           /* var j = list.First(e => e.name == "ram");
            Console.WriteLine(j.name);
            if (j != null)
            {
                list.Remove(j);
            }
            foreach (var i in list)
            {
                Console.WriteLine("name = {0} \t id = {1} \t age = {2} \t address = {3} \t ssn ={4}", i.name, i.id, i.age, i.address, i.ssn);
            }


            var values = list.First(a => a.age > 20);
            Console.WriteLine(values.age);

            double result = list.Average(a => a.age);
            Console.WriteLine(result);

        }*/
        public static void  SearchName(List<Person> pop , string Name)
        {
            var i = pop.Find(a => a.name == Name);
            //Console.WriteLine(i.name);
            if(i != null)
            {

                Console.WriteLine("the name exist : " + i.name);
                
            }
            else
            {
                Console.WriteLine("name not prsent");
            }
        }
        public static void DeleteName(List<Person> pop , string Name)
        {
            // var i = pop.First(a => a.name == Name);
            //return i;
            var j = pop.First(e => e.name == "ram");
           // Console.WriteLine(j.name);
            if (j != null)
            {
                pop.Remove(j);
            }
      
           DisplayData(pop);

        }
        public static void  Age(List<Person> pop ) 
         {
            //var values = pop.Where(a => a.age > age).Take(2);
            //return (Person)values;
            List<Person> values = pop.FindAll(a => a.age > 20).ToList();
            //Console.WriteLine("age greater than 20 : "+values);
            DisplayData(values);

        } 
        public static void  AgeRange(List<Person> pop)
        {
            // var values = pop.Find(e => e.age > Sage && e.age < Eage);
            //return (Person)values;
            List<Person> value = pop.FindAll(e => e.age >= 20 && e.age <= 26).ToList();
            //Console.WriteLine("age between : "+value);
            DisplayData(value);
            
        }
        public static void Average(List<Person> pop)
        {
            double result = pop.Average(a => a.age);
            Console.WriteLine("Average age : "+result);

        }


         
        //search by name and then delete it.
        //age > 20 take top 2 value.
        //age bwt 20 - 26.
        //average of age.
    }
}
