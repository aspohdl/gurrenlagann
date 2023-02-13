double x = Convert.ToDouble(Console.ReadLine());
double y = Convert.ToDouble(Console.ReadLine());
int square_root = 2;
if (y > 0)
{
    if (x < 0)
    {
        if ((Math.Pow(x, square_root) + Math.Pow(y, square_root)) <= 1)
        {
            Console.WriteLine("0");
        }
        else
        {
            Console.WriteLine(y);
        }
    }
    else
    {
        if ((Math.Pow(x, square_root) + Math.Pow(y, square_root)) <= 1)
        {
            if ((Math.Pow(x, square_root) + Math.Pow(y, square_root)) >= 0.09)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(y);
            }
        }
        else
        {
            Console.WriteLine(y);
        }
    }
}
else
{
    Console.WriteLine(y);
}
