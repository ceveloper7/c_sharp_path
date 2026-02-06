using System;
using System.Collections.Generic;


namespace ForEach
{
    class People
    {
        private string name;
        private int age;

        public People(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 120)
                {
                    value = 1;
                    Console.WriteLine("Error, edad no puede superar los 120 años");
                }
                this.age = value;
            }
        }

        public string getInfo()
        {
            return "Personal info: " + name + ", age: " + age;
        }
    }

    class Program
    {
        static void Main(string[] args) {
            // inferencia del tipo
            var numbers = new List<int>() {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18
            };

            foreach (var number in numbers) {
                Console.WriteLine(number);
            }

            List<People> students = new List<People>() 
            {
                new People("Andres", 34),
                new People("Julio", 37),
                new People("Ana", 43)
            };

            Show(students);
        }

        static void Show(List<People> listado) {
            Console.WriteLine("-- Personas --");
            foreach (People p in listado) {
                Console.WriteLine($"People Name: {p.Name}, Age: {p.Age}");
            }
        }
    }
}