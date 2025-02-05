using IMS.CoreBusiness.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases.PluginInterfaces
{
    public interface IInventoryRepository
    {
        Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name);
		Task<Inventory> GetInventoriesByIdAsync(int id);
		Task AddInventoryAsync(Inventory inventory);
		Task UpdateInventoryAsync(Inventory inventory);
		Task DeleteInventoryByIdAsync(int id);
	}
}
