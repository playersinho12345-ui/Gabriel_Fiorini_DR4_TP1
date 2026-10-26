using System.ComponentModel.DataAnnotations;

namespace Exercicio12.Models
{
    public class Event
    {
        [Required(ErrorMessage = "O título é obrigatório.")]
        public string Titulo { get; set; } = string.Empty;

        [Required(ErrorMessage = "A data é obrigatória.")]
        public DateTime? Data { get; set; }

        [Required(ErrorMessage = "O local é obrigatório.")]
        public string Local { get; set; } = string.Empty;
    }
}
