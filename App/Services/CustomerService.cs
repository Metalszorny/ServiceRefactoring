using App.Interfaces;
using App.Model;
using System;

namespace App.Services
{
    public class CustomerService : ICustomerService
    {
        private ICompanyRepository companyRepository;
        private ICustomerCreditService customerCreditService;

        public CustomerService(ICompanyRepository companyRepository, ICustomerCreditService customerCreditService)
        {
            this.companyRepository = companyRepository;
            this.customerCreditService = customerCreditService;
        }

        ~CustomerService()
        {
            this.companyRepository = null;
            this.customerCreditService = null;
        }

        public bool AddCustomer(int companyId, Customer customer, Action<Customer> AddCustomer)
        {
            if (!this.ValidateCustomer(customer))
            {
                return false;
            }

            var company = this.companyRepository.GetById(companyId);
            customer.Company = company;
            this.SetCustomerCreditLimit(customer, company);

            if (customer.HasCreditLimit && customer.CreditLimit < 500)
            {
                return false;
            }

            AddCustomer(customer);

            return true;
        }

        private bool ValidateCustomer(Customer customer)
        {
            if (customer == null)
            {
                return false;
            }

            if (string.IsNullOrEmpty(customer.Firstname) || string.IsNullOrEmpty(customer.Surname))
            {
                return false;
            }

            if (!customer.EmailAddress.Contains("@") || !customer.EmailAddress.Contains("."))
            {
                return false;
            }

            var now = DateTime.Now;
            int age = now.Year - customer.DateOfBirth.Year;

            if (now.Month < customer.DateOfBirth.Month || (now.Month == customer.DateOfBirth.Month && now.Day < customer.DateOfBirth.Day))
            {
                age--;
            }

            if (age < 21 || age > 120)
            {
                return false;
            }

            return true;
        }

        private void SetCustomerCreditLimit(Customer customer, Company company)
        {
            if (company.Name == "VeryImportantClient")
            {
                // Skip credit check
                customer.HasCreditLimit = false;
            }
            else if (company.Name == "ImportantClient")
            {
                // Do credit check and double credit limit
                customer.HasCreditLimit = true;
                customer.CreditLimit = this.customerCreditService.GetCreditLimit(customer.Firstname, customer.Surname, customer.DateOfBirth);
                customer.CreditLimit *= 2;
            }
            else
            {
                // Do credit check
                customer.HasCreditLimit = true;
                customer.CreditLimit = this.customerCreditService.GetCreditLimit(customer.Firstname, customer.Surname, customer.DateOfBirth);
            }
        }
    }
}
