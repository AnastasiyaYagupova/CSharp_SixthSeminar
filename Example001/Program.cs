/*
Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Не использовать массив.
M=5 ; 0, 7, 8, -2, -2 -> 2
M=5 ; -1, -7, 567, 89, 223 -> 3
*/

Console.WriteLine("Введите число");
int M = Convert.ToInt32(Console.ReadLine());

int count = 0;
int time = 1;

while(M >= time)
{
    Random rand = new Random();
    int num = rand.Next(-10,11);
    Console.WriteLine(num);
    if(num > 0)
    {
        count++;
        time++;
    }
    else
    {
        time++;
    }
}

Console.WriteLine($"Чисел больше нуля = {count}");
