using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.TimoninIA.Sprint2.Task0.V14.Lib
{
    public class DataService : ISprint2Task0V14
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = x == y + 321;
            res[1] = x != y + 321;
            res[2] = x < y + 322;
            res[3] = x > y + 322;
            res[4] = x <= y + 321;
            res[5] = x >= y + 322;

            return res;
        }
    }
}

