using System.Collections.Generic;

namespace EvaluacionAgosto2021POO.Clases
{
    public class Proveedor
    {
        public string NombreFantasia { get; set; }
       
        public Contacto PersonaContacto { get; set; }


        public List<Telefono> Telefonos { get; set; } = new List<Telefono>();


        public override string ToString()
        {
            return $"{NombreFantasia} - {PersonaContacto}";
        }
    }
}