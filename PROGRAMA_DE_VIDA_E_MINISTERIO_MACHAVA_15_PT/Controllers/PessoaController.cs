using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PROGRAMA_DE_VIDA_E_MINISTERIO_MACHAVA_15_PT.DAO;
using PROGRAMA_DE_VIDA_E_MINISTERIO_MACHAVA_15_PT.Models;


namespace PROGRAMA_DE_VIDA_E_MINISTERIO_MACHAVA_15_PT.Controllers
{
    public class PessoaController : Controller
    {
        // GET: Pessoa
        [Route("ListaDePessoas", Name = "PList")]
        public ActionResult Index()
        {
            var PessoaDao = new PessoaDAO();
            ViewBag.LIstaPessoa = PessoaDao.ListaPessoa();

            return View();
        }

        [Route("FormAdicionaPessoas", Name = "PAdd")]
        public ActionResult Addview()
        {
            EstadosDao estadosDao = new EstadosDao();
            ViewBag.EstadoLista = estadosDao.EstadoLista();
            return View();
        }

       [HttpPost]
        public ActionResult SavaOne(Pessoa P)
        {
            PessoaDAO pessoaDAO = new PessoaDAO();
            pessoaDAO.ADDPessoa(P);

            return RedirectToRoute("PList");
        }

        [Route("DeletePessoas/{Id}", Name = "PDelete")]
        public ActionResult Delete(int Id)
        {
            PessoaDAO pessoaDAO = new PessoaDAO();
            pessoaDAO.RemovePessoa(pessoaDAO.FindPessoa(Id).PessoaID);


            return RedirectToAction("Index", "Pessoa");
        }
    }
}