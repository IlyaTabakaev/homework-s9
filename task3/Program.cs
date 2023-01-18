Console.WriteLine("input m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("input n");
int n = int.Parse(Console.ReadLine());

AkkermanFunc(m, n);

int Func (int m, int n)
{
    if (m == 0) 
    {
        return n + 1;
    }
    else if (n == 0)
    {
         return Func(m - 1, 1);
    }
    else
    {
         return Func(m - 1, Func(m, n - 1));
    }
}

 void AkkermanFunc(int m, int n)
 {
    Console.WriteLine(Func(m, n));
 }