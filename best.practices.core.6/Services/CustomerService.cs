using best.practices.core._6.ApiDto;
using best.practices.core._6.Interfaces;

namespace best.practices.core._6.Services
{
	public class CustomerService: ICustomerService
	{
		public CustomerService()
		{

			//Additional dependencies can go here...

		}

		public async Task<CustomerDTO> CreateAndSave(CustomerDTO customerDTO, CancellationToken cancellationToken)
		{
			await Task.Factory.StartNew(() =>
			{
				Console.WriteLine("Simulating Save...");
				Thread.Sleep(5000);
				Console.WriteLine("Save completed...");
			});

			return customerDTO;
		}
	}
}
