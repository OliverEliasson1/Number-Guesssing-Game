namespace Number_Guessing_Game;

class Program
{
    static void Main()
    {
        int secretNr = 25;
        Console.WriteLine("Gissa på ett heltal mellan 1-50");
        var guess = Console.ReadLine();
        if(!int.TryParse(guess, out int value))
        {
            Console.WriteLine("Du måste ange ett heltalsvärde");
        }
        else if(value == secretNr)
        {
            Console.WriteLine("Du gissade rätt!");
        }
        
    }
}
