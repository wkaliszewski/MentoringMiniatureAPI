using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinatureNoteBookPortalApi.Data;
using MinatureNoteBookPortalApi.Dtos.Miniature;
using MinatureNoteBookPortalApi.Mappers;
    using System.Xml;

namespace MinatureNoteBookPortalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MiniatureController : ControllerBase
    {
        private readonly AplicationDBContext _context;
        public MiniatureController(AplicationDBContext context)
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
        [HttpPost]
        public IActionResult Create([FromBody] CreateMiniatureRequestDto miniatureDto)
        {
            var miniatureModel = miniatureDto.ToMiniatureFromCreateDTO();
            _context.Miniature.Add(miniatureModel);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetbById), new { id = miniatureModel.Id }, miniatureModel.ToMiniatureDto());
        }
    }
}
