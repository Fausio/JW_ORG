using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PROGRAMA_DE_VIDA_E_MINISTERIO_MACHAVA_15_PT.DAO;
using ClosedXML.Excel;



namespace PROGRAMA_DE_VIDA_E_MINISTERIO_MACHAVA_15_PT.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var PessoaDao = new PessoaDAO();
            var Lista = PessoaDao.ListaPessoa();
            ViewBag.LIsta = Lista;

            DesignacaoDAO designacaoDAO = new DesignacaoDAO();
            CongregacaoDAO congregacaoDAO = new CongregacaoDAO();

            ViewBag.ListaDesignacao = designacaoDAO.ListaDesignacao();
            ViewBag.listaDeCongregacao = congregacaoDAO.ListaDeCongregacao();
            return View();

        }
        [HttpPost]
        public ActionResult Imput(string C1, DateTime date, string livro, string nome1, string PresidenteDaReuniao, string Orador1, string discurso1, string discurso1Pessoa, string BuscadeperolasPessoa, string LeituraDaBibliaPessoa, string Designacao1, string Estudante1, string Ajudante1, string Designacao2, string Estudante2, string Ajudante2, string Designacao3, string Estudante3, string Ajudante3, string Designacao4, string Estudante4, string Ajudante4, string Designacao5, string Estudante5, string Ajudante5,string Cantico2, string tema2,string tema2Pessoa, string Dirigente, string Leitor,string Cantico3,string Oracao3)
        {

            var Wb = new XLWorkbook();                              /*criar um WorkBook*/
            var Ws = Wb.Worksheets.Add("Planilha 1");               /* Adicionar uma planinha */


            //titulo do relatorio                                                       Data                                              Litura da Biblia
           

            var range1 = Ws.Range("A1:D1"); range1.Merge().Style.Font.FontSize = 22;               
            var range2 = Ws.Range("A2:D2"); range2.Merge().Style.Font.SetBold().Font.FontSize = 24;

            range1.Value = "MACHAVA 15 PORTUGUESA";                     range1.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            range2.Value = "Programação da reunião de semana";          range2.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            Ws.Cell("B3").Value = Convert.ToString(date) +" | LEITURA SEMANAL DA BÍBLIA"; Ws.Cell("B3").Style.Font.SetBold().Font.FontSize = 14;            Ws.Cell("L1").Value = livro;                             /* Adiciona um titulo na planilha, na celula B2*/
                                                             /*  Faz o merge das celulas onde tem o titulo da   planilha*/

            //FORMATACAO DE CELULAS C#
            Ws.Cell("C4").Style.Font.FontSize = 8;       Ws.Cell("C4").Style.Font.SetFontColor(XLColor.Blue);
            Ws.Cell("C21").Style.Font.FontSize= 8;       Ws.Cell("C21").Style.Font.SetFontColor(XLColor.Blue);
            Ws.Cell("C11").Style.Font.FontSize = 8;      Ws.Cell("C11").Style.Font.SetFontColor(XLColor.DarkGray);
            Ws.Cell("C12").Style.Font.FontSize = 8;      Ws.Cell("C12").Style.Font.SetFontColor(XLColor.DarkGray);
            Ws.Cell("C13").Style.Font.FontSize = 8;      Ws.Cell("C13").Style.Font.SetFontColor(XLColor.DarkGray);
            Ws.Cell("C14").Style.Font.FontSize = 8;      Ws.Cell("C14").Style.Font.SetFontColor(XLColor.DarkGray);
            Ws.Cell("C15").Style.Font.FontSize = 8;      Ws.Cell("C15").Style.Font.SetFontColor(XLColor.DarkGray);
            Ws.Cell("C9").Style.Font.FontSize  = 8;      Ws.Cell("C9").Style.Font.SetFontColor(XLColor.DarkGray);
            Ws.Cell("C19").Style.Font.FontSize = 8;      Ws.Cell("C19").Style.Font.SetFontColor(XLColor.DarkGray);
            Ws.Cell("C5").Style.Font.FontSize = 8;       Ws.Cell("C5").Style.Font.SetFontColor(XLColor.DarkGray);

                                                         range1.Style.Font.SetFontColor(XLColor.White);
                                                         range2.Style.Font.SetFontColor(XLColor.White);

            Ws.Cell("A7").Value="0:00";
            Ws.Cell("A8").Value="0:00";
            Ws.Cell("A9").Value="0:00"; 
            Ws.Cell("A11").Value="0:00";
            Ws.Cell("A12").Value="0:00";
            Ws.Cell("A13").Value="0:00";
            Ws.Cell("A14").Value="0:00";
            Ws.Cell("A15").Value="0:00";
            Ws.Cell("A17").Value="0:00";
            Ws.Cell("A18").Value="0:00";
            Ws.Cell("A19").Value="0:00";
            Ws.Cell("A20").Value="0:00";
            Ws.Cell("A21").Value="0:00";

            //PINTAMDO CELULAS A
            Ws.Cell("A6").Style.Fill.SetBackgroundColor(XLColor.DarkGray);
            Ws.Cell("A10").Style.Fill.SetBackgroundColor(XLColor.DarkGoldenrod);
            Ws.Cell("A16").Style.Fill.SetBackgroundColor(XLColor.DarkRed);

            range1.Style.Fill.SetBackgroundColor(XLColor.DarkGray);
            range2.Style.Fill.SetBackgroundColor(XLColor.DarkPastelPurple);

            //FORMATACAO DE CELULAS D#
            Ws.Cell("D4").Style.Font.SetFontColor(XLColor.Blue);
            Ws.Cell("D21").Style.Font.SetFontColor(XLColor.Blue);

            // 0:00 NAS CELUNAS A

            // Cabeçalhos do Relatorio                                                                             numero do cantico                               MUDAR A COR DA FONTE PARA AZUL 
            Ws.Cell("B4").Value = "Cântico : "+C1;                   Ws.Cell("C4").Value ="Oração";           Ws.Cell("D4").Value =Orador1;               
            Ws.Cell("B5").Value = "Comentários Introdutório (3 min.)";            /*|*/ Ws.Cell("C5").Value = "Presidente: ";          Ws.Cell("D5").Value =PresidenteDaReuniao;   /* Presidente Da Reuniao*/
            
            //TESOURO DA PALAVRA DE DEUS                                                            MUDAR A COR DA FONTE PARA BRANCO                                MUDA A COR DA CELULA, COR DE FUNDO PARA AMARELO                         ALINHAR O TEXTO NO CENTRO DA CELULA
            Ws.Cell("B6").Value = "TESOURO DA PALAVRA DE DEUS";                         Ws.Cell("B6").Style.Font.SetFontColor(XLColor.White);                Ws.Cell("B6").Style.Fill.SetBackgroundColor(XLColor.DarkGray);       Ws.Cell("B6").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            Ws.Cell("B7").Value = "● " + discurso1;                                      /*|*/ Ws.Cell("D7").Value = discurso1Pessoa;
            Ws.Cell("B8").Value = "● Em Busca de Pérolas Espirituais  (8 min.)";    /*|*/ Ws.Cell("D8").Value = BuscadeperolasPessoa;
            Ws.Cell("B9").Value = "● Leitura da Bíblia: (4 min. ou menos)";          /*|*/ Ws.Cell("C9").Value = "Estudante"; Ws.Cell("D9").Value = LeituraDaBibliaPessoa;

            // EMPENHE-SE NO MINISTÉRIO                                                                         MUDAR A COR DA FONTE PARA BRANCO                        MUDA A COR DA CELULA, COR DE FUNDO PARA AMARELO                                          ALINHAR O TEXTO NO CENTRO DA CELULA
            Ws.Cell("B10").Value = "EMPENHE-SE NO MINISTÉRIO";                                            Ws.Cell("B10").Style.Fill.SetBackgroundColor(XLColor.DarkGoldenrod);              Ws.Cell("B10").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            Ws.Cell("B11").Value ="● " + Designacao1;                            Ws.Cell("C11").Value = "Estudante / Ajudante :";          Ws.Cell("D11").Value =  Estudante1 + " / " + Ajudante1;
            Ws.Cell("B12").Value ="● " + Designacao2;                            Ws.Cell("C12").Value = "Estudante / Ajudante :";          Ws.Cell("D12").Value =  Estudante2 + " / " + Ajudante2;
            Ws.Cell("B13").Value ="● " + Designacao3;                            Ws.Cell("C13").Value = "Estudante / Ajudante :";          Ws.Cell("D13").Value =  Estudante3 + " / " + Ajudante3;
            Ws.Cell("B14").Value ="● " + Designacao4;                            Ws.Cell("C14").Value = "Estudante / Ajudante :";          Ws.Cell("D14").Value =  Estudante4 + " / " + Ajudante4;
            Ws.Cell("B15").Value ="● " + Designacao5;                            Ws.Cell("D15").Value = "Estudante / Ajudante :";          Ws.Cell("D15").Value =  Estudante5 + " / " + Ajudante5;

            // VIVER COMO CRISTÃOS                                                                          MUDAR A COR DA FONTE PARA BRANCO                           MUDA A COR DA CELULA, COR DE FUNDO VERMELHO                                                                   ALINHAR O TEXTO NO CENTRO DA CELULA
            Ws.Cell("B16").Value = "VIVER COMO CRISTÃOS";                            /*|*/Ws.Cell("B16").Style.Font.SetFontColor(XLColor.White);               Ws.Cell("B16").Style.Fill.SetBackgroundColor(XLColor.DarkRed);                              Ws.Cell("B16").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;


            Ws.Cell("B17").Value = "● Cântico : " + Convert.ToString(Cantico2);
            Ws.Cell("B18").Value = "● " + tema2;                                             /*|*/ Ws.Cell("D18").Value = tema2Pessoa;
            Ws.Cell("B19").Value = "● Estudo Bíblico de Congregação: (30 min.)";         /*|*/ Ws.Cell("C19").Value = "Dirigente/Leitor: ";                        Ws.Cell("D19").Value = Dirigente + " / " + Leitor;
            Ws.Cell("B20").Value = "● Recapitulação e Antivião da Reunião da Proxima Semana (3 min.)";                                            
            Ws.Cell("B21").Value = "● Cântico: " + Convert.ToString(Cantico3);            /*|*/ Ws.Cell("C21").Value = "Oração"; Ws.Cell("D21").Value = Oracao3;        
            ////Ajusto a numeracao da linha 
            //Linha--;

            ////cria a formatacao do tipo Money parao nosso sbtotal
            //Ws.Range("I4:I" + Linha.ToString()).Style.NumberFormat.Format = "M$ #,#,##00";

            ////cria uma tabela para ativar os filtros
            //Range = Ws.Range("B3:I" + Linha.ToString());

            //ajusta o tamanho da coluna com o conteudo da coluna
            Ws.Columns("1-2").AdjustToContents();
            Ws.Columns("3").AdjustToContents();
            Ws.Columns("4").AdjustToContents();
            //Grava o arquivo no HD
            string GetPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments );
            string FullPath = GetPath + "\\planilha.xlsx";
            Wb.SaveAs(FullPath);
            Wb.Dispose();  //limpar a memoria do Exce

            ViewBag.path = FullPath;



            return View();
        }
       public ActionResult OpenPath()
        {
            string GetPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string FullPath = GetPath + "\\planilha.xlsx";

            System.Diagnostics.Process.Start(FullPath);

            return RedirectToAction("Index", "Home");
        }
    }
}