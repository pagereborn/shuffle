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
                connection = "mongodb://54.210.57.27:27017";
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
        public bool[] isMatchDeck(string[] deck)
        {
            bool[] anyMatches  = new bool[52];
            Deck match1 = _decks.AsQueryable().Where(d => d.part1 == deck[0]).SingleOrDefault();
            Deck match2 = _decks.AsQueryable().Where(d => d.part1 == deck[1]).SingleOrDefault();
            Deck match3 = _decks.AsQueryable().Where(d => d.part1 == deck[2]).SingleOrDefault();
            Deck match4 = _decks.AsQueryable().Where(d => d.part1 == deck[3]).SingleOrDefault();
            Deck match5 = _decks.AsQueryable().Where(d => d.part1 == deck[4]).SingleOrDefault();
            Deck match6 = _decks.AsQueryable().Where(d => d.part1 == deck[5]).SingleOrDefault();
            Deck match7 = _decks.AsQueryable().Where(d => d.part1 == deck[6]).SingleOrDefault();
            Deck match8 = _decks.AsQueryable().Where(d => d.part1 == deck[7]).SingleOrDefault();
            Deck match9 = _decks.AsQueryable().Where(d => d.part1 == deck[8]).SingleOrDefault();
            Deck match10 = _decks.AsQueryable().Where(d => d.part1 == deck[9]).SingleOrDefault();
            Deck match11 = _decks.AsQueryable().Where(d => d.part1 == deck[10]).SingleOrDefault();
            Deck match12 = _decks.AsQueryable().Where(d => d.part1 == deck[11]).SingleOrDefault();
            Deck match13 = _decks.AsQueryable().Where(d => d.part1 == deck[12]).SingleOrDefault();
            Deck match14 = _decks.AsQueryable().Where(d => d.part1 == deck[13]).SingleOrDefault();
            Deck match15 = _decks.AsQueryable().Where(d => d.part1 == deck[14]).SingleOrDefault();
            Deck match16 = _decks.AsQueryable().Where(d => d.part1 == deck[15]).SingleOrDefault();
            Deck match17 = _decks.AsQueryable().Where(d => d.part1 == deck[16]).SingleOrDefault();
            Deck match18 = _decks.AsQueryable().Where(d => d.part1 == deck[17]).SingleOrDefault();
            Deck match19 = _decks.AsQueryable().Where(d => d.part1 == deck[18]).SingleOrDefault();
            Deck match20 = _decks.AsQueryable().Where(d => d.part1 == deck[19]).SingleOrDefault();
            Deck match21 = _decks.AsQueryable().Where(d => d.part1 == deck[20]).SingleOrDefault();
            Deck match22 = _decks.AsQueryable().Where(d => d.part1 == deck[21]).SingleOrDefault();
            Deck match23 = _decks.AsQueryable().Where(d => d.part1 == deck[22]).SingleOrDefault();
            Deck match24 = _decks.AsQueryable().Where(d => d.part1 == deck[23]).SingleOrDefault();
            Deck match25 = _decks.AsQueryable().Where(d => d.part1 == deck[24]).SingleOrDefault();
            Deck match26 = _decks.AsQueryable().Where(d => d.part1 == deck[25]).SingleOrDefault();
            Deck match27 = _decks.AsQueryable().Where(d => d.part1 == deck[26]).SingleOrDefault();
            Deck match28 = _decks.AsQueryable().Where(d => d.part1 == deck[27]).SingleOrDefault();
            Deck match29 = _decks.AsQueryable().Where(d => d.part1 == deck[28]).SingleOrDefault();
            Deck match30 = _decks.AsQueryable().Where(d => d.part1 == deck[29]).SingleOrDefault();
            Deck match31 = _decks.AsQueryable().Where(d => d.part1 == deck[30]).SingleOrDefault();
            Deck match32 = _decks.AsQueryable().Where(d => d.part1 == deck[31]).SingleOrDefault();
            Deck match33 = _decks.AsQueryable().Where(d => d.part1 == deck[32]).SingleOrDefault();
            Deck match34 = _decks.AsQueryable().Where(d => d.part1 == deck[33]).SingleOrDefault();
            Deck match35 = _decks.AsQueryable().Where(d => d.part1 == deck[34]).SingleOrDefault();
            Deck match36 = _decks.AsQueryable().Where(d => d.part1 == deck[35]).SingleOrDefault();
            Deck match37 = _decks.AsQueryable().Where(d => d.part1 == deck[36]).SingleOrDefault();
            Deck match38 = _decks.AsQueryable().Where(d => d.part1 == deck[37]).SingleOrDefault();
            Deck match39 = _decks.AsQueryable().Where(d => d.part1 == deck[38]).SingleOrDefault();
            Deck match40 = _decks.AsQueryable().Where(d => d.part1 == deck[39]).SingleOrDefault();
            Deck match41 = _decks.AsQueryable().Where(d => d.part1 == deck[40]).SingleOrDefault();
            Deck match42 = _decks.AsQueryable().Where(d => d.part1 == deck[41]).SingleOrDefault();
            Deck match43 = _decks.AsQueryable().Where(d => d.part1 == deck[42]).SingleOrDefault();
            Deck match44 = _decks.AsQueryable().Where(d => d.part1 == deck[43]).SingleOrDefault();
            Deck match45 = _decks.AsQueryable().Where(d => d.part1 == deck[44]).SingleOrDefault();
            Deck match46 = _decks.AsQueryable().Where(d => d.part1 == deck[45]).SingleOrDefault();
            Deck match47 = _decks.AsQueryable().Where(d => d.part1 == deck[46]).SingleOrDefault();
            Deck match48 = _decks.AsQueryable().Where(d => d.part1 == deck[47]).SingleOrDefault();
            Deck match49 = _decks.AsQueryable().Where(d => d.part1 == deck[48]).SingleOrDefault();
            Deck match50 = _decks.AsQueryable().Where(d => d.part1 == deck[49]).SingleOrDefault();
            Deck match51 = _decks.AsQueryable().Where(d => d.part1 == deck[50]).SingleOrDefault();
            Deck match52 = _decks.AsQueryable().Where(d => d.part1 == deck[51]).SingleOrDefault();
            if (match1 == null)
                anyMatches[0] = false;
            else
                anyMatches[0] = true;

            if (match1 == null)
                anyMatches[1] = false;
            else
                anyMatches[1] = true;

            if (match1 == null)
                anyMatches[2] = false;
            else
                anyMatches[2] = true;

            if (match1 == null)
                anyMatches[3] = false;
            else
                anyMatches[0] = true;

            if (match1 == null)
                anyMatches[0] = false;
            else
                anyMatches[0] = true;

            if (match1 == null)
                anyMatches[0] = false;
            else
                anyMatches[0] = true;

            if (match1 == null)
                anyMatches[0] = false;
            else
                anyMatches[0] = true;

            if (match1 == null)
                anyMatches[0] = false;
            else
                anyMatches[0] = true;

            if (match1 == null)
                anyMatches[0] = false;
            else
                anyMatches[0] = true;

            if (match1 == null)
                anyMatches[0] = false;
            else
                anyMatches[0] = true;

            if (match1 == null)
                anyMatches[0] = false;
            else
                anyMatches[0] = true;

            if (match1 == null)
                anyMatches[0] = false;
            else
                anyMatches[0] = true;

            if (match1 == null)
                anyMatches[0] = false;
            else
                anyMatches[0] = true;

            if (match1 == null)
                anyMatches[0] = false;
            else
                anyMatches[0] = true;

            if (match1 == null)
                anyMatches[0] = false;
            else
                anyMatches[0] = true;

            if (match1 == null)
                anyMatches[0] = false;
            else
                anyMatches[0] = true;

            if (match1 == null)
                anyMatches[0] = false;
            else
                anyMatches[0] = true;

            if (match1 == null)
                anyMatches[0] = false;
            else
                anyMatches[0] = true;

            if (match1 == null)
                anyMatches[0] = false;
            else
                anyMatches[0] = true;

            if (match1 == null)
                anyMatches[0] = false;
            else
                anyMatches[0] = true;

            if (match1 == null)
                anyMatches[0] = false;
            else
                anyMatches[0] = true;

            if (match1 == null)
                anyMatches[0] = false;
            else
                anyMatches[0] = true;

            if (match1 == null)
                anyMatches[0] = false;
            else
                anyMatches[0] = true;

            if (match1 == null)
                anyMatches[0] = false;
            else
                anyMatches[0] = true;

            if (match1 == null)
                anyMatches[0] = false;
            else
                anyMatches[0] = true;

            return anyMatches;
        }
        public void Save()
        {

        }
    }
}