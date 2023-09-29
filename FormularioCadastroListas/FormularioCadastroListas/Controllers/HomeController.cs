using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FormularioCadastroListas.Models;
using FormularioCadastroListas.Models.DAO;
using FormularioCadastroListas.Models.POJO;

namespace FormularioCadastroListas.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult GridUsuarios()
    {
        ViewBag.listaUsuarios = UsuariosListaDao.Instance.Lista;
        return View();
    }

    [HttpGet]
    public IActionResult Usuario()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Usuario(IFormCollection form)
    {
        string nome = form["nome"];
        string email = form["email"];
        string telefone = form["telefone"];
        string sexo = form["sexo"];
        string dataNascimento = form["dataNascimento"];

        List<string> dataList = new List<string>()
        {nome, email, telefone, sexo, dataNascimento};

        bool validData = true;


        foreach (string item in dataList)
        {
            validData = validData && !string.IsNullOrEmpty(item);
        }

        if (!validData)
        {
            ViewBag.resultado = "Preencha os dados";
            ViewData["resultado"] = "Preencha os dados";
            TempData["resultado"] = "Preencha os dados";

        }
        else
        {
            UsuariosListaDao UsuariosListaDao = UsuariosListaDao.Instance;
            List<Usuario> listaUsuarios = UsuariosListaDao.InserirUsuario(
                nome, email, telefone, sexo, dataNascimento);
            ViewBag.resultado = listaUsuarios.Last();
            ViewData["resultado"] = listaUsuarios.Last();
            ViewBag.IsPost = true;
        }

        ViewResult view = View();
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

