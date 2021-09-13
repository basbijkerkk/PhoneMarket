using System;
using PhoneMarket;
namespace PhoneMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneData.GenerateList();
            MainMenu();
        }

        static void MainMenu()
        {
            Console.WriteLine("Please Choose a Phone Type (By Number)\n");
            foreach (var item in PhoneData.Phones)
            {
                Console.WriteLine(PhoneData.Phones.IndexOf(item) + " " + item.TMerk);
            }


            Console.WriteLine("Press ESC to Exit Application");


            var iKey = Console.ReadKey();
            Console.Clear();
            if (iKey.Key == ConsoleKey.Escape)
            {
                return;
            }
            else
            {
                try
                {
                    MenuSelected(Convert.ToInt32(iKey.KeyChar.ToString()));
                }
                catch(Exception e)
                {
                    Console.WriteLine("Error Wrong Input.");
                }
                
            }
        }

        public static void MenuSelected(int Input)
        {
            if(Input >= 0 && Input < PhoneData.Phones.Count)
            {
                Console.WriteLine("Merk " + PhoneData.Phones[Input].TMerk + "\n");
                Console.WriteLine("Type " + PhoneData.Phones[Input].TType + "\n");
                Console.WriteLine("Info " + PhoneData.Phones[Input].TDescription + "\n");
                Console.WriteLine("Prijs " + PhoneData.Phones[Input].TPrice + "\n");
            }
            var iKey = Console.ReadKey();
            if(iKey.Key == ConsoleKey.Escape)
            {
                return;
            }else //if(iKey.Key == ConsoleKey.Enter || iKey.Key == ConsoleKey.Backspace)
            {
                Console.Clear();
                MainMenu();
            }
        }
    }
}
