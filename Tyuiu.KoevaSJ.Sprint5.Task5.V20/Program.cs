using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using Tyuiu.KoevaSJ.Sprint5.Task5.V20.Lib;

namespace Tyuiu.KoevaSJ.Sprint5.Task5.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила : Коева С. Ю. | АСОиУб-23-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                    *");
            Console.WriteLine("* Обработка файлов                                                             *");
            Console.WriteLine("* Задание #5                                                                   *");
            Console.WriteLine("* Вариант #20                                                                  *");
            Console.WriteLine("* Выполнила Коева Софья Юрьевна | АСОиУб-23-1                                  *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("*  Найти среднее значение всех целых чисел в файле,                            *");
            Console.WriteLine("* которые находятся в промежутке от -10 до 10.                                 *");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask5V20.txt";
            Console.WriteLine("Файл: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Среднее значение = " + res);
            Console.ReadKey();
        }
    }
}
