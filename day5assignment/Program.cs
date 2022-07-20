

//variables
int count = 0;
double tails = 0;
double heads = 0;
double percent1 = 0;
double percent = 0;
while (count < 1000)
{
    Random rnd = new Random();
    int result = rnd.Next(0, 2);
    if (result == 1)
    {
        Console.WriteLine("Tails!");
        tails = tails + 1;
        count = count + 1;
        
    }
    else if (result == 0)
    {
        Console.WriteLine("Heads!");
        heads = heads + 1;
        count = count + 1;
       
        
    }
}
percent1 = ((tails / 1000) * 100);
percent = ((heads / 1000) * 100);
Console.WriteLine("heads : " + heads );
Console.WriteLine("tails: " + tails );
Console.WriteLine("tails percent : " + percent1 );
Console.WriteLine("heads percent : " + percent );
Console.ReadLine();