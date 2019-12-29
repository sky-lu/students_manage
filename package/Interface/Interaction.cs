using System;
using Authority;
using System.Drawing;
using Console = Colorful.Console;
using StudentsInfo;
using System.Globalization;

namespace Interface{

    class Interaction {


        private string title = "STU MANAGE SYS";

        
        private string[] order = {
                "#home", "#logout", "#list", "#add",
                "#next", "#previous", "#show/{id}", 
                "#edit/{id}", "#delete/{id}", "#import", 
                "#quit"
            };
            
    

        public Interaction() {
           
        }
        public Interaction init() {
            
            this.ToTitleCase();
            return this;
        }
        public void ToTitleCase (){

            TextInfo myTI = new CultureInfo("en-US",false).TextInfo;
            for (int i = 0 ;i < this.order.Length ; i++){
                this.order[i] = myTI.ToTitleCase(this.order[i]);//this.ToTitleCase(this.order[i]);
            }
            
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
                //Interaction.echo(tip);
                Console.Write(tip, Color.Yellow);
            }
            return Console.ReadLine();
        }

        public void daemon() {

            while (true) {
                string routeStr = null;
                if (Auth.isAuth == true)
                {
                    routeStr = enter("Menu >>>: ");
                    
                }
                skeleton();
                if (Auth.isAuth == false)
                {
                    if (!Auth.isFirst)
                    {
                        Console.WriteLine("Your authorization is failed, please try again.", Color.Red);
                    }
                    (new Auth()).showAuth();
                    skeleton();
                    continue;
                }

                Console.WriteLine("\n>>>" + routeStr, Color.Green);
                Console.WriteLine("".PadRight(Console.LargestWindowWidth, '-'));
                switch(routeStr.Replace("#", "")) {
                        
                    case "logout":
                        (new Auth()).logout();
                        break;
                    case "quit":
                        (new Auth()).quit();
                        break;
                    case "import":

                        break;
                    //....
                    //Here fill the other module function route
                    case "list":
                        (new Students()).list();
                        break;
                    case "add":
                        (new Students()).add();
                        break;
                    case "delete":
                        (new Students()).delete();
                        break;
                    case "edit":
                        (new Students()).edit();
                        break;

                    default:
                        Console.WriteLine($"There have no \"{routeStr}\" order", Color.Orange);
                        break;
                }
                Console.WriteLine("".PadRight(Console.LargestWindowWidth, '-'));


            }
            
        }

    }
}