using Domain.Aggregates.ContactAggregate.Enums;

namespace Domain.Aggregates.ContactAggregate.ValueObjects;

public class PhoneNumber
{
    public required string Value { get; set; }
    public required string AreaCode { get; set; }
    public required string CountryCode { get; set; }
    public PhoneType Type { get; set; }
}