Console.WriteLine("input M");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("input N");
int n = int.Parse(Console.ReadLine());

SumNumbers(m, n, 0);

void SumNumbers (int m, int n, int sum)
{
    if (m > n)
    {
        Console.WriteLine($"sum from m to n is {sum}");
        return;
    }
    sum += m++;
    SumNumbers(m, n, sum);
}