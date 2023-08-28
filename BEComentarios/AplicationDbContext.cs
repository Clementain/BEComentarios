using BEComentarios.Models;
using Microsoft.EntityFrameworkCore;

namespace BEComentarios
{
	public class AplicationDbContext: DbContext
	{
		public DbSet<Comentario> comentario { get; set; }

        public AplicationDbContext(DbContextOptions<AplicationDbContext> options):base(options)
        {
                
        }
    }
}
