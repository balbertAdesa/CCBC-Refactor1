using System;

namespace CleanCodeBookClub.Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Clean Code Book Club Refactor 1");
            Console.Read();

            BaseCustomer customer;

            customer = new DefaultCustomer(6);
            Console.WriteLine(customer.Calculate(500));
            customer = new Type2Customer(6);
            Console.WriteLine(customer.Calculate(500));
            customer = new Type3Customer(6);
            Console.WriteLine(customer.Calculate(500));
            customer = new Type4Customer(6);
            Console.WriteLine(customer.Calculate(500));
        }
    }
}
