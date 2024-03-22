using Business.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CategoryManager:ICategoryService
    {
        private List<Category> categories;
        public CategoryManager()
        {
            categories = new List<Category>();
            categories.Add(new Category() {  CategoryId = 1, Name = "Giysi" });
            categories.Add(new Category() {  CategoryId = 2, Name = "Ev esyalari" });
        }
        public Category Add(Category category)
        {
            categories.Add(category);

            return category;
        }

        public void Delete(int id)
        {
            Category category = categories.Find(c => c.CategoryId == id);
            if (category == null)
            {
                throw new Exception("Kategori bulunamadi");

            }

            categories.Remove(category);
        }

        public List<Category> GetAll()
        {
            return categories;
        }

        public Category GetById(int id)
        {
            Category category = categories.Find(c => c.CategoryId == id);
            if (category == null)
            {
                throw new Exception("Kategori bulunamadi");

            }

            return category;
        }

        public Category Update(Category category)
        {
            Category checkCategory = categories.Find(c => c.CategoryId == category.CategoryId);
            if (checkCategory == null)
            {
                throw new Exception("Kategori bulunamadi");

            }
            checkCategory.Name = category.Name;
            checkCategory.CategoryId = category.CategoryId;
           

            return checkCategory;

        }
    }
}
