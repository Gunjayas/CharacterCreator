using CharacterCreator.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.Data.Services
{
    public class SqlCharacterData : ICharacterData
    {
        private readonly CharacterCreatorDbContext db;

        public SqlCharacterData(CharacterCreatorDbContext db)
        {
            this.db = db;
        }
        public void Add(Character character)
        {
            db.Characters.Add(character);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var character = db.Characters.Find(id);
            db.Characters.Remove(character);
            db.SaveChanges();
        }

        public Character Get(int id)
        {
            return db.Characters.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Character> GetAll()
        {
            return db.Characters.OrderBy(r => r.Name);
        }

        public void Update(Character character)
        {
            var entry = db.Entry(character);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
        
    }
}
