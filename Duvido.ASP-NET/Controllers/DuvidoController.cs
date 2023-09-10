using Duvido.ASP_NET.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Duvido.ASP_NET.Controllers
{
    public class DuvidoController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Anonimo()
        {
            string diretorioAvatares = Server.MapPath("~/Imagens/UsuarioAnonimo/Avatares");

            AvataresViewModel model = new AvataresViewModel();
            model.NomesAvatares = new List<string>();

            try
            {
                string[] arquivos = Directory.GetFiles(diretorioAvatares);

                foreach (string arquivo in arquivos)
                {
                    model.NomesAvatares.Add(Path.GetFileName(arquivo));
                }
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = "Ocorreu um erro ao listar os avatares: " + ex.Message;
                return View();
            }

            return View(model);
        }
    }
}