using System;
using System.Collections.Generic;
using System.Collections;
using Console = Colorful.Console;
using System.Drawing;
using System.IO;

namespace StudentsInfo{

    class Students{

        public static List<Dictionary<string, string>> stus = null;

        public Students(){
            if (stus == null) {
                Students.stus = new List<Dictionary<string, string>>();
                String fileName = "demo.txt";
            String fullPath = Path.GetFullPath(fileName);
            
            String text = System.IO.File.ReadAllText(@fullPath);
            string[] lines = text.Split("\n");
            
            foreach (var line in lines)
            {

                string[] field = line.Split("#");
                var userDic = new Dictionary<string, string>();
                userDic.Add("id", field[0]);
                userDic.Add("name", field[1]);
                userDic.Add("sex", field[2]);
                userDic.Add("age", field[3]);
                userDic.Add("major", field[4]);
                stus.Add(userDic);
            }
            }
        }

        public void add(){
            
            // Input student's name.
            Console.Write("Enter student's name:");
            string name = Console.ReadLine();
            Console.WriteLine("name:" + name);


            // Select student's sex.
            int sex = 0;
            string sexLable = null;
            do{
                Console.Write("The student's sex:press 0 for man ; press 1 for female.");
                //int sex;
                // int.TryParse(Console.ReadLine(), out sex);
                 sex = int.Parse(Console.ReadLine());
               // Console.WriteLine(sex);
                if ( sex == 0){
                    sexLable = "man";
                    Console.WriteLine("sex: man");
                }else if (sex == 1){
                    sexLable = "female";
                    Console.WriteLine("sex: female");
                }else{
                    Console.WriteLine("Please enter 0 or 1.");
                }
            }while (sex != 0 && sex != 1);
            
            
            // Input student's age.
            int age;
            do{
                
                Console.Write("Enter student's age:");
                age = int.Parse(Console.ReadLine());
                if (age > 0 && age < 100){
                    Console.WriteLine("age:" + age);
                }else{
                    Console.WriteLine("Please enter correct age!");
                }
            }while(age <= 0 || age >= 100);
            

            // Input student's major.
            Console.Write("Enter student's major:");
            string major = Console.ReadLine();
            Console.WriteLine("major:" + major);
            
            var addUser = new Dictionary<string,string>();
            addUser.Add("id", Convert.ToString(stus.Count));
            addUser.Add("name", name);
            addUser.Add("sex", sexLable);
            addUser.Add("age", Convert.ToString(age));
            addUser.Add("major", major);
            stus.Add(addUser);
            



            Console.WriteLine($"Success! {name}  {sexLable}  {age}  {major}", Color.Tomato);
           // Console.WriteLine("Success! " + name + "  " + sex + "  " + age + "  " + major, Color.Tomato);


        }

        public void list(){

            

            int i = 0;
            foreach (var stu in stus)
            {
                string showLine = null;
                foreach (KeyValuePair<string, string> f in (Dictionary<string, string>)stu)
                {
                    showLine += ("| "+f.Value.Trim().PadRight(20));
                }
                if (i > 0)
                {
                    Console.WriteLine(showLine);
                }
                else
                {
                    //showLine = showLine.ToUpper();
                    Console.WriteLine(showLine.ToUpper() + "\n", Color.Tomato);
                }
                i++;
            }


        }

        public void delete(){
            Console.WriteLine("Please offer the ID of the student:");
            string idChoose = Console.ReadLine();

            for(int i = stus.Count - 1; i >= 0; i--) {
                if (idChoose.Trim() == stus[i]["id"].Trim()) {
                   
                    Console.WriteLine($"{stus[i]["id"]} {stus[i]["name"]} {stus[i]["sex"]} {stus[i]["age"]} {stus[i]["major"]}" );
                    
                    Console.WriteLine("Do you want to delete this data? Choose Y for YES.");
                    string choice = Console.ReadLine();
                    if (choice.Trim().ToUpper() == "Y"){
                        stus.Remove(stus[i]);
                        Console.WriteLine("Delete successfully!");
                    }
                }
            }
  
        }


        public void edit(){
            Console.WriteLine("Please offer the ID of the student:");
            string idSelect = Console.ReadLine();

            Dictionary<string,string> newst = null;
            foreach (Dictionary<string,string> st in stus){
                if (idSelect.Trim() == st["id"].Trim()){

                    Console.WriteLine($"{st["id"]} {st["name"]} {st["sex"]} {st["age"]} {st["major"]}" );
                    newst = st;
                }
            }
            while(true){
                Console.WriteLine("Choose the item you want to edit:");
                Console.WriteLine("\"name\",\"sex\",\"age\",\"major\"");
                string opt = Console.ReadLine();

                switch(opt){
                    case "name":
                        Console.WriteLine("Please enter your name:");
                        string newName = Console.ReadLine();
                        newst["name"] = newName;
                        break;
                    case "sex":
                        Console.WriteLine("Please enter your sex:");
                        string newSex = Console.ReadLine();
                        newst["sex"] = newSex;
                        break;
                    case "age":
                        Console.WriteLine("Please enter your age:");
                        string newAge = Console.ReadLine();
                        newst["age"] = newAge;
                        break;
                    case "major":
                        Console.WriteLine("Please enter your major:");
                        string newMajor = Console.ReadLine();
                        newst["major"] = newMajor;
                        break;
                    default:
                        break;
                }

                Console.WriteLine("Do you want to continue to edit? y for yes, n for no.");
                string option = Console.ReadLine();
                if (option.ToLower() == "n"){
                    break;
                }
            }
        }
    } 



    
}