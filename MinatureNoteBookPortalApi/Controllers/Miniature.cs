using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinatureNoteBookPortalApi.Data;
using MinatureNoteBookPortalApi.Models;
using MinatureNoteBookPortalApi.Mappers;
    using System.Xml;

namespace MinatureNoteBookPortalApi.Controllers
{
    [Route("api/[miniature]")]
    [ApiController]
    public class Miniature : ControllerBase
    {
        private readonly AplicationDBContext _context;
        public Miniature(AplicationDBContext context)
        {
            _context = context;
        }

        public string Name { get; internal set; }

        [HttpGet]
        public IActionResult GetAll() {
            var minaitures = _context.Miniature.ToList()
                .Select(m => m.ToMiniatureDto());

            return Ok(minaitures);

        }
        [HttpGet("{id}")]
        public IActionResult GetbById([FromRoute] int id) {
            var minaiture = _context.Miniature.Find(id);

            if(minaiture == null)
            {
                return NotFound();
            }
            return Ok(minaiture.ToMiniatureDto());
        }
    }
}
