namespace GameShopPrototype
{
    public class GameModel
    {
        public int ID {  get; set; }
        public string Title { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public string Rating {  get; set; } = string.Empty;
        public bool IsCompleted { get; set; } = false;

        public GameModel() { }
        public GameModel(int iD, string title, string genre, string rating)
        {
            ID = iD;
            Title = title;
            Genre = genre;
            Rating = rating;
        }
    }
}
