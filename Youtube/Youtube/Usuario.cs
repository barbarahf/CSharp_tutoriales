using System;
using System.Collections.Generic;

namespace Youtube
{
    public class Usuario
    {
        static List<string> nomUsuarios = new List<string>();
        public static List<Usuario> Usuarios = new List<Usuario>();
        private List<Video> userVideos = new List<Video>();


        private string nomUsuario;
        private string nom;
        private string cognom;
        private string pasword;
        private DateTime fechaRegistro;

        public Usuario(string nomUsuario, string nom, string cognom, string pasword)
        {
            this.nomUsuario = nomUsuario;
            this.nom = nom;
            this.cognom = cognom;
            this.pasword = pasword;
            fechaRegistro = DateTime.Now;
            nomUsuarios.Add(this.nomUsuario);
        }

        //Metodos
        public DateTime FechaRegistro => fechaRegistro;
        public List<Video> UserVideos => userVideos;
        public static List<string> NomUsuarios => nomUsuarios;
        public string Pasword => pasword;

        public void CreateVideo(string url, string titulo)
        {
            userVideos.Add(new Video(url, titulo));
        }
    }
}