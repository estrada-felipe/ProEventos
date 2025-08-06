using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly DataContext _context;
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
        public Evento Get(int id)
        {
            return _context.Eventos.FirstOrDefault(evento => evento.EventoId == id);
        }




 







        [HttpPost("{id}")]
        public string Postar(int id)
        {
            return $"Exemplo Post = {id}";
        }
        [HttpPut("{id}")]
        public string Inserir(int id)
        {
            return $"Exemplo Put = {id}";
        }
        
        [HttpDelete("{id?}")]
        public string Delete(int? id)
        {
            return $"Exemplo Delete = {id}";
        }
    }
}
