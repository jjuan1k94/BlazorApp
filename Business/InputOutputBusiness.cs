using System;
using System.Collections.Generic;
using System.Linq;
using Entities;
using DataAccess;
using Business.Interfaces;


namespace Business
{
    public class InputOutputBusiness : ICrud<InputOutputEntity>
    {
        public List<InputOutputEntity> GetItems()
        {
            using(var dbContext = new InventoryContext())
            {
                return dbContext.LogsIO.ToList();
            }
        }
        public void CreateItem(InputOutputEntity item)
        {
            using(var dbContext = new InventoryContext())
            {
                dbContext.LogsIO.Add(item);
                dbContext.SaveChanges();
            }
        }

        public void UpdateItem(InputOutputEntity item)
        {
            using(var dbContext = new InventoryContext())
            {
                dbContext.LogsIO.Update(item);
                dbContext.SaveChanges();
            }
        }
        public void DeleteItem(InputOutputEntity item)
        {
            throw new NotImplementedException();
        }

        

        
    }
}
