/*
Задача 3*. Найдите сумму произведений пар чисел в одномерном целочисленном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. Если кол-во элементов нечетное, 
то элемент посередине не учитывать.
Результат сложения вывести на экран.
1, 3, 8, 3, 2 -> 11
8, 3, 4, 2 -> 28
*/

void FillArray(int[] collection)
{
Random rand = new Random();
int Length = collection.Length;
    for (int i = 0; i < Length; i++)
    {
     collection[i] = rand.Next(0, 11);
    }
} 

void PrintArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;  
     while(index < Length)
    {
        Console.Write($"{collection[index]} ");
        index++;
    }
}

int AditionPaitsOfNumbers(int[] collection)
{
    int result = 0;
    int Length = collection.Length;
    int index = 0;
    int count = collection.Length / 2;
    while(index < count)
    {
        result = result + collection[index] + collection[Length-1];
        index++;
        Length--;
    }
    return result;
}

int[] Array = new int[5];
FillArray(Array);
PrintArray(Array);
int answer = AditionPaitsOfNumbers(Array);
Console.Write("->  ");
Console.WriteLine(answer);