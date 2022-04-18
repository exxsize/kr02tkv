using static System.Console;
using static MyMath.MyFunc;


namespace Zadan3
{
    /// Контрольная работа №2 РЕАЛИЗОВАТЬ МЕТОДЫ
    /// Вариант
    /// Задача № 4
    /// Автор (на русском): Томилов Кирилл
    class Zadan4
    {
        static void Main(string[] args)
        {
            int i = 10;

            while (i <= 99)
            {
                if (Z4(i) != 0)
                {
                    WriteLine(Z4(i));
                }
                i++;
            }
            ReadKey();
        }
    }
}