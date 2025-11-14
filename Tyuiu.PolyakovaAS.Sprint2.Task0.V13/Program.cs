using Tyuiu.PolyakovaAS.Sprint2.Task0.V13.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #2 | Выполнила Полякова А С. | СТНб-24-1";
Console.WriteLine("***************************************************************************************************");
Console.WriteLine("* Спринт #2                                                                                       *");
Console.WriteLine("* Тема: Базовые навыки работы с C#                                                                *");
Console.WriteLine("* Задание #0                                                                                      *");
Console.WriteLine("* Вариант #13                                                                                     *");
Console.WriteLine("* Выполнила: Полякова А С | ИСТНб-24-1                                                            *");
Console.WriteLine("***************************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                                        *");
Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность операций     *");
Console.WriteLine("* не должна нарушаться) и арифметических выражений, которая вернет логическую                     *");
Console.WriteLine("* последовательность(массив): (False, True, False, True, False, True), при x = 1905, y = 475      *");
Console.WriteLine("***************************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                *");
Console.WriteLine("***************************************************************************************************");

int x = 1905;
int y = 475;
bool[] res = new bool[6];
res = ds.GetCompareOperations(x, y);

Console.WriteLine("Значение X = " + x);
Console.WriteLine("Хначение Y = " + y);

Console.WriteLine("***************************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                      *");
Console.WriteLine("***************************************************************************************************");

for (int i = 0; i < 6; i++)
{
    Console.WriteLine(res[i]);
}

Console.ReadKey();