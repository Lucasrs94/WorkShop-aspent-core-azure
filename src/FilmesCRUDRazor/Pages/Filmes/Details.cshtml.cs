using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FilmesCRUDRazor.Models;

namespace FilmesCRUDRazor.Pages.Filmes
{
    public class DetailsModel : PageModel
    {
        private readonly FilmesCRUDRazor.Models.FilmeContxt _context;

        public DetailsModel(FilmesCRUDRazor.Models.FilmeContxt context)
        {
            _context = context;
        }

        public Filme Filme { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Filme = await _context.Filme.FirstOrDefaultAsync(m => m.FilmeId == id);

            if (Filme == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
