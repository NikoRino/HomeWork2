Console.Write("Введите трехзначное число:");

int Value = Convert.ToInt32(Console.ReadLine());
int Length = Value.ToString().Length;
if (Length == 3)
{
    int result = (Value / 10) % 10;
    Console.WriteLine($"Вторая цифра {result}");
}
else
{
    Console.WriteLine("Не трехзначное число");
}
