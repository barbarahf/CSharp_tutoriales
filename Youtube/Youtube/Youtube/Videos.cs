using System;
namespace Youtube
{
  
    using System;
    using System.Collections.Generic;
    using System.Net.Mime;

    namespace Youtube

 
    {
        public class Videos
        {
            private static string url { get; set; }
            private static string titulo { get; set; }
            private List<string> groupOfTags = new List<string>();

            public Videos(string url, string titulo, List<string> groupOfTags)
            {
                url = Videos.url;
                titulo = Videos.titulo;
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

            /*static public void Main(String[] args)
            {
         
            }*/
        }
        //check password
        //CHeck si nom usuario existe
    
   
    }
}
