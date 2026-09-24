using MDS.Business;
using MDS.Data;

public class DiarioServicos
{
    DiarioDAO diarioDAO = new DiarioDAO();
    public void InserirFolha(Pagina pagina)
    {
        diarioDAO.InserirFolha(pagina);
        
    }
    public List<Pagina> ListarFolhas()
    {
        try
        {
            return diarioDAO.ListarFolhas();
        }
        catch (System.Exception e)
        {
            Console.WriteLine($"§| {e.Message}");
            throw;
        }
    }
    public void EditarFolha(Pagina pagina)
    {
        diarioDAO.EditarFolha(pagina);
    }
    public void RemoverFolha(Pagina pagina)
    {
        diarioDAO.RemoverFolha(pagina);
    }
}