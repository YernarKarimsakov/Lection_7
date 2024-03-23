void Numbers (int min, int max)
{
    if(max < min) return;
    Numbers(min, max-1);
    Console.Write($"{max} ");
}

Console.WriteLine("Введите натуральное число M");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число N");
int n = Convert.ToInt32(Console.ReadLine());

if(n > m)
{
    Numbers(m, n);
} 
else 
{
    Numbers(n, m);
}