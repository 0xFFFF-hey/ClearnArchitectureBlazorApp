using IMS.CoreBusiness.Entities;

namespace IMS.UseCases.Inventories.Interfaces
{
	public interface IViewInventoriesByIdUseCase
	{
		Task<Inventory> ExecuteAsync(int InventoryId);
	}
}
