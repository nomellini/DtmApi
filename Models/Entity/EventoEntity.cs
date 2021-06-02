using MimeKit;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDatamaceApi.Models.Entity
{
    public class EventoEntity
    {
        public List<Evento> Eventos { get; set; }
        public List<EventoEntityGroup> Groups { get; set; }

    }
}
