using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projeto_Hamburgueria.Entidades;

namespace Projeto_Hamburgueria.Context
{
    public class EstabelecimentoContext : DbContext
    {
        public EstabelecimentoContext(DbContextOptions<EstabelecimentoContext> options) : base(options)
        {

        }

        public DbSet<Clientes> Clientes { get; set; }
        
    }
}