namespace Play.Catalog.Service.Settings
{
    public class MongoDbSettings
    {
        // TODO: init olduktan sonra değer değişmesin diye set yerine init yazdık
        public string Host { get; init; }
        public int Port { get; init; }
        public string ConnectionString => $"mongodb://{Host}:{Port}";
    }
}