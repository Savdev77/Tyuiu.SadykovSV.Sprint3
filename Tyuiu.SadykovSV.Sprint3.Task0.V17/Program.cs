using Tyuiu.SadykovSV.Sprint3.Task0.V17.Lib;
Console.Title = "Спринт #3 | Выполнил: Садыков С.В. | ПИНб-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Операторы цикла for                                               *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #17                                                             *");
Console.WriteLine("* Выполнил: Садыков С.В. | ПИНб-26-1                                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу используя цикл for, которая вычисляет сумму ряда     *");
Console.WriteLine("* по формуле S = сумма от i=1 до 10 (cos(i) * 1/2).                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int startValue = 1;
int stopValue = 10;

Console.WriteLine($"Стартовое значение: {startValue}");
Console.WriteLine($"Конечное значение: {stopValue}");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
double res = ds.GetSumSeries(startValue, stopValue);

Console.WriteLine($"Сумма ряда равна: {res}");

Console.ReadKey();