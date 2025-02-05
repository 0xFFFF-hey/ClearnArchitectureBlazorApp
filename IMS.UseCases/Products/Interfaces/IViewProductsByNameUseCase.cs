using IMS.CoreBusiness.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases.Products.Interfaces
{
	public interface IViewProductsByNameUseCase
	{
		Task<IEnumerable<Product>> ExecuteAsync(string name = "");
	}
}
