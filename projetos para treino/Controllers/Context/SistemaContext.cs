﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Controllers.Context
{
    internal class SistemaContext : DbContext
    {
        public SistemaContext() : base("Server= SN-386958\\SQLEXPRESS; Database= simulado03;Integrated Security =True;")
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Database.SetInitializer<SistemaContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}
