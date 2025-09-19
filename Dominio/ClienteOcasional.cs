using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ClienteOcasional : Cliente
    {
        private bool premio;


        public ClienteOcasional()
        {
            Random premio = new Random();
            bool tienePremio = premio.Next(2) == 0;
            this.premio = tienePremio;

        }

        public bool Premio
        {
            get { return premio; }
            set { premio = value; }
        }

        public ClienteOcasional(string cedula, string nombre, string nacionalidad, string mail, string password) : base(cedula, nombre, nacionalidad, mail, password)
        {
            Random premio = new Random();
           bool tienePremio = premio.Next(2)== 0;
            this.premio = tienePremio;

        }

        public override string ToString()
        {
            string tienePremio = premio ? "Si" : "No";
            return $"{base.ToString()} - pertenece premio: {tienePremio}";
        }

        public override double Porcentaje(int equipaje)
        {
            if (equipaje == 1)
            {
                return base.Porcentaje(equipaje) + 10;
            }
            if (equipaje == 2)
            {
                return base.Porcentaje(equipaje) + 20;
            }
            return base.Porcentaje(equipaje);
        }
    }
}
