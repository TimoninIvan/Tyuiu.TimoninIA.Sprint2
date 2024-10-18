using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TimoninIA.Sprint2.Task7.V12.Lib
{
    public class DataService : ISprint2Task7V12
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            //bool z = (y <= Math.Pow(x, 2)) && (y >= 2 - x);
            //bool t = (x <= -2 && x >= 0 && x <= 2 && y >= 0 && y <= 2 && y >= 4);
            //bool t = (y >= 0) && y >= Math.Pow(x, 2) && (y <= 2 - x);
            //if (y <= Math.Pow(x, 2) && y <= 2 && x >= 0 && x <= 1 && y >= 0 && y >= 4)
            if (y <= Math.Pow(x, 2) && y >= 0 && x <= -2 && x <= 2 && y <= 1 && y >= 4)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}


//y <= Math.Pow(x, 2) && x <= 2 - x && x >= 0 && x <= 2 && y >= 0 && y >= 4
//y <= x^2 && x<=-2 && x>= 0 && x <= 2 && y >= 0 && y<= 2 && y>= 4