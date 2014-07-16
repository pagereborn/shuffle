using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.GridFS;
using MongoDB.Driver.Linq;
using Shuffle.Models;
using MongoDB.Bson;
using MongoDB.AspNet.Identity;
using System.Dynamic;
namespace Shuffle.DAL
{
    public class DeckRepository : IDeckRepository
    {
        MongoClient _client;
        MongoServer _server;
        MongoDatabase _database;
        MongoCollection<Deck> _decks;
        public DeckRepository(string connection)
        {
            if (string.IsNullOrWhiteSpace(connection))
            {
                connection = "mongodb://192.168.1.11:27017";
            }
            _client = new MongoClient(connection);
            _server = _client.GetServer();

            _database = _server.GetDatabase("Shuffle");

            _decks = _database.GetCollection<Deck>("Shuffle");

        }
        public IEnumerable<Deck> getAllDecks()
        {
            return _decks.FindAll();
        }

        public Deck getDeck(string id)
        {
            IMongoQuery query = Query.EQ("_id", id);
            return _decks.Find(query).FirstOrDefault();
        }

        public IEnumerable<Deck> getDeckByUserId(string userId)
        {
            return _decks.AsQueryable<Deck>().Where(d => d.userID == userId);
        }

        public void addDeck(Deck deck)
        {
            _decks.Insert(deck);
        }
        public void removeDeck(string id)
        {
            IMongoQuery query = Query.EQ("_id", id);
            _decks.Remove(query);
        }
        public bool isMatchDeck(string[] deck)
        {
            return false;
        }
        public void Save()
        {

        }
    }
}