using System;

namespace EvaluacionAgosto2021POO.Clases
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        

        public string Apellido { get; set; }
        

        public Telefono Telefono { get; set; }
        

        public virtual void MostrarDatos()
        {
            Console.WriteLine($"{Nombre} {Apellido} - {Telefono}");
        }

        public override string ToString()
        {
            return $"{Nombre} {Apellido} - {Telefono}";
        }
    }
}