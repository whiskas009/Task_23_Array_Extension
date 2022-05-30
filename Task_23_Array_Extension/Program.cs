using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_23_Array_Extension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordForExit = "";
            int number;
            int sumArray = 0;
            int[] array = new int[0];

            while (wordForExit != "exit")
            {
                Console.WriteLine("Введите число или соответвующую команду: \n");
                string userInput = Console.ReadLine();
                
                switch (userInput)
                {
                    case "sum":
                        for (int i = 0; i < array.Length; i++)
                        {
                            sumArray += array[i];
                        }
                        Console.WriteLine("Сумма введёных чисел: " + sumArray);
                        break;

                    case "exit":
                        wordForExit = userInput;
                        break;

                    default:
                        number = int.Parse(userInput);
                        int[] tempArray = new int[array.Length+1];

                        for (int i = 0; i < array.Length; i++)
                            tempArray[i] = array[i];

                        tempArray[tempArray.Length-1] = number;
                        array = tempArray;
                        break;
                }  
            }

            Console.WriteLine("\nПрограмма завершена");
        }
    }
}   
