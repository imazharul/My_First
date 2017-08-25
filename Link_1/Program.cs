using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;


namespace Link_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>(new Customer[]
            {
                new Customer {Id = 1, Name = "mazhar", Age = "12", BirtDate = new DateTime(1990/1/1995)},
                new Customer{Id = 2, Name = "jamal", Age = "12", BirtDate = new DateTime(1283/3/2130)}, 
                new Customer{Id = 3, Name = "kamal", Age = "3", BirtDate = new DateTime(1234/5/1345)}, 
                new Customer{Id = 4, Name = "dfgh", Age = "0", Rule = 3, BirtDate = new DateTime(1234567/3/1238)},
           });

            var quary = from c in customers
                where c.Age == "0"
                select c.Name;


            foreach (var Rule in quary)
            {
                Console.WriteLine(Rule);
                Console.ReadLine();
            }


        }

        
        

    }



    class Customer : Product
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Age { get; set; }
        public DateTime BirtDate { get; set; }
    }

    class Product
    {
        public int id { get; set; }
        public String Name { get; set; }
        public int Rule { get; set; }
    }
}
