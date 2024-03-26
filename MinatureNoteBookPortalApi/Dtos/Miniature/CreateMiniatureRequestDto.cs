using MinatureNoteBookPortalApi.Models;

namespace MinatureNoteBookPortalApi.Dtos.Miniature
{
    public class CreateMiniatureRequestDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manufactured { get; set; }
        public string MainImageUrl { get; set; }
        public string Description { get; set; }
        public List<Colors> Colors { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastEdited { get; set; }
    }
}
