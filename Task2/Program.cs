Console.Write("Введите число:");

int Value = Convert.ToInt32(Console.ReadLine());
int Length = Value.ToString().Length;
if (Length > 2)
{
    int result = (Value / 100) % 10;
    Console.WriteLine($"Третья цифра {result}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
