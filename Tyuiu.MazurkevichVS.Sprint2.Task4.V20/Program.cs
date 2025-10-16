using Tyuiu.MazurkevichVS.Sprint2.Task4.V20.Lib;
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите значение переменной X:");
double x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение переменной Y:");
double y = Convert.ToInt32(Console.ReadLine());

DataService ds = new DataService();
double z = ds.Calculate(x, y);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Z = " + z);

Console.ReadKey();