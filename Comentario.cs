namespace Projeto_streaming 
{
    public class Comentario
    {
        public DateTime data {get;set;}
        public string comentario{get;set;}
        public Comentario(string comentario)
        {
            this.comentario = comentario;
            data = DateTime.Now;
        }
    }
}