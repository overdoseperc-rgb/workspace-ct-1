using System;

namespace EmployeeProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=== Демонстрация Employee ===\n");


            Employee employee1 =
                new Employee(
                    "Иванов И.И.",
                    "Разработчик",
                    1500m
                );


            Employee employee2 =
                new Employee(
                    "Петров П.П.",
                    "Тестировщик"
                );


            Employee employee3 =
                new Employee(
                    "Сидоров С.С."
                );


            Employee employee4 =
                new Employee();



            Console.WriteLine(employee1);
            Console.WriteLine(employee2);
            Console.WriteLine(employee3);
            Console.WriteLine(employee4);



            Console.WriteLine("\n=== Повышения ===\n");


            employee1.Promote();

            Console.WriteLine(
                "После стандартного повышения:");
            Console.WriteLine(employee1);



            employee2.Promote(20);

            Console.WriteLine(
                "\nПосле повышения на 20%:");
            Console.WriteLine(employee2);



            employee3.Promote(
                "Менеджер"
            );

            Console.WriteLine(
                "\nПосле смены должности:");
            Console.WriteLine(employee3);



            employee4.Promote(
                "Инженер",
                15
            );

            Console.WriteLine(
                "\nПосле смены должности и повышения:");
            Console.WriteLine(employee4);



            Console.ReadLine();
        }
    }
}