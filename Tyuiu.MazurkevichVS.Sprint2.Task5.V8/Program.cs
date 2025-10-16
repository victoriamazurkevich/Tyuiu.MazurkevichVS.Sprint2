using Tyuiu.MazurkevichVS.Sprint2.Task5.V8.Lib;
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите число месяца:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите порядковый номер месяца:");
int n = Convert.ToInt32(Console.ReadLine());

DataService ds = new DataService();
string res = ds.FindDateOfPreviousDay(m, n);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Дата предыдущего дня: " + res);

Console.ReadKey();