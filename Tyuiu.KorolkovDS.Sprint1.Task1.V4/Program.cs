using Tyuiu.KorolkovDS.Sprint1.Task1.V4.Lib;

DataService ds = new DataService();

Console.Title = "Спринт 1 | Выполнил Корольков Д. С. | ПИНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт 1                                                                *");
Console.WriteLine("* Тема: Создание ввода/вывода в консольных приложениях                    *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #4                                                              *");
Console.WriteLine("* Выполнил: Корольков Дмитрий Сергеевич | ПИНб-25-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
Console.WriteLine("* вычисляет результат по формуле (x+y)/x*y и печатает его на экране.      *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: (x + y) / x * y                                        *");
Console.WriteLine("***************************************************************************");

double x, y;
Console.WriteLine("Введите значение Х:");
x = Convert.ToDouble(Console.ReadLine());   

Console.WriteLine("Введите значение Y:");
y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
Console.WriteLine("***************************************************************************");


Console.WriteLine( ds.Calculate(x,y));
Console.ReadKey();
