using System;

namespace EmployeeProject
{
    public class Employee
    {
        private string name;
        private string position;
        private decimal salary;


        public const decimal DefaultSalary = 500m;
        public const string DefaultPosition = "Стажёр";
        public const string DefaultName = "Без имени";
        public const decimal DefaultRaisePercent = 10m;



        // Полный конструктор
        public Employee(string name, string position, decimal salary)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Имя не может быть пустым");
            }

            if (string.IsNullOrWhiteSpace(position))
            {
                throw new ArgumentException("Должность не может быть пустой");
            }

            if (salary < 0)
            {
                throw new ArgumentException("Зарплата не может быть отрицательной");
            }


            this.name = name;
            this.position = position;
            this.salary = salary;
        }



        // Имя + должность
        public Employee(string name, string position)
            : this(name, position, DefaultSalary)
        {

        }



        // Только имя
        public Employee(string name)
            : this(name, DefaultPosition, DefaultSalary)
        {

        }



        // Без параметров
        public Employee()
            : this(DefaultName, DefaultPosition, DefaultSalary)
        {

        }




        // Повышение на стандартный процент
        public void Promote()
        {
            Promote(DefaultRaisePercent);
        }



        // Повышение зарплаты
        public void Promote(decimal raisePercent)
        {
            if (raisePercent <= 0)
            {
                throw new ArgumentException(
                    "Процент повышения должен быть положительным");
            }


            salary += salary * raisePercent / 100;
        }



        // Изменение должности
        public void Promote(string newPosition)
        {
            if (string.IsNullOrWhiteSpace(newPosition))
            {
                throw new ArgumentException(
                    "Должность не может быть пустой");
            }


            position = newPosition;
        }



        // Изменение должности + повышение
        public void Promote(string newPosition, decimal raisePercent)
        {
            Promote(newPosition);
            Promote(raisePercent);
        }



        public override string ToString()
        {
            return $"{name}, {position}, {salary}";
        }
    }
}