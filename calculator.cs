
using System;

class Calculator
{
    static void Main()
    {
        try
        {
            
            Console.WriteLine("Enter the first number:");
            
            int number1 = ReadInteger();

            Console.WriteLine("Enter the second number:");
            
            int number2 = ReadInteger();

            Console.WriteLine("Enter the operator (+, -, *, /):");
            string op = Console.ReadLine();

            

            switch (op)
            {
                case "+":
                    Add(number1,number2);
                    break;
                case "-":
                    Substract(number1,number2);
                    break;
                case "*":
                    Multiply(number1,number2);
                    break;
                case "/":
                    Devision(number1,number2);
                    break;
                default:
                    throw new ArgumentException("Invalid operator.");
            }

            
        }
        
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    static int ReadInteger()
    {
        while (true)
        {
            string input = Console.ReadLine();

            try
            {
                return int.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine($"'{input}' is not a valid integer.");
                Console.Write("Enter a valid integer: ");
            }
        }
    }
    static void Add(int input1, int input2){
        Console.WriteLine(input1+input2);
    }
    static void Substract(int input1,int input2){
        Console.WriteLine(input1-input2);
    }
    static void Multiply(int input1 , int input2){
        Console.WriteLine(input1*input2);
    }
    static void Devision(int input1, int input2){
        Console.WriteLine(input1/input2);
    }
}