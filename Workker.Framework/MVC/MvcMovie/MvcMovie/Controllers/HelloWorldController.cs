using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/

        public ActionResult Index()
        {
            //return "This is my <i>DEFAULT</i> action.";
            return View();
        }

        public ActionResult Welcome(String name, int numTimes = 1)
        {
            ViewBag.Message = "Rélôu " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }

        public String About()
        {
            return "About our lovely gambiarra.";
        }

        public String TesteBoladao(string nome, int numero)
        {
            return "Teste boladão de nome: " + nome + " e de número: " + numero;
        }
    }
}
