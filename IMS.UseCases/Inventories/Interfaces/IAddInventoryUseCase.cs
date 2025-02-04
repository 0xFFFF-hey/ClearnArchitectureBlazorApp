using IMS.CoreBusiness;
using IMS.CoreBusiness.Entities;
using IMS.UseCases.Inventories.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases.Inventories.Interfaces
{
	public interface IAddInventoryUseCase
	{
		Task ExecuteAsync(Inventory inventory);
	}
}
