using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using SistemaFinanceiroUGB2022.Models;


namespace SistemaFinanceiroUGB2022.Controllers
{
    public class InstituicaoController : Controller
    {
        public static IList<Instituicao> instituicoes = new List<Instituicao>()
        {
            new Instituicao()

            {
                InstitucaoId = 1,
                Nome = "Hogwarts",
                Endereco = "Escola",
            },

            new Instituicao()
            {
                InstitucaoId = 2,
                Nome = "Mansao X",
                Endereco = "Nova York",
            }
        };

        public IActionResult Index()
        {

            return View(instituicoes);

        }
        public IActionResult Create()
        {

            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Instituicao instituicao)
        {
            instituicao.InstitucaoId = instituicoes.Select(i => i.InstitucaoId).Max() + 1;

            instituicoes.Add(instituicao);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(long id)
        {
            return View(instituicoes.Where(i => i.InstitucaoId == id).First());
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Instituicao instituicao)
        {

            instituicoes.Remove(instituicoes.Where(i => i.InstitucaoId == instituicao.InstitucaoId).First());
    
            instituicoes.Add(instituicao);
            return RedirectToAction("Index");

        }
    }
}




