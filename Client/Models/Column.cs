using System.Collections.Generic;

namespace Client.Models {
    public class Column {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Card> Cards { get; set; } = new List<Card>();
    }
}