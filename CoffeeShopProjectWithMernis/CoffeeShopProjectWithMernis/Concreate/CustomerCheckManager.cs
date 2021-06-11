using System;
using System.Collections.Generic;
using System.Text;
using CoffeeShopProjectWithMernis.Abstract;
using CoffeeShopProjectWithMernis.Entities;
using MernisServiceReference;

namespace CoffeeShopProjectWithMernis.Concreate
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;

        }
    }
}