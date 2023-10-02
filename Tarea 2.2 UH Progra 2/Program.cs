using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2._2_UH_Progra_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Bienvenido al sistema de ventas.");

                Console.Write("Ingrese la cantidad de artículos que desea comprar: ");
                int cantidadArticulos = int.Parse(Console.ReadLine());

                double precioPorArticulo = CalcularPrecioPorArticulo(cantidadArticulos);
                double precioTotal = precioPorArticulo * cantidadArticulos;

                Console.WriteLine("Precio por artículo: $" + precioPorArticulo.ToString("0.00"));
                Console.WriteLine("Precio total: $" + precioTotal.ToString("0.00"));
            Console.Read();

            }

            static double CalcularPrecioPorArticulo(int cantidadArticulos)
            {
                if (cantidadArticulos <= 10)
                {
                    return 20.0; // Precio por artículo si se compran 10 o menos
                }
                else
                {
                    return 15.0; // Precio por artículo si se compran más de 10
                }
            }
        }

    }


