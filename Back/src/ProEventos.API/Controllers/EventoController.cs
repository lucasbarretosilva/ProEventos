using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;


namespace ProEventos.API.Controllers
{    

     

    [ApiController]
    [Route("[controller]")]
    public class EventoController : ControllerBase
    {
       
            public IEnumerable <Evento> _evento = new Evento[]{

                new Evento(){
              
              EventoId = 1,
              Tema = "Angular 13",
              Local = "Recife",
              Lote = "1º Lote",
              QtdPessoas = 250,
              DataEvento = DateTime.Now.AddDays(2).ToString()

          },
           new Evento(){
              
              EventoId = 2,
              Tema = "Asp",
              Local = "Salvador",
              Lote = "1º Lote",
              QtdPessoas = 200,
              DataEvento = DateTime.Now.AddDays(2).ToString()

          }
            };
            
        // private readonly ILogger<EventoController> _logger;

        public EventoController()
        {
           
        }

        [HttpGet]
        public IEnumerable <Evento> Get()
        {
          return _evento;

          
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
          return _evento.Where(evento=>evento.EventoId == id);

          
      }
    }
}
