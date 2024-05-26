using AutoMapper;
using Domain.Interfaces;
using MediatR;

namespace Application.UseCases.Contact.Commands.CreateContact;

public class CreateContactHandler(IContactRepository contactRepository, IMapper mapper) : IRequestHandler<CreateContactCommand, CreateContactResponse>
{
    public async Task<CreateContactResponse> Handle(CreateContactCommand request, CancellationToken cancellationToken)
    {
        var contact = mapper.Map<Domain.Aggregates.ContactAggregate.Contact>(request.Contact);
        await contactRepository.CreateContact(contact);
        return new CreateContactResponse();
    }
}