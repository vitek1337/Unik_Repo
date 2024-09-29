using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu1 = new Menu();
            menu1.choice();
        }
    }

    class Menu
    {
        Solves solve1 = new Solves();
        int choose = 0;
        public void choice()
        {
            do
            {
                Console.WriteLine(" Введите номер задания. (чтобы завершить работу введите '-1') ");
                this.choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine($"Задание {choose}");
                        Console.WriteLine("Среди заданных чисел программа находит количество нечетных чисел");
                        InputValues input = new InputValues();
                        input.input_values();
                        Console.WriteLine("количество нечетных чисел = " + solve1.task_1(input.digits));
                        break;
                    case 2:
                        Console.WriteLine($"Задание {choose}");
                        Console.WriteLine("Вводите целые положительные числа, программа будет выводить последовательность от 0 до введенного числа");
                        InputValues input2 = new InputValues();
                        input2.input_values();
                        solve1.task_2(input2.digits);
                        break;
                    case 3:
                        Console.WriteLine($"Задание {choose}");
                        Console.WriteLine("Вводите числа, програма выведет было ли самое маленькое число выведено раньше самого большого");
                        InputValues input3 = new InputValues();
                        input3.input_values();
                        if (solve1.task_3(input3.digits)) Console.WriteLine("TRUE (Минимальное число встречается раньше максимального)");
                        else Console.WriteLine("False Минимальное число встречается позже максимального");
                        break;
                    case 4:
                        Console.WriteLine($"Задание {choose}");
                        Console.WriteLine("сумма бесконечного ряда");
                        Form1 form = new Form1();
                        form.ShowDialog();
                        solve1.row(double.Parse(Console.ReadLine()));
                        break;
                    case 5:
                        Console.WriteLine($"Задание {choose}");
                        Form2 form2 = new Form2();
                        form2.ShowDialog();
                        solve1.task_5();
                        break;
                    case 6:
                        Console.WriteLine($"Задание {choose}");
                        Form3 form3 = new Form3();
                        form3.ShowDialog();
                        break;
                    case 7:
                        Console.WriteLine($"Заданние {choose}");
                        Form4 form4 = new Form4(); 
                        form4.ShowDialog();
                        break;
                }
            } while (choose != -1);
        }
    }

    class InputValues
    {
        public List<int> digits = new List<int>();
        int input_value = 0;

        public void input_values()
        {
            Console.WriteLine("Вводите необходиммые значения. (чтобы закончить работу введите -1)");
            while (this.input_value != -1)
            {
                this.digits.Add(this.input_value);
                int.TryParse(Console.ReadLine(), out int result);
                this.input_value = result;
                Console.WriteLine("Введите следующее значение");
            }
        }
    }

    class Solves
    {
        public int task_1(List<int> array) {
            int count_unordered = 0;
            for (int i = 0; i < array.Count; i++)
            {
                if (array[i] % 2 != 0)
                {
                    count_unordered++;
                }
            }

            return count_unordered;
        }

        public void task_2(List<int> array)
        {
            for (int i = 1; i < array.Count; i++)
            {
                for (int j = 0; j < array[i]; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        public bool task_3(List<int> array)
        {
            int min = 999999999;
            int max = -1;
            int ind_max = -1;
            for (int i = 1; i < array.Count; i++)
            {
                if (min > array[i]) min = array[i];
                if (max < array[i])
                {
                    max = array[i];
                    ind_max = i;
                }
            }

            if (array.IndexOf(min) < ind_max) return true;
            else return false;
        }

        public double row(double epsilon){
            double sum = 0.0;
            double term = 1.0;
            int n = 1;
            long factorial = 1;

            while (term >= epsilon)
            {
                sum += term;
                factorial *= n;
                term = 1.0 / Math.Sqrt(factorial);
                n++;
            }

        return sum;
        }

        public double task_5(){
            double start = 1.0;
            double end = 3.0;
            double sum = 0;
            double step = 1.0;

            for (double x = start; x <= end; x += step)
            {
                double functionValue = CalculateFunction(x);
            sum += functionValue;
                Console.WriteLine($"f({x}) = {functionValue}");
            }

            Console.WriteLine($"Сумма значений функции на отрезке [{start}, {end}] = {sum}");
            return sum;
        }


        public double CalculateFunction(double x)
        {
            return Math.Sqrt(4 * Math.Pow(x - 1, 2) * (8 - 1 / x));
        }

        public double CalculateLessThenHund(int x)
        {
            if (x < 100) return 0;
            return x % 10 + x % 100 / 10;
        }

        public double task_8(int N)
        {
            double sum = 0;

            for (int i = 1; i <= N; i++)
            {
                sum += Math.Pow(i, N - i + 1);
            }

            return sum;
        }
    }
}
