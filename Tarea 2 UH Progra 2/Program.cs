using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2_UH_Progra_2
{
    internal class Program
    {
        public static string condicion { get; private set; }

        static void Main(string[] args)
        {
           
            Console.WriteLine("Bienvenidos´al cálculo de la nota: ");
            Console.WriteLine("Favor de digitar los datos personales a continuación: ");

            Console.WriteLine("Digite el Numero de Identificacion del Estudiante: ");
            String carnet = Console.ReadLine();

            Console.WriteLine("Digite el Nombre del estudiante");
            String Nombre = Console.ReadLine();

            Console.WriteLine("Nota del quiz #1: ");
            double quiz1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota del quiz #2: ");
            double quiz2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota del quiz #3: ");
            double quiz3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota de la tarea #1: ");
            double tarea1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota de la tarea #2: ");
            double tarea2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota de la tarea #3: ");
            double tarea3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota del Examen #1:  ");
            double Examen1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota del Examen #2:  ");
            double Examen2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota del Examen #3:  ");
            double Examen3 = double.Parse(Console.ReadLine());

            

            double porcentajeQuices = (quiz1 + quiz2 + quiz3) / 3 * 0.25;
            double porcentajeTareas = (tarea1 + tarea2 + tarea3) / 3 * 0.30;
            double porcentajeExamenes = (Examen1 + Examen2 + Examen3) / 3 * 0.45;

            

            double PromedioFinal = porcentajeQuices + porcentajeTareas + porcentajeExamenes;

           

            if (PromedioFinal >= 70)
            {
                condicion = "Aprobado";
            }
            else if (PromedioFinal >= 50)
            {
                condicion = "Aplazado";
            }
            else
            {
                condicion = "Reprobado";
            }

            

        
            Console.WriteLine("Resultados: ");
            Console.WriteLine($"Carnet; {carnet}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Porcentaje de Quices: {porcentajeQuices}");
            Console.WriteLine($"Porcentaje de Tareas; {porcentajeTareas}");
            Console.WriteLine($"Porcentaje de Examenes: {porcentajeExamenes}");
           
            Console.WriteLine($"Promedio Final: {PromedioFinal}");
            Console.WriteLine($"Conficion: {condicion}");
            


            Console.ReadLine();


        }
    }
    }



