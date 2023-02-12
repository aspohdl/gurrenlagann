int number = Convert.ToInt32(Console.ReadLine());
if (number > 999)
{
    if (number % 10 == number / 1000)
    {
        if (number % 100 / 10 == number % 1000 / 100)
        {
            Console.WriteLine("True");
        }
        else if (number % 100 / 10 == number % 1000 / 100)
        {
            Console.WriteLine("False");
        }
    }
    else if (number % 10 != number / 1000)
    {
        Console.WriteLine("False");
    }
}
else if (number < 1000)
{
    Console.WriteLine("False");
}