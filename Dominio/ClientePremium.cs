using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ClientePremium : Cliente
    {
        private int puntos;

        public ClientePremium(int puntos, string cedula, string nombre, string nacionalidad, string mail, string password) : base(cedula, nombre, nacionalidad, mail, password)
        {
            this.puntos = puntos;
        }

        public int Puntos
        {
            get
            {
                return puntos;
            }
            set { puntos = value; }
        }

        public override void Validar()
        {
            base.Validar();
            ValidarPuntoS();
        }
        private void ValidarPuntoS()
        {
            if (puntos < 0) throw new Exception("La cantidad de puntos no puede ser negativa");
        }

        public override string ToString()
        {
            return $"{base.ToString()} - cantidad de puntos: {puntos}";
        }

        public override double Porcentaje(int equipaje)
        {
            if (equipaje == 2)
            {
                return base.Porcentaje(equipaje) + 5;
            }
            return base.Porcentaje(equipaje);
        }
    }
}
