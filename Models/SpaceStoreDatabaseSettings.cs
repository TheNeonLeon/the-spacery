namespace the_spacery.Models
{
    public class SpaceStoreDatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;
        public string DatabaseName { get; set; } = null!;
        public string SpaceCollectionName { get; set; } = null!;
    }
}
