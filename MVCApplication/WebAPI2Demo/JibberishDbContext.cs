using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAPI2Demo
{

    public class Person
    {
        public Person()
        {

        }

        public string Name { get; set; }
        
    }
    public class JibberishDbContext : DbContext
    {

        DbSet<Person> People { get; set; }

        public JibberishDbContext()
        {
            this.People.
        }
    }
}