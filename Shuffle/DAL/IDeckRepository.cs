using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shuffle.Models;

namespace Shuffle.DAL
{
    public interface IDeckRepository
    {
        IEnumerable<Deck> getAllDecks();
        Deck getDeck(string id);
        IEnumerable<Deck> getDeckByUserId();
        Deck addDeck(Deck item);
        bool isMatchDeck(string[] deck);
        void Save();
    }

    
}
