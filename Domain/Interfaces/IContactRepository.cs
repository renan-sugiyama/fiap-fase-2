
using Domain.Aggregates.ContactAggregate;

namespace Domain.Interfaces;

public interface IContactRepository
{
    Task<List<Contact>> GetContacts();
    Task CreateContact(Contact contact);
}