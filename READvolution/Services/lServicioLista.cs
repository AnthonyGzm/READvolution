using Microsoft.AspNetCore.Mvc.Rendering;

namespace READvolution.Services
{
    public interface lServicioLista
    {
        Task<IEnumerable<SelectListItem>> GetListaAutores();
        Task<IEnumerable<SelectListItem>> GetListaCategoria();

    }
}
