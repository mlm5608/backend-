using Microsoft.AspNetCore.Mvc;
using Projeto_Gamer.Infra;
using Projeto_Gamer.Models;

namespace Projeto_Gamer.Controllers
{
    [Route("[controller]")]
    public class EquipeController : Controller
    {
        private readonly ILogger<EquipeController> _logger;

        public EquipeController(ILogger<EquipeController> logger)
        {
            _logger = logger;
        }

        // Instancia do objeto da classe context : acessa o BD
        Context c = new Context();
        //             controller/action 
        [Route("Listar")] //http://localhost/Equipe/Listar
        public IActionResult Index()
        {
            // "mochila" que contém a lista das equipes, podemos usar essa "mochila" na view de equipe
            ViewBag.Equipe = c.Equipe.ToList();

            // retorna a view da equipe
            return View();
        }

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Equipe novaEquipe = new Equipe();

            novaEquipe.Nome = form["Nome"].ToString();
            novaEquipe.Imagem = form["Imagem"].ToString();
            
            // aqui começa a lógica do upload de imagem
            if (form.Files.Count < 0)
            {
                var file = form.Files[0];

                var folder = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/img/Equipes");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                var path = Path.Combine(folder, file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                novaEquipe.Imagem = file.FileName;
            }
            else
            {
                novaEquipe.Imagem = "padrao.png";
            }
            // fim da logica de upload
            
            c.Equipe.Add(novaEquipe);
            // c.Add(novaEquipe)
            // aqui começa a lógica do upload de imagem


            c.SaveChanges();

            return LocalRedirect("~/Equipe/Listar");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}