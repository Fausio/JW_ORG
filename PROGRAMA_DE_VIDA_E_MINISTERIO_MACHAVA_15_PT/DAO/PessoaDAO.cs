﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PROGRAMA_DE_VIDA_E_MINISTERIO_MACHAVA_15_PT.AppContext;
using PROGRAMA_DE_VIDA_E_MINISTERIO_MACHAVA_15_PT.Models;
using PagedList;


namespace PROGRAMA_DE_VIDA_E_MINISTERIO_MACHAVA_15_PT.DAO
{
    public class PessoaDAO
    {
        MACHAVA15Context contexto = new MACHAVA15Context();


        // Encontrar Pessoa
        public Pessoa FindPessoa(int PessoaID)
        {
          return contexto.pessoas.Find(PessoaID);
        }

        // Lista de Pessoas
        public IPagedList<Pessoa> PagedPessoa(int? Pagina)
        {
            int NumeroDeLinhas = 14;
            int npagina = Pagina ?? 1;
            var busca = from p in contexto.pessoas
                        orderby p.Nome
                        select p;

            return busca.ToPagedList(npagina, NumeroDeLinhas);
        }

        public IList<Pessoa> ListaPessoa()
        {
            
            var busca = from p in contexto.pessoas
                        orderby p.Nome
                        select p;

            return busca.ToList();
        }

        // Gravar Pessoas 
        public void ADDPessoa(Pessoa pessoa)
        {
            contexto.pessoas.Add(pessoa);
            contexto.SaveChanges();
        }

        //remover Pessoa

        public void RemovePessoa(int ID)
        {
            contexto.pessoas.Remove(this.FindPessoa(ID));
            contexto.SaveChanges();
        }
         
    }
}