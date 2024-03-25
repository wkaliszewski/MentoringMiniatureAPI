namespace MinatureNoteBookPortalApi.Models
{
    public class Miniature
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manufactured {  get; set; }
        public string MainImageUrl { get; set; }
        public string Description { get; set; }
        public List<Colors> Colors { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastEdited {  get; set; }


    }
}
