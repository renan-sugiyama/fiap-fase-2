using MediatR;

namespace Application.UseCases.Contact.Queries.GetContacts;

public record GetContactsQuery() : IRequest<GetContactsResponse>;