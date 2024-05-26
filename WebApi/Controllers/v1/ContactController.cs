using Application.UseCases.Contact.Queries.GetContacts;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;


[ApiController]
[Route( "[controller]" )]
public class ContactController(IMediator mediator) : ControllerBase
{
   
    [HttpGet()]
    public async Task<IActionResult> GetContacts(CancellationToken cancellationToken)
    {
        var query = new GetContactsQuery();
        var result = await mediator.Send(query, cancellationToken);
        return Ok(result);
    }
}