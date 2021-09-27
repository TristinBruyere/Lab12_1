using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab12_1.Models
{
    public class Deck
    {
        public bool success { get; set; }
        public string deck_id { get; set; }
        public int remaining { get; set; }
        public bool shuffled { get; set; }
    }
    public class Hand
    {
        public bool success { get; set; }
        public string deck_id { get; set; }
        public List<Cards> cards { get; set; }
        public int remaining { get; set; }
    }
    public class Cards
    {
        public string code { get; set; }
        public string image { get; set; }
        //public List<Images> images { get; set; }
        public string value { get; set; }
        public string suit { get; set; }

    }
    public class Images
    {
        public string svg { get; set; }
        public string png { get; set; }
    }
}
