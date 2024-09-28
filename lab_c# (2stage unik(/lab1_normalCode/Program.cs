using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace lab1_normalCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }
    }

    class Menu
    {
        Solve solution1 = new Solve();
        int choice = 0;
        int numb = 0;

        public void choose()
        {
            checkType checkVar = new checkType();
            int choice = 0;

            while (true){
                Console.WriteLine("Введите номер задания");
                (checkVar as Icheck).check(ref choice);
                if (choice == -1) break;
                Console.WriteLine($"Задание #{choice} \n");

                switch (choice)
                {
                    case 1:
                        List<double> list = new List<double>();
                        (checkVar as Icheck).check(list, true);
                        solution1.Square(list);
                        list.Clear();
                        break;

                    case 2:
                        list = new List<double>();
                        (checkVar as Icheck).check(list);
                        solution1.SquareProblem(list);
                        break;

                    case 3:
                        Console.WriteLine("Введите число, которое необходимо преобразовать в слово (от 0 до 1000) \n");
                        (checkVar as Icheck).check(ref numb);
                        Console.WriteLine($"число {numb} соответствует слову {solution1.NumberToWords(numb)}");
                        break;
                }
            }
        }
        

    }

    class Solve
    {
        public double Square(List<double> list) {
            double a = (2 + list[0]) * (1 + list[1] / (list[0] * list[0] + 3)) / (list[1] * list[1] + 1 / (list[2] * list[2] + 4));
            double b = (1 + Math.Tan(list[0] / 2) * Math.Tan(list[0] / 2));
            double p = a + b + list[2];
            return Math.Sqrt(p * (p - a) * (p - b) * (p - list[2]));
        }

        public string SquareProblem(List<double> list)
        {
            double disk = list[1] * list[1] - 4 * list[0] * list[2];

            if (disk > 0)
            {
                return ("x1 = " + (-list[1] + Math.Sqrt(disk)) / (2 * list[0]) + "\n" +
                    "x2 = " + (-list[1] - Math.Sqrt(disk)) / (2 * list[0]));
            }

            else if (disk == 0) return ("x12 = " + (-list[1] - Math.Sqrt(disk)) / (2 * list[0]));

            else return ("Данное квадратное уравнение не имеет решений");
        }

        public string NumberToWords(int number)
        {
            if (number == 1000)
                return "тысяча";
            if (number == 0) return "ноль";
            string[] units = { "", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
            string[] teens = { "десять", "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать" }; string[] tens = { "", "десять", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто" };
            string[] hundreds = { "", "сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот", "семьсот", "восемьсот", "девятьсот" };
            string words = "";
            if (number >= 100)
            {
                words += hundreds[number / 100] + " "; number %= 100;
            }
            if (number >= 20)
            {
                words += tens[number / 10] + " "; number %= 10;
            }
            else if (number >= 10)
            {
                words += teens[number - 10] + " ";
                number = 0;
            }
            if (number > 0)
            {
                words += units[number] + " ";
            }
            return words.Trim();
        }
    }

    public interface Icheck
    {
        void check(ref int choice);
        void check(List<double> list, bool triangle = false);
        bool check(string value);
    }

    public class checkType: Icheck
    {
        bool Icheck.check(string value)
        {
            if (double.TryParse(value, out double choice)) return true;
            else return false;
        }

        void Icheck.check(ref int choice)
        {
            int i = 0;

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    choice = result;
                    break;
                }
                else
                    Console.WriteLine(
                        "Введено неверное значение. \n" +
                        "Введите значенние повторно"
                    );
            }
        }

        void Icheck.check(List<double> list, bool triangle = false)
        {
            int i = 0;

            while (i < 3)
            {
                if (triangle) Console.WriteLine($"Введите длину {i + 1}/3 стороны треугольника");
                else Console.WriteLine($"Введите {i + 1}/3 значение переменной для квадратного уравнение ");
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    if (triangle)
                    {
                        if (result > 0)
                        {
                            list.Add(result);
                            i++;
                        }
                        else Console.WriteLine("Длина треугольника не может быть отрицательной. Введите значение повторно");
                    }
                    else {
                        i++;
                        list.Add(result);
                    }
                }
                else
                    Console.WriteLine(
                        "Введены неверные данные. \n" +
                        "Введите значенние повторно"
                    );
            }
        }
    }
}
