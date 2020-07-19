using Business.Interfaces;
using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Business
{
    public class StorageBusiness : ICrud<StorageEntity>
    {
        public List<StorageEntity> GetItems()
        {
            using(var dbContext = new InventoryContext())
            {
                return dbContext.Storages.ToList();
            }
        }
        public  List<StorageEntity> GetItemsByWareHouseId(string wareHouseId)
        {
            using (var dbContext = new InventoryContext())
            {
                return dbContext.Storages
                    .Include(f => f.Product)
                    .Include(f => f.WareHouse)
                    .Where(f => f.WareHouseId == wareHouseId)
                    .ToList();
            }
        }
        public void CreateItem(StorageEntity item)
        {
            using(var dbContext = new InventoryContext())
            {
                dbContext.Storages.Add(item);
                dbContext.SaveChanges();
            }
        }
        public void UpdateItem(StorageEntity item)
        {
            using (var dbContext = new InventoryContext())
            {
                dbContext.Storages.Update(item);
                dbContext.SaveChanges();
            }
        }
        public void DeleteItem(StorageEntity item)
        {
            throw new NotImplementedException();
        }
        public bool ProductAlreadyExists(string productId,string wareHouseId)
        {
            using(var dbContext = new InventoryContext())
            {
                var product = dbContext.Storages
                    .FirstOrDefault(f => f.ProductId == productId && f.WareHouseId == wareHouseId);
                return product != null ? true : false;

            }
        }
    }
}
