using MediatR;

namespace Application.UseCases.Contact.Queries.GetContacts;

public class GetContactsHandler : IRequestHandler<GetContactsQuery, GetContactsResponse>
{
    public async Task<GetContactsResponse> Handle(GetContactsQuery request, CancellationToken cancellationToken)
    {
        return await Task.FromResult(new GetContactsResponse());
    }
}