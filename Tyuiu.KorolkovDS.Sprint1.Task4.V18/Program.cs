using Tyuiu.KorolkovDS.Sprint1.Task4.V18.Lib;
DataService ds =  new DataService();

Console.Title = "Спринт 1 | Выполнил Корольков Д. С. | ПИНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт 1                                                                *");
Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #18                                                             *");
Console.WriteLine("* Выполнил: Корольков Дмитрий Сергеевич | ПИНб-25-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");


double x, y;
Console.WriteLine("Введите значение Х");
x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение У");
y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("((3+x)^(1/2))/(x*y)^2 = " + ds.Calculate(x,y));
Console.ReadKey();