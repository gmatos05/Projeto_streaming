namespace Projeto_streaming
{
    public class Avaliacao{
        public int avaliacao{get;private set;}
        public void Avaliar()
        {
            bool verificacao;
            int nota;

            do
            {
                System.Console.Write("  Avalie com uma nota entre 1 e 5: ");
                verificacao = int.TryParse(Console.ReadLine(),out nota);

                if (!verificacao)
                {
                    Console.WriteLine("  Apenas valores numericos inteiros ser�o aceitos.");
                }
                else if(nota < 1 || nota > 5)
                {
                    Console.WriteLine("  Ultilize apenas valores inteiros entre 1 e 5.");
                }

            }while(!verificacao || (nota < 1 || nota > 5));

            this.avaliacao = nota;
        }
    }
}