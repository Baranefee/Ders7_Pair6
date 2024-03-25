using Business.Abstracts;
using DataAccess.Abstract;
using Entities.Concretes;

namespace Business.Concretes
{
	public class ProductManager : IProductService
	{
		private readonly IProductDal _productDal;

		public ProductManager(IProductDal productDal)
		{
			_productDal = productDal;
		}

		public void Add(Product product)
		{
			_productDal.Add(product);
		}

		public void Delete(int id)
		{
			Product? product = _productDal.Get(id);
			if (product == null)
			{
				throw new Exception("İlgili id'ye sahip ürün mevcut değil.");
			}
			_productDal.Delete(product);
		
		}

		public List<Product> GetAll()
		{
			return _productDal.GetAll();
		}

		public Product GetById(int id)
		{
			Product? product = _productDal.Get(id);
			if (product == null)
			{
				throw new Exception("İlgili id'ye sahip ürün mevcut değil.");
			}
			return product;
		}

		public void Update(Product product)
		{
			_productDal.Update(product);
		}
	}
}
