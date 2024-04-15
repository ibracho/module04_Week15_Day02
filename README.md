# Intro to .Net

## Assignment: ATM

#### Overview
For this assignment, you will create a math game that takes user input, manipulates data, and utilizes error handling, by following the given the specifications.


### Instructions

Within the `Program.cs` file, add the following function described below.


### Part 1: ViewBalance function
- create an integer variable called "balance" and assign it an intial value of 0

-  create a function called `ViewBalance()`
    - **Functionality**: Returns the value of the current balance
    - **Return**: decimal

      
### Part 2: Widthdraw function
   - create a function called `Withdraw()`
      - **Functionality**: Subtracts money from the balance
      - **Return**: decimal
      - Do not allow the user to withdraw more money than what's available.
      - Do not allow the user to withdraw a value less than zero.


### Part 3: Deposit function
- create a function called `Deposit()`
    - **Functionality**: Adds money to the balance
    - **Return**: decimal
    - Do not allow the user to deposit a negative amount


### Part 4: User Interface
- create a user interface that repeatedly prompts a user to select one of the following options
    - View Current Balance
        - output the value of the "balance" variable to the console
    - Widthdraw 
        - prompt the user for the amount they want to widthdraw
    - Deposit
        - prompt the user for the amount they want to deposit

    - Exit
        - exit the prompt loop and end the program
