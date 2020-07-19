using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    internal interface ICrud<T>
    {
        List<T> GetItems();
        void CreateItem(T item);
        void UpdateItem(T item);
        void DeleteItem(T item);
    }
}
