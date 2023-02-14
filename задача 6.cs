int n = Convert.ToInt32(Console.ReadLine());
double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double h = (b - a) / n;
Console.WriteLine($"H = {h}");
double z = a;
for (int i = 0; i < n; i++)
{
    z = z + h;
    Console.WriteLine(z);
}
