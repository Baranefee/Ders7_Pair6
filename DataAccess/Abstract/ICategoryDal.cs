using Entities.Concretes;

namespace DataAccess.Abstract
{
	public interface ICategoryDal
	{
		void Add(Category category);
		void Delete(Category category);
		void Update(Category category);
		List<Category> GetAll();
		Category Get(int id);
	}
}
