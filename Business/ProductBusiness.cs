using Business.Interfaces;
using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class ProductBusiness : ICrud<ProductEntity>
    {
        public List<ProductEntity> GetItems()
        {
            using (var dbContext = new InventoryContext())
            {
                return dbContext.Products.ToList();
            }
        }
        public void CreateItem(ProductEntity item)
        {
            using (var dbContext = new InventoryContext())
            {

                dbContext.Products.Add(item);
                dbContext.SaveChanges();
            }
        }
        public void UpdateItem(ProductEntity item)
        {
            using (var dbContext = new InventoryContext())
            {
                dbContext.Update(item);
                dbContext.SaveChanges();
            }
        }
        public void DeleteItem(ProductEntity item)
        {
            throw new NotImplementedException();
        }

    }
}
