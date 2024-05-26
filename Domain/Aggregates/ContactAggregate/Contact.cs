namespace Domain.Aggregates.Aggregates.ContactAggregate;

public class Contact : IAggregate
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    
}