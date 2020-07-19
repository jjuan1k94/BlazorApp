using System.Collections.Generic;
using System.Linq;
using Entities;
using DataAccess;
using Business.Interfaces;

namespace Business
{
    public class CategoryBusiness: ICrud<CategoryEntity>
    {
        public List<CategoryEntity> GetItems()
        {
            using(var dbContext = new InventoryContext())
            {
                return dbContext.Categories.ToList();
            }
        }
        public void CreateItem(CategoryEntity item)
        {
            using (var dbContext = new InventoryContext())
            {
                dbContext.Categories.Add(item);
                dbContext.SaveChanges();
            }
        }
        public void UpdateItem(CategoryEntity item)
        {
            using(var dbContext = new InventoryContext())
            {
                dbContext.Update(item);
                dbContext.SaveChanges();
            }
        }
        public void DeleteItem(CategoryEntity item)
        {
            throw new System.NotImplementedException();
        }
    }
}
