using Shuffle.DAL;
using Shuffle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using MongoDB.Bson;
using System.Web.Security;
using MongoDB.AspNet.Identity;


namespace Shuffle.Controllers
{
    public class DeckController : Controller
    {
        private static readonly IDeckRepository _decks = new DeckRepository("");
        private string[] array = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", 
                "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40" ,
                "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52"};
        private Random r = new Random();
        // GET: Deck
        UserStore<ApplicationUser> myuser = new UserStore<ApplicationUser>("Shuffle");

        public ActionResult Index()
        {
            //myuser.FindByIdAsync
            return View();
        }

        public IQueryable<Deck> Get()
        {
            return _decks.getAllDecks().AsQueryable();
        }

        public Deck get(string id)
        {
            Deck deck = _decks.getDeck(id);
            if (deck == null)
            {

            }
            return deck;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create()
        {
            if (User.Identity.IsAuthenticated)
            {
                bool match = false;

                r.Shuffle(array);
                match = _decks.isMatchDeck(array);
                string[] parts = getDeckParts(array);
                _decks.addDeck(makeDeck(User.Identity.GetUserId().ToString(), parts));
                //ApplicationUser user = await myuser.FindByIdAsync(User.Identity.GetUserId().ToString());

                /*while (match != true) {
                    array2 = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", 
                    "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40" ,
                    "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52"};
                    r.Shuffle(array2);
                    match = _decks.isMatchDeck(array2);
                    Deck deck = new Deck { Id = ObjectId.GenerateNewId().ToString(), userID = User.Identity.GetUserId().ToString(), deck = array2 };
                    _decks.addDeck(deck);
                }*/
                return View();
            }
            else
            {
                return View();
            }

        }

        public string[] getDeckParts(string[] deck)
        {
            string[] deckParts = new string[52];
            for (int i = 0; i < deck.Length; i++)
            {
                if (i == 0)
                    deckParts[i] = deck[i];
                else
                    deckParts[i] = deckParts[i - 1] + "," + deck[i];
            }
            return deckParts;

        }

        public Deck makeDeck(string userid, string[] parts)
        {
            return new Deck
            {
                Id = ObjectId.GenerateNewId().ToString(),
                userID = userid,
                part1 = parts[0],
                part2 = parts[1],
                part3 = parts[2],
                part4 = parts[3],
                part5 = parts[4],
                part6 = parts[5],
                part7 = parts[6],
                part8 = parts[7],
                part9 = parts[8],
                part10 = parts[9],
                part11 = parts[10],
                part12 = parts[11],
                part13 = parts[12],
                part14 = parts[13],
                part15 = parts[14],
                part16 = parts[15],
                part17 = parts[16],
                part18 = parts[17],
                part19 = parts[18],
                part20 = parts[19],
                part21 = parts[20],
                part22 = parts[21],
                part23 = parts[22],
                part24 = parts[23],
                part25 = parts[24],
                part26 = parts[25],
                part27 = parts[26],
                part28 = parts[27],
                part29 = parts[28],
                part30 = parts[29],
                part31 = parts[30],
                part32 = parts[31],
                part33 = parts[32],
                part34 = parts[33],
                part35 = parts[34],
                part36 = parts[35],
                part37 = parts[36],
                part38 = parts[37],
                part39 = parts[38],
                part40 = parts[39],
                part41 = parts[40],
                part42 = parts[41],
                part43 = parts[42],
                part44 = parts[43],
                part45 = parts[44],
                part46 = parts[45],
                part47 = parts[46],
                part48 = parts[47],
                part49 = parts[48],
                part50 = parts[49],
                part51 = parts[50],
                part52 = parts[51]
            };
        }


    }

    static class RandomExtensions
    {
        public static void Shuffle<T>(this Random rng, T[] array)
        {
            int n = array.Length;
            while (n > 1)
            {
                int k = rng.Next(n--);
                T temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }
    }
}