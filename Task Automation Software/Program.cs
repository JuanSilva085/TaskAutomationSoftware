using System;
using System.Diagnostics;

namespace Automation
{
    class Program
    {
        static void Main(string[] args) 
        { 
          while (true)
            {
                Console.Clear();
                Console.WriteLine("----- Task Automation Software-----");
                Console.WriteLine("1. Search Google");
                Console.WriteLine("2. ChatGPT");
                Console.WriteLine("3. Open Visual Studio");
                Console.WriteLine("4. Open Visual Studio Code");
                Console.WriteLine("5. Youtube");
                Console.WriteLine("6. GitHub");
                Console.WriteLine("7. Exit");
                Console.Write("Choose a option: ");

                string choose = Console.ReadLine();


                switch (choose) 
                {
                    case "1":
                        IntoUrl("https://www.google.com");
                        break;

                    case "2":
                        IntoUrl("https://chat.openai.com");
                        break;

                    case "3":
                        IntoUrl("https://www.google.com");
                        break;

                    case "4":
                        IntoUrl("https://www.google.com");
                        break;

                    case "5":
                        IntoUrl("https://www.youtube.com");
                        break;

                    case "6":
                        IntoUrl("https://github.com");
                        break;

                    case "0":
                        Console.WriteLine("Leave...");
                        return;

                    default:
                        Console.WriteLine("Invalid Option! Try Again!");
                        break;
                }

                Console.WriteLine("Press any key");
                Console.ReadKey();
            }
        static void IntoUrl(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true,
                });
            }

            catch (Exception ex) 
            {
                Console.WriteLine($"Error opening URL: {ex.Message}\"");
            }
        }

        static void OpenProgram(string folderPath)
        {
            try
            {
                Process.Start(folderPath);
            }

            catch (Exception ex) 
            {
                Console.WriteLine($"Error opening URL: {ex.Message}\"");
            }
        }
        }

    }
}