using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicio11.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string Nome { get; set; }
        

        [BindProperty]
        [Required(ErrorMessage = "O sobrenome é obrigatório.")]
        public string Sobrenome { get; set; }

        public string Resultado { get; set; } = "";

        Func<string, string, string> FormataTexto;

        
        public string ConcatenarTexto(string nome, string sobrenome)
        {
            return nome + " " + sobrenome;
        }
        public string RemoverEspacoBranco(string nome, string sobrenome)
        {
            nome = nome.Replace(" ", "");
            sobrenome = sobrenome.Replace(" ", "");

            string texto = nome + " " + sobrenome;

            return texto;
        }

        public string TornarLetrasEmMaiúsculas(string nome, string sobrenome)
        {
            nome = nome.ToUpper();
            sobrenome = sobrenome.ToUpper();

            string texto = nome + " " + sobrenome;

            return texto;
        }
        

        public void OnGet()
        {

        }

        public void OnPost()
        {
            FormataTexto = ConcatenarTexto;
            FormataTexto += TornarLetrasEmMaiúsculas;
            FormataTexto += RemoverEspacoBranco;

            Resultado = FormataTexto(Nome, Sobrenome);
        }
    }
}
