using API.ROBO.Models;
using System.ComponentModel.DataAnnotations;

namespace API.ROBO.DTOs
{
    public class CabecaDTO
    {
        [Required(ErrorMessage = "O valor da rotação da cabeça é obrigatório.")]
        public RotacaoCabeca Rotacao { get; set; }
        public string RotacaoDesc { get; set; }

        [Required(ErrorMessage = "O valor da inclinação da cabeça é obrigatório.")]
        public InclinacaoCabeca Inclinacao { get; set; }
        public string InclinacaoDesc { get; set; }

        public CabecaDTO() { }
    }
}
