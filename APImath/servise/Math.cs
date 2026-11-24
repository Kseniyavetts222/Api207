using System;

namespace calc2
{
    internal class Math
    {
        public double sum(double a, double b)
        {
            return a + b;
        }

        public double minus(double a, double b)
        {
            return a - b;
        }

        public double del(double a, double b)
        {
            return a / b;
        }

        public double multiplication(double a, double b)
        {
            return a * b;
        }

        public double percent(double a, double b)
        {
            return a * (b / 100);
        }

        public double depercent(double a, double b)
        {
            return (a / 100) * b;
        }

        public double factorial_a(double a)
        {
            double factorial = 1;

            if (a < 0)
            {
                Console.WriteLine(" Факториал вычислить нельзя.Вводимое значение <0");
                return 0;
            }

            if (a == 0)
            {
                return 1;
            }

            if (a == 1)
            {
                return 1;
            }

            for (int i = 1; i <= a; i = i + 1)
            {
                factorial = factorial * i;
            }

            return factorial;
        }

        public double Summ(double[] values)
        {
            double total = 0;

            foreach (double value in values)
            {
                total = total + value;
            }

            return total;
        }
        public double Count(double[] numbers)
        {
            return numbers.Length;
        }
        public double Max(double[] numbers)
        {
            var result = numbers[0];
            foreach (var number in numbers)
            {
                if (result < number)
                {
                    result = number;
                }
            }
            return result;
        }
        public double Min(double[] numbers)
        {
            var result = numbers[0];
            foreach (var number in numbers)
            {
                if (result > number)
                {
                    result = number;
                }
            }
            return result;
        }
        public double Exdiv(double num1, double num2)
        {
            return num1 % num2;
        }
    }
}