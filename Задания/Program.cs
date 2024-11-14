using System;

namespace BankAccountExample
{
    public struct BankAccount //// Определение структуры данных для банковского счета
    {
        public string AccountNumber; // Номер счета
        public AccountType AccountType; // Тип счета
        public decimal Balance; // Баланс

        public void DisplayInfo()
        {
            Console.WriteLine($"Номер счета: {AccountNumber}");
            Console.WriteLine($"Тип счета: {AccountType}");
            Console.WriteLine($"Баланс: {Balance:C}"); // Форматирование в валюте
        }
    }

    public enum AccountType
    {
        Current,  // Текущий
        Savings   // Сберегательный
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount; //// Создание переменной типа BankAccount и заполнение структуры значениями
            myAccount.AccountNumber = "1234567890";
            myAccount.AccountType = AccountType.Current;
            myAccount.Balance = 2500.75m;

            myAccount.DisplayInfo();//// Вывод информации о счете
        }
    }
}