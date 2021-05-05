using System;

namespace Models
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CardNumber { get; set; }
        private int PinNumber { get; set; }
        private double AccountBalance { get; set; }

        public Customer(string firstName, string lastName, string cardNumber, int pin, double balance)
        {
            FirstName = firstName;
            LastName = lastName;
            CardNumber = cardNumber;
            PinNumber = pin;
            AccountBalance = balance;
        }
        public double GetAccountBalance()
        {
            return AccountBalance;
        }

        public bool VerifyPinNumber(int pin)
        {
            return PinNumber == pin;
        }

        public void DepositAmount(int amount)
        {
            AccountBalance += amount;
        }

        public bool WithdrawAmount(int amount)
        {
            if (amount > AccountBalance)
            {
                return false;
            }
                
            AccountBalance -= amount;
            return true;
        }
    }
}