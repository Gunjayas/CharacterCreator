using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.Data.Models
{
    public class Character
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        
        public RaceType Race { get; set; }
        
        public int Hp { get; set; }
        
        public int Attack { get; set; }
        
        public int Speed { get; set; }
        
    }
}
