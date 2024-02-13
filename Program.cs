using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    class Program
    {

        

        static void Print(out int number)
        {
            number = 10;
            Console.WriteLine($"Переменная number = {number}");
        }

        static void Main(string[] args)
        {
            //string str = "Hello";  
            //string str1 = str;
            //str1 = "Bye";
            //Console.WriteLine($"Переменная str = {str}");
            //Console.WriteLine($"Переменная str1 = {str1}");


            //int a = 100;
            //Print(out a);

            //Console.WriteLine($"Переменная а = {a}");
            //int rezult;


            //bool b = int.TryParse(Console.ReadLine(), out rezult);
            //Console.WriteLine($"Переменная rezult = {rezult}");

            //Complex cmp1;
            //cmp1.im = -3;
            //cmp1.re = 10;
            //Console.WriteLine(cmp1);

            //Complex cmp2;
            //cmp2.im = 5;
            //cmp2.re = -1;
            //Console.WriteLine(cmp2);

            //Console.WriteLine(Complex.Plus(cmp1, cmp2));
            //Complex cpmSum = Complex.Plus(cmp1, cmp2);

            //Console.WriteLine(cmp1.Plus(cmp2)); 


            Fraction fr1 = new Fraction(3,0);
            Console.WriteLine(fr1);

            fr1.Numerator = 4;

            Console.WriteLine(fr1);


            
        }

        



    }

    /// <summary>
    /// Класс, описывающий логику работы с дробями
    /// </summary>
    public class Fraction
    {
        /// <summary>
        /// Числитель дроби
        /// </summary>
        private int _numerator;

        public int Numerator
        {
            get { return _numerator; }
            set { _numerator = value; }
        }

        /// <summary>
        /// Знаменатель дроби
        /// </summary>
        private int _denumenator;

        public int Denumenator
        {
            get { return _denumenator; }
            set {

                try
                {
                    if (value == 0)
                    {
                        throw new Exception("На ноль делить нельзя");
                    }
                    else
                    {
                        _denumenator = value;
                    }
                    
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

                
                
            }
        }

        public Fraction(int num, int denum)
        {
            Numerator = num;
            Denumenator = denum;
            
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denumenator}";
        }


    }

    /// <summary>
    /// Структура комплексных чисел
    /// </summary>
    struct Complex
    {
        /// <summary>
        /// Действительная часть
        /// </summary>
        public double re;

        /// <summary>
        /// Мнимая часть
        /// </summary>
        public double im;

        /// <summary>
        /// Статический метод для сложения комплексных чисел
        /// </summary>
        /// <param name="complex1">description</param>
        /// <param name="complex2"></param>
        /// <returns>Возвращает комплексное число</returns>
        public static Complex Plus(Complex complex1, Complex complex2)
        {
            Complex complexRes;
            complexRes.im = complex1.im + complex2.im;
            complexRes.re = complex1.re + complex2.re;
            return complexRes;
        }
        /// <summary>
        /// Нестатический метод для сложения комплексных чисел
        /// </summary>
        /// <param name="complex1"></param>
        /// <returns>Возвращает комплексное число</returns>
        public Complex Plus(Complex complex1)
        {
            Complex complexRes;
            complexRes.im = complex1.im + im;
            complexRes.re = complex1.re + re; 
            return complexRes;
        }

        public static Complex Minus(Complex complex1, Complex complex2)
        {
            Complex complexRes;
            complexRes.im = complex1.im - complex2.im;
            complexRes.re = complex1.re - complex2.re;
            return complexRes;
        }

        public Complex Minus(Complex complex1)
        {
            Complex complexRes;
            complexRes.im = complex1.im - im;
            complexRes.re = complex1.re - re;
            return complexRes;
        }

        public override string ToString()
        {
            return $"{re} + {im}i";
        }
    }
}
