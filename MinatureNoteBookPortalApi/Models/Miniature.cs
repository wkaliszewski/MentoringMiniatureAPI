namespace MinatureNoteBookPortalApi.Models
{
    public class Miniature
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manufactured {  get; set; } = string.Empty;
        public string MainImageUrl { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<Colors> Colors { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastEdited {  get; set; }


    }
}
