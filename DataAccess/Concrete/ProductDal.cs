using DataAccess.Abstract;
using DataAccess.Contexts.EntityFramework;
using Entities.Concretes;

namespace DataAccess.Concrete
{
	public class ProductDal : IProductDal
	{
		public void Add(Product product)
		{
			using (PairContext context = new PairContext())
			{
				context.Products.Add(product);
				context.SaveChanges();
			}	
		}

		public void Delete(Product product)
		{
			using (PairContext context = new PairContext())
			{
				context.Products.Remove(product);
				context.SaveChanges();
			}
		}

		public Product Get(int id)
		{
			using (PairContext context = new PairContext())
			{
				return context.Products.FirstOrDefault(x => x.ProductId == id);
			}
		}

		public List<Product> GetAll()
		{
			using (PairContext context = new PairContext())
			{
				return context.Products.ToList();
			}
		}

		public void Update(Product product)
		{
			using (PairContext context = new PairContext())
			{
				context.Products.Update(product);
				context.SaveChanges();
			}
		}
	}
}
