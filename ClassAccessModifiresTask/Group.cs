using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAccessModifiresTask
{
    class Group
    {
        public string No;
        public int Limit;
        private Student[] _students;

        public Group(string no,int limit)
        {
            No = no;
            Limit = limit;
            _students = new Student[0];
        }
        public void AddStudent(Student stu)
        {
            if(_students.Length < Limit)
            {
                Array.Resize(ref _students, _students.Length + 1);
                _students[_students.Length - 1] = stu;
            }
            else
            {
                Console.WriteLine($"{No} Qrupunda artiq yerler dolub.");
            }
        }
        public void GetStudents()
        {
           foreach(var std in _students)
            {
                Console.WriteLine($"Adi- {std.Name} Soyadi- {std.SurName} Qrup nomresi- {No}");
            }
        }
    }
}
