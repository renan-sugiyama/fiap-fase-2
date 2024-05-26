using Domain.Aggregates.ContactAggregate;
using Domain.Interfaces;
using MongoDB.Driver;

namespace Infrastructure.Persistence;

public class ContactMongoDbRepository(IMongoDatabase db) : IContactRepository
{
    private readonly IMongoCollection<Contact> _collection = db.GetCollection<Contact>(nameof(Contact));

    public async Task<List<Contact>> GetContacts()
    {
        return await _collection.Find(_ => true).ToListAsync();
    }
    
    public async Task CreateContact(Contact contact)
    {
        await _collection.InsertOneAsync(contact);
    }
}