using EvaluacionAgosto2021POO.Enums;

namespace EvaluacionAgosto2021POO.Clases
{
    public class Telefono
    {
        public string Caracteristica { get; set; }
        public string NroTelefonico { get; set; }
        public OrigenTelefono OrigenTelefono { get; set; }
        public TipoTelefono TipoTelefono { get; set; }
        public override string ToString()
        {
            return $"({Caracteristica})-{NroTelefonico}";
        }
    }
}