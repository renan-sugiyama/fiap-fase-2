using Domain.Common;
using MediatR;

namespace Application.UseCases.Contact.Queries.GetContacts;

public record GetContactsQuery(SearchRequest SearchRequest) : IRequest<GetContactsResponse>;