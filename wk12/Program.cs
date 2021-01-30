using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace wk12
{
    class Program
    {
        public static double Factoria(int number)
        {
            if (number == 0)
                return 1;
                return number * Factoria(number - 1); 

        }
        public static double Fibbonanci(int num)
        {
            if (num == 0) return 0;
            if (num == 1) return 1;
            return Fibbonanci(num - 1) + Fibbonanci(num - 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Fibbonanci(10));
            Console.WriteLine(Factoria(10));
            string path = @"D:\TestFolders2";
            //Create Directory
            Directory.CreateDirectory(path);
            //Create File
            string file1 = "File01.txt";
            //FileStream fs = File.Create(Path.Combine(path, fileName));
            //write into a file
            string[] data = { "First", "Second", "Third" };
            string theData = "Who are you to edit my file ";
            try
            {
                File.WriteAllText(Path.Combine(path, file1), theData);
               // File.WriteAllLines(Path.Combine(path, fileName), data);
            } catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                using (StreamWriter aFile = new StreamWriter(Path.Combine(path, "File02.txt")))
                {
                    foreach(string item in data)
                    {
                    aFile.WriteLine(item);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            string readText = File.ReadAllText(Path.Combine(path, "File02.txt"));
            Console.WriteLine(readText);
            try
            {
                StreamReader file = new StreamReader(Path.Combine(path, file1));
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
