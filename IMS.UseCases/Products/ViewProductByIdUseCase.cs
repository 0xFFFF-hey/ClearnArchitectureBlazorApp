using IMS.CoreBusiness.Entities;
using IMS.UseCases.PluginInterfaces;
using IMS.UseCases.Products.Interfaces;

namespace IMS.UseCases.Products
{
	public class ViewProductByIdUseCase : IViewProductByIdUseCase
	{
		private readonly IProductRepository productRepository;

		public ViewProductByIdUseCase(IProductRepository productRepository)
		{
			this.productRepository = productRepository;
		}

		public async Task<Product?> ExecuteAsync(int productId)
		{
			return await this.productRepository.GetProductByIdAsync(productId);
		}
	}
}
