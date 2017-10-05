using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Enhancement.Core.Context
{
    public class ExtendedDbContext : DbContext
    {
        public ExtendedDbContext(DbContextOptions options) 
            : base(options)
        {
        }

        protected ExtendedDbContext() 
        {
        }



    }
}
