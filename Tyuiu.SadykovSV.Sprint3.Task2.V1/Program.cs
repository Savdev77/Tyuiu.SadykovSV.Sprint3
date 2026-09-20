using Tyuiu.SadykovSV.Sprint3.Task2.V1.Lib;

Console.Title = "Спринт #3 | Выполнил: Садыков С.В. | ПИНб-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Оператор цикла do-while                                           *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #1                                                              *");
Console.WriteLine("* Выполнил: Садыков С.В. | ПИНб-26-1                                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет сумму   *");
Console.WriteLine("* ряда по формуле S = сумма от i=1 до 10 (sin(i) * (1/2)^2).              *");
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