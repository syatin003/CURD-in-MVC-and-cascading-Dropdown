using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CRUD_With_CF.Models
{
    public class Emp_Context :DbContext
    {
    
        public Emp_Context()
        :base ("name=EmpContext")
        { }
        public DbSet<Emp> Emp { get; set; }

        public DbSet<Country> Country { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<City> City { get; set; }
        
    
    }
}