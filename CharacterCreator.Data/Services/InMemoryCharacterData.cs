using CharacterCreator.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.Data.Services
{
    public class InMemoryCharacterData:ICharacterData
    {
        List<Character> characters;

        public InMemoryCharacterData()
        {
            characters = new List<Character>()
            {
             new Character {Id=1,Name = "Tom", Race=RaceType.Human, Hp=10,Attack=20,Speed=30},
             new Character {Id=2,Name = "Harry", Race=RaceType.Elf, Hp=10,Attack=20,Speed=30},
            };
        }

        public Character Get(int id)
        {
            return characters.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Character> GetAll()
        {
            return characters.OrderBy(r => r.Name);
        }

        public void Add(Character character)
        {
            characters.Add(character);
            character.Id = characters.Max(r => r.Id) + 1;

        }

        public void Update(Character character)
        {
            var existing = Get(character.Id);
            if (existing != null)
            {
                existing.Name = character.Name;
                existing.Race = character.Race;
                existing.Hp = character.Hp;
                existing.Attack = character.Attack;
                existing.Speed = character.Speed;

            }
        }

        public void Delete(int id)
        {
            var character = Get(id);
            if (character != null)
            {
                characters.Remove(character);
            }
        }
    }
}
