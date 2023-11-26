﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using Tyuiu.KoevaSJ.Sprint5.Task4.V1.Lib;

namespace Tyuiu.KoevaSJ.Sprint5.Task4.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила : Коева С. Ю. | АСОиУб-23-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                    *");
            Console.WriteLine("* Чтение данных из текстового файла                                            *");
            Console.WriteLine("* Задание #4                                                                   *");
            Console.WriteLine("* Вариант #1                                                                   *");
            Console.WriteLine("* Выполнила Коева Софья Юрьевна | АСОиУб-23-1                                  *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Прочитать значение из файла и подставить вместо Х в формуле                  *");
            Console.WriteLine("* Вычислить значение по формуле                                                *");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask4V1.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}