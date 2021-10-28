using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17App1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Создать класс для моделирования счета в банке. Предусмотреть закрытые поля для номера счета, баланса, ФИО владельца.
            //    Класс должен быть объявлен как обобщенный. Универсальный параметр T должен определять тип номера счета. Разработать методы  для доступа  к данным  –  заполнения и  чтения.
            //    Создать несколько экземпляров класса, параметризированного различными типам. Заполнить его поля и вывести информацию об экземпляре класса на печать.
            Bank<int> bank = new Bank<int>();
            bank.InputAccount(12, 564.04, "Дмитров Дмитрий Иванович");
            bank.UserAccount();
            Console.WriteLine("хххххххххххххххххххххххххххххххххххххххххххх");
            Bank<string> bank1 = new Bank<string>();
            bank1.InputAccount("12", 564.04, "Дмитров Дмитрий Иванович");
            bank1.UserAccount();
            Console.WriteLine("хххххххххххххххххххххххххххххххххххххххххххх");
            Bank<double> bank3 = new Bank<double>();
            bank3.InputAccount(12, 564.04, "Дмитров Дмитрий Иванович");
            bank3.UserAccount();
            Console.ReadKey();
        }
        class Bank<T>
        {
            T number;
            double balans;
            string name;
            public void InputAccount(T number, double balans, string name)
            {
                this.number = number;
                this.balans = balans;
                this.name = name;

            }

            public void UserAccount()
            {
                Console.Write($"Номер счета:\t {number}\nБаланс счета:\t {balans}\nФИО Пользователя:\t {name}\n");
            }

        }
    }
}
