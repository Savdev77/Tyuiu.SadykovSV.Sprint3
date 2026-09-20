using Tyuiu.SadykovSV.Sprint3.Task3.V8.Lib;

Console.Title = "Спринт #3 | Выполнил: Садыков С.В. | ПИНб-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #8                                                              *");
Console.WriteLine("* Выполнил: Садыков С.В. | ПИНб-26-1                                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Используя цикл foreach удалить все буквы и знаки препинания, оставить   *");
Console.WriteLine("* цифру затем преобразовать в число в строке: vc,x12fc fc!e               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string value = "vc,x12fc fc!e";

Console.WriteLine($"Исходная строка: {value}");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
int res = ds.ConvertStringToInt(value);

Console.WriteLine($"Полученное число: {res}");

Console.ReadKey();