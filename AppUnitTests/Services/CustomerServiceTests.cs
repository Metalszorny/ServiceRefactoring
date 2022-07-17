using App.Enum;
using App.Interfaces;
using App.Model;
using App.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace AppUnitTests.Services
{
    [TestClass]
    public class CustomerServiceTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Customer input = null;
            var companyId = 0;
            Action<Customer> addCustomerDelegate = null;
            var expectedResult = false;
            var customerService = new CustomerService(null, null);

            var actualResult = customerService.AddCustomer(companyId, input, addCustomerDelegate);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var input = new Customer();
            var companyId = 0;
            Action<Customer> addCustomerDelegate = null;
            var expectedResult = false;
            var customerService = new CustomerService(null, null);

            var actualResult = customerService.AddCustomer(companyId, input, addCustomerDelegate);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var input = new Customer()
            {
                Firstname = null,
            };
            var companyId = 0;
            Action<Customer> addCustomerDelegate = null;
            var expectedResult = false;
            var customerService = new CustomerService(null, null);

            var actualResult = customerService.AddCustomer(companyId, input, addCustomerDelegate);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var input = new Customer()
            {
                Firstname = string.Empty,
            };
            var companyId = 0;
            Action<Customer> addCustomerDelegate = null;
            var expectedResult = false;
            var customerService = new CustomerService(null, null);

            var actualResult = customerService.AddCustomer(companyId, input, addCustomerDelegate);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var input = new Customer()
            {
                Firstname = "Test",
                Surname = null,
            };
            var companyId = 0;
            Action<Customer> addCustomerDelegate = null;
            var expectedResult = false;
            var customerService = new CustomerService(null, null);

            var actualResult = customerService.AddCustomer(companyId, input, addCustomerDelegate);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod6()
        {
            var input = new Customer()
            {
                Firstname = "Test",
                Surname = string.Empty,
            };
            var companyId = 0;
            Action<Customer> addCustomerDelegate = null;
            var expectedResult = false;
            var customerService = new CustomerService(null, null);

            var actualResult = customerService.AddCustomer(companyId, input, addCustomerDelegate);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod7()
        {
            var input = new Customer()
            {
                Firstname = " ",
            };
            var companyId = 0;
            Action<Customer> addCustomerDelegate = null;
            var expectedResult = false;
            var customerService = new CustomerService(null, null);

            var actualResult = customerService.AddCustomer(companyId, input, addCustomerDelegate);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod8()
        {
            var input = new Customer()
            {
                Firstname = "Test",
                Surname = " ",
            };
            var companyId = 0;
            Action<Customer> addCustomerDelegate = null;
            var expectedResult = "Object reference not set to an instance of an object.";
            var customerService = new CustomerService(null, null);

            var exception = Assert.ThrowsException<NullReferenceException>(() => customerService.AddCustomer(companyId, input, addCustomerDelegate));

            Assert.AreEqual(expectedResult, exception.Message);
        }

        [TestMethod]
        public void TestMethod9()
        {
            var input = new Customer()
            {
                Firstname = "Test",
                Surname = "Test",
                EmailAddress = null,
            };
            var companyId = 0;
            Action<Customer> addCustomerDelegate = null;
            var expectedResult = "Object reference not set to an instance of an object.";
            var customerService = new CustomerService(null, null);

            var exception = Assert.ThrowsException<NullReferenceException>(() => customerService.AddCustomer(companyId, input, addCustomerDelegate));

            Assert.AreEqual(expectedResult, exception.Message);
        }

        [TestMethod]
        public void TestMethod10()
        {
            var input = new Customer()
            {
                Firstname = "Test",
                Surname = "Test",
                EmailAddress = string.Empty,
            };
            var companyId = 0;
            Action<Customer> addCustomerDelegate = null;
            var expectedResult = false;
            var customerService = new CustomerService(null, null);

            var actualResult = customerService.AddCustomer(companyId, input, addCustomerDelegate);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod11()
        {
            var input = new Customer()
            {
                Firstname = "Test",
                Surname = "Test",
                EmailAddress = " ",
            };
            var companyId = 0;
            Action<Customer> addCustomerDelegate = null;
            var expectedResult = false;
            var customerService = new CustomerService(null, null);

            var actualResult = customerService.AddCustomer(companyId, input, addCustomerDelegate);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod12()
        {
            var input = new Customer()
            {
                Firstname = "Test",
                Surname = "Test",
                EmailAddress = "Test",
            };
            var companyId = 0;
            Action<Customer> addCustomerDelegate = null;
            var expectedResult = false;
            var customerService = new CustomerService(null, null);

            var actualResult = customerService.AddCustomer(companyId, input, addCustomerDelegate);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod13()
        {
            var input = new Customer()
            {
                Firstname = "Test",
                Surname = "Test",
                EmailAddress = "@",
            };
            var companyId = 0;
            Action<Customer> addCustomerDelegate = null;
            var expectedResult = false;
            var customerService = new CustomerService(null, null);

            var actualResult = customerService.AddCustomer(companyId, input, addCustomerDelegate);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod14()
        {
            var input = new Customer()
            {
                Firstname = "Test",
                Surname = "Test",
                EmailAddress = ".",
            };
            var companyId = 0;
            Action<Customer> addCustomerDelegate = null;
            var expectedResult = false;
            var customerService = new CustomerService(null, null);

            var actualResult = customerService.AddCustomer(companyId, input, addCustomerDelegate);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod15()
        {
            var input = new Customer()
            {
                Firstname = "Test",
                Surname = "Test",
                EmailAddress = ".@",
            };
            var companyId = 0;
            Action<Customer> addCustomerDelegate = null;
            var expectedResult = false;
            var customerService = new CustomerService(null, null);

            var actualResult = customerService.AddCustomer(companyId, input, addCustomerDelegate);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod16()
        {
            var input = new Customer()
            {
                Firstname = "Test",
                Surname = "Test",
                EmailAddress = "@.",
            };
            var companyId = 0;
            Action<Customer> addCustomerDelegate = null;
            var expectedResult = false;
            var customerService = new CustomerService(null, null);

            var actualResult = customerService.AddCustomer(companyId, input, addCustomerDelegate);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod17()
        {
            var input = new Customer()
            {
                Firstname = "Test",
                Surname = "Test",
                EmailAddress = "@.",
                DateOfBirth = DateTime.MinValue,
            };
            var companyId = 0;
            Action<Customer> addCustomerDelegate = null;
            var expectedResult = false;
            var customerService = new CustomerService(null, null);

            var actualResult = customerService.AddCustomer(companyId, input, addCustomerDelegate);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod18()
        {
            var input = new Customer()
            {
                Firstname = "Test",
                Surname = "Test",
                EmailAddress = "@.",
                DateOfBirth = DateTime.MaxValue,
            };
            var companyId = 0;
            Action<Customer> addCustomerDelegate = null;
            var expectedResult = false;
            var customerService = new CustomerService(null, null);

            var actualResult = customerService.AddCustomer(companyId, input, addCustomerDelegate);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod19()
        {
            var input = new Customer()
            {
                Firstname = "Test",
                Surname = "Test",
                EmailAddress = "@.",
                DateOfBirth = DateTime.Now,
            };
            var companyId = 0;
            Action<Customer> addCustomerDelegate = null;
            var expectedResult = false;
            var customerService = new CustomerService(null, null);

            var actualResult = customerService.AddCustomer(companyId, input, addCustomerDelegate);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod20()
        {
            var input = new Customer()
            {
                Firstname = "Test",
                Surname = "Test",
                EmailAddress = "@.",
                DateOfBirth = DateTime.Now.AddYears(-21).AddMonths(1),
            };
            var companyId = 0;
            Action<Customer> addCustomerDelegate = null;
            var expectedResult = false;
            var customerService = new CustomerService(null, null);

            var actualResult = customerService.AddCustomer(companyId, input, addCustomerDelegate);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod21()
        {
            var input = new Customer()
            {
                Firstname = "Test",
                Surname = "Test",
                EmailAddress = "@.",
                DateOfBirth = DateTime.Now.AddYears(-21).AddDays(1),
            };
            var companyId = 0;
            Action<Customer> addCustomerDelegate = null;
            var expectedResult = false;
            var customerService = new CustomerService(null, null);

            var actualResult = customerService.AddCustomer(companyId, input, addCustomerDelegate);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod22()
        {
            var input = new Customer()
            {
                Firstname = "Test",
                Surname = "Test",
                EmailAddress = "@.",
                DateOfBirth = DateTime.Now.AddYears(-21),
            };
            var companyId = 0;
            Action<Customer> addCustomerDelegate = null;
            var errorMessage = "Object reference not set to an instance of an object.";
            var customerService = new CustomerService(null, null);

            var exception = Assert.ThrowsException<NullReferenceException>(() => customerService.AddCustomer(companyId, input, addCustomerDelegate));

            Assert.AreEqual(errorMessage, exception.Message);
        }

        [TestMethod]
        public void TestMethod23()
        {
            var input = new Customer()
            {
                Firstname = "Test",
                Surname = "Test",
                EmailAddress = "@.",
                DateOfBirth = DateTime.Now.AddYears(-21),
            };
            var companyId = 0;
            Action<Customer> addCustomerDelegate = null;
            var errorMessage = "Object reference not set to an instance of an object.";
            Company companyData = null;
            var companyRepository = new Mock<ICompanyRepository>();
            companyRepository.Setup(c => c.GetById(companyId)).Returns(companyData);
            var customerService = new CustomerService(companyRepository.Object, null);

            var exception = Assert.ThrowsException<NullReferenceException>(() => customerService.AddCustomer(companyId, input, addCustomerDelegate));

            Assert.AreEqual(errorMessage, exception.Message);
        }

        [TestMethod]
        public void TestMethod24()
        {
            var input = new Customer()
            {
                Firstname = "Test",
                Surname = "Test",
                EmailAddress = "@.",
                DateOfBirth = DateTime.Now.AddYears(-21),
            };
            var companyId = 1;
            var userId = 1;
            Action<Customer> addCustomerDelegate = new Action<Customer>(x => x.Id = userId);
            var expectedResult = true;
            var companyData = new Company()
            {
                Id = companyId,
                Name = "VeryImportantClient",
                Classification = Classification.Gold,
            };
            var companyRepository = new Mock<ICompanyRepository>();
            companyRepository.Setup(c => c.GetById(companyId)).Returns(companyData);
            var customerService = new CustomerService(companyRepository.Object, null);

            var actualResult = customerService.AddCustomer(companyId, input, addCustomerDelegate);

            Assert.AreEqual(input.HasCreditLimit, false);
            Assert.AreEqual(input.Id, userId);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod25()
        {
            var input = new Customer()
            {
                Firstname = "Test",
                Surname = "Test",
                EmailAddress = "@.",
                DateOfBirth = DateTime.Now.AddYears(-21),
            };
            var companyId = 1;
            Action<Customer> addCustomerDelegate = null;
            var errorMessage = "Object reference not set to an instance of an object.";
            var companyData = new Company()
            {
                Id = companyId,
                Name = "ImportantClient",
                Classification = Classification.Silver,
            };
            var companyRepository = new Mock<ICompanyRepository>();
            companyRepository.Setup(c => c.GetById(companyId)).Returns(companyData);
            var customerService = new CustomerService(companyRepository.Object, null);

            var exception = Assert.ThrowsException<NullReferenceException>(() => customerService.AddCustomer(companyId, input, addCustomerDelegate));

            Assert.AreEqual(input.HasCreditLimit, true);
            Assert.AreEqual(errorMessage, exception.Message);
        }

        [TestMethod]
        public void TestMethod26()
        {
            var input = new Customer()
            {
                Firstname = "Test",
                Surname = "Test",
                EmailAddress = "@.",
                DateOfBirth = DateTime.Now.AddYears(-21),
            };
            var companyId = 1;
            Action<Customer> addCustomerDelegate = null;
            var expectedResult = false;
            var companyData = new Company()
            {
                Id = companyId,
                Name = "ImportantClient",
                Classification = Classification.Silver,
            };
            var companyRepository = new Mock<ICompanyRepository>();
            companyRepository.Setup(c => c.GetById(companyId)).Returns(companyData);
            var customerCreditService = new Mock<ICustomerCreditService>();
            customerCreditService.Setup(x => x.GetCreditLimit(input.Firstname, input.Surname, input.DateOfBirth)).Returns(0);
            var customerService = new CustomerService(companyRepository.Object, customerCreditService.Object);

            var actualResult = customerService.AddCustomer(companyId, input, addCustomerDelegate);

            Assert.AreEqual(input.HasCreditLimit, true);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod27()
        {
            var input = new Customer()
            {
                Firstname = "Test",
                Surname = "Test",
                EmailAddress = "@.",
                DateOfBirth = DateTime.Now.AddYears(-21),
            };
            var companyId = 1;
            Action<Customer> addCustomerDelegate = null;
            var expectedResult = false;
            var companyData = new Company()
            {
                Id = companyId,
                Name = "ImportantClient",
                Classification = Classification.Silver,
            };
            var companyRepository = new Mock<ICompanyRepository>();
            companyRepository.Setup(c => c.GetById(companyId)).Returns(companyData);
            var creditLimit = 249;
            var customerCreditService = new Mock<ICustomerCreditService>();
            customerCreditService.Setup(x => x.GetCreditLimit(input.Firstname, input.Surname, input.DateOfBirth)).Returns(creditLimit);
            var customerService = new CustomerService(companyRepository.Object, customerCreditService.Object);

            var actualResult = customerService.AddCustomer(companyId, input, addCustomerDelegate);

            Assert.AreEqual(input.HasCreditLimit, true);
            Assert.AreEqual(input.CreditLimit, creditLimit * 2);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod28()
        {
            var input = new Customer()
            {
                Firstname = "Test",
                Surname = "Test",
                EmailAddress = "@.",
                DateOfBirth = DateTime.Now.AddYears(-21),
            };
            var companyId = 1;
            var userId = 1;
            Action<Customer> addCustomerDelegate = new Action<Customer>(x => x.Id = userId);
            var expectedResult = true;
            var companyData = new Company()
            {
                Id = companyId,
                Name = "ImportantClient",
                Classification = Classification.Silver,
            };
            var companyRepository = new Mock<ICompanyRepository>();
            companyRepository.Setup(c => c.GetById(companyId)).Returns(companyData);
            var creditLimit = 250;
            var customerCreditService = new Mock<ICustomerCreditService>();
            customerCreditService.Setup(x => x.GetCreditLimit(input.Firstname, input.Surname, input.DateOfBirth)).Returns(creditLimit);
            var customerService = new CustomerService(companyRepository.Object, customerCreditService.Object);

            var actualResult = customerService.AddCustomer(companyId, input, addCustomerDelegate);

            Assert.AreEqual(input.HasCreditLimit, true);
            Assert.AreEqual(input.CreditLimit, creditLimit * 2);
            Assert.AreEqual(input.Id, userId);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod29()
        {
            var input = new Customer()
            {
                Firstname = "Test",
                Surname = "Test",
                EmailAddress = "@.",
                DateOfBirth = DateTime.Now.AddYears(-21),
            };
            var companyId = 1;
            Action<Customer> addCustomerDelegate = null;
            var expectedResult = false;
            var companyData = new Company()
            {
                Id = companyId,
                Name = "Client",
                Classification = Classification.Bronze,
            };
            var companyRepository = new Mock<ICompanyRepository>();
            companyRepository.Setup(c => c.GetById(companyId)).Returns(companyData);
            var creditLimit = 499;
            var customerCreditService = new Mock<ICustomerCreditService>();
            customerCreditService.Setup(x => x.GetCreditLimit(input.Firstname, input.Surname, input.DateOfBirth)).Returns(creditLimit);
            var customerService = new CustomerService(companyRepository.Object, customerCreditService.Object);

            var actualResult = customerService.AddCustomer(companyId, input, addCustomerDelegate);

            Assert.AreEqual(input.HasCreditLimit, true);
            Assert.AreEqual(input.CreditLimit, creditLimit);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod30()
        {
            var input = new Customer()
            {
                Firstname = "Test",
                Surname = "Test",
                EmailAddress = "@.",
                DateOfBirth = DateTime.Now.AddYears(-21),
            };
            var companyId = 1;
            var userId = 1;
            Action<Customer> addCustomerDelegate = new Action<Customer>(x => x.Id = userId);
            var expectedResult = true;
            var companyData = new Company()
            {
                Id = companyId,
                Name = "Client",
                Classification = Classification.Bronze,
            };
            var companyRepository = new Mock<ICompanyRepository>();
            companyRepository.Setup(c => c.GetById(companyId)).Returns(companyData);
            var creditLimit = 500;
            var customerCreditService = new Mock<ICustomerCreditService>();
            customerCreditService.Setup(x => x.GetCreditLimit(input.Firstname, input.Surname, input.DateOfBirth)).Returns(creditLimit);
            var customerService = new CustomerService(companyRepository.Object, customerCreditService.Object);

            var actualResult = customerService.AddCustomer(companyId, input, addCustomerDelegate);

            Assert.AreEqual(input.HasCreditLimit, true);
            Assert.AreEqual(input.CreditLimit, creditLimit);
            Assert.AreEqual(input.Id, userId);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
