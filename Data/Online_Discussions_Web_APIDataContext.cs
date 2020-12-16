using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Online_Discussions_Web_API.Model;

namespace Online_Discussions_Web_API.Models
{
    public class Online_Discussions_Web_APIDataContext : DbContext
    {
        public Online_Discussions_Web_APIDataContext (DbContextOptions<Online_Discussions_Web_APIDataContext> options)
            : base(options)
        {
        }

        public DbSet<Online_Discussions_Web_API.Model.Message> Message { get; set; }
    }
}
