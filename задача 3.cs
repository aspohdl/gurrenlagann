double x = Convert.ToDouble(Console.ReadLine());
double y = Convert.ToDouble(Console.ReadLine());
int square_root = 2;
if (y > 0)
{
    if ((Math.Pow(x, square_root) + Math.Pow(y, square_root)) <= 4)
    {
        if ((Math.Pow(x, square_root) + Math.Pow(y, square_root)) >= 1)
        {
            Console.WriteLine("1");
        }
        else
        {
            Console.WriteLine("0");
        }
    }
    else
    {
        Console.WriteLine("0");
    }
}
else
{
    Console.WriteLine("0");
}
