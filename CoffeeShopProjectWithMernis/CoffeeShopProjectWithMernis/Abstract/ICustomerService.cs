using System;
using System.Collections.Generic;
using System.Text;
using CoffeeShopProjectWithMernis.Entities;


namespace CoffeeShopProjectWithMernis.Abstract
{
    public interface ICustomerService
    { 
        void Save(Customer customer);
    }
}
