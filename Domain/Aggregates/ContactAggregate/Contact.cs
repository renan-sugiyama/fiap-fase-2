using Domain.Aggregates.ContactAggregate.ValueObjects;

namespace Domain.Aggregates.ContactAggregate;

public class Contact : IAggregate
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<Email> Emails { get; set; }
    public List<PhoneNumber> PhoneNumbers { get; set; }
    
    
}