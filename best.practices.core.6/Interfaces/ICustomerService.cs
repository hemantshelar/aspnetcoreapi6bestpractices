using best.practices.core._6.ApiDto;

namespace best.practices.core._6.Interfaces
{
    public interface ICustomerService
    {
        Task<CustomerDTO> CreateAndSave(CustomerDTO customerDTO,CancellationToken cancellationToken);
    }
}
