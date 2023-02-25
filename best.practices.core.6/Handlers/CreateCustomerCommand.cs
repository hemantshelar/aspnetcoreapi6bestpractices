using best.practices.core._6.ApiDto;
using best.practices.core._6.Interfaces;
using MediatR;
using System.Diagnostics.CodeAnalysis;

namespace best.practices.core._6.Handlers
{
	public class CreateCustomerCommand : IRequest<CustomerDTO>
	{
		public CreateCustomerCommand(string name, string twitterHandle)
		{
			this.Name = name;
			this.TwitterHandle = twitterHandle;
		}

		public string Name { get; private set; }
		public string TwitterHandle { get; private set; }
	}


	public class CreateCustomerHandler : IRequestHandler<CreateCustomerCommand,CustomerDTO>
	{
		private ICustomerService _customerService;

		public CreateCustomerHandler(ICustomerService customerService)
		{
			_customerService = customerService;

		}
		public async Task<CustomerDTO> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
		{
			Console.WriteLine("Handling request");
			CustomerDTO result = null;
			var input = new CustomerDTO
			{
				Name = request.Name,
				TwitterHandle = request.TwitterHandle
			};
			result = await _customerService.CreateAndSave(input,cancellationToken);
			return result;
		}
	}

}
