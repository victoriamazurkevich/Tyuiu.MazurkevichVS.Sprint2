using Tyuiu.MazurkevichVS.Sprint2.Task3.V29.Lib;
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите значение переменной X:");
double x = Convert.ToInt32(Console.ReadLine());

DataService ds = new DataService();
double y = ds.Calculate(x);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine(y);

Console.ReadKey();