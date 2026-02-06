using System;

namespace ControlDeFlujo
{
    class Program {

        static bool isOpenRestaurant(string name, int hour=0) {
            if (name == "Lonches pepe" && hour > 13 && hour < 23) {
                return true;
            } else if (name == "Restaurant 24 horas") {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args) {
            // Simple IF - ELSE
            bool areYouHungry = true;
            bool haveMoney = true;

            if (areYouHungry) {
                Console.WriteLine("Ok debes hacer algo...");
            } 
            else
            {
                Console.WriteLine("Estas satisfecho...");
            }

            // && (AND) Conditions
            if (areYouHungry && haveMoney && isOpenRestaurant("Lonches pepe", 11)) {
                Console.WriteLine("Compra algo para comer...");
            }
            else
            {
                Console.WriteLine("Aun no puedes comprar");
            }

            // || (OR) Conditions
            if (areYouHungry || haveMoney)
            {
                Console.WriteLine("No te preocupes...");
            }
        }
    }
}