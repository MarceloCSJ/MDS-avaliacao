using MDS.Business;

namespace MDS.Service;

public class RegistroService
{
    public void TituloNaoEstaVazio(Pagina pagina)
    {
        if (string.IsNullOrWhiteSpace(pagina.Titulo))
        {
            throw new ArgumentException("O título não pode estar vazio.");
        }
    }
}