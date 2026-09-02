using MDS.Data;

public class DiarioServicos
{
    DiarioDAO diarioDAO = new DiarioDAO();
    public void InserirFolha()
    {
        Pagina folha = new Pagina();
        Console.Write("§| Digite o título da página de hoje: \n§| ");
        folha.Titulo = Console.ReadLine();
        Console.WriteLine("§| ");
        Console.Write("§| Digite o conteúdo da sua página aqui: \n§| ");
        folha.Conteudo = Console.ReadLine();
        diarioDAO.InserirFolha(folha);


        Console.WriteLine("");
        Console.WriteLine("§| Página salva com sucesso!");
    }
    public void ListarFolhas()
    {
        Console.WriteLine("§| Lista das páginas do Diário:");
        try
        {
            diarioDAO.ListarFolhas();
        }
        catch (System.Exception e)
        {
            Console.WriteLine($"§| {e.Message}");
            throw;
        }
        
    }
    public void EditarFolha()
    {
        Pagina diario = new Pagina();
        Console.Write("§| Digite o ID da página que deseja editar: ");
        diario.Id = int.Parse(Console.ReadLine()!);
        diarioDAO.EditarFolha(diario);
    }
    public void RemoverFolha()
    {
        Pagina diario = new Pagina();
        Console.Write("§| Digite o ID da página que deseja rasgar: ");
        diario.Id = int.Parse(Console.ReadLine()!);
        diarioDAO.RemoverFolha(diario);
    }
}