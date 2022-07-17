using App.Model;
using System;

namespace App.Interfaces
{
    public interface ICustomerService
    {
        bool AddCustomer(int companyId, Customer customer, Action<Customer> AddCustomer);
    }
}
