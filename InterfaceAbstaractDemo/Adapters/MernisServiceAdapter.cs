using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            var result = GetResult(customer).Result.Body.TCKimlikNoDogrulaResult;
            return result;
        }

        private async Task<TCKimlikNoDogrulaResponse> GetResult(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.IdentityNumber), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year).Result;
        }
    }
}
