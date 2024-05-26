using MongoDB.Driver;

namespace WebApi.Configuration;

public static class MongoDBSettings
{
    public static void AddMongoDB(this IServiceCollection services, IConfiguration configuration)
    {
        var mongoClient = new MongoClient(configuration["ConnectionStrings:MongoDB"]);
        var database = mongoClient.GetDatabase("ContactDB");
        services.AddSingleton(database);
    }
}