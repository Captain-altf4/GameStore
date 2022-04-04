using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace GameStore
{
    public static class LoginData
    {
        public static bool CheckLogin(string loginString)
        {
            Regex rx = new Regex(@"^[a-zA-Z0-9-_]{3,32}$");
            return rx.IsMatch(loginString);
        }

        public static bool CheckPassword(string passwordString)
        {
            Regex rx = new Regex(@"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])[0-9A-z!@#$%^&*]{6,}");
            return rx.IsMatch(passwordString);
        }

        public static bool CheckMail(string mailString)
        {
            Regex rx = new Regex(@"^((([0-9A-z]{1}[-0-9A-z\.]{0,30}[0-9A-z]?)|([0-9A-zА-я]{1}[-0-9A-zА-я\.]{0,30}[0-9A-zА-я]?))@([-A-Za-z]{1,}\.){1,}[-A-Za-z]{2,})$");
            return rx.IsMatch(mailString);
        }
    }
}
