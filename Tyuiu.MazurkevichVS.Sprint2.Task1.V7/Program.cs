using Tyuiu.MazurkevichVS.Sprint2.Task1.V7.Lib;

DataService ds = new DataService();
int a = 195;
int b = 16;
int c = 14;
int d = 45;
bool[] res = new bool[6];
res = ds.GetLogicOperations(a, b, c, d);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("A = " + a);
Console.WriteLine("B = " + b);
Console.WriteLine("C = " + c);
Console.WriteLine("D = " + d);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

for (int i = 0; i < 6; i++)
{
    Console.WriteLine(res[i]);
}
Console.ReadKey();