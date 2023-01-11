using APIEnglishFlashCards.DataBase;
using FlashCards.Models;

namespace APIEnglishFlashCards.Repositories
{
    public class PhrasesRepository : IPhrasesRepository
    {

        private readonly APIEnglishFlashCardsContext _repository;
        public PhrasesRepository(APIEnglishFlashCardsContext repository)
        {
            _repository = repository;
        }

        public List<Phrases> GetAll()
        {
            return _repository.Phrases.OrderBy(p => p.Id).ToList();
        }
        public Phrases Get(int id)
        {
            return _repository.Phrases.Find(id)!;
        }
        public void AddPhrase(Phrases phrase)
        {
            _repository.Phrases.Add(phrase);
            _repository.SaveChanges();
        }

        public void UpdatePhrase(Phrases phrase)
        {
            _repository.Phrases.Update(phrase);
            _repository.SaveChanges();
        }
        public void DeletePhrase(int id)
        {
            _repository.Phrases.Remove(Get(id));
            _repository.SaveChanges();
        }



    }
}
