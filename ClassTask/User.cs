using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask
{
    internal class User :IAccountable
    {
        private static int _id;
        private string _password;

       

        public int Id { get; set; }
        public string Fullname { get; set; }
        public int Point { get; set; }
        public User(string fullName)
        {
            Fullname = fullName;
        }
        private User()
        {
            Id = ++_id;
        }

        public bool PasswordChecker(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }
            bool checkUpper = false; 
            bool checkLower = false;
            bool checkIsdigit = false;
            
            foreach (var item in password)
            {
                if (char.IsUpper(item))
                {
                    checkUpper = true;
                }
                if (char.IsLower(item))
                {
                    checkLower = true;
                }
                if (char.IsDigit(item))
                {
                    checkIsdigit = true;


                }
                if (checkIsdigit&& checkUpper && checkLower)
                {
                    return true;
                }
                





            }
            return false;
        }
        public void ShowInfo()
        {
            Console.WriteLine("melumatlari yoxlayin");
            Console.WriteLine($"id{Id},Fullname{Fullname},Point{Point}");
        }


    }
}

