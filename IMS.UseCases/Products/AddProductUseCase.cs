using IMS.CoreBusiness.Entities;
using IMS.UseCases.PluginInterfaces;
using IMS.UseCases.Products.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases.Products
{
	public class AddProductUseCase : IAddProductUseCase
	{
		private IProductRepository _productRepository;
        public AddProductUseCase(IProductRepository productRepository)
        {
			_productRepository = productRepository;
		}
		public async Task ExecuteAsync(Product product)
		{
			await this._productRepository.AddProductAsync(product);
		}
	}
}
