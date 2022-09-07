using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string group { get; set; }
        public double averageMark { get; set; }
        public void ustudent()
        {
            Console.WriteLine($"Имя студента: {firstName}, " + $"Фамилия: {lastName}, " + $"Группа: {group}, " + $"Средняя оценка = {averageMark}");
        }
        public void getScholarship()
        {
            if (averageMark == 5)
            {
                Console.WriteLine("Стипендия 10000р");
            }
            else
            { 
                Console.WriteLine("Стипендия 8000р");

            }
        }
    }
}
