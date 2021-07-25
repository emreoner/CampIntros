using HWGameAutomation.Abstract;
using HWGameAutomation.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HWGameAutomation.Adapters
{
    public class MernisServiceAdapter : ICheckRealPersonService
    {
        public bool CheckIfRealPerson(Person customer)
        {
            var result = GetResult(customer).Result.Body.TCKimlikNoDogrulaResult;
            return result;
        }

        private async Task<TCKimlikNoDogrulaResponse> GetResult(Person customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.IdentityNumber), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year).Result;
        }
    }
}
