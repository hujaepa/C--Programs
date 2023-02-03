using System;

class MyInputOutput
{
    public static void Main(string[] args)
    {
        //declaration
        string getInput;
        int num1, num2, total = 0;

        //reading num1
        Console.Write("Enter num1: ");
        getInput = Console.ReadLine();
        num1 = Convert.ToInt32(getInput);

        //reading num2
        Console.Write("Enter num2: ");
        getInput = Console.ReadLine();
        num2 = Convert.ToInt32(getInput);

        //perform calculation
        total = num1 + num2;

        //prinout the total
        Console.WriteLine("{0} + {1} = {2}", num1, num2, total);
    }
}