using IMS.CoreBusiness.Entities;

namespace IMS.UseCases.Products.Interfaces
{
	public interface IEditProductUseCase
	{
		Task ExecuteAsync(Product product);
	}
}
