using API.ROBO.DTOs;
using API.ROBO.Models;

namespace API.ROBO.Services
{
    public class ControlaRoboService
    {
        public Robo ExecutarComandosRobo(RoboDTO comandosRobo)
        {
            Robo robo = new Robo();

            robo.Cabeca.Rotacao = comandosRobo.Cabeca.Rotacao;
            robo.Cabeca.Inclinacao = comandosRobo.Cabeca.Inclinacao;

            robo.BracoDireito.Cotovelo = comandosRobo.BracoDireito.Cotovelo;
            robo.BracoDireito.Pulso = comandosRobo.BracoDireito.Pulso;

            robo.BracoEsquerdo.Cotovelo = comandosRobo.BracoEsquerdo.Cotovelo;
            robo.BracoEsquerdo.Pulso = comandosRobo.BracoEsquerdo.Pulso;

            return robo;
        }

        public string ValidarComandosRobo(RoboDTO comandoAlterar, Robo comandoAtual)
        {
            var validar = ValidarRotacaoCabeca(comandoAlterar.Cabeca, comandoAtual.Cabeca);
            if (!string.IsNullOrEmpty(validar))
                return validar;

            validar = ValidarInclinacaoCabeca(comandoAlterar.Cabeca, comandoAtual.Cabeca);
            if (!string.IsNullOrEmpty(validar))
                return validar;

            validar = ValidarComandosBracoDireto(comandoAlterar.BracoDireito, comandoAtual.BracoDireito);
            if (!string.IsNullOrEmpty(validar))
                return validar;

            validar = ValidarComandosBracoEsquerdo(comandoAlterar.BracoEsquerdo, comandoAtual.BracoEsquerdo);
            if (!string.IsNullOrEmpty(validar))
                return validar;

            return string.Empty;
        }

        private string ValidarProgressaoComando(object value1, object value2, string comando)
        {
            // Verifica se a progressão de estados esta em ordem crescente ou decrescente
            if ((int)value1 != (int)value2 + 1 && (int)value1 != (int)value2 - 1)
                return string.Format("Não é possível alterar a '{0}' pois o valor informado não segue a sequencia de atualização correta.", comando);

            return string.Empty;
        }

        private string ValidarRotacaoCabeca(CabecaDTO comandoAlterar, Cabeca comandoAtual)
        {
            if (comandoAlterar.Rotacao != comandoAtual.Rotacao)
            {
                if ((int)comandoAlterar.Rotacao < 1 || (int)comandoAlterar.Rotacao > 5)
                    return "Para a 'Rotação da Cabeça' o valor informado é inválido. Informe um valor entre 1 e 5.";

                if (comandoAlterar.Inclinacao != InclinacaoCabeca.ParaBaixo)
                    return ValidarProgressaoComando(comandoAlterar.Rotacao, comandoAtual.Rotacao, "Rotação da Cabeça");
                else
                    return "'Rotação da Cabeça' não é permitida quando 'Inclinação da Cabeça' for 'Para Baixo'";
            }

            return string.Empty;
        }

        private string ValidarInclinacaoCabeca(CabecaDTO comandoAlterar, Cabeca comandoAtual)
        {
            if (comandoAlterar.Inclinacao != comandoAtual.Inclinacao)
            {
                if ((int)comandoAlterar.Inclinacao < 1 || (int)comandoAlterar.Inclinacao > 3)
                    return "Para a 'Inclinação da Cabeça' o valor informado é inválido. Informe um valor entre 1 e 3.";

                return ValidarProgressaoComando(comandoAlterar.Inclinacao, comandoAtual.Inclinacao, "Inclinação da Cabeça");
            }

            return string.Empty;
        }

        private string ValidarComandosBracoDireto(BracoDTO comandoAlterar, Braco comandoAtual)
        {
            if (comandoAlterar.Cotovelo != comandoAtual.Cotovelo)
            {
                // Cotovelo
                if ((int)comandoAlterar.Cotovelo < 1 || (int)comandoAlterar.Cotovelo > 4)
                    return "Para mover o 'Cotovelo Direito' o valor informado é inválido. Informe um valor entre 1 e 4.";

                var validar = ValidarProgressaoComando(comandoAlterar.Cotovelo, comandoAtual.Cotovelo, "Cotovelo Direito");
                if (!string.IsNullOrEmpty(validar))
                    return validar;
            }

            if (comandoAlterar.Pulso != comandoAtual.Pulso)
            {
                //Pulso
                if ((int)comandoAlterar.Pulso < 1 || (int)comandoAlterar.Pulso > 7)
                    return " Para o 'Pulso Direito o valor informado é inválido. Informe um valor entre 1 e 7.";

                if (comandoAlterar.Cotovelo == PosicaoCotovelo.FortementeContraido)
                    return ValidarProgressaoComando(comandoAlterar.Pulso, comandoAtual.Pulso, "Pulso Direito");
                else
                    return "'Rotação do Pulso Direito' não é permitida quando 'Cotovelo Direito' não estiver 'Fortemente Contraído'";
            }

            return string.Empty;
        }

        private string ValidarComandosBracoEsquerdo(BracoDTO comandoAlterar, Braco comandoAtual)
        {
            if (comandoAlterar.Cotovelo != comandoAtual.Cotovelo)
            {
                // Cotovelo
                if ((int)comandoAlterar.Cotovelo < 1 || (int)comandoAlterar.Cotovelo > 4)
                    return "Para mover o 'Cotovelo Esquerdo' o valor informado é inválido. Informe um valor entre 1 e 4.";

                var validar = ValidarProgressaoComando(comandoAlterar.Cotovelo, comandoAtual.Cotovelo, "Cotovelo Esquerdo");
                if (!string.IsNullOrEmpty(validar))
                    return validar;
            }

            if (comandoAlterar.Pulso != comandoAtual.Pulso)
            {
                //Pulso
                if ((int)comandoAlterar.Pulso < 1 || (int)comandoAlterar.Pulso > 7)
                    return " Para o 'Pulso Esquerdo o valor informado é inválido. Informe um valor entre 1 e 7.";

                if (comandoAlterar.Cotovelo == PosicaoCotovelo.FortementeContraido)
                    return ValidarProgressaoComando(comandoAlterar.Pulso, comandoAtual.Pulso, "Pulso Esquerdo");
                else
                    return "'Rotação do Pulso Esquerdo' não é permitida quando 'Cotovelo Esquerdo' não estiver 'Fortemente Contraído'";
            }

            return string.Empty;
        }
    }
}
