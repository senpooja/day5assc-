
Console.WriteLine("enter year ");
int year = Convert.ToInt32(Console.ReadLine());

if ((year % 4) == 0)
    
   
    {
        Console.WriteLine("this is leap year");

    }

else if ((year % 400) == 0)
    {
        Console.WriteLine("this is leap year ");
    }
else
        {
            Console.WriteLine("this is not a leap year");
        }
    

