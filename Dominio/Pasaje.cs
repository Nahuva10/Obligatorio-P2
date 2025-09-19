using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dominio.Vuelo;

namespace Dominio
{
    public class Pasaje : IComparable<Pasaje>
    {
        public enum Equipaje
        {
            LIGHT,
            CABINA,
            BODEGA,
        }
        private int id;
        private static int ultId = 1;
        private Vuelo vuelo;
        private DateTime fecha;
        private Cliente pasajero;
        private Equipaje equipaje;

        public Pasaje()
        {
            this.id = ultId++;
        }


        public DateTime Fecha
        {
            get { return fecha; }
        }

        public Equipaje Equip
        {
            get { return equipaje; }
        }

        public Vuelo Vuelo
        {
            get { return vuelo; }
        }



        public Cliente Pasajero
        {
            get { return pasajero; }
        }


        public Pasaje(Vuelo vuelo, DateTime fecha, Cliente pasajero, Equipaje equipaje)
        {
            this.id = ultId++;
            this.vuelo = vuelo;
            this.fecha = fecha;
            this.pasajero = pasajero;
            this.equipaje = equipaje;
        }
        public void Validar()
        {
            ValidarFecha();
            
        }
        private void ValidarFecha()
        {
            if (!vuelo.Frecuencia.Contains(fecha.DayOfWeek)) throw new Exception("No coincide la frecuencia del vuelo con el dia del pasaje");
        }

        public override bool Equals(object? obj)
        {
            return obj is Pasaje pas && pas.id == this.id;
        }
        public override string ToString()
        {
            return $"ID de pasaje: {id} - Nombre de pasajero: {pasajero.Nombre} - fecha: {fecha} - Numero de vuelo: {vuelo.NumeroDeVuelo}";
        }

        public double CostoPasaje()
        {
            double PrecioPasaje = vuelo.CostoPorAsiento * (1 + (pasajero.Porcentaje((int)equipaje)) / 100) + vuelo.RutaQueCubre.AeropuertoDeSalida.CostoTasa + vuelo.RutaQueCubre.AeropuertoDeLlegada.CostoTasa;
            return Math.Round(PrecioPasaje, 2);
        }
        public int CompareTo(Pasaje? pas)
        {
            return this.fecha.CompareTo(pas.fecha);
        }

    }
}
