using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProdutoApp.Data;
using ProdutoApp.Models;
using System.Threading.Tasks;

namespace ProdutoApp.Pages.Produtos
{
    public class DetailsModel : PageModel
    {
        private readonly AppDbContext _context;

        public DetailsModel(AppDbContext context)
        {
            _context = context;
        }

        public Produto Produto { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Produto = await _context.Produtos.FindAsync(id);

            if (Produto == null)
            {
                return RedirectToPage("Index");
            }

            return Page();
        }
    }
}
