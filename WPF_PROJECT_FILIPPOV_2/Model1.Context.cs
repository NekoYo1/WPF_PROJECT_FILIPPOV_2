﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPF_PROJECT_FILIPPOV_2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ProjectFilippov_2Entities : DbContext
    {
        private static ProjectFilippov_2Entities _context;

        public static ProjectFilippov_2Entities GetContext()
        {
            if (_context == null)
                _context = new ProjectFilippov_2Entities();
            return _context;
        }

        public ProjectFilippov_2Entities()
            : base("name=ProjectFilippov_2Entities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Postavchik> Postavchik { get; set; }
        public virtual DbSet<Proizvoditel> Proizvoditel { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tovar> Tovar { get; set; }
    }
}
