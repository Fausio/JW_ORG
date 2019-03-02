using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PROGRAMA_DE_VIDA_E_MINISTERIO_MACHAVA_15_PT.AppContext;
using PROGRAMA_DE_VIDA_E_MINISTERIO_MACHAVA_15_PT.Models;

namespace PROGRAMA_DE_VIDA_E_MINISTERIO_MACHAVA_15_PT.DAO
{
    public class DesignacaoDAO
    {
        MACHAVA15Context conetxto = new MACHAVA15Context();


        //findDesignacaoDAO
        public Designacao FindDesignacao(int ID)
        {
            return conetxto.designacaos.Find(ID);
        }

        //listaDesignacao

        public IList<Designacao> ListaDesignacao()
        {
            var busca = from D in conetxto.designacaos
                        orderby D.Descricao
                        select D;

            return busca.ToList();
        }

        // Gravar designacao 
        public void AddDesignacao(Designacao designacao)
        {
            conetxto.designacaos.Add(designacao);
            conetxto.SaveChanges();
        }

        //remover Desgnacao
        public void Removedesignacao(int Id)
        {
            conetxto.designacaos.Remove(this.FindDesignacao(Id));
            conetxto.SaveChanges();
        }
    }
}