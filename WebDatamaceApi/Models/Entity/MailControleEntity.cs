using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDatamaceApi.Models.Entity
{
    public class MailControleEntity
    {
        public string Nome { get; set; }
        public string controle { get; set; }
        public int qtde{ get; set; }
        public string porcentagem{ get; set; }



    }
}
