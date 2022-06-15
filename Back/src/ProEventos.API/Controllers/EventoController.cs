using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;


namespace ProEventos.API.Controllers
{



    [ApiController]
    [Route("[controller]")]
    public class EventoController : ControllerBase
    {

      

        // private readonly ILogger<EventoController> _logger;
        public DataContext _context { get; }

        public EventoController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;


        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _context.Eventos.Where(evento => evento.EventoId == id);


        }
    }
}
