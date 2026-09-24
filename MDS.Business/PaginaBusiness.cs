using System.Data;
using System.Net;
using System.Security.Cryptography.X509Certificates;
namespace MDS.Business;
public class PaginaBusiness 
{
    // um método bool para cada regra de negócio
    public bool TituloFoiInformado(Pagina pagina)
    {
        // Implementar dentro de cada método um try/catch
        // try se verdadeiro
        // catch se falso, lançar uma exceção(throw new)
        try
        {
            if (pagina is not null)
            {
                return true;
            }
            return false;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw new NoNullAllowedException();
        }
        
    }
}
