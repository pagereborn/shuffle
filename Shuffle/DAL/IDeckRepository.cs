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
        IEnumerable<Deck> getDeckByUserId(string userId);
        void addDeck(Deck deck);
        void removeDeck(string id);
        bool[] isMatchDeck(Deck deck);
        int numDecks();
        int numDecksbyUser(string userId);
        void Save();
    }

    
}
