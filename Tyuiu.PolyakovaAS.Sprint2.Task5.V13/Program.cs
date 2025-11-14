using Tyuiu.PolyakovaAS.Sprint2.Task5.V13.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #2 | Выполнил: Полякова А. С | ИСТНб-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Оператор switch                                                   *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #13                                                             *");
Console.WriteLine("* Выполнил: Полякова А С | ИСТНб-24-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
Console.WriteLine("* требуемое значение и возвращает результат.                              *");
Console.WriteLine("* Дата некоторого дня характеризуется тремя натуральными числами:         *");
Console.WriteLine("* g(год), m(порядковый номер месяца) и n(число). По заданным g, n и m     *");
Console.WriteLine("* определить дату следующего дня.Заданный год является високосным.        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите номер дня: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер месяца: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер года: ");
int g = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Дата следующего дня: " + ds.FindDateOfNextDay(g, m, n));

Console.ReadKey();