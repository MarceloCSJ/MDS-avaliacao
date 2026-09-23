using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
namespace MDS.Data;

public class DiarioDAO
{
    private MDSContext conexao = new MDSContext();

    public void InserirFolha(Pagina pagina)
    {
        try
        {
            conexao.Paginas.Add(pagina);
            conexao.SaveChanges();
        }
        catch (System.Exception e)
        {
            Console.WriteLine(e.InnerException);
            throw;
        }
        
    }
    public List<Pagina> ListarFolhas()
    {
        //List<Pagina> lista = conexao.Paginas.ToList();

            return conexao.Paginas.ToList();
            //.AsNoTracking().Include(r => r.Usuario).ToList();

            // foreach (var r in lista)
            // {
            //     Console.WriteLine("§|_____________________________________");
            //     Console.WriteLine("§|");
            //     Console.WriteLine($"§| ID: {r.Id}");
            //     Console.WriteLine($"§| Título: {r.Titulo}");
            //     //Console.WriteLine($"§| Data: {r.DataPagina:dd/MM/yyyy}");
            //     Console.WriteLine($"§| Conteúdo: {r.Conteudo}");
            // }
            // Console.WriteLine($"§|_____________________________________");

            // if (lista.Count == 0)
            // {
            //     Console.WriteLine("§| Nenhum registro encontrado.");
            // }
            // return null!;
    }
    public void EditarFolha(Pagina pagina)
    {
        conexao.Paginas.Update(pagina);
        conexao.SaveChanges();
    }
    public void RemoverFolha(Pagina pagina)
    {
        conexao.Paginas.Remove(pagina);
        conexao.SaveChanges();
    }
}