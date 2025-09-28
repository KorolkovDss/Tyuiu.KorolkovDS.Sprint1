using Tyuiu.KorolkovDS.Sprint1.Task0.V21.Lib;
DataService ds = new DataService();
Console.Title = "Спринт 1 | Выполнил Корольков Д. С. | ПИНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт 1                                                                *");
Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #21                                                             *");
Console.WriteLine("* Выполнил: Корольков Дмитрий Сергеевич | ПИНб-25-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет выражение 3*4+10/2                *");
Console.WriteLine("* и печатает результат на экране.                                         *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:   3*4+10/2                                             *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
Console.WriteLine("***************************************************************************");


Console.WriteLine(ds.Calculate());
Console.ReadKey();

