﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using Tyuiu.KoevaSJ.Sprint5.Task0.V19.Lib;

namespace Tyuiu.KoevaSJ.Sprint5.Task0.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 3;

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила : Коева С. Ю. | АСОиУб-23-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                    *");
            Console.WriteLine("* Класс File. Запись данных в текстовый файл                                   *");
            Console.WriteLine("* Задание #0                                                                   *");
            Console.WriteLine("* Вариант #19                                                                  *");
            Console.WriteLine("* Выполнила Коева Софья Юрьевна | АСОиУб-23-1                                  *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3                              *");
            Console.WriteLine("* Результат сохранить в текстовый файл OutPutFileTask0.txt                     *");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("********************************************************************************");
            


            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            string res = ds.SaveToFileTextData(y);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан");
            Console.ReadKey();
        }
    }
}
