using System;
using Interface;
using StudentsInfo;

namespace students_manage
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Interaction()).init().daemon();
            // Students b = new Students();
            // b.add();
        }
    }
}
