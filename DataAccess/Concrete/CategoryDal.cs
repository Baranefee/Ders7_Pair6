using DataAccess.Abstract;
using DataAccess.Contexts.EntityFramework;
using Entities.Concretes;

namespace DataAccess.Concrete
{
	public class CategoryDal : ICategoryDal
	{
		public void Add(Category category)
		{
			using (PairContext context = new PairContext())
			{
				context.Categories.Add(category);
				context.SaveChanges();
			}
		}

		public void Delete(Category category)
		{
			using (PairContext context = new PairContext())
			{
				context.Categories.Remove(category);
				context.SaveChanges();
			}
		}

		public Category Get(int id)
		{
			using (PairContext context = new PairContext())
			{
				return context.Categories.FirstOrDefault(x => x.CategoryId == id);
			}
		}

		public List<Category> GetAll()
		{
			using (PairContext context = new PairContext())
			{
				return context.Categories.ToList();
			}
		}

		public void Update(Category category)
		{
			using (PairContext context = new PairContext())
			{
				context.Categories.Update(category);
				context.SaveChanges();
			}
		}
	}
}
