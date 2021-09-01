using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EvaluacionAgosto2021POO.Clases;

namespace EvaluacionAgosto2021POO
{
    public class Empresa
    {
        public List<Empleado> Personal { get; set; } = new List<Empleado>();
        public List<Cliente> Clientes { get; set; } = new List<Cliente>();
        public List<Proveedor> Proveedores { get; set; } = new List<Proveedor>();
        public void CalcularSueldos()
        {
            throw new System.NotImplementedException();
        }
        public void MostrarEmpleados()
        {
            throw new System.NotImplementedException();
        }

        public static Empresa instancia;

        public static Empresa GetInstancia()
        {
            if (instancia==null)
            {
                instancia = new Empresa();
            }

            return instancia;
        }
        private Empresa()
        {
            
        }
    }
}