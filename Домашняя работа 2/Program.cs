using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;


namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1. Информация и максимальных и минимальных значениях всех типов данных.
            Console.WriteLine("(1)\n");
            Console.WriteLine("Тип данных - Максимальное значение - Минимальное значение\n"); // Информация о типах данных
            Console.WriteLine($"float - {float.MaxValue} - {float.MinValue}");
            Console.WriteLine($"double - {double.MaxValue} - {double.MinValue}");
            Console.WriteLine($"decimal - {decimal.MaxValue} - {decimal.MinValue}");
            Console.WriteLine($"byte - {byte.MaxValue} - {byte.MinValue}");
            Console.WriteLine($"sbyte - {sbyte.MaxValue} - {sbyte.MinValue}");
            Console.WriteLine($"short - {short.MaxValue} - {short.MinValue}");
            Console.WriteLine($"ushort - {ushort.MaxValue} - {ushort.MinValue}");
            Console.WriteLine($"int - {int.MaxValue} - {int.MinValue}");
            Console.WriteLine($"uint - {uint.MaxValue} - {uint.MinValue}");
            Console.WriteLine($"long - {long.MaxValue} - {long.MinValue}");
            Console.WriteLine($"ulong - {ulong.MaxValue} - {ulong.MinValue}");
            Console.WriteLine($"char - {(char)char.MaxValue} - {(char)char.MinValue}");
            Console.WriteLine($"bool - true - false");


            // Задание 2. Напишите программу, в которой принимаются данные пользователя в виде имени, города, возраста и PIN - кода.Далее сохраните все значение в соответствующей переменной, а затем распечатайте всю информацию в правильном формате.
            Console.WriteLine("\n(2)\n");
            string name;
            string city;
            int age;
            string PINcode;

            Console.WriteLine("Введите свое имя:"); // ввод имени пользователя
            name = Console.ReadLine();

            Console.WriteLine("Ведите свой город:"); // ввод города пользователя
            city = Console.ReadLine();

            Console.WriteLine("Введите ваш возраст:"); // ввод возраста пользователя
            while (!int.TryParse(Console.ReadLine(), out age)) // преобразование строки int и проверка правильного ввода
            {
                Console.WriteLine("Некорректный ввод!Введите возраст цифрами:");
            }
            Console.WriteLine("Введите ваш PIN-код:");
            PINcode = Console.ReadLine();

            Console.WriteLine("Информация о пользователе:");
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Город: {city}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"PIN-код: {PINcode}");


            // Задание 3.Преобразуйте входную строку: строчные буквы замените на заглавные, заглавные – на строчные.
            Console.WriteLine("\n(3)\n");
            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();
            string result = new string(input.Select(c => char.IsLower(c) ? char.ToUpper(c) : char.ToLower(c)).ToArray()); // изменение стрчных на заглавнык и наоборот
            Console.WriteLine(result);


            // Задание 4. Введите строку, введите подстроку. Необходимо найти количество вхождений и вывести на экран.
            Console.WriteLine("\n(4)\n");
            Console.WriteLine("Введите строку:");
            string mainString = Console.ReadLine();
            Console.WriteLine("Введите подстроку:");
            string subString = Console.ReadLine();

            int count = Regex.Matches(mainString, Regex.Escape(subString)).Count;
            Console.WriteLine($"Количество вхождений подстроки \"{subString}\" в основной строке: {count}");


            /* Задание 5.  Определить, сколько бутылок виски беспошлинной торговли вам нужно будет купить,
             чтобы экономия по сравнению с обычной средней ценой фактически покрыла расходы на ваш отпуск.
            Известны:стандартная цена (normPrice), скидка в Duty Free (salePrice) и стоимость отпуска. */
            Console.WriteLine("\n(5)\n");
            Console.WriteLine("Введите стандартную цену бутылки:");
            int normPrice = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите процент скидки в Duty Free:");
            int sale = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите стоимость отпуска:");
            int holidayPrice = int.Parse(Console.ReadLine());

            int salePrice = normPrice * sale / 100; // бутылка со скидкой
            int savedMoney = normPrice - salePrice; // сэкономленные деньги 
            int bottles = holidayPrice / savedMoney; // количество бутылок, чтобы покрыть расходы
            Console.WriteLine($"Количество бутылок, которые нужно купить: {bottles}");
        }
    }
}