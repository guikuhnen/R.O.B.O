namespace API.ROBO.Models
{
    public class Cabeca
    {
        public RotacaoCabeca Rotacao { get; set; }
        public InclinacaoCabeca Inclinacao { get; set; }

        // Construtor padrao com membros "Em repouso"
        public Cabeca()       
        {
            Rotacao = RotacaoCabeca.EmRepouso;
            Inclinacao = InclinacaoCabeca.EmRepouso;
        }

        public Cabeca(RotacaoCabeca rotacao, InclinacaoCabeca inclinacao)
        {
            this.Rotacao = rotacao;
            this.Inclinacao = inclinacao;
        }
    }
}
