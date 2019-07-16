using BudgetCarRental.Model.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BudgetCarRental.Business.Repositories.Interfaces
{
    public interface IBudgetRepo
    {
        Task<ICollection<Customer>> GetAllCustomers();
        Task<Customer> GetACustomer(int customerId);

        Task<ICollection<Driver>> GetAllDrivers();
        Task<Address> GetADriver(int DriverId);

        Task<ICollection<Employee>> GetAllEmployees();
        Task<Address> GetAEmployee(int EmployeeId);

        Task<ICollection<Address>> GetAllAddresses();
        Task<Address> GetAnAddress(int AddressId);

        Task<ICollection<Contact>> GetAllContacts();
        Task<Address> GetAContact(int ContactId);

        Task<ICollection<Payment>> GetAllPayments();
        Task<Payment> GetAPayment(int PaymentId);

    }
}
