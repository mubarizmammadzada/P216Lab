using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29102020
{
    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int ExamResult { get; set; }

        public void Exam()
        {
            if (ExamResult > 50)
            {
                Console.WriteLine("Imtahandan kecdiniz.Diplomu gelin goturun)))");
            }
            else
            {
                Console.WriteLine("Imtahannan kesildiniz.Narmalni oxuyardiz");
            }
        }
    }
}
