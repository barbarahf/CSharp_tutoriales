using System;
using System.Collections.Generic;


namespace poo
{
    public class Video
    {
        private static string url { get; set; }
        private static string titulo { get; set; }
        private List<string> groupOfTags = new List<string>();

        public Video(string url, string titulo, List<string> groupOfTags)
        {
            url = Video.url;
            titulo = Video.titulo;
        }
    }

    public class Usuario
    {
        private string nomUsuario;
        private string nom;
        private string cognom;
        private string pasword;
        private DateTime fechaRegistro;
        
        public Usuario(string nomUsuario,string nom, string cognom,string pasword, DateTime fechaRegistro)
        {
            nomUsuario = this.nomUsuario;
            nom = this.nom;
            cognom = this.cognom;
            pasword = this.pasword;
            fechaRegistro = this.fechaRegistro;
        }

        void createVideo()
        {
            //Video temp=new Video();
        }
    }
    //check password
    //CHeck si nom usuario existe
    //Metodo de control y propertt y
    public class Videos
    {
        static void Main01(string[] args)
        {
            Usuario user1= new Usuario("Unatalbarbara","Barbara","Herrera","123456", DateTime.Now);
        }
    }
}