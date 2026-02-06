using System;

namespace Herencia {

    class People {
        private string name;
        private int age;

        public People(string name, int age) {
            this.name = name;
            this.age = age;
        }

        public string Name {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set {
                if (value > 120) {
                    value = 1;
                    Console.WriteLine("Error, edad no puede superar los 120 años");
                }
                this.age = value;
            }
        }

        public string getInfo() {
            return "Personal info: " + name + ", age: " + age;
        }
    }

    /**
     * Los metodos protected definidos en la super clase solo pueden ser accedidos dentro de la subclase
     * pero no fuera de la subclase.
     */
    class Doctor : People {
        private string speciality;
        // pasamos al constructor de la super clase Doctor que es la clase People los atributos que necesita
        public Doctor(string name, int age, string speciality) : base(name, age)
        {
            this.speciality = speciality;
        }

        public string Speciality
        {
            get { return speciality; }
            set { speciality = value; }
        }

        public string getFullDescription() {
            return getInfo() + ", whith speciality: " + speciality;
        }
    }

    class Developer : People
    {
        private string programmingLanguage;
        public Developer(string name, int age, string programmingLanguage) : base(name, age) {
            this.programmingLanguage = programmingLanguage;
        }

        public string ProgrammingLanguage {
            get { return programmingLanguage; }
            set { programmingLanguage = value; }
        }

        public string getFullDescription() {
            return getInfo() + ", with programming language: " + programmingLanguage;
        }
    }

    class Program {
        static void Main(string[] args) {
            Doctor doc = new Doctor("Fernando Arenas", 58, "Gastro");
            Console.WriteLine(doc.getFullDescription());

            Developer dev = new Developer("Julio Paredes", 44, "C# .NET and Java");
            Console.WriteLine(dev.getFullDescription());
        }
    }
}