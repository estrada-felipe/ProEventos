using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public IEnumerable<Evento> _evento = new Evento[] {
            new Evento() {
            EventoId = 1,
            Local = "Local do Evento",
            DataEvento = DateTime.Now.AddDays(1),
            Tema = "Tema do Evento",
            QtdPessoas = 100,
            Lote = "Lote 1",
            ImagemUrl = "http://localhost:5000/imagens/evento1.jpg",
            Telefone = "(11) 99999-9999",
            Email = ""
            },
            new Evento(){
                EventoId = 2,
                Local = "Local do Evento",
                DataEvento = DateTime.Now.AddDays(1),
                Tema = "Tema do Evento",
                QtdPessoas = 100,
                Lote = "Lote 1",
                ImagemUrl = "http://localhost:5000/imagens/evento1.jpg",
                Telefone = "(11) 99999-9999",
                Email = ""
            }
        };

        public EventoController()
        {

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;    
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> Get(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);    
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
