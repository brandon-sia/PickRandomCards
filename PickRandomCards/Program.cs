using System;

namespace PickRandomCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of cards picked: ");
            string line = Console.ReadLine();

            if(int.TryParse(line, out int numberofCards))
            {
                // this block is executed if line COULD be converted to an int 
                // value that's stored in a new variable called numberofCards
                foreach (string card in CardPicker.PickSomeCards(numberofCards))
                {
                    Console.WriteLine(card);
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number!");
            }
        }
    }
}
