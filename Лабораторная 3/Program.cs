using BankAccount;
using MyBankAccount;
using System;
using VUSinfo;

namespace MyBankAccount
{
    // Лабораторная 3.1. Создать перечислимый тип ВУЗ{КГУ, КАИ, КХТИ}. Создать структуру работник с двумя полями: имя, ВУЗ.Заполнить структуру данными и распечатать.
    struct BankAccountType
    {
        public AcType AccountType;

        public void PrintInformation()
        {
            Console.WriteLine($"Вид банковского счета: {AccountType}");
        }
    }
    public enum AcType
    {
        Current,  // Текущий
        Savings   // Сберегательный
    }

}

namespace BankAccount
{
    //Упражнение 3.2 Создать структуру данных, которая хранит информацию о банковском счете – его номер, тип и баланс.Создать переменную такого типа, заполнить структуру значениями и напечатать результат.
    struct OwnBankAccount
    {
        public string AccountNumber; // Номер счета
        public AccountType AccountType; // Тип счета
        public decimal Balance; // Баланс

        public void DisplayInfo() // Выводит информацию о баковском счете
        {
            Console.WriteLine($"Номер счета: {AccountNumber}");
            Console.WriteLine($"Тип счета: {AccountType}");
            Console.WriteLine($"Баланс: {Balance}");
        }
    }
    public enum AccountType
    {
        Current,  // Текущий
        Savings   // Сберегательный
    }
}


namespace VUSinfo
{
    //Домашнее задание 3.1 Создать перечислимый тип ВУЗ{КГУ, КАИ, КХТИ}. Создать структуру работник с двумя полями: имя, ВУЗ.Заполнить структуру данными и распечатать.
    struct Worker
    {
        public string Name; // Имя работника
        public VUS VUSname; // Название ВУЗа
        public void DisplayInfo() // Выводит информацию о работнике
        {
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Название ВУЗа: {VUSname}");
        }
    }
    public enum VUS
    {
        КГУ,
        КАИ,
        КХТИ
    }
}
class Program
{
    static void Main(string[] args)
    {
        // вывод информации о типе бакновского счета. Упр 3.1
        BankAccountType AccountInfo = new BankAccountType()
        {
            AccountType = AcType.Savings,
        };
        Console.WriteLine("Лабораторная 3.1");
        AccountInfo.PrintInformation();

        Console.WriteLine();


        // вывод полной информации о счете. Упр 3.2
        OwnBankAccount myBankAccount = new OwnBankAccount()
        {
            AccountNumber = "23854728193",
            AccountType = AccountType.Savings,
            Balance = 2500
        };
        Console.WriteLine("Лабораторная 3.2");
        myBankAccount.DisplayInfo();

        Console.WriteLine();


        // вывод информации работника вуза. ДЗ 3.1
        {
            Worker Info;
            Info.Name = "Арина";
            Info.VUSname = VUS.КГУ;

            Console.WriteLine("Домашнее задание 3.1");
            Info.DisplayInfo();
        }
    }
}
