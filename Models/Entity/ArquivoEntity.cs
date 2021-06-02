using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDatamaceApi.Models.Entity
{
    public class ArquivoEntity
    {
        public int Arquivo { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public bool? Status { get; set; }
        public int idCategoria { get; set; }
        public int Produto { get; set; }
        public string? nomeCategoria { get; set; }
        public string? lastDate { get; set; }
        public string? lastUsuario { get; set; }



    }
}
