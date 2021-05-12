﻿using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace InvoiceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice1 = new Invoice("EVN", 1200, new DateTime(2021, 04, 30), new DateTime(2021, 05, 07));
            Invoice invoice2 = new Invoice("EVN", 850, new DateTime(2021, 05, 05), new DateTime(2021, 05, 06));
            Invoice invoice3 = new Invoice("BEG", 1700, new DateTime(2021, 03, 17), new DateTime(2021, 04, 17));
            Invoice invoice4 = new Invoice("BEG", 1500, new DateTime(2021, 02, 15), new DateTime(02 / 02 / 2021));
            Invoice invoice5 = new Invoice("Vodovod", 600, new DateTime(2021, 07, 12), new DateTime(2021, 06, 27));
            Invoice invoice6 = new Invoice("Vodovod", 550, new DateTime(2021, 04, 27), new DateTime(2021, 03, 27));

            List<Invoice> invoices = new List<Invoice> { invoice1, invoice2, invoice3, invoice4, invoice5, invoice6 };

            List<User> users = new List<User>
            {
                new Customer("Velimir", "Stojanov", 0, new List<Invoice>{invoice1, invoice3, invoice5}),
                new Customer("Bob", "Bobsky", 1200, new List<Invoice>{invoice2, invoice4, invoice6}),
                new Administrator("Greg", "greg123", "EVN"),
                new Administrator("Evan", "evan123", "Vodovod"),
                new Administrator("Mallory", "mallory123", "BEG")
            };

            while (true)
            {
                try
                {
                    Console.Write("Please enter username: ");
                    string username = Console.ReadLine();
                    Console.Write("Please enter password: ");
                    string password = Console.ReadLine();

                    User loginUser = users.FirstOrDefault(x => x.LogIn(username, password) != null);

                    if (loginUser == null)
                    {
                        throw new Exception("User not found!");
                    }
                    if (loginUser.Role == RoleEnum.Customer)
                    {
                        CustomerUI((Customer)loginUser);

                    }
                    else if (loginUser.Role == RoleEnum.Administrator)
                    {
                        AdministratorUI((Administrator)loginUser, invoices);
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

        }

        static void CustomerUI(Customer customer)
        {
            Console.WriteLine($"\nWelcome {customer.Username}.\n" +
                $"Your current balance is : {customer.Balance}.");

            while (true)
            {
                Console.WriteLine($"\nHow can we help you?\n" +
                    $"1. Deposit cash\n" +
                    $"2. Show all invoices\n" +
                    $"3. Pay invoice\n" +
                    $"4. Log out");
                string userChoiceString = Console.ReadLine();

                if (int.TryParse(userChoiceString, out int userChoice) && userChoice < 5 && userChoice > 0)
                {
                    switch (userChoice)
                    {
                        case 1:
                            Console.WriteLine("Please enter the amount of money you want to deposit: ");
                            string amountString = Console.ReadLine();

                            if (int.TryParse(amountString, out int amount))
                            {
                                Console.WriteLine(customer.DepositMoney(amount));
                            }
                            else
                            {
                                Console.WriteLine("Invalid amount. Try again.");
                            }
                            continue;

                        case 2:
                            Console.WriteLine(customer.OverviewInvoices());
                            continue;

                        case 3:
                            Console.WriteLine("Please choose an invoice to pay: \nNOTE: Aditional $10 per day are added if you are pass the due date.");
                            Console.WriteLine(customer.OverviewInvoices());
                            string invoiceChoiceString = Console.ReadLine();

                            if (int.TryParse(invoiceChoiceString, out int invoiceChoice) && invoiceChoice > 0 && invoiceChoice < customer.Invoices.Count + 1)
                            {
                                Console.WriteLine(customer.PayInvoice(customer.Invoices[invoiceChoice - 1]));
                            }
                            else
                            {
                                Console.WriteLine("There is no invoice with that number!");
                            }
                            continue;

                        case 4:
                            Console.WriteLine("See you soon!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("There are only three options. Please choose one.");
                    continue;
                }
                break;
            }
        }


        static void AdministratorUI(Administrator administrator, List<Invoice> invoices)
        {

            Console.WriteLine($"\nWelcome {administrator.Username}");
            Console.WriteLine(administrator.GetCompanyInvoices(invoices));
            Console.WriteLine("Bye!");
        }
    
    }
}
