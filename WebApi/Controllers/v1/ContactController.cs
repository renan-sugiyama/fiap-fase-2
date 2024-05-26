using Application.UseCases.Contact.Commands.CreateContact;
using Application.UseCases.Contact.Queries.GetContacts;
using Domain.Common;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;


[ApiController]
[Route( "[controller]" )]
public class ContactController(IMediator mediator) : ControllerBase
{
   
    [HttpPost("search")]
    public async Task<IActionResult> GetContacts([FromBody] SearchRequest searchRequest, CancellationToken cancellationToken)
    {
        var result = await mediator.Send(new GetContactsQuery(searchRequest), cancellationToken);
        return Ok(result);
    }
    
    [HttpPost()]
    public async Task<IActionResult> CreateContact([FromBody] CreateContactCommand createContactCommand, CancellationToken cancellationToken)
    {
        var result = await mediator.Send(createContactCommand, cancellationToken);
        return Ok(result);
    }
}