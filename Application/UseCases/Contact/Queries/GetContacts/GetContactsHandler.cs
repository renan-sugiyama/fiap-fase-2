using Domain.Interfaces;
using MediatR;

namespace Application.UseCases.Contact.Queries.GetContacts;

public class GetContactsHandler(IContactRepository contactRepository) : IRequestHandler<GetContactsQuery, GetContactsResponse>
{
    private readonly IContactRepository _contactRepository = contactRepository;
    public async Task<GetContactsResponse> Handle(GetContactsQuery request, CancellationToken cancellationToken)
    {
        var result = await _contactRepository.GetContacts();
        return new GetContactsResponse(result);
    }
}