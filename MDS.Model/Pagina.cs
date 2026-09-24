using System.Dynamic;
public class Pagina
{
    public int Id {get; set;}
    public string? Titulo {get; set;}
    public DateTime DataPagina {get; set;} = DateTime.Now;
    public string? Conteudo {get; set;}
}