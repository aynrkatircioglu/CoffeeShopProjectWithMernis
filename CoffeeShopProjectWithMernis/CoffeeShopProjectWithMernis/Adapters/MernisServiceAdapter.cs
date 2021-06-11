using System;
using System.Collections.Generic;
using System.Text;
using CoffeeShopProjectWithMernis.Abstract;
using CoffeeShopProjectWithMernis.Entities;
using MernisServiceReference;

namespace CoffeeShopProjectWithMernis.Adapters
{
    class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {


            MernisServiceReference.KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(
                customer.NationalityId, customer.FirstName.ToUpper(),
                customer.LastName.ToUpper(), customer.DateOfBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}