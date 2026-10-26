using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicio10.Pages
{
    public class AddProductModel : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string nome { get; set; }


        [BindProperty]
        [Required(ErrorMessage = "O preço é obrigatório.")]
        [Range(0.01, 999999, ErrorMessage = "O preço deve ser maior que zero.")]
        public decimal preco { get; set; }

        public bool ExibirResultado { get; set; } = false;

        public void OnGet()
        {
        }

        public void OnPost()
        {
            ExibirResultado = true;
        }
    }
}
