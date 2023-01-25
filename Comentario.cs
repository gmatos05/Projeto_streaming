namespace Streaming {
    class Comentario{
        public bool publicado{get;set;}
        public string comentario{get;set;}
        public Comentario(string comentario,bool publicado){
            this.comentario = comentario;
            this.publicado = publicado;
        }
    }
}