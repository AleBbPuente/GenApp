using System;
namespace GenApp.Modelos
{
    public class Usuario
    {
        private string usuario;
        private string password;

        public Usuario()
        {

        }

        public string User
        {
            get => usuario;
            set => usuario = value;
        }

        public string Password
        {
            get => password;
            set => password = value;
        }
    }
}