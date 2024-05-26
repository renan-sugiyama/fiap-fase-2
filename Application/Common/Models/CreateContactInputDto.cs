using System.ComponentModel.DataAnnotations;
using Domain.Aggregates.ContactAggregate.ValueObjects;

namespace Application.Common.Models;

public class CreateContactInputDto(string name, List<Email> emails, List<PhoneNumber> phoneNumbers)
{
    [MinLength(3, ErrorMessage = "Name must have at least 3 characters")]
    public string Name { get; init; } = name;
    
    [MinLength(1, ErrorMessage = "Email cannot be empty")]
    public List<Email> Emails { get; init; } = emails;
    
    [MinLength(1, ErrorMessage = "PhoneNumbers cannot be empty")]
    public List<PhoneNumber> PhoneNumbers { get; init; } = phoneNumbers;
}