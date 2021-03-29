using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("Введите первое число: ");
            if(!double.TryParse(Console.ReadLine(), out double firstNumber))
            {
                Console.WriteLine("Вы ввели не число");
                return;
            }
        
            Console.Write("Введите второе число: ");
            if (!double.TryParse(Console.ReadLine(), out double secondNumber))
            {
                Console.WriteLine("Вы ввели не число");
                return;
            }
            
            Console.Write("Введите оператор ('+' '-' '*' '/'): ");
            string action = Console.ReadLine();

            switch (action)
            {
                case "+":               
                    Console.WriteLine("Ответ: " + (firstNumber + secondNumber));
                    break;             
                case "-":
                    Console.WriteLine("Ответ: " + (firstNumber - secondNumber));
                    break;               
                case "*":
                    Console.WriteLine("Ответ: " + (firstNumber * secondNumber));
                    break;                
                case "/":
                    Console.WriteLine("Ответ: " + (firstNumber / secondNumber));
                    break;
                default:
                    Console.WriteLine("Вы ввели не один из предложенных операторов");
                    return;
            }

            Console.ReadLine();            
        }
    }
}
