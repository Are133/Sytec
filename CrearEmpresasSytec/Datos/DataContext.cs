using CrearEmpresasSytec.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrearEmpresasSytec.Datos
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext>options):base(options)
        {

        }

        public DbSet<Empresa> Empresas { get; set; }

        public DbSet<Configuracion> Configuraciones { get; set; }
    }
}
