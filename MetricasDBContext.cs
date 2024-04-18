using Metricas.Models;
using Microsoft.EntityFrameworkCore;

namespace Metricas
{
    public class MetricasDBContext : DbContext
    {
        public MetricasDBContext(DbContextOptions<MetricasDBContext> options) : base(options)
        {
        }

        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Pago> Pagos { get; set; }
    }
}
