using System.Data;
using Dapper;
using estacionamento.Models;
using Microsoft.AspNetCore.Mvc;

namespace estacionamento.Controllers;

public class ValorMinutoController : Controller
{

    private readonly IDbConnection _connection;

    public ValorMinutoController (IDbConnection connection)
    {
        _connection = connection;
    }


    [Route("/valores")]
    public IActionResult Index()
    {
        var valores = _connection.Query<ValorCobrado>("SELECT * FROM valores"); 
        return View(valores);
    }

    [HttpGet("/novo")]
    public IActionResult Novo()
    {
        return View();
    }

    [HttpPost("/criar")]
    public IActionResult Criar([FromForm] ValorCobrado valorCobrado)
    {
        string sql = "INSERT INTO valores (Minuto, Valor) VALUES (@Minuto, @Valor);";
        
            _connection.Open();
            _connection.Execute(sql, new { valorCobrado.Minuto, valorCobrado.Valor });
        

        // Redireciona para a página principal ou lista de valores
        return RedirectToAction("Index");
    }

    [HttpPost("/{id}/apagar")]
    public IActionResult Apagar([FromRoute] int Id)
    {
        string sql = "Delete FROM valores WHERE Id=@Id;";

        _connection.Open();
        _connection.Execute(sql, new ValorCobrado { Id = Id});


        // Redireciona para a página principal ou lista de valores
        return RedirectToAction("Index");
    }


    [HttpGet("/{id}/editar")]
    public IActionResult Editar([FromRoute] int Id)
    {
        var valor = _connection.Query<ValorCobrado>("SELECT * FROM valores WHERE Id=@Id", new ValorCobrado { Id = Id }).FirstOrDefault();
        return View(valor);
    }

    [HttpPost("/{id}/alterar")]
    public IActionResult Alterar([FromRoute] int Id, [FromForm] ValorCobrado valorCobrado)
    {
        string sql = "UPDATE valores SET Minuto = @Minuto, Valor = @Valor WHERE Id = @Id;";

        _connection.Open();
        _ = _connection.Execute(sql, new { Id, valorCobrado.Minuto, valorCobrado.Valor });


        // Redireciona para a página principal ou lista de valores
        return Redirect("/valores");
    }
}
