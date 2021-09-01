using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvaluacionAgosto2021POO.Clases;
using EvaluacionAgosto2021POO.Enums;

namespace EvaluacionAgosto2021POO
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("0-Salir");
                Console.WriteLine("1-Generar empleados");
                Console.WriteLine("2-Mostrar Empleados");

                Console.Write("Ingrese selección:");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 0:
                        break;
                    case 1:
                        GenerarEmpleados();
                        break;
                    case 2:
                        MostrarEmpleados();
                        break;
                    default:
                        break;
                }
            } while (true);
        }

        private static void MostrarEmpleados()
        {
            Console.Clear();
            foreach (var empleado in Empresa.GetInstancia().Personal)
            {
                Console.WriteLine(empleado.ToString());
            }

            Console.ReadLine();
        }

        private static void GenerarEmpleados()
        {
            Random r = new Random();
            for (int i = 0; i < 20; i++)
            {
                Empleado empleado = new Empleado()
                {
                    Nombre = $"Empleado {i}",
                    Apellido = $"ApellidoEmpleado {i}",
                    FechaNacimiento = new DateTime(2000, 1, 1),
                    Sector = (Sector) r.Next(0, 2)
                };
                Empresa.GetInstancia().Personal.Add(empleado);
            }

            for (int i = 0; i < 3; i++)
            {
                Directivo directivo = new Directivo()
                {
                    Nombre = $"Directivo {i}",
                    Apellido = $"ApellidoDirectivo {i}",
                    FechaNacimiento = new DateTime(2000, 1, 1),
                    Sector = (Sector) r.Next(0, 2),
                    Categoria = (Categoria) r.Next(0, 2)

                };
                Empresa.GetInstancia().Personal.Add(directivo);
            }

            Console.WriteLine("Generación finalizada");
        }
    }
}
