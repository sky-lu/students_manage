using System;
using Authority;

namespace Interface{

    class Interaction {

        public Interaction() {


        }

        public void init() {

            User u = new User();
            string userRecord = u.getUser();
            Console.WriteLine("#############################################\n");
            Console.WriteLine("              Student Manage System          \n");
            Console.WriteLine("#############################################");
            Console.WriteLine(userRecord);
        }

        
    }
}