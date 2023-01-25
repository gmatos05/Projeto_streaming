namespace Streaming{
    class Serie:Conteudo{
        //Propriedades
        public int NumerodeEpisodios{get;set;}
        public int episodioAtual{get;set;}
        public int NumerodeTemporada{get;set;}
        public int TemporadaAtual{get;set;}
        
        //Metodos
        public void NextEpisode(){
            if(this.NumerodeEpisodios == this.episodioAtual ){
                if(this.NumerodeTemporada == this.TemporadaAtual){
                    System.Console.WriteLine("Este é o ultimo episodio, so da para voltar ou assista outra coisa");
                }
                else{
                    this.episodioAtual=1;
                    this.TemporadaAtual +=1;
                    System.Console.WriteLine($"Voce esta no {this.episodioAtual}º episodio  da temporada {this.NumerodeTemporada}");
                }
               // this.episodioAtual = this.NumerodeEpisodios;

     
            }
            else{
                this.episodioAtual += 1;
            }
        }
        public void PrevEpisode(){
            if(this.episodioAtual == 1 ){
                if(this.TemporadaAtual == 1){
                    System.Console.WriteLine($"Este é o {this.episodioAtual}º episodio, so há como avancar!  ");
                }
                else{
                    this.episodioAtual = this.NumerodeEpisodios;
                    this.TemporadaAtual -=1;
                    System.Console.WriteLine($"Voce esta no {this.episodioAtual}º episodio  da temporada {this.NumerodeTemporada}");
                }
               // this.episodioAtual = this.NumerodeEpisodios;

     
            }
            else{
                this.episodioAtual -= 1;
            }
        }
        public void NextSeason(){
            if(this.NumerodeTemporada == this.TemporadaAtual){
                System.Console.WriteLine("Voce esta na ultima temporada,voce so pode voltar");
            }
            else{
                this.TemporadaAtual+=1;
                EscolherEpisodio();
                
            }
        }
        public void PrevSeason(){
            if(this.TemporadaAtual == 1){
                System.Console.WriteLine($"Voce esta na {this.TemporadaAtual}º temporada,voce so pode avancar");
            }
            else{
                this.TemporadaAtual-=1;     
                EscolherEpisodio();
            }
        }
        public void EscolherSeason(){
            bool verificacao;
            int num_Temp;
            
            do{
                System.Console.WriteLine("Selecione uma Temporada:");
                for (int i =1 ; i<=this.NumerodeTemporada;i++){
                    System.Console.WriteLine($"{i}º Temporada");
                }
                verificacao = int.TryParse(Console.ReadLine(),out num_Temp);
            }while(verificacao == false || (num_Temp>1 && num_Temp<=this.NumerodeTemporada));
            this.TemporadaAtual = num_Temp;
            EscolherEpisodio();
        }
        public void EscolherEpisodio(){
            bool verificacao;
            int num_Ep;
            do{
                System.Console.WriteLine("Selecione um episodio:");
                for (int i =1 ; i<=this.NumerodeEpisodios;i++){
                    System.Console.WriteLine($"{i}º Episodio");
                }
                verificacao = int.TryParse(Console.ReadLine(),out num_Ep);
            }while(verificacao == false || (num_Ep>1 && num_Ep<=this.NumerodeEpisodios));
            this.episodioAtual = num_Ep;
        }
    }
}