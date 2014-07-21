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
        MongoClient _client;
        MongoServer _server;
        MongoDatabase _database;
        MongoCollection<Deck> _decks;
        public DeckRepository(string connection)
        {
            if (string.IsNullOrWhiteSpace(connection))
            {
                connection = "mongodb://Shuffle:cfXvkQcf_yd7Pch4K1R4UeZ79QBuqwNngQF_XudB6go-@ds035787.mongolab.com:35787/Shuffle";
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
            return null;
        }

        public void addDeck(Deck deck)
        {
            _decks.Insert(deck);
        }
        public void removeDeck(string id)
        {

        }
        public bool[] isMatchDeck(Deck deck)
        {
            bool[] anyMatches  = new bool[52];
            Deck match1 = _decks.AsQueryable().Where(d => d.part1 == deck.part1).FirstOrDefault();
            Deck match2 = _decks.AsQueryable().Where(d => d.part2 == deck.part2).FirstOrDefault();
            Deck match3 = _decks.AsQueryable().Where(d => d.part3 == deck.part3).FirstOrDefault();
            Deck match4 = _decks.AsQueryable().Where(d => d.part4 == deck.part4).FirstOrDefault();
            Deck match5 = _decks.AsQueryable().Where(d => d.part5 == deck.part5).FirstOrDefault();
            Deck match6 = _decks.AsQueryable().Where(d => d.part6 == deck.part6).FirstOrDefault();
            Deck match7 = _decks.AsQueryable().Where(d => d.part7 == deck.part7).FirstOrDefault();
            Deck match8 = _decks.AsQueryable().Where(d => d.part8 == deck.part8).FirstOrDefault();
            Deck match9 = _decks.AsQueryable().Where(d => d.part9 == deck.part9).FirstOrDefault();
            Deck match10 = _decks.AsQueryable().Where(d => d.part10 == deck.part10).FirstOrDefault();
            Deck match11 = _decks.AsQueryable().Where(d => d.part11 == deck.part11).FirstOrDefault();
            Deck match12 = _decks.AsQueryable().Where(d => d.part12 == deck.part12).FirstOrDefault();
            Deck match13 = _decks.AsQueryable().Where(d => d.part13 == deck.part13).FirstOrDefault();
            Deck match14 = _decks.AsQueryable().Where(d => d.part14 == deck.part14).FirstOrDefault();
            Deck match15 = _decks.AsQueryable().Where(d => d.part15 == deck.part15).FirstOrDefault();
            Deck match16 = _decks.AsQueryable().Where(d => d.part16 == deck.part16).FirstOrDefault();
            Deck match17 = _decks.AsQueryable().Where(d => d.part17 == deck.part17).FirstOrDefault();
            Deck match18 = _decks.AsQueryable().Where(d => d.part18 == deck.part18).FirstOrDefault();
            Deck match19 = _decks.AsQueryable().Where(d => d.part19 == deck.part19).FirstOrDefault();
            Deck match20 = _decks.AsQueryable().Where(d => d.part20 == deck.part20).FirstOrDefault();
            Deck match21 = _decks.AsQueryable().Where(d => d.part21 == deck.part21).FirstOrDefault();
            Deck match22 = _decks.AsQueryable().Where(d => d.part22 == deck.part22).FirstOrDefault();
            Deck match23 = _decks.AsQueryable().Where(d => d.part23 == deck.part23).FirstOrDefault();
            Deck match24 = _decks.AsQueryable().Where(d => d.part24 == deck.part24).FirstOrDefault();
            Deck match25 = _decks.AsQueryable().Where(d => d.part25 == deck.part25).FirstOrDefault();
            Deck match26 = _decks.AsQueryable().Where(d => d.part26 == deck.part26).FirstOrDefault();
            Deck match27 = _decks.AsQueryable().Where(d => d.part27 == deck.part27).FirstOrDefault();
            Deck match28 = _decks.AsQueryable().Where(d => d.part28 == deck.part28).FirstOrDefault();
            Deck match29 = _decks.AsQueryable().Where(d => d.part29 == deck.part29).FirstOrDefault();
            Deck match30 = _decks.AsQueryable().Where(d => d.part30 == deck.part30).FirstOrDefault();
            Deck match31 = _decks.AsQueryable().Where(d => d.part31 == deck.part31).FirstOrDefault();
            Deck match32 = _decks.AsQueryable().Where(d => d.part32 == deck.part32).FirstOrDefault();
            Deck match33 = _decks.AsQueryable().Where(d => d.part33 == deck.part33).FirstOrDefault();
            Deck match34 = _decks.AsQueryable().Where(d => d.part34 == deck.part34).FirstOrDefault();
            Deck match35 = _decks.AsQueryable().Where(d => d.part35 == deck.part35).FirstOrDefault();
            Deck match36 = _decks.AsQueryable().Where(d => d.part36 == deck.part36).FirstOrDefault();
            Deck match37 = _decks.AsQueryable().Where(d => d.part37 == deck.part37).FirstOrDefault();
            Deck match38 = _decks.AsQueryable().Where(d => d.part38 == deck.part38).FirstOrDefault();
            Deck match39 = _decks.AsQueryable().Where(d => d.part39 == deck.part39).FirstOrDefault();
            Deck match40 = _decks.AsQueryable().Where(d => d.part40 == deck.part40).FirstOrDefault();
            Deck match41 = _decks.AsQueryable().Where(d => d.part41 == deck.part41).FirstOrDefault();
            Deck match42 = _decks.AsQueryable().Where(d => d.part42 == deck.part42).FirstOrDefault();
            Deck match43 = _decks.AsQueryable().Where(d => d.part43 == deck.part43).FirstOrDefault();
            Deck match44 = _decks.AsQueryable().Where(d => d.part44 == deck.part44).FirstOrDefault();
            Deck match45 = _decks.AsQueryable().Where(d => d.part45 == deck.part45).FirstOrDefault();
            Deck match46 = _decks.AsQueryable().Where(d => d.part46 == deck.part46).FirstOrDefault();
            Deck match47 = _decks.AsQueryable().Where(d => d.part47 == deck.part47).FirstOrDefault();
            Deck match48 = _decks.AsQueryable().Where(d => d.part48 == deck.part48).FirstOrDefault();
            Deck match49 = _decks.AsQueryable().Where(d => d.part49 == deck.part49).FirstOrDefault();
            Deck match50 = _decks.AsQueryable().Where(d => d.part50 == deck.part50).FirstOrDefault();
            Deck match51 = _decks.AsQueryable().Where(d => d.part51 == deck.part51).FirstOrDefault();
            Deck match52 = _decks.AsQueryable().Where(d => d.part52 == deck.part52).FirstOrDefault();
            if (match1 == null)
                anyMatches[0] = false;
            else
                anyMatches[0] = true;

            if (match2 == null)
                anyMatches[1] = false;
            else
                anyMatches[1] = true;

            if (match3 == null)
                anyMatches[2] = false;
            else
                anyMatches[2] = true;

            if (match4 == null)
                anyMatches[3] = false;
            else
                anyMatches[3] = true;

            if (match5 == null)
                anyMatches[4] = false;
            else
                anyMatches[4] = true;

            if (match6 == null)
                anyMatches[5] = false;
            else
                anyMatches[5] = true;

            if (match7 == null)
                anyMatches[6] = false;
            else
                anyMatches[6] = true;

            if (match8 == null)
                anyMatches[7] = false;
            else
                anyMatches[7] = true;

            if (match9 == null)
                anyMatches[8] = false;
            else
                anyMatches[8] = true;

            if (match10 == null)
                anyMatches[9] = false;
            else
                anyMatches[9] = true;

            if (match11 == null)
                anyMatches[10] = false;
            else
                anyMatches[10] = true;

            if (match12 == null)
                anyMatches[11] = false;
            else
                anyMatches[11] = true;

            if (match13 == null)
                anyMatches[12] = false;
            else
                anyMatches[12] = true;

            if (match14 == null)
                anyMatches[13] = false;
            else
                anyMatches[13] = true;

            if (match15 == null)
                anyMatches[14] = false;
            else
                anyMatches[14] = true;

            if (match16 == null)
                anyMatches[15] = false;
            else
                anyMatches[15] = true;

            if (match17 == null)
                anyMatches[16] = false;
            else
                anyMatches[16] = true;

            if (match18 == null)
                anyMatches[17] = false;
            else
                anyMatches[17] = true;

            if (match19 == null)
                anyMatches[18] = false;
            else
                anyMatches[18] = true;

            if (match20 == null)
                anyMatches[19] = false;
            else
                anyMatches[19] = true;

            if (match21 == null)
                anyMatches[20] = false;
            else
                anyMatches[20] = true;

            if (match22 == null)
                anyMatches[21] = false;
            else
                anyMatches[21] = true;

            if (match23 == null)
                anyMatches[22] = false;
            else
                anyMatches[22] = true;

            if (match24 == null)
                anyMatches[23] = false;
            else
                anyMatches[23] = true;

            if (match25 == null)
                anyMatches[24] = false;
            else
                anyMatches[24] = true;

            if (match26 == null)
                anyMatches[25] = false;
            else
                anyMatches[25] = true;

            if (match27 == null)
                anyMatches[26] = false;
            else
                anyMatches[26] = true;

            if (match28 == null)
                anyMatches[27] = false;
            else
                anyMatches[27] = true;

            if (match29 == null)
                anyMatches[28] = false;
            else
                anyMatches[28] = true;

            if (match30 == null)
                anyMatches[29] = false;
            else
                anyMatches[29] = true;

            if (match31 == null)
                anyMatches[30] = false;
            else
                anyMatches[30] = true;

            if (match32 == null)
                anyMatches[31] = false;
            else
                anyMatches[31] = true;

            if (match33 == null)
                anyMatches[32] = false;
            else
                anyMatches[32] = true;

            if (match34 == null)
                anyMatches[33] = false;
            else
                anyMatches[33] = true;

            if (match35 == null)
                anyMatches[34] = false;
            else
                anyMatches[34] = true;

            if (match36 == null)
                anyMatches[35] = false;
            else
                anyMatches[35] = true;

            if (match37 == null)
                anyMatches[36] = false;
            else
                anyMatches[36] = true;

            if (match38 == null)
                anyMatches[37] = false;
            else
                anyMatches[37] = true;

            if (match39 == null)
                anyMatches[38] = false;
            else
                anyMatches[38] = true;

            if (match40 == null)
                anyMatches[39] = false;
            else
                anyMatches[39] = true;

            if (match41 == null)
                anyMatches[40] = false;
            else
                anyMatches[40] = true;

            if (match42 == null)
                anyMatches[41] = false;
            else
                anyMatches[41] = true;

            if (match43 == null)
                anyMatches[42] = false;
            else
                anyMatches[42] = true;

            if (match44 == null)
                anyMatches[43] = false;
            else
                anyMatches[43] = true;

            if (match45 == null)
                anyMatches[44] = false;
            else
                anyMatches[44] = true;

            if (match46 == null)
                anyMatches[45] = false;
            else
                anyMatches[45] = true;

            if (match47 == null)
                anyMatches[46] = false;
            else
                anyMatches[46] = true;

            if (match48 == null)
                anyMatches[47] = false;
            else
                anyMatches[47] = true;

            if (match49 == null)
                anyMatches[48] = false;
            else
                anyMatches[48] = true;

            if (match50 == null)
                anyMatches[49] = false;
            else
                anyMatches[49] = true;

            if (match51 == null)
                anyMatches[50] = false;
            else
                anyMatches[50] = true;

            if (match52 == null)
                anyMatches[51] = false;
            else
                anyMatches[51] = true;

            return anyMatches;
        }
        public void Save()
        {

        }
    }
}