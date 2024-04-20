namespace READvolution.Services
{
    public interface lServicioImagen
    {
        Task<string> SubirImagen(Stream archivo, string nombre);
    }
}
