/*
Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

Console.Write("Какое количество чисел Вы хотите ввести? - ");
int amountNumbers = Convert.ToInt32(Console.ReadLine());

int numberPositive = 0; 

for(int i = 1; i <= amountNumbers; i++ )
{
    Console.Write($"Введите число {i} ");
    int userNumber = Convert.ToInt32(Console.ReadLine());
    if (userNumber > 0)
        numberPositive ++;
}

System.Console.WriteLine($"Вы ввели {numberPositive} положительных числа");