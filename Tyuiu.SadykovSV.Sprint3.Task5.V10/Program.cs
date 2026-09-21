using Tyuiu.SadykovSV.Sprint3.Task5.V10.Lib;
Console.Title = "Спринт #3 | Выполнил: Садыков С.В. | ПИНб-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Вложенные циклы                                                   *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #10                                                             *");
Console.WriteLine("* Выполнил: Садыков С.В. | ПИНб-26-1                                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Вычислить сумму ряда y = сумма от i=1 до 3 (сумма от k=1 до 10          *");
Console.WriteLine("* (x^3 * k) + 2) при x = 5.                                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int x = 5;
int startValue1 = 1;
int stopValue1 = 3;
int startValue2 = 1;
int stopValue2 = 10;

Console.WriteLine($"Переменная x = {x}");
Console.WriteLine($"Старт внешнего цикла i = {startValue1}");
Console.WriteLine($"Конец внешнего цикла i = {stopValue1}");
Console.WriteLine($"Старт внутреннего цикла k = {startValue2}");
Console.WriteLine($"Конец внутреннего цикла k = {stopValue2}");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

Console.WriteLine($"Сумма двойного ряда равна: {res}");

Console.ReadKey();