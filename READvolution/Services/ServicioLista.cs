using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using READvolution.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace READvolution.Services
{
    public class ServicioLista : lServicioLista
    {
        private readonly READvolutionContext _context;

        public ServicioLista(READvolutionContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SelectListItem>> GetListaAutores()
        {
            List<SelectListItem> list = new List<SelectListItem>();

            if (_context != null && _context.Autores != null)
            {
                list = await _context.Autores
                    .Select(x => new SelectListItem
                    {
                        Text = x.Nombre,
                        Value = x.Id.ToString()
                    })
                    .OrderBy(x => x.Text)
                    .ToListAsync();
            }

            list.Insert(0, new SelectListItem
            {
                Text = "[Seleccione Un Autor...]",
                Value = "0"
            });

            return list;
        }

        public async Task<IEnumerable<SelectListItem>> GetListaCategorias()
        {
            List<SelectListItem> list = new List<SelectListItem>();

            if (_context != null && _context.Categorias != null)
            {
                list = await _context.Categorias
                    .Select(x => new SelectListItem
                    {
                        Text = x.Nombre,
                        Value = x.Id.ToString()
                    })
                    .OrderBy(x => x.Text)
                    .ToListAsync();
            }

            list.Insert(0, new SelectListItem
            {
                Text = "[Seleccione una categoría...]",
                Value = "0"
            });

            return list;
        }
    }
}

