using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2_
{
    struct Student
    {
        public string LastName;
        public string Initials;
        public string GroupNumber;
        public int[] Grades;

        public Student(string lastName, string initials, string groupNumber, int[] grades)
        {
            LastName = lastName;
            Initials = initials;
            GroupNumber = groupNumber;
            Grades = grades;
        }

        // Метод для вычисления среднего балла
        public double AverageGrade()
        {
            return Grades.Average();
        }

        // Метод для проверки, есть ли только 4 и 5
        public bool HasOnlyGoodGrades()
        {
            return Grades.All(grade => grade == 4 || grade == 5);
        }

        // Метод для вывода информации о студенте (фамилия, группа, средний балл)
        public void PrintInfo()
        {
            Console.WriteLine($"Фамилия: {LastName}, Группа: {GroupNumber}, Средний балл: {AverageGrade():F2}");
        }

        // Метод для вывода только фамилии и группы студента
        public void PrintNameAndGroup()
        {
            Console.WriteLine($"Фамилия: {LastName}, Группа: {GroupNumber}");
        }
    }

    class Program
    {
        static void Main()
        {
            // Массив из трёх студентов
            Student[] students = new Student[]
            {
            new Student("Алабуга", "П.Р.", "ПОИТ22", new int[] { 5, 5, 4, 5, 4 }),
            new Student("Машеров", "П.М.", "ИЯ30", new int[] { 4, 4, 4, 4, 4 }),
            new Student("Бог", "И.Х.", "ДО15", new int[] { 5, 3, 3, 3, 3 })
            };

            // Сортировка студентов по возрастанию среднего балла
            var sortedStudents = students.OrderBy(s => s.AverageGrade()).ToArray();

            Console.WriteLine("Студенты, отсортированные по среднему баллу:");
            foreach (var student in sortedStudents)
            {
                student.PrintInfo(); // Вывод информации о студенте (средний балл)
            }

            Console.WriteLine("\nСтуденты с оценками 4 и 5:");
            foreach (var student in sortedStudents)
            {
                if (student.HasOnlyGoodGrades())
                {
                    student.PrintNameAndGroup(); // Вывод только фамилии и группы студента
                }
            }
            Console.ReadLine();
        }
    }

}
