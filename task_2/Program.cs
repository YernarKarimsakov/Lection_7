Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

int Akkerman (int m, int n)
{
    if(m == 0)
    {
        return n + 1;
    }
    else if (n == 0) 
    {
        return Akkerman(m - 1, 1);
    }
    else 
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}

Console.WriteLine($"A({m}, {n}) =  {Akkerman(m, n)}");

