using Tyuiu.MazurkevichVS.Sprint2.Task6.V15.Lib;
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите число дня в году:");
int k = Convert.ToInt32(Console.ReadLine());


DataService ds = new DataService();
string res = ds.FindDayName(k);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("День недели: " + res);

Console.ReadKey();