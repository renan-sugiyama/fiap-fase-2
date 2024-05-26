using Domain.Aggregates.ContactAggregate.Enums;

namespace Domain.Aggregates.ContactAggregate.ValueObjects;

public class Email
{
    public required string Address { get; set; }
    public EmailAddressType Type { get; set; }
}