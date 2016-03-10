using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class ApplictionDBContext:DbContext
    {
        public ApplictionDBContext():base("DefaultConnection")
        {
            
        }
        public DbSet<BookModel> Books { get; set; }
    }
}