double x = Convert.ToDouble(Console.ReadLine());
double y = Convert.ToDouble(Console.ReadLine());
int square_root = 2;
if ((Math.Pow(x, square_root) + Math.Pow(y, square_root)) <= 1)
{
    if (y >= x)
    {
        if (y >= -x)
        {
            Console.WriteLine(x + y);
        }
    }
}
else
{
    Console.WriteLine(x - y);
}
