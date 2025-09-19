using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Ruta
    {
        private int id;
        private static int ultId = 0;
        private Aeropuerto aeropuertoDeSalida;
        private Aeropuerto aeropuertoDeLlegada;
        private double distancia;


        public Aeropuerto AeropuertoDeSalida
        {
            get { return aeropuertoDeSalida; }
        }

        public Aeropuerto AeropuertoDeLlegada
        {
            get { return aeropuertoDeLlegada; }
        }
        public double Distancia
        {
            get { return distancia; }
        }

        public int Id
        {
            get { return id; }
        }
        

        public Ruta(Aeropuerto aeropuertoDeSalida, Aeropuerto aeropuertoDeLlegada, double distancia)
        {
            this.aeropuertoDeSalida = aeropuertoDeSalida;
            this.aeropuertoDeLlegada = aeropuertoDeLlegada;
            this.distancia = distancia;
            this.id = ultId++;
        }

        public void Validar()
        {
            ValidarDistancia();
            ValidarAeropuertoDeLlegada();
        }
        private void ValidarDistancia()
        {
            if (distancia < 0) throw new Exception("La distancia no puede ser negativa");
        }
        private void ValidarAeropuertoDeLlegada()
        {
            if (aeropuertoDeSalida == aeropuertoDeLlegada) throw new Exception("El aeropuerto de llegada no puede ser el mismo que el de salida");
        }
        public override bool Equals(object? obj)
        {
            return obj is Ruta ru && ru.id == this.id;
        }
        public override string ToString()
        {
            return $"{aeropuertoDeSalida.CodigoIATA} - {aeropuertoDeLlegada.CodigoIATA}";
        }
    }
}
