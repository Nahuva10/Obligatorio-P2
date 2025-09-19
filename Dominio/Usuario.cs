using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        private string mail;
        private string password;

        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public Usuario()
        {

        }
        public Usuario(string mail, string password)
        {
            this.mail = mail;
            this.password = password;
        }

        public virtual void Validar()
        {
            ValidarMail();
            ValidarPassword();

        }
        private void ValidarMail()
        {
            if (string.IsNullOrEmpty(mail)) throw new Exception("El mail no puede estar vacio");
        }
        private void ValidarPassword()
        {
            if (string.IsNullOrEmpty(password)) throw new Exception("La contraseña no puede estar vacio");
            if (password.Length < 8) throw new Exception("La contraseña debe tener al menos 8 caracteres.");
        }
        public override bool Equals(object? obj)
        {
            return obj is Usuario usu && usu.mail == this.mail;
        }

        public override string ToString()
        {
            return $"Email: {mail}";
        }

    }
}
