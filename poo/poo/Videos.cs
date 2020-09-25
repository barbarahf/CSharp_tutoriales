using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;

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
    }

    public class Videos
    {
        static void Main01(string[] args)
        {
        }
    }
}