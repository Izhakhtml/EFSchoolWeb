using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EFSchoolWeb.Models
{
    public partial class SchoolModel : DbContext
    {
        public SchoolModel()
            : base("name=SchoolModel")
        {
        }

        public DbSet<School> Schools { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
