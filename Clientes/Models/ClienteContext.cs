using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clientes.Models
{
    public class ClienteContext:DbContext
    {
        public ClienteContext(DbContextOptions options):base(options){}

        public DbSet<Cliente> Clientes { get; set; }
    }
}
