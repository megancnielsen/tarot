namespace  cSharpTarot.Models
{
    public class TarotDbSettings : ITarotDbSettings
    {
        public string TarotCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface ITarotDbSettings
    {
        string TarotCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}