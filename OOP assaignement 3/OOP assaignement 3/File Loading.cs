using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_assaignement_3
{
    class File_Loading
    {
        public static void Loading_Files(int file_First,int file_Second)
        {
            //Loads the file and assaigns it
            string[] File1;
            string[] File2;
            if (file_First == 1)
                File1 = System.IO.File.ReadAllLines("..\\file1.txt");
            else
                File1 = System.IO.File.ReadAllLines("..\\file2.txt");
            if (file_Second == 1)
                File2 = System.IO.File.ReadAllLines("..\\file1.txt");
            else
                File2 = System.IO.File.ReadAllLines("..\\file2.txt");





            string Answer = File_Check(File1, File2);
            
            
            
            
            
            if (Answer == "yes")
            {//prints out if they are the same or not
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Your files are the same!");
                Console.ReadLine();
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your files are different!");
            }
        }

        private static string File_Check(string[] File1, string[] File2)
        {
            string Same = "yes";
            string Different = "no";
            int i;
            //checks length of files
            if (File1.Length != File2.Length)
            {
                return (Different);
            }
            else
            {//checks actual characters of files to make sure they are the same
                for (i = 0; i < File1.Length; i++)
                {
                    if (File1[i] != File2[i])
                    {
                        return (Different);
                    }
                }
                return (Same);
                
            }

        }
        
        

    }
}
