using Business.Abstracts;
using DataAccess.Abstract;
using Entities.Concretes;

namespace Business.Concretes
{
	public class CategoryManager : ICategoryService
	{
		private readonly ICategoryDal _categoryDal;

		public CategoryManager(ICategoryDal categoryDal)
		{
			_categoryDal = categoryDal;
		}

		public void Add(Category category)
		{
			_categoryDal.Add(category);
		}

		public void Delete(int id)
		{
			Category? category = _categoryDal.Get(id);
			if (category == null)
			{
				throw new Exception("İlgili id'ye sahip ürün mevcut değil.");
			}
			_categoryDal.Delete(category);

		}

		public Category Get(int id)
		{
			return _categoryDal.Get(id);
		}

		public List<Category> GetAll()
		{
			return _categoryDal.GetAll();
		}

		public Category GetById(int id)
		{
			Category? category = _categoryDal.Get(id);
			if (category == null)
			{
				throw new Exception("İlgili id'ye sahip ürün mevcut değil.");
			}
			return category;
		}

		public void Update(Category category)
		{
			_categoryDal.Update(category);
		}
	}
}
