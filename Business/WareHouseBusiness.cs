using Business.Interfaces;
using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class WareHouseBusiness : ICrud<WareHouseEntity>
    {
        private InventoryContext dbContext = null;
        public List<WareHouseEntity> GetItems()
        {
            using (dbContext = new InventoryContext())
            {
                return dbContext.WareHouses.ToList();
            }
        }
        public void UpdateItem(WareHouseEntity item)
        {
            using (dbContext = new InventoryContext())
            {
                dbContext.WareHouses.Add(item);
                dbContext.SaveChanges();

            }
        }
        public void CreateItem(WareHouseEntity item)
        {
            using (dbContext = new InventoryContext())
            {
                dbContext.WareHouses.Update(item);
                dbContext.SaveChanges();

            }
        }

        public void DeleteItem(WareHouseEntity item)
        {
            throw new NotImplementedException();
        }



    }
}
