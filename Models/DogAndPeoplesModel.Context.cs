//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DogAndPeoples.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DogAndPeoplesEntities : DbContext
    {
        public DogAndPeoplesEntities()
            : base("name=DogAndPeoplesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Caes> Caes { get; set; }
        public virtual DbSet<Caes_Dono> Caes_Dono { get; set; }
        public virtual DbSet<Donos> Donos { get; set; }
    }
}
