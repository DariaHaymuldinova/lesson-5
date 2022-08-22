// Программа выдает сумму цифр в числе

Console.WriteLine("Введите числo: ");
int number = Convert.ToInt32(Console.ReadLine());
int Sum = 0;
while (number > 0)
{
    Sum = Sum + number % 10;
    number = number / 10;
}
Console.WriteLine(Sum);