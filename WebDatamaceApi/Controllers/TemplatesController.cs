using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebDatamaceApi.Controllers
{
    [Produces("application/json")]
    [Route("v1/[controller]")]
    [ApiController]
    [Authorize]
    public class TemplatesController : ControllerBase
    {
        // GET: api/<TemplatesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Desenvolvimento_Pessoal", "feriado","gestao_ferias", "informe_on_site","ultimas_noticias" };
        }

    }
}
