using System;

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
            
            String text = System.IO.File.ReadAllText(@"D:\Programs\Project\Practice\StudentsManagement\demo.txt");
            Console.WriteLine("ffffff" + text);
           
        }
    } 



    
}