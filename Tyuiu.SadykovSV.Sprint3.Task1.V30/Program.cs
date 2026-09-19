using Tyuiu.SadykovSV.Sprint3.Task1.V30.Lib;
Console.Title = "Спринт #3 | Выполнил: Садыков С.В. | ПИНб-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Операторы цикла while                                             *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #30                                                             *");
Console.WriteLine("* Выполнил: Садыков С.В. | ПИНб-26-1                                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу используя цикл while, которая вычисляет сумму ряда   *");
Console.WriteLine("* по формуле S = сумма от k=1 до 12 ((t^k + 5/(k+4)) * sin(t)), где t=0,5 *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

double value = 0.5;
int startValue = 1;
int stopValue = 12;

Console.WriteLine($"Переменная t = {value}");
Console.WriteLine($"Стартовое значение k = {startValue}");
Console.WriteLine($"Конечное значение k = {stopValue}");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
double res = ds.GetSumSeries(value, startValue, stopValue);

Console.WriteLine($"Сумма ряда равна: {res}");

Console.ReadKey();