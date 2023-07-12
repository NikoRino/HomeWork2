Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int Length = number.ToString().Length;
if (Length >= 3)
{
    while (number > 999)
    {
        number = number / 10;
    }
    int result = number % 10;
    Console.WriteLine("Третья цифра " + result);
}
else
{
    Console.WriteLine("Нет третьей цифры");
}