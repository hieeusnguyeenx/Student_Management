using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class QLSV_Context : DbContext
    {
        public QLSV_Context(): base("name=QLSV_Context")
        {

        }

        public virtual DbSet<User> Users { get; set; } 
    }
}
