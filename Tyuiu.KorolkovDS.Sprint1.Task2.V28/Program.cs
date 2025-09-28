using Tyuiu.KorolkovDS.Sprint1.Task2.V28.Lib;

DataService ds = new DataService();

Console.Title = "Спринт 1 | Выполнил Корольков Д. С. | ПИНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт 1                                                                *");
Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #28                                                             *");
Console.WriteLine("* Выполнил: Корольков Дмитрий Сергеевич | ПИНб-25-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Введите температуру в градусах Цельсия: ");
int x;
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Температура в градусах Кельвина : " + ds.ConvertCelsiusToKelvin(x));
Console.ReadKey();