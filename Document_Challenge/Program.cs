using System;
using System.IO;

namespace Document_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            Console.WriteLine("Document");

            while (running)
            {
                Console.WriteLine("\nPlease enter the name of the document:");
                string File = Console.ReadLine();

                Console.WriteLine("Please enter the content that is to be in the document:");
                string Content = Console.ReadLine();

                if (!File.EndsWith(".txt"))
                {
                    File += ".txt";
                }

                StreamWriter sw = null;

                try
                {
                    sw = new StreamWriter(File);
                    sw.WriteLine(Content);
                    Console.WriteLine(File + " was successfully saved. This document contains " + Content.Length + " characters.");
                }

                catch (Exception e1)
                {
                    Console.WriteLine(e1);
                }

                finally
                {
                    if (sw != null)
                    {
                        sw.Close();
                    }
                }

                Console.WriteLine("\nDo you want to create another document? (Y/N)");
                string yesOrNo = Console.ReadLine();

                if (yesOrNo == "n" || yesOrNo == "N")
                {
                    running = false;
                }

            }
        }
    }
}
