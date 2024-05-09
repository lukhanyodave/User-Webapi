using Application.DTOs.User;
using Application.Features.User.Handlers.QueryHandlers;
using Application.Features.User.Request.Commands;
using Application.Features.User.Request.Queries;
using Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace Client.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IMediator _mediator;
        public UserController(IMediator mediator) => _mediator = mediator;

        [HttpGet]
        public async Task<ActionResult> GetVacancies()
        {
            //var vacancies = await _mediator.Send(new GetAllVacanciesQuery(),default(CancellationToken));
            return Ok();
            //return Ok(vacancies);        
        }


    }
}
