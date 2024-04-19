using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using READvolution.Models;

namespace READvolution.Services
{
    public class ServicioLista : lServicioLista
    {

        private readonly READvolutionContext _context;
        public async Task<IEnumerable<SelectListItem>> GetListaAutores()
        {
            List<SelectListItem> list = await _context.Autores.Select(x => new SelectListItem
            {
                Text = x.Nombre,
                Value = $"{x.Id}"
            })
                .OrderBy(x => x.Text)
                .ToListAsync();

            list.Insert(0, new SelectListItem
            {
                Text = "[Seleccione Un Autor...]",
                Value = "0"
            });
            return list;
        }

        public async Task<IEnumerable<SelectListItem>> GetListaCategoria()
        {
            List<SelectListItem> list = await _context.Categorias.Select(x => new SelectListItem
            {
                Text = x.Nombre,
                Value = $"{x.Id}"
            })
                .OrderBy(x => x.Text)
                .ToListAsync();

            list.Insert(0, new SelectListItem
            {
                Text = "[Seleccione Una Categoria...]",
                Value = "0"
            });
            return list;
        }
    }
}
