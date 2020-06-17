namespace Client.Models {
    public class Card {
        public int ID { get; set; }
        public string Name { get; set; }
        public int ColumnID { get; set; }
        public bool IsCompleted { get; set; }
    }
}