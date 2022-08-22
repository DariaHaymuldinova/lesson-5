// Программа возводит число А в натуральную степень В

Console.WriteLine("Введите два числа: ");
double numberA = Convert.ToInt32(Console.ReadLine());
double numberB = Convert.ToInt32(Console.ReadLine());
double result = Math.Pow(numberA, numberB);
Console.WriteLine(result);