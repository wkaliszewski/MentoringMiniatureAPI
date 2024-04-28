namespace MinatureNoteBookPortalApi.Models
{
    public class Colors
    {
        public int Id { get; set; }
        public int MiniatureId { get; set; }
        public string ColorCode { get; set; } = string.Empty;
        public string PositionX { get; set; } = string.Empty;   
        public string PositionY { get; set; } = string.Empty;
    }
}
