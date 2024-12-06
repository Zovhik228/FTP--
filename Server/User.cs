using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Server
{

    public static List<User> Users = new List<User>();
    public static IPAddress IpAdress;
    public static int Port;

    public class User
    {
        public string login { get; set; }
        public string password { get; set; }
        public string src { get; set; }
        public string temp_src { get; set; }
        public User(string login, string password, string src) 
        {
            this.login = login;
            this.password = password;
            this.src = src;
            temp_src = src;
        }
    }
}