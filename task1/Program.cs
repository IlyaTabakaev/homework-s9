Console.WriteLine("input number");
int n = int.Parse(Console.ReadLine());

NaturalNumbers(n);


void NaturalNumbers (int n)
{
    if (n < 0) Console.WriteLine("not a natural number");
    if (n == 0) return;
    Console.Write(n + " ");
    NaturalNumbers (n - 1);
}
