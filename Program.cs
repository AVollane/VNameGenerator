using System;

namespace VNameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Name Generator by Vollane");
            Console.ForegroundColor = ConsoleColor.White;
            while(true){
                Console.WriteLine("Press enter to quit. . .");
                Console.WriteLine("Enter the name length: ");
                string nameLengthString = Console.ReadLine();

                if(nameLengthString == String.Empty){
                    Console.WriteLine("Goodbye!");
                    break;
                }

                int nameLength;
                bool isNumber = Int32.TryParse(nameLengthString ,out nameLength);
                if(isNumber){
                    string name = NameGenerator.GenerateName(nameLength);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(name);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else{
                    Console.WriteLine("Value is not a number!");
                    return;
                }
            }
        }
    }
}
