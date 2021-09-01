using System;
using EvaluacionAgosto2021POO.Enums;

namespace EvaluacionAgosto2021POO.Clases
{
    public class Empleado : Persona
    {
        public Sector Sector { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public decimal Sueldo { get; set; }
        public int InformarEdad()
        {
            return (int) Math.Truncate(DateTime.Today.Subtract(FechaNacimiento).TotalDays / 365.25);
        }

        public override string ToString()
        {
            return $"{Nombre} {Apellido} - {Telefono} - {Sector}";
        }
    }
}