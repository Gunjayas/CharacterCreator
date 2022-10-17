using CharacterCreator.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.Data.Services
{
    public class CharacterCreatorDbContext:DbContext
    {
        public DbSet<Character> Characters { get; set; }
    }
}
