using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

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
paginasGroup.MapPost("/", ([FromBody] Pagina pagina) =>{
    new DiarioServicos().InserirFolha(pagina);
    return "Registro inserido com sucesso!";
});
paginasGroup.MapPut("/", ([FromBody] Pagina pagina) =>{
    new DiarioServicos().EditarFolha(pagina);
    return "Registro editado com sucesso!";
});
paginasGroup.MapDelete("/", ([FromBody] Pagina pagina) =>{
    new DiarioServicos().RemoverFolha(pagina);
    return "Registro deletado com sucesso!";
});
app.Run();
