using ConsoleApp2;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    public static void Main(string[] args)
    {
        List<Employee> people = new()
        {
          new Employee("Жуков Антон Павлович", 1, 13500),
           new Employee("Миклашевский Данила Сергеевич", 2, 15954),
          new Employee("Косых Иван Андреевич", 3, 14500),
           new Employee("Облепихова Дарья Анатольевна", 4, 6799),
          new Employee("Махлепова Кристина Андреевна", 5, 9800),
           new Employee("Шевченко Макар Николаевич", 1, 5777),
          new Employee("Чанин Дмитрий Додопицевич", 2, 27650),
           new Employee("Хомяков Никита Джугашвилевич", 3, 1554),
          new Employee("Нурминский Сурен Хачинович", 4, 1200),
          new Employee("Нагиев Дмитрий Генадьевич", 5, 80000)
        };
         void EmplpyeeInfo()
        {
            foreach (Employee e in people)
            {
                Console.WriteLine($"{e.FIO}, {e.Otdel}, {e.Salary}");
            }
        }
        void test2(){
            double sum = 0;
            foreach(var emp in people)
            {
                sum += emp.Salary;
            }
            Console.WriteLine($"{sum}");
        }
        EmplpyeeInfo();
        test2();
    }
   
}

