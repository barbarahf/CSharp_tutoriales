using System;

namespace Youtube
{
    public class Usuario
    {
        private string nomUsuario;
        private string nom;
        private string cognom;
        private string pasword;
        private DateTime fechaRegistro;
        
        public Usuario(string nomUsuario,string nom, string cognom,string pasword)
        {
            this.nomUsuario = nomUsuario;
            this.nom = nom;
            this.cognom = cognom;
            this.pasword = pasword;
            this.fechaRegistro= DateTime.Today;
          //  this.fechaRegistro = fechaRegistro;
        }

       
    }
}