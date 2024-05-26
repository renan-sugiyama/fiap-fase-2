namespace Application.UseCases.Contact.Queries.GetContacts;

public record GetContactsResponse(List<Domain.Aggregates.ContactAggregate.Contact> Contacts);