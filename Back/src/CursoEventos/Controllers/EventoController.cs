using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoEventos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CursoEventos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {   
       public IEnumerable<Evento> _evento = new Evento[]{
            new Evento(){
            EventoId = 1,
            Tema = "Angular 11 e .NET 5",
            Local = "Belo Horizonte",
            Lote = "1º Lote",
            QtdMaxPessoas = 250,
            DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
            ImagemURL = "foto.JPG"
            },
            new Evento(){
            EventoId = 2,
            Tema = "Angular 12 e .NET 6",
            Local = "São Paulo",
            Lote = "2º Lote",
            QtdMaxPessoas = 450,
            DataEvento = DateTime.Now.AddDays(9).ToString("dd/MM/yyyy"),
            ImagemURL = "foto2.JPG"
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
        public IEnumerable<Evento> GetById(int id)
        {
           return _evento.Where(evento => evento.EventoId == id);
        }

         [HttpPost]
        public string Post()
        {
           return "Exemplo de Post";
        }

         [HttpPut("{id}")]
        public string Put(int id)
        {
           return "Exemplo de Put com id = " + id;
        }

         [HttpDelete("{id}")]
        public string Delete(int id)
        {
           return "Exemplo de Put com id = " + id;
        }
    }
}