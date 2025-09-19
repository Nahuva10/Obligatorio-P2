using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Administrador: Usuario
    {
        private string apodo;

        public Administrador(string apodo, string mail, string password):base(mail, password)
        {
            this.apodo = apodo;
        }
        public void Validar()
        {
            ValidarApodo();
        }
        private void ValidarApodo()
        {
            if (string.IsNullOrEmpty(apodo)) throw new Exception("El apodo no puede estar vacio");
        }
    }

    
}
