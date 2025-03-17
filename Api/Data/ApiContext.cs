using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Api.Models;

namespace Api.Data
{
    public class ApiContext : DbContext
    {
        public ApiContext (DbContextOptions<ApiContext> options)
            : base(options)
        {
        }

        public DbSet<Api.Models.Aluno> Aluno { get; set; } = default!;
        public DbSet<Api.Models.Professor> Professor { get; set; } = default!;
        public DbSet<Api.Models.Escola> Escola { get; set; } = default!;
    }
}
