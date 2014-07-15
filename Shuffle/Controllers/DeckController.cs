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


namespace Shuffle.Controllers
{
    public class DeckController : Controller
    {
        private static readonly IDeckRepository _decks = new DeckRepository("");
        private string[] array = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", 
                "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40" ,
                "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52"};
        // GET: Deck

        public ActionResult Index()
        {
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
            new Random().Shuffle(array);
            Deck deck = new Deck { Id = ObjectId.GenerateNewId().ToString(), userID = User.Identity.GetUserId().ToString(), deck = array};
            _decks.addDeck(deck);
            return View();
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