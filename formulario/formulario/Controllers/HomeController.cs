using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace formulario.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //Isto é uma função
        public ActionResult Index()
        {

            //viewBag para guardar a resposta
            ViewBag.msg = "";

            return View();
        }
        [HttpPost]
        public ActionResult Index(string nome, int? idade)
        {
            ///precisamos de validar os dados introduzidos pelo utilizador
            ///1ª questão: o 'nome' é um nome?
            ///2ª questão: a idade está dentro dos parâmetros pretendidos?[0;130]

            string mensagem = "";

            //validar a idade
            if (idade >= 0 && idade <= 120)
            {
                //criar a mensagem da resposta
                mensagem = "Você chama-se " + nome + " e tem " + idade + " anos.";
            }
            else
            {
                //mensagem alternativa
                mensagem = "Deve especificar uma idade válida!\n" +
                    "A idade deve ser maior que 0 e menor que 120 anos.";
            }

            //criar o 'contentor' que levará a mensagem para a View
            ViewBag.msg = mensagem;
            //Invoca a view
            return View();
        }
    }
}