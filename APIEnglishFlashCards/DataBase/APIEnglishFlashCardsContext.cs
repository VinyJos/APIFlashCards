using FlashCards.Models;
using Microsoft.EntityFrameworkCore;

namespace APIEnglishFlashCards.DataBase
{
    public class APIEnglishFlashCardsContext : DbContext
    {
        public APIEnglishFlashCardsContext(DbContextOptions<APIEnglishFlashCardsContext>options) : base(options) { }

        public DbSet<Phrases> Phrases { get; set; }
    }
}
