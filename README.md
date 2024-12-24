Bank Account and ATM Simulation

Overview

This project is a simple simulation of a bank account and an ATM system written in C#. It demonstrates object-oriented programming concepts such as encapsulation, constructors, methods, and interactions between classes. The program enables users to interact with a simulated ATM to check their balance, deposit money, and withdraw funds.

Features

Bank Account Class

The BankAccount class models a simple bank account, with the following features:

Encapsulated Balance:

The balance field is private, ensuring that it can only be modified through defined methods.

Constructor:

Initializes the account balance when the account is created.

Check Balance Method:

Returns the current balance of the account.

Deposit Method:

Adds a valid amount to the balance.

Prints a confirmation message.

Handles invalid inputs gracefully.

Withdraw Method:

Deducts a valid amount from the balance if funds are sufficient.

Prints a confirmation message for successful transactions or error messages for invalid/insufficient withdrawals.

ATM Class

The ATM class models an ATM interface, which interacts with a BankAccount object to provide the following functionalities:

ATM Menu:

Displays a user-friendly menu with options to:

Check Balance

Deposit Money

Withdraw Money

Exit

Run Method:

Simulates the ATM's operation in a loop until the user exits.

Handles user input for menu options and calls the appropriate methods on the BankAccount object.

How It Works

Initialization:

A BankAccount object is created with an initial balance of $1000.

An ATM object is created, and the bank account is passed to it.

Menu Interaction:

The user interacts with the ATM by selecting options (1-4).

Based on the selected option, the ATM performs the following actions:

Option 1: Displays the current account balance.

Option 2: Prompts the user to input a deposit amount and processes the deposit.

Option 3: Prompts the user to input a withdrawal amount and processes the withdrawal.

Option 4: Exits the program.

Invalid inputs are handled with appropriate error messages.

Exit:

The user exits the program by selecting option 4.

Sample Output:

ATM Menu:
1. Check Balance
2. Deposit Money
3. Withdraw Money
4. Exit
Choose an option from 1-4:
1
Current balance: $1000

ATM Menu:
1. Check Balance
2. Deposit Money
3. Withdraw Money
4. Exit
Choose an option from 1-4:
2
Enter deposit amount: 500
You successfully deposited $500. Wow, you're rich!

ATM Menu:
1. Check Balance
2. Deposit Money
3. Withdraw Money
4. Exit
Choose an option from 1-4:
3
Enter withdraw amount: 300
You successfully withdrew $300

ATM Menu:
1. Check Balance
2. Deposit Money
3. Withdraw Money
4. Exit
Choose an option from 1-4:
4
Exiting ATM. Goodbye!
