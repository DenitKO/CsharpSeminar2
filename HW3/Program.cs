int day = 0;
 
    while (true)
    {
        Console.WriteLine("Введите день недели (от 1 до 7)");
        day = Convert.ToInt32(Console.ReadLine());
 
        if (day < 1 || day > 7)
        {
            continue;
        }
 
        break;
    }
if (day > 5 & day < 8)
{
    Console.Write("Сегодня выходной день, и это ");
    Console.WriteLine(day);
} else
{
    Console.Write("Сегодня будние, и это ");
    Console.WriteLine(day);    
}