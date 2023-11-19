using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using Tyuiu.KoevaSJ.Sprint5.Task1.V17.Lib;

namespace Tyuiu.KoevaSJ.Sprint5.Task1.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            int startValue = 5;
            int stopValue = -5;

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила : Коева С. Ю. | АСОиУб-23-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                    *");
            Console.WriteLine("* Класс File. Запись набора данных в текстовый файл                            *");
            Console.WriteLine("* Задание #1                                                                   *");
            Console.WriteLine("* Вариант #17                                                                  *");
            Console.WriteLine("* Выполнила Коева Софья Юрьевна | АСОиУб-23-1                                  *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дана функция, произвести табулирование от -5 до 5 с шагом 1. Произвести      *");
            Console.WriteLine("* проверку деления на ноль. При делении на ноль вернуть значение 0.            *");

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();



        }
    }
}
