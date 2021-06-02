using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDatamaceApi.Models.Entity
{
    public class SolucaoEntity
    {
        public int Id { get; set; }
        public string Slug { get; set; }

        public string Menu { get; set; }

        public string Titulo { get; set; }

        public string Conteudo { get; set; }
        public string ImagePath { get; set; }
        public bool Parent{ get; set; }


    }
}
