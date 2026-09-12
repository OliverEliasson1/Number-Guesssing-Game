namespace Number_Guessing_Game;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int secretNr = rnd.Next(1,51);
        
        while (true)
        {
            Console.WriteLine("Gissa på ett heltal mellan 1-50");
            var guess = Console.ReadLine();
            if(!int.TryParse(guess, out int value))
            {
                Console.WriteLine("Du måste ange ett heltalsvärde");
            }
            else if(value < secretNr)
            {
                Console.WriteLine("Numret är för lågt");
            }
            else if(value > secretNr)
            {
                Console.WriteLine("Numret är för högt");
            }
            else
            {
                Console.WriteLine("Du gissade rätt!");
                break;
            }
        }
    }
}
