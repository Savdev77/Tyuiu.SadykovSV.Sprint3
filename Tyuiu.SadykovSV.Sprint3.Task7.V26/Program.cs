using Tyuiu.SadykovSV.Sprint3.Task7.V26.Lib;

Console.Title = "Спринт #3 | Выполнил: Садыков С.В. | ПИНб-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #26                                                             *");
Console.WriteLine("* Выполнил: Садыков С.В. | ПИНб-26-1                                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая выводит таблицу значений функции на         *");
Console.WriteLine("* заданном диапазоне [-5; 5] с шагом 1. Значения занести в массив.        *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
int startValue = -5;
int stopValue = 5;

Console.WriteLine($"Старт диапазона = {startValue}");
Console.WriteLine($"Конец диапазона = {stopValue}");

double[] func = ds.GetMassFunction(startValue, stopValue);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("+----------+-----------+");
Console.WriteLine("|    X     |   f(x)    |");
Console.WriteLine("+----------+-----------+");

for (int i = 0; i <= func.Length; i++)
{
    Console.WriteLine($"| {startValue,8} | {func[i],9} |");
    startValue++;
}

Console.WriteLine("+----------+-----------+");
Console.ReadKey();