using System;

namespace CsharpFundamentals
{
    public class BankAccount
    {
        //It's private, meaning it can't be accessed directly from outside the BankAccount class.
        //This ensures the balance can only be changed through the methods provided in the class (like depositing or withdrawing money)
        private decimal balance;

        // Constructor to initialize balance 
        //The constructor is like a special method that runs when you create a new BankAccount object.
        //It takes an initialBalance as a parameter and sets the balance to that value when the bank account is first created.
        //For example, if you create a bank account with $1000, it will start with that balance.
        public BankAccount(decimal initialBalance) 
        {
            balance = initialBalance;
        }

        // Method to check balance
        public decimal CheckBalance()
        {
            return balance;
        }

        // Method to withdraw money
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"You successfully withdrew ${amount}");
            }
            else if (amount > balance)
            {
                Console.WriteLine("I wish I had some money to give you, but I don't. Your girlfriend spent it all ;')");
            }
            else 
            {
                Console.WriteLine("Sorry, Buddy, invalid withdrawal amount");
            }
        }

        // Method to deposit money
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"You successfully deposited ${amount}. Wow, you're rich!");
            }
            else
            {
                Console.WriteLine("Sorry, Buddy, invalid deposit amount. Please try again.");
            }
        }
    }

    public class ATM
    {
        
        //This is where the ATM stores the BankAccount object. The ATM will interact with this account to check the balance, withdraw money, or deposit money.
        private BankAccount bankAccount;

        // Constructor to accept a BankAccount object
        //The constructor of the ATM class receives a BankAccount object as a parameter and stores it in the bankAccount field.
        //This means that the ATM class can use this account to perform operations like checking the balance or withdrawing money.
        public ATM(BankAccount bankAccount)
        {
            this.bankAccount = bankAccount;
        }

        // Display ATM menu
        public void DisplayMenu()
        {
            Console.WriteLine("\nATM Menu:");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Exit");
        }

        // Run the ATM simulation
        public void Run()
        {
            bool running = true;
            while (running)
            {
                DisplayMenu();
                Console.WriteLine("Choose an option from 1-4:");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"Current balance: ${bankAccount.CheckBalance()}");
                        break;
                    case "2":
                        Console.Write("Enter deposit amount: ");
                        decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                        bankAccount.Deposit(depositAmount);
                        break;
                    case "3":
                        Console.Write("Enter withdraw amount: ");
                        decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
                        bankAccount.Withdraw(withdrawAmount);
                        break;
                    case "4":
                        Console.WriteLine("Exiting ATM. Goodbye!");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a BankAccount object with an initial balance of 1000
            var bankAccount = new BankAccount(1000);

            // Create an ATM object, passing the bank account to the constructor
            var atm = new ATM(bankAccount);

            // Run the ATM application
            atm.Run();
        }
    }
}

