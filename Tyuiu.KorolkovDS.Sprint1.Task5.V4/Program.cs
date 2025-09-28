using Tyuiu.KorolkovDS.Sprint1.Task5.V4.Lib;

DataService ds = new DataService();

Console.Title = "Спринт 1 | Выполнил Корольков Д. С. | ПИНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт 1                                                                *");
Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #4                                                              *");
Console.WriteLine("* Выполнил: Корольков Дмитрий Сергеевич | ПИНб-25-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая решает следующую задачу:                    *");
Console.WriteLine("* Идет k-я секунда суток. Определить, сколько полных часов (h)            *");
Console.WriteLine("* прошло к этому моменту.                                                 *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
int time = 13257;
Console.WriteLine(time + " Секунд");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Прошло полных часов :"+ ds.SecondsToHours(time));
Console.ReadKey();