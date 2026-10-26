using Exercicio12.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicio12.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public Event NovoEvento { get; set; } = new();
        Action<Event> CriarEvento;

        public void ReceberEvento(Event e)
        {
            Console.WriteLine(e.Titulo);
            Console.WriteLine(e.Data);
            Console.WriteLine(e.Local);
        }
        public void OnGet()
        {
           
        }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }

            CriarEvento = ReceberEvento;
            CriarEvento?.Invoke(NovoEvento);
        }
    }
}
