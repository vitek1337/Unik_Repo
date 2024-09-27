using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите число от 0 до 1000: "); if (int.TryParse(Console.ReadLine(), out int number) && number >= 0 && number <= 1000)
        {
            string result = NumberToWords(number);
            Console.WriteLine($"Число {number} соответствует слову '{result}'.");
        }
        else
        {
            Console.WriteLine("Введено недопустимое значение. Пожалуйста, введите число от 0 до 1000.");
        }
        Console.ReadKey();
    }
    static string NumberToWords(int number)
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
