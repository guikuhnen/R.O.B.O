using System.ComponentModel;

namespace API.ROBO.Models
{
    // Arquivo contendo todos os estados dos membros do Robo

    #region Cabeca

    public enum RotacaoCabeca
    {
        [Description("Rotação -90o")]
        Menos90Graus = 1,

        [Description("Rotação -45o")]
        Menos45Graus = 2,

        [Description("Em Repouso")]
        EmRepouso = 3,

        [Description("Rotação 45o")]
        Mais45Graus = 4,

        [Description("Rotação 90o")]
        Mais90Graus = 5
    }

    public enum InclinacaoCabeca
    {
        [Description("Para Cima")]
        ParaCima = 1,

        [Description("Em Repouso")]
        EmRepouso = 2,

        [Description("Para Baixo")]
        ParaBaixo = 3
    }

    #endregion Cabeca

    #region Bracos

    public enum BracoLado
    {
        [Description("Direito")]
        Direito = 1,

        [Description("Esquerdo")]
        Esquerdo = 2
    }

    public enum PosicaoCotovelo
    {
        [Description("Em Repouso")]
        EmRepouso = 1,

        [Description("Levemente Contraído")]
        LevementeContraido = 2,

        [Description("Contraído")]
        Contraido = 3,

        [Description("Fortemente Contraído")]
        FortementeContraido = 4
    }

    public enum RotacaoPulso
    {
        [Description("Rotação para -90o")]
        Menos90Graus = 1,

        [Description("Rotação para -45o")]
        Menos45Graus = 2,

        [Description("Em Repouso")]
        EmRepouso = 3,

        [Description("Rotação para 45o")]
        Mais45Graus = 4,

        [Description("Rotação para 90o")]
        Mais90Graus = 5,

        [Description("Rotação para 135o")]
        Mais135Graus = 6,

        [Description("Rotacao para 180o")]
        Mais180Graus = 7
    }

    #endregion Bracos
}
