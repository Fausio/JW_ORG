
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PROGRAMA_DE_VIDA_E_MINISTERIO_MACHAVA_15_PT.Models;
using PROGRAMA_DE_VIDA_E_MINISTERIO_MACHAVA_15_PT.AppContext;

namespace PROGRAMA_DE_VIDA_E_MINISTERIO_MACHAVA_15_PT.Controllers
{
    public class CongregacaoController : Controller
    {
        // GET: Congregação
        public ActionResult Index()
        {
            MACHAVA15Context C = new MACHAVA15Context();
            List<Congregacao> Lista = C.Congregacao.ToList();

            ViewBag.Listac = Lista;

            return View();
        }


        public ActionResult Remover(int Id)
        {
            MACHAVA15Context C = new MACHAVA15Context();
            C.Congregacao.Remove(C.Congregacao.Find(Id));
            C.SaveChanges();
            return RedirectToAction("Index", "Congregacao");
        }

    }
}