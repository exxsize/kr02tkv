using MyMath;
using static System.Console;

namespace Zadan1
{
    /// Контрольная работа №2 РЕАЛИЗОВАТЬ МЕТОДЫ
    /// Вариант
    /// Задача № 1
    /// Автор (на русском): Томилов Кирилл
    class Z1
    {
        static void Main(string[] args)
        {
            double x = 1;
            while (x <= 3.1)
            {
                WriteLine($"{(x):#.##}\t{MyFunc.Z1(x):0.##}");
                x += 0.2;
            }
            ReadKey();
        }
    }
}