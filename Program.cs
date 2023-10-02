using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2._1_UH_Progra_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Bienvenido a la tienda de camisas.");

                Console.Write("Ingrese la cantidad de camisas que desea comprar: ");
                int cantidadCamisas = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el precio de una camisa: ");
                double precioCamisa = double.Parse(Console.ReadLine());

                double precioTotal = CalcularPrecioTotal(cantidadCamisas, precioCamisa);

                Console.WriteLine("El precio total a pagar es: $" + precioTotal.ToString("0.00"));
                Console.Read();            }

            static double CalcularPrecioTotal(int cantidadCamisas, double precioCamisa)
            {
                double precioTotal = cantidadCamisas * precioCamisa;

                if (cantidadCamisas >= 2 && cantidadCamisas <= 5)
                {
                    // Aplicar descuento del 15%
                    precioTotal *= 0.85;
                }
                else if (cantidadCamisas > 5)
                {
                    // Aplicar descuento del 20%
                    precioTotal *= 0.80;
                }

                return precioTotal;
            }
        }

    }




