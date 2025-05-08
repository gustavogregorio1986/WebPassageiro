﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebPassageiro.Dominio.Dominio;

namespace WebPassageiro.Data.Context
{
    public class DbContexto : DbContext
    {
        public DbContexto(DbContextOptions options)
            : base(options)
        {
            
        }

        public DbSet<Passageiro> Passageiros { get; set; }

        public DbSet<Aviao> Avioes { get; set; }
    }
}
