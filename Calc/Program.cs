using System;
using System.Text;
using System.Threading.Tasks;

namespace calculator_c_sharp
{
    class Public
    {
        static void Main(string[] args)
        {
            float one, two, result;
            char sign;
            Console.WriteLine("Добро пожаловать в калькулятор. Вам нелбходимо ввести первое число, затем знак действия(+,-,*,/), которое хотите совершить и второе число.");
            Console.Write("Введите первое число: ");
            one = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите знак действия : ");
            sign = Convert.ToChar(Console.ReadLine());
            Console.Write("Введите Второе число: ");
            two = Convert.ToSingle(Console.ReadLine());
        }
        public void Doaddition()
        {
            static void Main(string[] args)
            {
                if (sign == '+')
                {
                    result = one + two;
                    Console.WriteLine("Сумма ваших чисел равна " + result);
                    Console.WriteLine("Для выхода нажмите любую клавишу...");
                    Console.ReadKey();
                }
            }
        }
        public void Vichitan()
        {
            static void Main(string[] args)
            {
                if (sign == '-')
                {
                    result = one - two;
                    Console.WriteLine("Разность ваших чисел равна " + result);
                    Console.WriteLine("Для выхода нажмите любую клавишу...");
                    Console.ReadKey();
                }
            }
        }
        public void Umnochenie()
        {
            static void Main(string[] args)
            {
                if (sign == '*')
                {
                    result = one * two;
                    Console.WriteLine("Произведение ваших чисел равно " + result);
                    Console.WriteLine("Для выхода нажмите любую клавишу...");
                    Console.ReadKey();
                }
            }
        }
        public void Deleniye()
        {
            static void Main(string[] args)
            {
                if (sign == '/')
                {
                    result = one / two;
                    Console.WriteLine("Частное ваших чисел равно " + result);
                    Console.WriteLine("Для выхода нажмите любую клавишу...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Ошибка. Вы ввели неверный знак.");
                    Console.WriteLine("Для выхода нажмите любую клавишу...");
                    Console.ReadKey();
                }
        }
    }
