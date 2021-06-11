using System;
using System.Collections.Generic;
using System.Text;
using CoffeeShopProjectWithMernis.Entities;

namespace CoffeeShopProjectWithMernis.Abstract
{
    public interface ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
