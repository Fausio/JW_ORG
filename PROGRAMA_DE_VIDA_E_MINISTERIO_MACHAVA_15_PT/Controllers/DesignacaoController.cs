using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PROGRAMA_DE_VIDA_E_MINISTERIO_MACHAVA_15_PT.DAO;
using PROGRAMA_DE_VIDA_E_MINISTERIO_MACHAVA_15_PT.Models;

namespace PROGRAMA_DE_VIDA_E_MINISTERIO_MACHAVA_15_PT.Controllers
{
    public class DesignacaoController : Controller
    {
        // GET: Designacao
        public ActionResult Index()
        {
            DesignacaoDAO desgincao = new DesignacaoDAO();
            var lista = desgincao.ListaDesignacao().ToList();

            ViewBag.ListaDesgincao = lista;

            return View();
        }

        public ActionResult AddView()
        {
            return View();
        }


        public ActionResult AddNew(Designacao designacao)
        {
            var desgincaoDao = new DesignacaoDAO();
            desgincaoDao.AddDesignacao(designacao);
            return RedirectToAction("Index", "Designacao");
        }


        public ActionResult Remover(int Id)
        {
            var desgincaoDao = new DesignacaoDAO();
            desgincaoDao.Removedesignacao(desgincaoDao.FindDesignacao(Id).DesignacaoID);

            return RedirectToAction("Index", "Designacao");
        }
    }
}