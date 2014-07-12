using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.GridFS;
using MongoDB.Driver.Linq;
namespace Shuffle.Models
{
    public class Deck
    {
        [BsonId]
        public string Id { get; set; }
        public string[] deck { get; set; }
        public string userID { get; set;}
    }

    

    


    public class MongoDBEntities : ApplicationDbContext
    {

    }
}