Console.WriteLine("enter a number  :");
int number  = Convert.ToInt32(Console.ReadLine());

if (number == 0)
{
    Console.WriteLine("given number is even :" + number);

}
else if (number % 2 == 0)
{
    Console.WriteLine("given number is even : " + number);
}
else
{
    Console.WriteLine("given number is odd : " + number);
}