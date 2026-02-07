using System;

// bibliote que permite leer archivo
using System.IO;

namespace Exceptions
{
    /**
     * Las exceptions manejan situaciones inesperadas que ocurren en la ejecucion del programa
     */
    class Program {
        static void Main(string[] args) {
            // Declarando bloque try-catch
            try
            {
                string dataContent = File.ReadAllText(@"C:\Users\carlo\Downloads\data.txt");
                Console.WriteLine(dataContent);

                throw new Exception("Se produjo un error inesperado");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Se busco el archivo pero no se encontro o el archivo no existe");
            }
            // encadenando mas exceptions
            catch (IOException ex)
            {
                Console.WriteLine("Se produjo un error en la operacion Input/Ouput (IO)");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error pero no se pudo determinar que paso");
            }
            // pase lo que pase, siempre se ejecuta el bloque finally
            finally {
                Console.WriteLine("Si, sucedio un exception pero do not worry, be happy!");
            }

            Console.WriteLine("El sistema continua su ejecucion");
        }
    }
}