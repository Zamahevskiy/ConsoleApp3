using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Aspirant : Student
    {
        public void uaspirant()
        {
            Console.WriteLine($"Имя аспиранта: {firstName}, " + $"Фамилия: {lastName}, " + $"Группа: {group}, " + $"Средняя оценка = {averageMark}");
        }
        public void getScholarship()
        {
            if (averageMark == 5)
            {
                Console.WriteLine("Стипендия 20000р");
            }
            else
            {
                Console.WriteLine("Стипендия 18000р");

            }
        }
    }
}
