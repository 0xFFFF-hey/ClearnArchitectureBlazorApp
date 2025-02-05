using IMS.CoreBusiness.Entities;

namespace IMS.UseCases.Inventories.Interfaces
{
	public interface IViewInventoryByIdUseCase
	{
		Task<Inventory> ExecuteAsync(int InventoryId);
	}
}
