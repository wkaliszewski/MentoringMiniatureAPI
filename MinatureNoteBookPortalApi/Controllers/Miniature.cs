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
        public IActionResult GetAll() 
        {
            var minaitures = _context.Miniature.ToList()
                .Select(m => m.ToMiniatureDto());

            return Ok(minaitures);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id) 
        {
            var minaiture = _context.Miniature.Find(id);

            if (minaiture == null)
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
            return CreatedAtAction(nameof(GetById), new { id = miniatureModel.Id }, miniatureModel.ToMiniatureDto());
            
        }

        [HttpPut]
        [Route("{id}")]

        public IActionResult Update([FromRoute] int id, [FromBody] UpdateMiniatureRequestDto updateDto)
        {
            var miniatureModel = _context.Miniature.FirstOrDefault(x => x.Id == id);
            if (miniatureModel == null)
            {
                return NotFound();
            }

            miniatureModel.Name = updateDto.Name;
            miniatureModel.Manufactured = updateDto.Manufactured; 
            miniatureModel.MainImageUrl = updateDto.MainImageUrl;
            miniatureModel.Description = updateDto.Description;
            miniatureModel.Colors = updateDto.Colors;
            miniatureModel.CreatedOn = updateDto.CreatedOn;
            miniatureModel.LastEdited  = updateDto.LastEdited;

            _context.SaveChanges();

            return Ok(miniatureModel.ToMiniatureDto());
        }

        [HttpDelete]
        [Route("{id}")]

        public IActionResult Delete([FromRoute] int id) 
        {
            var miniatureModel = _context.Miniature.FirstOrDefault(x => x.Id == id);
            if (miniatureModel == null)
            {
                return NotFound();
            }
            _context.Miniature.Remove(miniatureModel);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
