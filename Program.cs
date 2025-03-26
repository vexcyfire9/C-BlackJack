using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

int x = 0;
int card1;
int card2;
int card3;
int ai = 0;
int card1_2;
int card2_2;
int card3_2;
String hoc;
String input;

Console.WriteLine("Would you like to play a game of Black Jack");
Console.Write("> ");

input = Console.ReadLine();

if (input.ToLower() == "yes" || input.ToLower() == "ye" || input.ToLower() == "y") 
{
    Random rand = new Random();

    card1 = rand.Next(1,12);
    card2 = rand.Next(1,11);

    card1_2 = rand.Next(1,12);
    card2_2 = rand.Next(1,11);

    ai = card2_2 + card1_2;
    x = card1 + card2;
    
    int y = 0;

    while (y < 1) 
    {
        
        Console.Write($"You have a {x} would you like to Hit or Check > ");

        hoc = Console.ReadLine();

        if (hoc.ToLower() == "h" || hoc.ToLower() == "hit" )
        {

            card3 = rand.Next(1,11);
            x = x + card3;
            card3_2 = rand.Next(1,11);
            ai = ai + card3_2;

            if (x > 21) 
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write($"You lost with {x}");
                break;
            }
            if (x < ai) 
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write($"You lost to the ai with {ai}");
                break;
            }
            if (x == ai)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"You and the AI both have {x}");
                break;
            }
            if (x > ai && x < 21)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write($"You beat the ai with your {x} and his {ai}");
                break;
            }
            if (x == 21)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write($"YOU GOT A BLAKCJACK!!!");
                break;
            }
            if (ai > 21)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write($"The AI has gone over 21");
                break;
            }
        }
        else 
        {
            if (x > 21) 
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write($"You lost with {x}");
                break;
            }
            if (x < ai) 
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write($"You lost to the ai with {ai}");
                break;
            }
            if (x == ai)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"You and the AI both have {x}");
                
                break;
            }
            if (x > ai && x < 21)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write($"You beat the ai with your {x} and his {ai}");
                break;
            }
            if (x == 21)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write($"YOU GOT A BLAKCJACK!!!");
                break;
            }
            if (ai > 21)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write($"The AI has gone over 21");
                break;
            }
        }
    }
} 
else 
{
    Console.Write("GoodBye");
    return;
}