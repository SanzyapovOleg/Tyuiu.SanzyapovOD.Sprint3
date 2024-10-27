using Tyuiu.SanzyapovOD.Sprint3.Task1.V16.Lib;
namespace Tyuiu.SanzyapovOD.Sprint3.Task1.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Санзяпов О. Д. | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла while                                              *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Санзяпов Олег Дмитриевич| ИСТНб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл while,                                *");
            Console.WriteLine("* которая вычисляет сумму ряда по формуле, при х=0,7.                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double value = 0.7;
            int startValue = 1;
            int stopValue = 15;
            Console.WriteLine("Переменная X: " + value);
            Console.WriteLine("Старт шага: " + startValue);
            Console.WriteLine("Конец шага: " + stopValue);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(value, startValue, stopValue));
            Console.ReadKey();
        }
    }
}
