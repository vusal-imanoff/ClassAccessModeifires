using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAccessModifiresTask
{
    class User
    {
        private string _userName;
        private string _password;

        public User(string username, string password)
        {
            Username = username;
            Password = password;

        }
        public string Username
        {
            get
            {
                return _userName;
            }
            set
            {
                while (true)
                {
                    if (value.Length < 8)
                    {
                        Console.WriteLine("Username-i duzgun daxil et");
                        value = Console.ReadLine();

                    }
                    else
                    {
                        _userName = value;
                        break;
                    }

                }


            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                while (true)
                {
                    if (value.Length < 8)
                    {
                        Console.WriteLine("parol 8 simvoldan kicik ola bilmez");
                        value = Console.ReadLine();
                    }
                    else
                    {
                        bool checkUpper = false;
                        bool checkLower = false;
                        bool checkDigit = false;
                        for (int i = 0; i < value.Length; i++)
                        {
                            if (char.IsUpper(value[i]))
                            {
                                checkUpper = true;
                            }
                            if (char.IsLower(value[i]))
                            {
                                checkLower = true;
                            }
                            if (char.IsDigit(value[i]))
                            {
                                checkDigit = true;
                            }
                        }
                        if (checkDigit && checkLower && checkUpper)
                        {
                            _password = value;
                            break;

                        }
                        else
                        {
                            Console.WriteLine("Parolu duzgun daxil et");
                            value = Console.ReadLine();
                        }
                    }


                }

            }
        }
    }
}
