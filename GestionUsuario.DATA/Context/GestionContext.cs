using GestionUsuario.DATA.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionUsuario.Data.Context
{
    public class GestionContext : DbContext
    {
        public GestionContext()
        {

        }
        public GestionContext(DbContextOptions<GestionContext> options) : base(options)
        {

        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<TypeDocument> TypeDocument { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
    }
}
