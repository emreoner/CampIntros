using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager baseCustomerManager = new StarbucksCustomerManager(new MernisServiceAdapter());

            baseCustomerManager.Save(new Customer
            {
                Id = 1,
                FirstName = "EMRE",
                LastName = "ÖNER",
                DateOfBirth = new DateTime(1989, 6, 5),
                IdentityNumber = "51730724414"
            });
        }
    }
}
