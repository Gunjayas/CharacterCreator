using CharacterCreator.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.Data.Services
{
    public interface ICharacterData
    {
        IEnumerable<Character> GetAll();

        Character Get(int id);
        void Add(Character character);
        void Update(Character character);
        void Delete(int id);
    }
}
