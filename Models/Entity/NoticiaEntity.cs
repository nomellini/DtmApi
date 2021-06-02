using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDatamaceApi.Models.Entity
{
    public class NoticiaEntity
    {
            public int NotId { get; set; }
            public string NotTitulo { get; set; }
            public string NotResenha { get; set; }
            public string NotConteudo { get; set; }
            public string NotFonte { get; set; }
            public string NotImagem { get; set; }
            public string NotComentario { get; set; }
            public DateTime? NotVigenciaInicio { get; set; }
            public DateTime? NotVigenciaFim { get; set; }
            public bool? NotStatus { get; set; }
            public int? NotIdCategoria { get; set; }


    }
}
