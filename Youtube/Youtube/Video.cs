using System;
using System.Collections.Generic;

namespace Youtube

{
    public class Video
    {
        private string _url;
        private string titulo;
        private List<string> groupOfTags = new List<string>();

        public List<string> GroupOfTags => groupOfTags;

        private Estado video;

        public Video(string url, string titulo)
        {
            _url = url;
            this.titulo = titulo;
            video = Estado.Reproducir;
     
        }


        private enum Estado
        {
            Reproducir = 1,
            Pausar = 0
        }

        public string Titulo => titulo;
        public string Url => _url;

        public void CreateTag(string tagName)
        {
            groupOfTags.Add(tagName); //Tag especifica de ese video
        }
    }
}