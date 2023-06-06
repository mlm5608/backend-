using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Projeto_Gamer.Infra;
using Projeto_Gamer.Models;

namespace Projeto_Gamer.Controllers
{
    [Route("[controller]")]
    public class JogadorController : Controller
    {
        private readonly ILogger<JogadorController> _logger;

        public JogadorController(ILogger<JogadorController> logger)
        {
            _logger = logger;
        }

        Context c = new Context();

        [Route("Listar")]
        public IActionResult Index()
        {
            ViewBag.Jogador = c.Jogador.ToList();
            ViewBag.Equipe = c.Equipe.ToList();
            
            return View();
        }

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Jogador novoJogador = new Jogador();

            novoJogador.Nome = form["Nome"].ToString();
            novoJogador.Email = form["Email"].ToString();
            novoJogador.Senha = form["Senha"].ToString();
            novoJogador.IdEquipe = int.Parse(form["Equipe".ToString()]);

            c.Jogador.Add(novoJogador);
            c.SaveChanges();
            return LocalRedirect ("~/Jogador/Listar");
        }

        [Route("Excluir/{id}")]
        public IActionResult excluir(int id)
        {
            Jogador j = c.Jogador.First(j => j.IdJogador == id);

            c.Jogador.Remove(j);
            c.SaveChanges();
            return LocalRedirect("~/Jogador/Listar");
        }

        [Route("Editar/{id}")]
        public IActionResult Editar(int id)
        {
            Jogador p = c.Jogador.First(jg => jg.IdJogador == id);

            ViewBag.Jogador = p;
            ViewBag.Equipe = c.Equipe.ToList();
            return View("Edit");
        }

        [Route("Atualizar")]
        public IActionResult Atualizar(IFormCollection form, Jogador n)
        {
            Jogador novoJogador = new Jogador();

            novoJogador.Nome = n.Nome;
            novoJogador.Email = n.Email;
            novoJogador.Senha = n.Senha;
            novoJogador.Equipe = n.Equipe;

            Jogador jogador = c.Jogador.First(x => x.IdJogador == n.IdJogador);

            jogador.Nome = novoJogador.Nome;
            jogador.Email = novoJogador.Email;
            jogador.Senha = novoJogador.Senha;
            jogador.IdEquipe = n.IdEquipe;
            
            c.Jogador.Update(jogador);
            c.SaveChanges();
            return LocalRedirect("~/Jogador/Listar");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}