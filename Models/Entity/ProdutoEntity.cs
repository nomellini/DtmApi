using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDatamaceApi.Models.Entity
{
    public class ProdutoEntity
    {
        public int Produto { get; set; }
        public string Nome { get; set; }
        public bool? Status { get; set; }
        public int? ContArquivos { get; set; }



    }
}
