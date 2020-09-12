namespace API.ROBO.Models
{
    public class Braco
    {
        public BracoLado Lado { get; set; }
        public PosicaoCotovelo Cotovelo { get; set; }
        public RotacaoPulso Pulso { get; set; }

        // Construtor padrao com membros "Em repouso"
        public Braco(BracoLado lado)
        {
            this.Lado = lado;
            this.Cotovelo = PosicaoCotovelo.EmRepouso;
            this.Pulso = RotacaoPulso.EmRepouso;
        }

        public Braco(BracoLado lado, PosicaoCotovelo cotovelo, RotacaoPulso pulso)
        {
            this.Lado = lado;
            this.Cotovelo = cotovelo;
            this.Pulso = pulso;
        }
    }
}
