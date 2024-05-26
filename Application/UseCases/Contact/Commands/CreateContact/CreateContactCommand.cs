using Application.Common.Models;
using MediatR;

namespace Application.UseCases.Contact.Commands.CreateContact;

public record CreateContactCommand(CreateContactInputDto Contact) : IRequest<CreateContactResponse>;