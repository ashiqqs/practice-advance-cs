using PracticeAdvanceCS.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAdvanceCS
{
    //Inner Exception
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Number-1: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Number-2: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    int devideResult = num1 / num2;
                    Console.WriteLine(devideResult);
                }
                catch (Exception ex)
                {
                    string filePath = @"I:\PracticeBasicCS\Notesjk\ExceptionLog.txt";
                    if (File.Exists(filePath))
                    {
                        StreamWriter streamWrite = new StreamWriter(filePath);
                        streamWrite.Write(ex.GetType().Name);
                        streamWrite.WriteLine();
                        streamWrite.Write(ex.Message);
                        streamWrite.WriteLine();
                        streamWrite.Write(ex.StackTrace);
                        streamWrite.Close();
                    }
                    else
                    {
                        throw new Exception($"{filePath} not exist!", ex);
                    }
                }
            }
            catch(Exception ex2)
            {
                Console.WriteLine($"Current Exception : {ex2.Message}");
                if (ex2.InnerException != null)
                {
                    Console.WriteLine($"Inner Exception : {ex2.InnerException}");
                }
            }


            Console.ReadKey();
        }

    }
}
