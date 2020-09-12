using API.ROBO.Models;
using API.ROBO.Utils;

namespace API.ROBO.DTOs
{
    public class RoboDTO
    {
        public CabecaDTO Cabeca { get; set; }
        public BracoDTO BracoDireito { get; set; }
        public BracoDTO BracoEsquerdo { get; set; }

        public RoboDTO() { }

        public RoboDTO(Robo robo)
        {
            #region Cabeca

            Cabeca = new CabecaDTO();

            Cabeca.Rotacao = robo.Cabeca.Rotacao;
            Cabeca.RotacaoDesc = EnumHelper.GetDescription(robo.Cabeca.Rotacao);

            Cabeca.Inclinacao = robo.Cabeca.Inclinacao;
            Cabeca.InclinacaoDesc = EnumHelper.GetDescription(robo.Cabeca.Inclinacao);

            #endregion Cabeca

            #region Bracos

            BracoDireito = new BracoDTO();

            BracoDireito.Cotovelo = robo.BracoDireito.Cotovelo;
            BracoDireito.CotoveloDesc = EnumHelper.GetDescription(robo.BracoDireito.Cotovelo);

            BracoDireito.Pulso = robo.BracoDireito.Pulso;
            BracoDireito.PulsoDesc = EnumHelper.GetDescription(robo.BracoDireito.Pulso);

            BracoEsquerdo = new BracoDTO();

            BracoEsquerdo.Cotovelo = robo.BracoEsquerdo.Cotovelo;
            BracoEsquerdo.CotoveloDesc = EnumHelper.GetDescription(robo.BracoEsquerdo.Cotovelo);

            BracoEsquerdo.Pulso = robo.BracoEsquerdo.Pulso;
            BracoEsquerdo.PulsoDesc = EnumHelper.GetDescription(robo.BracoEsquerdo.Pulso);

            #endregion Bracos
        }
    }
}
