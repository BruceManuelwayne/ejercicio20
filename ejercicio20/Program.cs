using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validarNumero; 
            int numero1;
            int numero2;
            string input;

            do
            {
                Console.WriteLine("Ingrese primer numero:");

                input = Console.ReadLine();

                validarNumero = Int32.TryParse(input, out numero1);

                if (!validarNumero) 
                {
                    Console.WriteLine("Numero invalido, ingrese otro numero:");
                    continue; 
                }
                do
                {
                    Console.WriteLine("Ingrese el segundo numero:");

                    input = Console.ReadLine();

                    validarNumero = Int32.TryParse(input, out numero2);

                    if (!validarNumero)
                    {
                        Console.WriteLine("Numero invalido, ingrese el segundo numero de nuevo:  ");
                        continue;
                    }
                    if (numero1 > numero2)
                    {
                        Console.WriteLine($"El primer numero: {numero1} es mayor al segundo: {numero2}");
                    }
                    else
                    {
                        if (numero1 == numero2)
                        {
                            Console.WriteLine("los numeros son iguales");
                        }
                        else
                        {
                            Console.WriteLine($"El primero numero: {numero1} es menor al segundo numero: {numero2}");
                        }
                    }
                } while (!validarNumero);

            } while (!validarNumero);

            Console.ReadKey();

           
        } 
    }
}
