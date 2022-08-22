// Программа задает массив из 8 элементов и выводит их на экран

int[] array = new int[8];
Random myRandom = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = myRandom.Next();
    Console.WriteLine("{0}", array[i]); 
}
