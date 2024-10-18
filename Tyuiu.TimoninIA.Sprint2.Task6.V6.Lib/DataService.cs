using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TimoninIA.Sprint2.Task6.V6.Lib
{
    public class DataService : ISprint2Task6V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            switch (value1)
            {
                case 1:
                    switch (value2)
                    {
                        case 6: return "Шестёрка пик";
                        case 7: return "Семёрка пик";
                        case 8: return "Восьмёрка пик";
                        case 9: return "Девятка пик";
                        case 10: return "Десятка пик";
                        case 11: return "Валет пик";
                        case 12: return "дама пик";
                        case 13: return "Король пик";
                        case 14: return "Туз пик";
                    }
                    return "Введено неправильное число ";

                case 2:
                    switch (value2)
                    {
                        case 6: return "Шестёрка треф";
                        case 7: return "Семёрка треф";
                        case 8: return "Восьмёрка треф";
                        case 9: return "Девятка треф";
                        case 10: return "Десятка треф";
                        case 11: return "Валет треф";
                        case 12: return "Дама треф";
                        case 13: return "Король треф";
                        case 14: return "Туз треф";
                    }
                    return "Введено неправильное число ";

                case 3:
                    switch (value2)
                    {
                        case 6: return "Шестёрка бубен";
                        case 7: return "Семёрка бубен";
                        case 8: return "Восьмёрка бубен";
                        case 9: return "Девятка бубен";
                        case 10: return "Десятка бубен";
                        case 11: return "Валет бубен";
                        case 12: return "Дама бубен";
                        case 13: return "Король бубен";
                        case 14: return "Туз бубен";
                    }
                    return "Введено неправильное число ";

                case 4:
                    switch (value2)
                    {
                        case 6: return "Шестёрка черви";
                        case 7: return "Семёрка черви";
                        case 8: return "Восьмёрка черви";
                        case 9: return "Девятка черви";
                        case 10: return "Десятка черви";
                        case 11: return "Валет черви";
                        case 12: return "Дама черви";
                        case 13: return "Король черви";
                        case 14: return "Туз черви";
                    }
                    return "Введено неправильное число ";
                default: return "Введено неправильное число";
            }
        }
    }
}