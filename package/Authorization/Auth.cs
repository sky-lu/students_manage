using System;
using Interface;

namespace Authority
{

    class Auth
    {

        public static bool isAuth = false;

        public static bool isFirst = true;

        public bool showAuth() {

            Interaction.echo("Please enter your login name and login password, devided by '|'");
            string input = null;
            while (true){
                ConsoleKeyInfo ck = Console.ReadKey(true);
                if (ck.Key != ConsoleKey.Enter){
                    if (ck.Key != ConsoleKey.Backspace) {
                        input += ck.KeyChar.ToString();
                        Console.Write("*");
                    } else {
                       Console.Write("\b \b");
                    }
                } else {
                    break;
                }
            }
            return this.authUser(input == null ? "" : input);
        }
        
        public bool authUser(string authInfo) {

            string[] auth = authInfo.Split("|");
            if (auth[0] == "xm" && auth[1] == "xp") {
                Auth.isAuth = true;
                return true;
            } else {
                Auth.isFirst = false;
                Auth.isAuth = false;
                return false;
            }
        }

        public void logout() {
            Auth.isFirst = true;
            Auth.isAuth = false;
        }

        public void quit() {
            Environment.Exit(0);
        }

        public bool lockUser() {

            return false;
        }

        

    }
    
}