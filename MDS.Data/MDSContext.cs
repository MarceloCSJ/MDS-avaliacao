using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cms;

namespace MDS.Data;

public class MDSContext : DbContext
{
    // Será criado a tabela Diarios do tipo DbSet
    public DbSet<Pagina> Paginas {get; set;}
    // Esse será o primeiro atributo da tabela Diarios
    private readonly string stringConexao = "Server=localhost;Port=3306;Database=MDS;Uid=root;Pwd=S&nac2024;";

    // Método de conexão através do Entity Framework
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(stringConexao, 
            ServerVersion.AutoDetect(stringConexao));
    }
}
