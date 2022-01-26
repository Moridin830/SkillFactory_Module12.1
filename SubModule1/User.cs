using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubModule1
{
    public class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }

        public void SayHi()
        {

            if (!IsPremium)
            {
                User.ShowAds();
            }

            // Поприветствуем пользователя
            ConsoleOperations.WriteString($"Hi, {Name}!", true);
        }

        public static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
        
        public static List<User> FillUsers()
        {
            var users = new List<User>();

            bool Continue = true;

            int number = 1;

            while (Continue)
            {
                Console.WriteLine("Добавить нового пользователя (Да/Нет)?");

                string answer = Console.ReadLine() ?? "нет";
                if (answer.ToLower() == "да")
                {
                    User user = new User();

                    ConsoleOperations.WriteDelimiter();
                    
                    user.Name = ConsoleOperations.AskUser("Введите имя пользователя:", $"User{number}");
                    
                    user.Login = ConsoleOperations.AskUser("Введите логин пользователя:", $"User{number}");

                    string currentAnswer = ConsoleOperations.AskUser("У пользователя есть премиум-подписка (Да/Нет)?:");

                    if (currentAnswer.ToLower() == "да")
                    {
                        user.IsPremium = true;
                    }

                    users.Add(user);

                    ConsoleOperations.WriteDelimiter();

                    number++;
                }
                else
                {
                    ConsoleOperations.WriteString($"Ввод завершен. Добавлено пользователей: {users.Count}");
                    Continue = false;
                }
            }

            return users;
        }
    }
}
