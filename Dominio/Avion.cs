using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{

    public class Avion
    {
        private string fabricante;
        private string modelo;
        private int cantidadAsientos;
        private double alcance;
        private double costoOperacionPorKm;
        private int id;
        private static int ultId = 0;

        public string Modelo { get { return modelo; } }
        public double CostoOperacionPorKm
        {
            get { return costoOperacionPorKm;}
        }
        public double Alcance
        {
            get { return alcance;}
        }

        public int CantidadAsientos
        {
            get { return cantidadAsientos; }
        }

        public int Id
        {
            get
            {
                return id;
            }
        }

        public Avion()
        {
            
        }
        public Avion(string fabricante, string modelo, int cantidadAsientos, double alcance, double costoOperacionPorKm)
        { 
            this.fabricante = fabricante;
            this.modelo = modelo;
            this.cantidadAsientos = cantidadAsientos;
            this.alcance = alcance;
            this.costoOperacionPorKm = costoOperacionPorKm;
            this.id = ultId++;
        }

        public void Validar()
        {
            ValidarFabricante();
            ValidarModelo();
            ValidarCantidadAsientos();
            ValidarAlcance();
            ValidarCostoOperacionPorKm();
        }
        private void ValidarFabricante()
        {
            if (string.IsNullOrEmpty(fabricante)) throw new Exception("El fabricante no puede estar vacio");
        }
        private void ValidarModelo()
        {
            if (string.IsNullOrEmpty(modelo)) throw new Exception("El modelo no puede estar vacio");
        }
        private void ValidarCantidadAsientos()
        {
            if (cantidadAsientos <= 0) throw new Exception("La cantidad de asientos no puede estar vacia");
        }
        private void ValidarAlcance()
        {
            if (alcance < 0) throw new Exception("El alcance no puede ser negativo");
        }
        private void ValidarCostoOperacionPorKm()
        {
            if (costoOperacionPorKm < 0) throw new Exception("El alcance no puede ser negativo");
        }

        public override bool Equals(object? obj)
        {
            return obj is Avion av && av.id == this.id;
        }


        public override string ToString()
        {
            return $"{fabricante} - {modelo}";
        }

    }
}
