using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace LamToan
{
    public class LamToanContext : DbContext
    {
        //v muon them 1 bang trong db thi tao 1 dong ntn, o day t tao 1 bang ten user
        public DbSet<User> Users { get; set; }
    }
}
