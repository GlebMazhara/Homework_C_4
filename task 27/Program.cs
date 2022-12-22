Console.Clear();
Console.WriteLine("введите число  ");
int n = Convert.ToInt32(Console.ReadLine()), a=0, b=0;
while(n!=0)
{
    a= n%10;
    n=n/10;
    b=b+a;
}
Console.WriteLine(b);