int FindSecondDigit(int a)
{
int FirstDigit = a / 10;
int SecondDigit = FirstDigit % 10;

return SecondDigit;
}

Console.WriteLine("Введите трехзначное число");

int b = Convert.ToInt32(Console.ReadLine());

FindSecondDigit(b);

Console.WriteLine("Второе по разрядности число равно = ");

int WhatIsSecond = FindSecondDigit(b);

Console.WriteLine(WhatIsSecond);