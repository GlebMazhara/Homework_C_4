 Console.Clear();
Console.Write("ВВедите число  ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите степень числа  ");
int m = Convert.ToInt32(Console.ReadLine());
int s = n;
while (m!=1)
{ 
    s= s*n;
    m=m-1;
}
Console.WriteLine(s);
