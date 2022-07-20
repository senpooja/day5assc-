
double result = 0, num = 0; 
Console.WriteLine("enter your number :");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i++)
{ 
    num = num + (1 / i);

  result = num;
   // Console.WriteLine("the value of harmonic no. " + num + " is: " + result);
}

Console.WriteLine("the value of harmonic no. " + num + " is: " + result);