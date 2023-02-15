double s = 1000;
Console.WriteLine("Введите действительное число от 0 до 25:");
double p = Convert.ToDouble(Console.ReadLine());
if ((p > 25) | (p < 0))
{
    Console.WriteLine("Число не соответствует диапозону условия");
}
else
{
    int k = 0;
    do
    {
        s = s * (1 + p / 100);
        k = k + 1;
    }
    while (s < 1100);
    Console.WriteLine($"Количество месяцев: {k}, итоговый размер вклада: {s}");
}