using MDS.Data;
using MDS.Business;

public class DiarioServicos
{
    DiarioDAO diarioDAO = new DiarioDAO();
    PaginaBusiness business = new PaginaBusiness();
    public void InserirFolha(Pagina pagina)
    {
        //Pagina folha = new Pagina();
        //Console.Write("§| Digite o título da página de hoje: \n§| ");
        //pagina.Titulo = Console.ReadLine();
        //business.TituloFoiInformado(pagina.Titulo!);
        //Console.WriteLine("§| ");
        //Console.Write("§| Digite o conteúdo da sua página aqui: \n§| ");
        //pagina.Conteudo = Console.ReadLine();
        diarioDAO.InserirFolha(pagina);


        //Console.WriteLine("§|");
        //Console.WriteLine("§| Página salva com sucesso!");
    }
    public List<Pagina> ListarFolhas()
    {
        Console.WriteLine("§| Lista das páginas do Diário:");
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
        // Pagina diario = new Pagina();
        // Console.Write("§| Digite o ID da página que deseja editar: ");
        // diario.Id = int.Parse(Console.ReadLine()!);
        diarioDAO.EditarFolha(pagina);
    }
    public void RemoverFolha(Pagina pagina)
    {
        // Pagina diario = new Pagina();
        // Console.Write("§| Digite o ID da página que deseja rasgar: ");
        // diario.Id = int.Parse(Console.ReadLine()!);
        diarioDAO.RemoverFolha(pagina);
    }
}