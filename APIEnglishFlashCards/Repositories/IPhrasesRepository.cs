using FlashCards.Models;

namespace APIEnglishFlashCards.Repositories
{
    public interface IPhrasesRepository
    {
        List<Phrases> GetAll();
        Phrases Get(int id);
        void AddPhrase(Phrases phrase);
        void UpdatePhrase(Phrases phrase);
        void DeletePhrase(int id);
    }
}
