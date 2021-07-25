using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Individual customer1 = new Individual();
            customer1.Id = 1;
            customer1.CustomerNumber = "123456789";
            customer1.FirstName = "Emre";
            customer1.LastName = "ONER";
            customer1.IdentityNumber = "12345678910";

            Corporate customer2 = new Corporate();
            customer2.Id = 2;
            customer2.CustomerNumber = "213456789";
            customer2.CompanyName = "ONER SSC";
            customer2.TaxNo = "123456789";

            Customer customer3 = new Individual();
            Customer customer4 = new Corporate();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            




            //Sirket adi bireysel musteriye ait olabilecek bir alan degil, eger nesne duzgun olusturulmaz ise 
            //zamanla bu alanlara yanlis veri girilmis olabilir
            //customer1.CompanyName=
            //Gercek musteri - Tuzel musteri
            //SOLID
        }
    }
}
