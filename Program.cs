using System;
using Interface;
using StudentsInfo;

namespace students_manage
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Interaction act = new Interaction();
            act.init();

            Students b = new Students();
            b.add();
        }
    }
}
