using System;

namespace Static {
    class People {
        // propiedad de clase
        private static int count = 0;
        // propiedades de objetos
        private string name;
        private int age;

        public People() {
            count++;
        }

        public string Name
        {
            get { return name; } 
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public static string GetCount()
        {
            return $"Esta clase se ha utilizado {count} veces";
        }
    }

    class Program {
        static void Main(string[] args) {
            People people = new People();
            people.Name = "Mario";
            people.Age = 33;

            People antonio = new People() {
                Name="Antonio",
                Age=40
            };

            Console.WriteLine(People.GetCount());
        }
    }
}