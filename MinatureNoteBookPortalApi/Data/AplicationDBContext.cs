using Microsoft.EntityFrameworkCore;
using MinatureNoteBookPortalApi.Models;

namespace MinatureNoteBookPortalApi.Data
{
    public class AplicationDBContext: DbContext
    {
        public AplicationDBContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {

        }

        public DbSet<Miniature> Miniature { get; set; }
       
    }
}
