using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente: Usuario , IComparable<Cliente>
    {
        private string cedula;
        private string nombre;
        private string nacionalidad;

        public Cliente()
        {

        }

        public Cliente(string cedula, string nombre, string nacionalidad, string mail, string password):base(mail, password)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.nacionalidad = nacionalidad;
        }

        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { nacionalidad = value; }
        }

        public override void Validar()
        {
            base.Validar();
            ValidarCedula();
            ValidarNombre();
            ValidarNacionalidad();
        }
        private void ValidarCedula()
        {
            if (string.IsNullOrEmpty(cedula)) throw new Exception("La cedula no puede estar vacio");
        }
        private void ValidarNombre()
        {
            if (string.IsNullOrEmpty(nombre)) throw new Exception("El nombre no puede estar vacio");
        }
        private void ValidarNacionalidad()
        {
            if (string.IsNullOrEmpty(nacionalidad)) throw new Exception("La nacionalidad no puede estar vacio");
        }

        public override string ToString()
        {
            return $"Nombre: {nombre} - {base.ToString()} - Nacionalidad: {nacionalidad}";
        }

        public virtual double Porcentaje(int equipaje)
        { 
            return 25;
        }

        public int CompareTo(Cliente? cli)
        {
            return this.cedula.CompareTo(cli.cedula);
        }
    }
}
