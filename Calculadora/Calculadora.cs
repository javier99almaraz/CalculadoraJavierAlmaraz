using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Calculadora
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Calculadora \r");
            Console.WriteLine("------------------------\n");
            string n1 = args[0]; 
            string n2 = args[1];
            string opcion = args[2];
            int codigo = 0;

            // Impresión de cálculos
            int num1 = Convert.ToInt32(n1); int num2= Convert.ToInt32(n2);
            if ((opcion == "s") || (opcion == "r") || (opcion == "m") || (opcion == "d"))
                switch (opcion)
                {

                    case "s":
                        Console.WriteLine($"Tu resultado es: {num1} + {num2} = " + (num1 + num2));
                        break;
                    case "r":
                        Console.WriteLine($"Tu resultado es: {num1} - {num2} = " + (num1 - num2));
                        break;
                    case "m":
                        Console.WriteLine($"Tu resultado es: {num1} * {num2} = " + (num1 * num2));
                        break;
                    case "d":
                        if (num2 != 0)
                            Console.WriteLine($"Tu resultado es: {num1} / {num2} = " + (num1 / num2));
                        else
                            codigo = 1;
                        Console.WriteLine("No se pueden hacer divisiones con un divisor 0");
                        break;


                }
            else
                codigo = 2;
                Console.WriteLine("No se ha seleccionado una operacion correcta");
            Console.WriteLine("Error codigo: "+codigo);
            Console.WriteLine("Presiona cualquier botón para salir...");
            Console.ReadKey();
        }

    }    
}
