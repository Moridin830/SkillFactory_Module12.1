using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubModule1
{
    public static class Program
    {
        static void Main()
        {
            List<User> users = User.FillUsers();

            foreach(User user in users)
            {
                user.SayHi();
            }

            Console.ReadKey();
        }   
    }
}
