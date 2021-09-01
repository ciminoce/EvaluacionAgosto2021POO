namespace EvaluacionAgosto2021POO.Clases
{
    public class Cliente : Persona
    {
        public string Mail { get; set; }
        public override string ToString()
        {
            return $"{Nombre} {Apellido} - {Telefono} - {Mail}";
        }
    }
}