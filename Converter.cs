using System;

namespace Celcius2Fahrenheit
{
    class Converter
    {
        public static void Main(String[] args)
        {
            string getInput;
            double celcius, fahrenheit;
            Console.Write("Enter Fahrenheit value:");
            
            getInput = Console.ReadLine();
            fahrenheit = Convert.ToDouble(getInput);

            celcius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine(fahrenheit.ToString("#.##") + " Fahrenheit in C is " + celcius.ToString("#.##")+" Celcius");

        }
    }
}
