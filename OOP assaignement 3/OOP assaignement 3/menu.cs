using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_assaignement_3
{
    class menu
    {
        public static void Menu()
        {
            String Answer;
            int file_First;
            int file_Second;

            do
            {//basic menu
                Console.WriteLine("Would you like to compare the two files?");
                Answer = Console.ReadLine();
                Answer = Answer.ToLower();
                if (Answer == "yes")
                {
                    break;
                }
                else if (Answer == "no")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Please only enter yes or no.");
                }

            } while (Answer != "yes" || Answer != "no");
            do
            {
                Console.WriteLine("Which file do you want to compare(1 or 2)?");
                if (!int.TryParse(Console.ReadLine(), out file_First))
                {
                    Console.WriteLine("Only enter numbers please!");
                }
                else if (file_First == 1 || file_First == 2)
                    break;
                else
                    Console.WriteLine("Please only enter 1 or 2");
            } while (file_First != 1 || file_First != 2);
            do
            {
                Console.WriteLine("Which file do you want to compare second(1 or 2)?");
                if (!int.TryParse(Console.ReadLine(), out file_Second))
                {
                    Console.WriteLine("Only enter numbers please!");
                }
                if (file_Second == 1 || file_Second == 2)
                    break;
                else
                    Console.WriteLine("Please only enter 1 or 2");

            } while (file_Second != 1 || file_Second != 2);
            File_Loading.Loading_Files(file_First, file_Second);//calls the next function
        }
    }
}
