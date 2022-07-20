Console.WriteLine("enter any 3 number :");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if (a == b && b == c)
{
    Console.WriteLine("a,b and c are equal : " + a + b + c );

}
else if (a > b  && a > c)
{
    Console.WriteLine("a is greter number : " + a);

}
else if (b > c && b > a)
{
    Console.WriteLine("b is greter number : " + b);

}
else
{
    Console.WriteLine("c is greter number :" + c);

}
