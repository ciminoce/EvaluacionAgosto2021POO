using System.Collections.Generic;
using EvaluacionAgosto2021POO.Enums;

namespace EvaluacionAgosto2021POO.Clases
{
    public class Directivo : Empleado
    {
        public Categoria Categoria { get; set; }
        

        public List<Empleado> EmpleadosACargo { get; set; }
        public override string ToString()
        {
            return $"{Nombre} {Apellido} - {Telefono} - {Sector} - {Categoria}";
        }
    }
}