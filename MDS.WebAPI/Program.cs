using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// builder.Services.ConfigureHttpJsonOptions(options => {
// options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
// });

var app = builder.Build();

var paginasGroup = app.MapGroup("/registros");

// app.MapGet("/", () => "Hello World!");

app.MapGet("/motivacional", () => "Aqui contém uma frase motivacional, para lhe inspirar a continuar fracassando!");

//End-point para listar todos os registros do MDS
paginasGroup.MapGet("/", () => {
    List<Pagina> paginas = new DiarioServicos().ListarFolhas();
    return paginas;
});
app.Run();
