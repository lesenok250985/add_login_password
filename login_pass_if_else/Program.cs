using System;
using System.Text;
//ZADANIE 2 ADMINISTRATOR
namespace VerySimpleAuth
{
    class Program
    {
        private static void Main()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            // Получаем от пользователя логин и пароль
            string login, pass;
            GetLoginAndPassword(out login, out pass);
            Console.WriteLine("enter login");

            // Проверяем правильность логина и пароля
            while (login != "Lesya" || pass != "ADMINISTRANOR")
            {
                Console.WriteLine("Вы ввели неверный пароль. Попробуйте снова.");
                GetLoginAndPassword(out login, out pass);
            }
                  

            // Выводим сообщение, что пользователь вошёл в систему
            Console.WriteLine("\"HELLO ADMINISTRATOR\"");

            // Delay
            Console.ReadKey();
        }

        private static void GetLoginAndPassword(out string login, out string pass)
        {
            // Выводим пользователю приглашение ввести логин
            Console.Write("Введите логин: ");

            // Получаем от пользователя логин
            login = Console.ReadLine();

            // Выводим пользователю приглашение ввести пароль
            Console.Write("Введите пароль: ");

            // Получаем от пользователя пароль
            pass = Console.ReadLine();
        }
    }
}
