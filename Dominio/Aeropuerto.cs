using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Aeropuerto
    {
        private string codigoIATA;
        private string ciudad;
        private double costoOperacion;
        private double costoTasa;

        public string CodigoIATA
        {
            get { return codigoIATA; }
        }
        public string Ciudad
        {
            get { return ciudad; }
        }

        public double CostoTasa
        {
            get { return costoTasa; }
        }

        public double CostoOperacion
        {
            get { return costoOperacion; }
        }

        public Aeropuerto()
        {

        }
        public Aeropuerto(string codigoIATA, string ciudad, double costoOperacion, double costoTasa)
        {
            this.codigoIATA = codigoIATA;
            this.ciudad = ciudad;
            this.costoOperacion = costoOperacion;
            this.costoTasa = costoTasa;
        }
        public void Validar()
        {
            ValidarCodigoIATA();
            ValidarCiudad();
            ValidarCostoOperacion();
            ValidarCostoTasa();
        }
        private void ValidarCodigoIATA()
        {
            if (string.IsNullOrEmpty(codigoIATA)) throw new Exception("El codigo IATA no puede estar vacio");
            if (codigoIATA.Length != 3) throw new Exception("El codigo IATA debe tener 3 letras");
            foreach(char c in codigoIATA)
            {
                if (!char.IsLetter(c)) throw new Exception("El codigo IATA debe tener solo letras");
            }
        }
        private void ValidarCiudad()
        {
            if (string.IsNullOrEmpty(ciudad)) throw new Exception("La ciudad no puede estar vacia");
        }
        private void ValidarCostoOperacion()
        {
            if (costoOperacion < 0) throw new Exception("El costo de la operacion no puede ser negativo");
        }
        private void ValidarCostoTasa()
        {
            if (costoTasa < 0) throw new Exception("El costo de la tasa no puede ser negativo");
        }


        public override bool Equals(object? obj)
        {
            return obj is Aeropuerto aero && aero.codigoIATA == this.codigoIATA;
        }



        public override string ToString()
        {
            return $"El codigo IATA es: {codigoIATA} la ciudad es: {ciudad} el costo de la operacion es: {costoOperacion} y el costo de la tasa es: {costoTasa}";
        }
    }
}
