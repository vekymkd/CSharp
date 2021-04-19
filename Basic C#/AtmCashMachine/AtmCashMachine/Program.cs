using System;
using Models;

namespace AtmCashMachine
{
    class Program
    {
        static Customer FindCustomer(Customer[] customers, string cardNumber)
        {
            foreach (Customer c in customers)
            {
                if (c.CardNumber == cardNumber)
                {
                    return c;
                }
            }
            return null;
        }

        static void Main(string[] args)
        {
            Customer[] customers = new Customer[] {
                new Customer("Velimir","Stojanov", "3293829398239238293", 34562, 2300),
                new Customer("Risto","Panchevski", "8235823582358235", 45000, 1500),
                new Customer("Adis","Drndar", "03243482882774426", 23240, 1200),
                new Customer("Petko","Petkovski", "0000220311012203", 30000, 400)
            };

            Console.WriteLine("Welcome to our ATM");
            Console.WriteLine("Please enter card number: ");
            string cardNumber = Console.ReadLine();

            if (string.IsNullOrEmpty(cardNumber))
            {
                Console.WriteLine("Please enter card number: ");
            }
            else
            {
                Customer customer = FindCustomer(customers, cardNumber);
                if (customer == null)
                {
                    Console.WriteLine("Customer not found!");
                    return;
                }
                Console.WriteLine("Please enter pin number: ");
                bool success = int.TryParse(Console.ReadLine(), out int pin);
                if (success)
                {
                    if (customer.VerifyPinNumber(pin))
                    {

                    }
                    else
                    {
                        Console.WriteLine("Incorrect pin!");
                        return;
                    }
                }

            }
        }
    }
}
