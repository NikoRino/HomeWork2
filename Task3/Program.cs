Console.Write("Введите день недели ");
int Day = Convert.ToInt32(Console.ReadLine());
if (Day < 6)
{
    Console.Write("Это будний день");
}

else
{
    if (Day > 7)
    {
        Console.Write("Введите число от 1 до 7");
    }

    else
    {
        Console.Write("Это выходной день");
    }

}