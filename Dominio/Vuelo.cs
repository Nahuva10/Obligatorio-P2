using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Vuelo
    {

        private string numeroDeVuelo;
        private Ruta rutaQueCubre;
        private Avion avion;
        private List<DayOfWeek>frecuencia;
        private double costoPorAsiento;

        
        public Ruta RutaQueCubre
        {
            get { return rutaQueCubre; }
        }
        public List<DayOfWeek> Frecuencia
        {
            get { return frecuencia; }
        }
        public Avion Avion
        {
            get { return avion; }
        }

        public string NumeroDeVuelo
        {
            get { return numeroDeVuelo; }
        }

        public double CostoPorAsiento
        {
            get { return costoPorAsiento; }
        }
        public Vuelo(string numeroDeVuelo, Ruta rutaQueCubre, Avion avion, List<DayOfWeek> frecuencia)
        {
            this.numeroDeVuelo = numeroDeVuelo;
            this.rutaQueCubre = rutaQueCubre;
            this.avion = avion;
            this.frecuencia = frecuencia;
            this.costoPorAsiento = PrecioPorAsiento(avion.CostoOperacionPorKm, rutaQueCubre.Distancia, rutaQueCubre.AeropuertoDeSalida.CostoOperacion, rutaQueCubre.AeropuertoDeLlegada.CostoOperacion, avion.CantidadAsientos);
        }
        
        public void Validar()
        {
            ValidarNumeroDeVuelo();
            ValidarAlcanceDeAvion();
        }
        private void ValidarNumeroDeVuelo()
        {
            if (string.IsNullOrEmpty(numeroDeVuelo)) throw new Exception ("El numero de vuelo no puede estar vacio");
            if (numeroDeVuelo.Length > 6 || numeroDeVuelo.Length < 3) throw new Exception("El numero de vuelo debe tener 2 letras y entre 1 y 4 numeros");
            int contadorLetras = 0;
            int contadorNumeros = 0;
            foreach(char c in numeroDeVuelo)
            {
                if (char.IsLetter(c))
                {
                    contadorLetras++;
                }else if (char.IsDigit(c))
                {
                    contadorNumeros++;
                }
                else
                {
                    throw new Exception("El numero de vuelo no puede contener nigun caracter especial");
                }
            }
            if (contadorLetras != 2) throw new Exception("El numero de vuelo debe tener 2 letras");
            if (contadorNumeros < 1 && contadorNumeros > 4) throw new Exception("El numero de vuelo debe tener 2 letras");
        }
        private void ValidarAlcanceDeAvion()
        {
            if (avion.Alcance < rutaQueCubre.Distancia) throw new Exception("El alcance del avion asignado no puede cubrir la distancia de la ruta");
        }

        public override bool Equals(object? obj)
        {
            return obj is Vuelo vue && vue.numeroDeVuelo == this.numeroDeVuelo;
        }
        public override string ToString()
        {
            string dias = "";
            foreach(DayOfWeek day in frecuencia)
            {
                dias += $"{day} ";
            }
            return $"Numero de vuelo: {numeroDeVuelo} - Modelo de avion: {avion.Modelo} - ruta de vuelo: {rutaQueCubre} - Frecuencia: {dias}";
        }

        public string MostrarFrecuencia()
        {
            string dias = "";
            foreach (DayOfWeek day in frecuencia)
            {
                dias += $"{day}, ";
            }
            dias = dias.Substring(0, dias.Length - 2);
            return dias;
        }
        
        public double PrecioPorAsiento(double costoOperacion, double distanciaRuta, double costoSalida, double costoLlegada, int cantAsientos)
        {
            double costoPorAsiento = (costoOperacion * distanciaRuta + costoSalida + costoLlegada) / cantAsientos;
            return costoPorAsiento;
        }
    }
}
