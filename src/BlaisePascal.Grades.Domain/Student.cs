using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlaisePascal.Grades.Domain
{
    public class Student
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Class {  get; private set; }
        List<Grade> _grades = new List<Grade>();
        HashSet<string> _subject;
        public Student (int id, string name, string surname, string c)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Class = c;
        }
        public void AddGrade (int value, string subject)
        {
            _grades.Add (new Grade (value, subject));
        }
        public float GetAverage (string subject)
        {
            float sum = 0;
            int counter = 0;
            for (int i = 0; i < _grades.Count; i++)
            {
                if (_grades[i].Subject == subject)
                {
                    sum += _grades[i].Value;
                    counter++;
                }
            }
            return sum / counter;
        }

    }
}
