using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyEyes_API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEyes_API.Tests
{
    [TestClass()]
    public class ProcessamentoImagemTests
    {
        [TestMethod()]
        public void buscarCartaTest()
        {
            string retorno;

            ProcessamentoImagem teste1 = new ProcessamentoImagem();
            
            retorno = teste1.buscarCarta("Foo");

            Assert.AreEqual(retorno, "Foo");
        }
    }
}