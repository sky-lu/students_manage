using System;
using System.Collections.Generic;
using System.Collections;
using Console = Colorful.Console;
using System.Drawing;

namespace StudentsInfo{

    class Students{

        public Students(){

        }

        public void add(){
            
            // Input student's name.
            Console.Write("Enter student's name:");
            String name = Console.ReadLine();
            Console.WriteLine("name:" + name);


            // Select student's sex.
            int sex;
            do{
                Console.Write("The student's sex:press 0 for man ; press 1 for female.");
                //int sex;
                // int.TryParse(Console.ReadLine(), out sex);
                 sex = int.Parse(Console.ReadLine());
               // Console.WriteLine(sex);
                if ( sex == 0){
                    Console.WriteLine("sex: man");
                }else if (sex == 1){
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
            String major = Console.ReadLine();
            Console.WriteLine("major:" + major);
        }

        public void list(){
            
            String text = System.IO.File.ReadAllText(@"E:\Pratices\students_manage\demo.txt");
            string[] lines = text.Split("\n");

            List<Dictionary<string, string>> stus = new List<Dictionary<string, string>>();
            
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
                    Console.WriteLine(showLine + "\n", Color.Tomato);
                }
                i++;
            }


        }
    } 



    
}