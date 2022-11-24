using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask.Models
{
    internal class User
    {
        string _username;
        string _password;
        bool _isSignedIn;
        Product[] products;

        public string UserName
        {
            get { return _username; }
            set
            {
                if(value.Length>5 && value.Length <= 20)
                {
                    _username = value;
                }
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                if(value.Length > 7 && value.Length <= 20)
                {
                    _password = value;
                }
            }
        }

        public bool IsSignedIn
        {
            get { return _isSignedIn; }
            set { _isSignedIn = value; }
            
        }
        
        public Product[] Products
        {
            get { return Products; }
            set
            {
                Products = value;
            }
        }

        public static bool HasDigit(string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (char.IsDigit(value[i]))
                {
                    return true;
                }

            }
            return false;
        }

        public static bool HasUpper(string value)
        {
            for (var i = 0; i < value.Length; i++)
            {
                if (char.IsUpper(value[i]))
                {
                    return true;
                }

            }
            return false;
        }

        public static bool HasLower(string value)
        {
            for (var i = 0; i < value.Length; i++)
            {
                if (char.IsLower(value[i]))
                {
                    return true;
                }

            }
            return false;
        }

        public static void Login()
        {

        }


    }
}
