namespace API.ROBO.Models
{
    public class Robo
    {
        public Cabeca Cabeca { get; set; }
        public Braco BracoDireito { get; set; }
        public Braco BracoEsquerdo { get; set; }

        // Construtor padrao para definir os lados dos bracos
        public Robo()
        {
            this.Cabeca = new Cabeca();
            this.BracoDireito = new Braco(BracoLado.Direito);
            this.BracoEsquerdo = new Braco(BracoLado.Esquerdo);
        }

        public Robo (Cabeca cabeca, Braco bracoDireito, Braco bracoEsquerdo)
        {
            this.Cabeca = cabeca;
            this.BracoDireito = bracoDireito;
            this.BracoEsquerdo = bracoEsquerdo;
        }
    }
}
