using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.GridFS;
using MongoDB.Driver.Linq;
using Shuffle.Models;
namespace Shuffle.DAL
{
    public class DeckRepository : IDeckRepository
    {
        MongoServer _server;
        MongoDatabase _database;
        MongoCollection<Deck> _decks;
        public DeckRepository(string connection)
        {
            if (string.IsNullOrWhiteSpace(connection))
            {
                connection = "mongodb://localhost:27017";
            }
            
            _server = MongoServer.Create(connection);

            _database = _server.GetDatabase("Shuffle");

            _decks = _database.GetCollection<Deck>("Shuffle");

        }
        public IEnumerable<Deck> GetAllDecks()
        {
            return _decks.FindAll();
        }

        public Deck GetDeck(string id)
        {
            IMongoQuery query = Query.EQ("_id", id);
            return _decks.Find(query).FirstOrDefault();
        }
    }
}