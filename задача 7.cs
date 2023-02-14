double a = Convert.ToDouble(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
double s = 1;
for (int i = 0; i < n; i++)
{
    s = s * a;
}
Console.WriteLine(s);
