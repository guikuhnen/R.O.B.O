using API.ROBO.Models;
using System.ComponentModel.DataAnnotations;

namespace API.ROBO.DTOs
{
    public class BracoDTO
    {
        [Required(ErrorMessage = "O valor da posição do cotovelo é obrigatório.")]
        public PosicaoCotovelo Cotovelo { get; set; }
        public string CotoveloDesc { get; set; }

        [Required(ErrorMessage = "O valor da rotação do pulso é obrigatório.")]
        public RotacaoPulso Pulso { get; set; }
        public string PulsoDesc { get; set; }

        public BracoDTO() { }
    }
}
