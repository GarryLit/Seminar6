/*
Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*/

// В ответе судя по всему опечатка. Правильно (-0,5; -0,5)

double InputNumber(string name)
{
    System.Console.Write($"Введите  {name} = ");    
    double number = Convert.ToDouble(Console.ReadLine());
    return number;        
}

double b1 = InputNumber("b1");
double b2 = InputNumber("b2");
double k1 = InputNumber("k1");
double k2 = InputNumber("k2");

double x = (b1 - b2) / (k2 - k1);
double y = (k2 * b1 - k1 * b2) / (k2 - k1);
System.Console.WriteLine(y);
System.Console.WriteLine(x);

