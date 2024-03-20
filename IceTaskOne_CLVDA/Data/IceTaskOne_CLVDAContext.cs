using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IceTaskOne_CLVDA.Models.Tasks;
using IceTaskOne_CLVDA.Models.Login;

namespace IceTaskOne_CLVDA.Data
{
    public class IceTaskOne_CLVDAContext : DbContext
    {
        public IceTaskOne_CLVDAContext (DbContextOptions<IceTaskOne_CLVDAContext> options)
            : base(options)
        {
        }

        public DbSet<IceTaskOne_CLVDA.Models.Tasks.Tasks> Tasks { get; set; } = default!;
        public DbSet<IceTaskOne_CLVDA.Models.Login.LoginReg> LoginReg { get; set; } = default!;
    }
}
