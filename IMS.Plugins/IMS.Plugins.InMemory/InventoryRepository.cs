using IMS.CoreBusiness.Entities;
using IMS.UseCases.PluginInterfaces;

namespace IMS.Plugins.InMemory
{
    public class InventoryRepository : IInventoryRepository
    {
        private List<Inventory> _inventories;
        public InventoryRepository()
        {
            _inventories = new List<Inventory>
            {
                new Inventory {InventoryId = 1, InventoryName = "Bike Seat", Quantity = 10, Price = 2},
                new Inventory {InventoryId = 2, InventoryName = "Bike Frame", Quantity = 5, Price = 20},
                new Inventory {InventoryId = 3, InventoryName = "Bike Tire", Quantity = 15, Price = 5},
                new Inventory {InventoryId = 4, InventoryName = "Bike Pedal", Quantity = 8, Price = 3},
                new Inventory {InventoryId = 5, InventoryName = "Bike Chain", Quantity = 12, Price = 4},
                new Inventory {InventoryId = 6, InventoryName = "Helmet", Quantity = 20, Price = 15},
                new Inventory {InventoryId = 7, InventoryName = "Bike Lock", Quantity = 30, Price = 8},
                new Inventory {InventoryId = 8, InventoryName = "Water Bottle", Quantity = 25, Price = 2},
                new Inventory {InventoryId = 9, InventoryName = "Bike Light", Quantity = 18, Price = 6},
                new Inventory {InventoryId = 10, InventoryName = "Handlebar Grip", Quantity = 22, Price = 3}
            };

        }

		public Task AddInventoryAsync(Inventory inventory)
		{
			if (_inventories.Any(x => x.InventoryName.Equals(inventory.InventoryName, StringComparison.OrdinalIgnoreCase)))
		            { return Task.CompletedTask; }
		
		            var maxId = _inventories.Max(x => x.InventoryId);
		            inventory.InventoryId = maxId + 1;
		
		            _inventories.Add(inventory);
		
		            return Task.CompletedTask;
		}

		public async Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name)
        {
            if(string.IsNullOrEmpty(name)) return await Task.FromResult(_inventories);
            return _inventories.Where(x => x.InventoryName.Contains(name, 
                StringComparison.OrdinalIgnoreCase));
        }

		public Task UpdateInventoryAsync(Inventory inventory)
		{
			throw new NotImplementedException();
		}

		public Task DeleteInventoryAsync(int id)
		{
			throw new NotImplementedException();
		}
	}
}
