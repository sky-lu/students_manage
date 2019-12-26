using System;
using Authority;
using System.Drawing;
using Console = Colorful.Console;
using StudentsInfo;

namespace Interface{

    class Interaction {

        private string title = "STU MANAGE SYS";

        private string[] order = {
            "#home", "#logout", "#list", 
            "#next", "#previous", "#show/{id}", 
            "#edit/{id}", "#delete/{id}", "#quit"
        };

        public Interaction() {


        }
        public Interaction init() {
            
            
            return this;
        }

        public void skeleton() {

            Console.Clear();
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            int consoleWidth = Console.WindowWidth;
            string widthPadStr = "";
            do
            {
                widthPadStr += "#";
                consoleWidth--;
            } while (consoleWidth > 0);

            Console.WriteLine($"{widthPadStr}", Color.Orange);
            Console.WriteAscii(this.title, Color.Orange);
            Console.WriteLine("Menu >>>:   " + string.Join("  ", this.order), Color.Yellow);
            Console.WriteLine($"{widthPadStr}", Color.Orange);

        }

        public static void echo(string tip = "") {
            
            Console.WriteLine(tip);
        }

        public static string enter(string tip = "") {
            if (string.IsNullOrEmpty(tip) == false) {
                Interaction.echo(tip);
            }
            return Console.ReadLine();
        }

        public void daemon() {
            while (true) {
                skeleton();
                if (Auth.isAuth == false) {
                    if (!Auth.isFirst) {
                        Console.WriteLine("Your authorization is failed, please try again.", Color.Red);
                    }
                    (new Auth()).showAuth();
                }else {
                    string routeStr = enter("Menu >>>:");

                    switch(routeStr.Replace("#", "")) {
                        
                        case "logout":
                            (new Auth()).logout();
                            break;
                        case "quit":
                            (new Auth()).quit();
                            break;
                        //....
                        //Here fill the other module function route
                        case "list":
                            (new Students()).list();
                            Console.ReadLine();
                            break;
                        default:

                            break;
                    }

                }
            }
            
        }

    }
}