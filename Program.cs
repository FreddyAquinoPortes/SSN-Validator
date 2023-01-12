using System;

namespace SSN_VAlIDATOR
{
    class Program
    {
        static void Main(string[] args)
        {
            string ssn = "xxx-xx-xxxx";
            string respuesta = "r";

            while (respuesta !="n")
            {


                Console.WriteLine("Ingresa el SSN En formato xxx-xx-xxxx");


                ssn = Console.ReadLine();

                if (SSNValidation.IsValid(ssn) == true)
                {
                    Console.WriteLine("Formato SSN Correcto");

                }
                else
                {
                    Console.WriteLine("Formato SSN Incorrecto");


                }
                Console.WriteLine("\nPresiona cualquier tecla para repetir el proceso o n para salir");
                respuesta=  Console.ReadLine();
                Console.Clear();
            }

        }
    }
}
