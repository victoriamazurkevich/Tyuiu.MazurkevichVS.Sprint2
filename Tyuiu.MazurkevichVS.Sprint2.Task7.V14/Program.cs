using Tyuiu.MazurkevichVS.Sprint2.Task7.V14.Lib;
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите значение для X:");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение для Y:");
double y = Convert.ToDouble(Console.ReadLine());

DataService ds = new DataService();
bool res = ds.CheckDotInShadedArea(x, y);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
if (res)
    Console.WriteLine("Точка находится в заштрихованной области");
else
    Console.WriteLine("Точка не находится в заштрихованной области");

Console.ReadKey();
