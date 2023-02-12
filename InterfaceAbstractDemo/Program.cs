using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //BaseCustomerManager customerManager = new NeroCustomerManager();
            //customerManager.Save(new Customer { DateOfBirth= new System.DateTime(1993,9,25), FirstName= "Bilge", LastName="Yılmaz", NationalityId="***********});

            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth= new System.DateTime(1993,9,25), FirstName= "Bilge", LastName="Yılmaz", NationalityId="***********"});
            Console.ReadLine();
        }
    }
}
