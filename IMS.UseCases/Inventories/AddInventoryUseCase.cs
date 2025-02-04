using IMS.CoreBusiness.Entities;
using IMS.UseCases.Inventories.DTOs;
using IMS.UseCases.Inventories.Interfaces;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases.Inventories
{
    internal class AddInventoryUseCase : IAddInventoryUseCase
    {
        private readonly IInventoryRepository _inventoryRepository;
        public AddInventoryUseCase(IInventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;

        }
		public async Task ExecuteAsync(Inventory inventory)
        {
            await this._inventoryRepository.AddInventoryAsync(inventory);
        }
    }
}
