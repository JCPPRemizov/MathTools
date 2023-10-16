using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTools
{
    
    public static class MathTools
    {
        /// <summary>
        /// Метод для вычисления корней квадратного уравнения
        /// </summary>
        /// <param name="a">Старший коэфициент</param>
        /// <param name="b">Средний коэфициент</param>
        /// <param name="c">Свободный член</param>
        /// <returns>Динамический массив типа "dynamic"</returns>
        public static List<dynamic> SolveQuadraticEquation(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;
            if (discriminant > 0)
            {
                dynamic root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                dynamic root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                return new List<dynamic> { root1, root2 };
            }
            else if (discriminant == 0)
            {
                dynamic root = -b / (2 * a);
                return new List<dynamic> { root };
            }
            else
            {
                double realPart = -b / (2 * a);
                double imaginaryPart = Math.Sqrt(Math.Abs(discriminant)) / (2 * a);
                dynamic root1 = realPart + "+" + imaginaryPart + "i";
                dynamic root2 = realPart + "-" + imaginaryPart + "i";
                return new List<dynamic> { root1, root2 };
            }
        }

        public static double CalculatePercentage(double number, double percentage)
        {
            return (percentage / 100) * number;
        }
    }
}
