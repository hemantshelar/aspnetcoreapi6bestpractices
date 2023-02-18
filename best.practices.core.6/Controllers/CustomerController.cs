using best.practices.core._6.ApiDto;
using best.practices.core._6.Handlers;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace best.practices.core._6.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CustomerController : ControllerBase
	{
		public CustomerController(IMediator mediator)
		{
			Mediator = mediator;
		}
		public IMediator Mediator { get; }

		[HttpPost()]
		public async Task<ActionResult<CustomerDTO>> Create(CustomerDTO newCustomer,CancellationToken cancellationToken)
		{

			var cutomerCommand = new CreateCustomerCommand(newCustomer.Name, newCustomer.TwitterHandle);
			var result = await Mediator.Send(cutomerCommand, cancellationToken);
			return Created("xyz", result);

		}
	}
}
