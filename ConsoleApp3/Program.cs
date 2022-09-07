using System;


namespace ConsoleApp3 {
    class Program : Aspirant
    {
        static void Main(string[] args)
        {
            Student student = new Student { firstName = "Danila", lastName = "Zamatevskiy", group = "ПКС-320", averageMark = 5 };
            student.ustudent();
            student.getScholarship();
            Aspirant aspirant = new Aspirant { firstName = "Danila", lastName = "Zamatevskiy", group = "ПКС-320", averageMark = 5 };
            aspirant.uaspirant();
            aspirant.getScholarship();
        }
    }
}
