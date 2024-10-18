using Tyuiu.TimoninIA.Sprint2.Task6.V6.Lib;
namespace Tyuiu.TimoninIA.Sprint2.Task6.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Тимонин Иван Александрович | ИИПБ-24-1";
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                         *");
            Console.WriteLine("* Тема: Получение результата из switch                                              *");
            Console.WriteLine("* Задание #6                                                                        *");
            Console.WriteLine("* Вариант #6                                                                        *");
            Console.WriteLine("* Выполнил: Тимонин Иван Александрович | ИИПБ-24-1                             *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Задание:                                                                          *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи оператора switch  *");
            Console.WriteLine("* вычисляет требуемое значение и возвращает результат.                              *");
            Console.WriteLine("* Условие: Мастям игральных карт условно присвоены следующие порядковые номера:     *");
            Console.WriteLine("* масти «пики» — 1, масти «трефы» — 2, масти «бубны» — 3, масти «червы» — 4,        *");
            Console.WriteLine("* а достоинству карт:  «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14       *");
            Console.WriteLine("* (порядковые номера карт остальных достоинств соответствуют их названиям:          *");
            Console.WriteLine("* «шестерка», «девятка» и т. п.).  По заданным номеру масти m (1 <= m <= 4) и       *");
            Console.WriteLine("* номеру достоинства карты k (6 <= k <= 14) определить полное название              *");
            Console.WriteLine("* (масть и достоинство) соответствующей карты в виде «Дама пик»,                    *");
            Console.WriteLine("* Шестерка бубен» и т.п.                                                            *");
            Console.WriteLine("*                                                                                   *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine("Введите номер масти:");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер достоинства карты:");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine($"Полное название: {ds.FindCardNameAndValue(m, k)}");

            Console.ReadKey();
        }
    }
}