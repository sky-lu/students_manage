using System;
using Interface;
using StudentsInfo;
using Authority;

namespace students_manage
{
    class Program
    {
        static void Main(string[] args)
        {
            (new User()).getUser();
            //(new Interaction()).init().daemon();
            // Students b = new Students();
            // b.add();
        }
    }
}
