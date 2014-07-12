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
        IEnumerable<Deck> getAllShuffles();
        Deck getShuffle(string id);
        Deck addShuffle(Deck item);
        void Save();
    }

    /*public DeckRepository(string connection)
    {
        if (string.IsNullOrWhiteSpace(connection))
        {
            connection = "mongodb://localhost:27017";
        }
        _server = MongoServer.Create(connection);
        
        _database = _server.GetDatabase("Shuffles", SafeMode.True);

        _shuffles = _database.GetCollection<Shuffle>("Shuffles");

  

        // Reset database and add some default entries

        _shuffles.RemoveAll();

        for (int index = 1; index < 5; index++)
        {

            Deck shuffle1 = new Deck
            {

            };

            addShuffle(shuffle1);

        }
    }*/
}
