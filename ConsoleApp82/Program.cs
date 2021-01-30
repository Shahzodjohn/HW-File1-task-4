using System;


namespace ConsoleApp82
{
    class Students
    {
        public string name { get; set; }
        public string surname { get; set; }
        public double points { get; set; }

        public Students(string name, string surname, double points)
        {
            this.name = name;
            this.surname = surname;
            this.points = points;


        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name: {name} \nSurname: {surname} \nPoints: {points}");

        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите фамилию: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите вашу оценку от 1.0 до 5.0: ");
            double points = double.Parse(Console.ReadLine());

            Students students = new Students(name, surname, points);
            students.ShowInfo();

            if (students.points >= 4.5)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Отлично");
            }
            else if (students.points >= 3.5 && points <= 4.4)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Хорошо");
            }
            else if (students.points >= 2.8 && points <= 3.4)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Удовлетворительно");
            }
            else if (students.points <= 2.7)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Ну значит ты двоешник");
            }




        }
    }
}
