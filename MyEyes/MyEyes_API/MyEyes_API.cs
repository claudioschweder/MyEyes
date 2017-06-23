using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MtgApiManager.Lib.Dto;
using MtgApiManager.Lib.Model;

namespace MyEyes_API
{
    public class ProcessamentoImagem
    {
        public string buscarCarta(string nomeCarta)
        {            
            var dto = new CardDto()
            {
                Name = "Foo"
            };
            Card model = new Card(dto);

            return model.Artist;
        }
    }

}
