using System;

namespace OOP_assaignement_3
{
    class Program
    {
        static void Main(string[] args)
        {
            String Answer;
            int file_First;
            int file_Second;

            do
            {//basic menu
                Console.WriteLine("Would you like to compare the two files?");
                Answer = Console.ReadLine();
                Answer.ToLower();
                if (Answer == "yes")
                {
                    break;
                }
                else if (Answer == "no")
                {
                    Console.WriteLine("Please close the application");
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Please only enter yes or no.");
                }

            } while (Answer != "yes" || Answer != "no");
            do
            {
                Console.WriteLine("Which file do you want to compare(1 or 2)?");
                file_First = int.Parse(Console.ReadLine());
                if (file_First == 1 || file_First == 2 )
                    break;
                else
                    Console.WriteLine("Please only enter 1 or 2");
            } while (file_First != 1 || file_First != 2);
            do
            {
                Console.WriteLine("Which file do you want to compare second(1 or 2)?");
                file_Second = int.Parse(Console.ReadLine());
                if (file_Second == 1 || file_Second == 2)
                    break;
                else
                    Console.WriteLine("Please only enter 1 or 2");

            } while (file_Second != 1 || file_Second != 2);
            File_Loading.Loading_Files(file_First, file_Second);//calls the next function
        }
    }
}
