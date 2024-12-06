using System;
using System.Collections.Generic;
using System.Net;

namespace Server
{
    public class Program
    {
        public static List<User> Users = new List<User>();
        public static IPAddress IpAdress;
        public static int Port;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static bool AutorizationUser(string login, string password)
        {
            User user = null;
            user = Users.Find(x => x.login == login && x.password == password);
            return user != null;
        }
    }
}
