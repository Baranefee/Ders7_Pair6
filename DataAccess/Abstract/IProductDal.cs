using Entities.Concretes;

namespace DataAccess.Abstract
{
	public interface IProductDal
	{
		void Add(Product product);
		void Delete(Product product);
		void Update(Product product);
		List<Product> GetAll();
		Product Get(int id);
	}
}
