﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Quiron.LojaVirtual.Dominio.Repositorio;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class ProdutoController : Controller
    {
        private ProdutosRespositorios _repositorio;
        //
        // GET: /Produto/
        public ActionResult Index()
        {
            _repositorio = new ProdutosRespositorios();
            var produtos = _repositorio.Produtos.Take(3);
            return View(produtos);
        }
	}
}