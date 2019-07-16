using BudgetCarRental.Model;
using BudgetCarRental.Model.Model;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetCarRental.api.Data
{
    public class SeedData
    {
        private readonly AppDbContext _context;

        public SeedData(AppDbContext context)
        {
            _context = context;
        }


        public void Seed()
        {
            if (!_context.AppUsers.Any())
            {

               

                var Data = new List<Customer>
                {

                #region Recardo Enterprises

                new Customer()
                {
                    OrganizationName = "Ricardo",
                    CustomerType = EnumCustomerType.CorpCustomer,
                    AppUser = new AppUser
                    {
                        Email = "RicardoEnterprises@gmail.com",
                        PasswordHash = CreatePasswordHash("password"),
                        PasswordSalt = CreatePasswordSalt("password"),
                        JoinDate = DateTime.Now
                    },
                    CustomerContacts = new List<CustomerContact>
                    {
                        new CustomerContact()
                        {
                            Contact = new Contact
                            {
                                Detail = "008801675759801",
                                IsDeleted = false
                            }
                        },
                        new CustomerContact()
                        {
                            Contact = new Contact
                            {
                                Detail = "0088016658401",
                                IsDeleted = false
                            }
                        }
                    },
                    CustomerAddresses = new List<CustomerAddress>
                    {
                        new CustomerAddress
                        {
                            Address = new Address
                            {
                                House = "34/6",
                                Road = "Ataturk Road",
                                City= "Banani",
                                State= "Dhaka",
                                Country= "Bangladesh",
                                IsDeleted= false
                            }
                        },
                        new CustomerAddress
                        {
                            Address = new Address
                            {
                                House = "34/6",
                                Road = "Panthapath",
                                City= "Dhanmondi",
                                State= "Dhaka",
                                Country= "Bangladesh",
                                IsDeleted= true
                            }
                        }
                    },
                    Fleets = new List<Fleet>
                    {
                       new Fleet
                       {
                           StartDate = new DateTime(2017, 08, 05) ,
                           EndDate = new DateTime(2022, 08, 04),
                           VehicleFleets = new List<VehicleFleet>
                           {
                               new VehicleFleet
                               {
                                   Vehicle = new Vehicle
                                    {
                                        ModelName = "Ford Focus",
                                        RegNo = "S10 URP",
                                        Type = Model.EnumVehicleType.SmallCar,
                                        IsAvailable = true,
                                        VehiclePhotos = new List<VehiclePhoto>
                                        {
                                            new VehiclePhoto
                                            {
                                                Photo = new Photo
                                                {
                                                    PhotoUrl = "CarDefault.jpg",
                                                    IsMain =  true
                                                }
                                            }
                                        },
                                        Descriptions = new List<VehicleDescription>
                                        {
                                            new VehicleDescription
                                            {
                                                Description = "Any Supermini, small family car or city car"
                                            }
                                        },
                                        RentalArrangements = new List<RentalArrangement>
                                        {
                                            new RentalArrangement
                                            {
                                                StartDate = new DateTime(2017, 03, 01),
                                                EndDate = new DateTime(2018, 03, 01),
                                                ArrangementType = EnumArrangementType.OneOff,
                                                Driver= new Driver
                                                {
                                                    UniqeId = "D77",
                                                    FirstName = "Leon",
                                                    LastName = "Garfield",
                                                    InsuranceNumber = "DR-1548",
                                                    IsAvailable = true,
                                                    DriverContacts =  new List<DriverContact>
                                                    {
                                                        new DriverContact
                                                        {
                                                            Contact = new Contact
                                                            {
                                                                Detail = "+332546452"
                                                            }
                                                        },
                                                        new DriverContact
                                                        {
                                                            Contact = new Contact
                                                            {
                                                                Detail = "+954546452"
                                                            }
                                                        }
                                                    },
                                                    DriverPhotos = new List<DriverPhoto>
                                                    {
                                                        new DriverPhoto
                                                        {
                                                            Photo = new Photo
                                                            {
                                                                PhotoUrl = "CarDefault.jpg",
                                                                IsMain =  true
                                                            }
                                                        }
                                                    },
                                                    DriverPayments = new List<DriverPayment>
                                                    {
                                                        new DriverPayment
                                                        {
                                                            Payment = new Payment
                                                            {
                                                                paymentMedia = "Bank",
                                                                PaymentDate = new DateTime(2014, 10, 03)
                                                            }
                                                        }
                                                    },
                                                    AppUser = new AppUser
                                                    {
                                                        Email ="leongarfield@budget.com",
                                                        JoinDate = DateTime.Now,
                                                        PasswordHash = CreatePasswordHash("password"),
                                                        PasswordSalt = CreatePasswordSalt("password"),
                                                    },
                                                    DriverAddresses = new List<DriverAddress>
                                                    {
                                                        new DriverAddress
                                                        {
                                                            Address = new Address
                                                            {
                                                                House = "34/6",
                                                                Road = "Camp Road",
                                                                City= "Mohammadpur",
                                                                State= "Dhaka",
                                                                Country= "Bangladesh"
                                                            }
                                                        }

                                                    }
                                                }
                                            }
                                        }
                                    }
                               },
                               new VehicleFleet
                               {
                                   Vehicle = new Vehicle
                                    {
                                        ModelName = "Kia Picanto",
                                        RegNo = "S30 KLL",
                                        Type = Model.EnumVehicleType.SmallCar,
                                        IsAvailable = true,
                                        VehiclePhotos = new List<VehiclePhoto>
                                        {
                                            new VehiclePhoto
                                            {
                                                Photo = new Photo
                                                {
                                                    PhotoUrl = "CarDefault.jpg",
                                                    IsMain =  true
                                                }
                                            }
                                        },
                                        Descriptions = new List<VehicleDescription>
                                        {
                                            new VehicleDescription
                                            {
                                                Description = "Any Supermini, small family car or city car"
                                            }
                                        },
                                        RentalArrangements = new List<RentalArrangement>
                                        {
                                            new RentalArrangement
                                            {
                                                StartDate = new DateTime(2017, 03, 01),
                                                EndDate = new DateTime(2018, 03, 01),
                                                ArrangementType = EnumArrangementType.OneOff,
                                                Driver= new Driver
                                                {
                                                    UniqeId = "D99",
                                                    FirstName = "Oliver",
                                                    LastName = "Morton",
                                                    InsuranceNumber = "DR-1546",
                                                    IsAvailable = true,
                                                    DriverContacts =  new List<DriverContact>
                                                    {
                                                        new DriverContact
                                                        {
                                                            Contact = new Contact
                                                            {
                                                                Detail = "+332546452"
                                                            }
                                                        },
                                                        new DriverContact
                                                        {
                                                            Contact = new Contact
                                                            {
                                                                Detail = "+954546452"
                                                            }
                                                        }
                                                    },
                                                    DriverPhotos = new List<DriverPhoto>
                                                    {
                                                        new DriverPhoto
                                                        {
                                                            Photo = new Photo
                                                            {
                                                                PhotoUrl = "UserDefault.jpg",
                                                                IsMain =  true
                                                            }
                                                        }
                                                    },
                                                    DriverPayments = new List<DriverPayment>
                                                    {
                                                        new DriverPayment
                                                        {
                                                            Payment = new Payment
                                                            {
                                                                paymentMedia = "Bank",
                                                                PaidAmount = 80000,
                                                                PaymentDate = new DateTime(2014, 10, 03)
                                                            }
                                                        }
                                                    },
                                                    AppUser = new AppUser
                                                    {
                                                        Email ="leongarfield@budget.com",
                                                        JoinDate = DateTime.Now,
                                                        PasswordHash = CreatePasswordHash("password"),
                                                        PasswordSalt = CreatePasswordSalt("password"),
                                                    },
                                                    DriverAddresses = new List<DriverAddress>
                                                    {
                                                        new DriverAddress
                                                        {
                                                            Address = new Address
                                                            {
                                                                House = "34/6",
                                                                Road = "Camp Road",
                                                                City= "Mohammadpur",
                                                                State= "Dhaka",
                                                                Country= "Bangladesh"
                                                            }
                                                        }

                                                    }
                                                }
                                            }
                                        }
                                    }
                               },
                               new VehicleFleet
                               {
                                   Vehicle = new Vehicle
                                    {
                                        ModelName = "Fort Transit",
                                        RegNo = "S123 UTT",
                                        Type = Model.EnumVehicleType.Van,
                                        IsAvailable = true,
                                        VehiclePhotos = new List<VehiclePhoto>
                                        {
                                            new VehiclePhoto
                                            {
                                                Photo = new Photo
                                                {
                                                    PhotoUrl = "CarDefault.jpg",
                                                    IsMain =  true
                                                }
                                            }
                                        },
                                        Descriptions = new List<VehicleDescription>
                                        {
                                            new VehicleDescription
                                            {
                                                Description = "Any Van"
                                            }
                                        },
                                        RentalArrangements = new List<RentalArrangement>
                                        {
                                            new RentalArrangement
                                            {
                                                StartDate = new DateTime(2017, 04, 03),
                                                ArrangementType = EnumArrangementType.OneOff,
                                                Driver= new Driver
                                                {
                                                    UniqeId = "D81",
                                                    FirstName = "Edger",
                                                    LastName = "West",
                                                    InsuranceNumber = "EW-1596",
                                                    IsAvailable = true,
                                                    JoinDate = new DateTime(2016, 12, 22),
                                                    DriverContacts =  new List<DriverContact>
                                                    {
                                                        new DriverContact
                                                        {
                                                            Contact = new Contact
                                                            {
                                                                Detail = "+332857852"
                                                            }
                                                        },
                                                        new DriverContact
                                                        {
                                                            Contact = new Contact
                                                            {
                                                                Detail = "+956656852"
                                                            }
                                                        }
                                                    },
                                                    DriverPhotos = new List<DriverPhoto>
                                                    {
                                                        new DriverPhoto
                                                        {
                                                            Photo = new Photo
                                                            {
                                                                PhotoUrl = "CarDefault.jpg",
                                                                IsMain =  true
                                                            }
                                                        }
                                                    },
                                                    DriverPayments = new List<DriverPayment>
                                                    {
                                                        new DriverPayment
                                                        {
                                                            Payment = new Payment
                                                            {
                                                                paymentMedia = "Bank",
                                                                PaidAmount = 70000,
                                                                PaymentDate = new DateTime(2019, 1, 3)
                                                            }
                                                        }
                                                    },
                                                    AppUser = new AppUser
                                                    {
                                                        Email ="leongarfield@budget.com",
                                                        JoinDate = DateTime.Now,
                                                        PasswordHash = CreatePasswordHash("password"),
                                                        PasswordSalt = CreatePasswordSalt("password"),
                                                    },
                                                    DriverAddresses = new List<DriverAddress>
                                                    {
                                                        new DriverAddress
                                                        {
                                                            Address = new Address
                                                            {
                                                                House = "34/6",
                                                                Road = "Camp Road",
                                                                City= "Mohammadpur",
                                                                State= "Dhaka",
                                                                Country= "Bangladesh"
                                                            }
                                                        }

                                                    }
                                                }
                                            }
                                        }

                                    }
                               }
                           }
                       },
                       new Fleet
                       {
                           StartDate = new DateTime(2018, 1, 31) ,
                           EndDate = new DateTime(2022, 12, 31),
                           VehicleFleets = new List<VehicleFleet>
                           {
                               new VehicleFleet
                               {
                                   Vehicle = new Vehicle
                                    {
                                        ModelName = "BMW 5 Series",
                                        RegNo = "S20 UYT",
                                        Type = EnumVehicleType.LargeCare,
                                        IsAvailable = true,
                                        VehiclePhotos = new List<VehiclePhoto>
                                        {
                                            new VehiclePhoto
                                            {
                                                Photo = new Photo
                                                {
                                                    PhotoUrl = "CarDefault.jpg",
                                                    IsMain =  true
                                                }
                                            }
                                        },
                                        Descriptions = new List<VehicleDescription>
                                        {
                                            new VehicleDescription
                                            {
                                                Description = "Any people mover, small or large MPV"
                                            }
                                        },
                                        RentalArrangements = new List<RentalArrangement>
                                        {
                                            new RentalArrangement
                                            {
                                                StartDate = new DateTime(2017, 03, 01),
                                                EndDate = new DateTime(2021, 03, 01),
                                                ArrangementType = EnumArrangementType.OneOff,
                                                Driver= new Driver
                                                {
                                                    UniqeId = "D98",
                                                    FirstName = "Mavis",
                                                    LastName = "Cutter",
                                                    InsuranceNumber = "MC-1566",
                                                    IsAvailable = true,
                                                    JoinDate = new DateTime(2016, 12, 22),
                                                    DriverContacts =  new List<DriverContact>
                                                    {
                                                        new DriverContact
                                                        {
                                                            Contact = new Contact
                                                            {
                                                                Detail = "+332857852"
                                                            }
                                                        },
                                                        new DriverContact
                                                        {
                                                            Contact = new Contact
                                                            {
                                                                Detail = "+956656852"
                                                            }
                                                        }
                                                    },
                                                    DriverPhotos = new List<DriverPhoto>
                                                    {
                                                        new DriverPhoto
                                                        {
                                                            Photo = new Photo
                                                            {
                                                                PhotoUrl = "CarDefault.jpg",
                                                                IsMain =  true
                                                            }
                                                        }
                                                    },
                                                    DriverPayments = new List<DriverPayment>
                                                    {
                                                        new DriverPayment
                                                        {
                                                            Payment = new Payment
                                                            {
                                                                paymentMedia = "Online",
                                                                PaidAmount = 70000,
                                                                PaymentDate = new DateTime(2019, 1, 3)
                                                            }
                                                        }
                                                    },
                                                    AppUser = new AppUser
                                                    {
                                                        Email ="leongarfield@budget.com",
                                                        JoinDate = DateTime.Now,
                                                        PasswordHash = CreatePasswordHash("password"),
                                                        PasswordSalt = CreatePasswordSalt("password"),
                                                    },
                                                    DriverAddresses = new List<DriverAddress>
                                                    {
                                                        new DriverAddress
                                                        {
                                                            Address = new Address
                                                            {
                                                                House = "34/6",
                                                                Road = "Barnabo",
                                                                City= "Mohammadpur",
                                                                State= "Dhaka",
                                                                Country= "Bangladesh"
                                                            }
                                                        }

                                                    }
                                                }
                                            }
                                        },
                                        VehicleFleets = new List<VehicleFleet>
                                        {
                                            new VehicleFleet
                                            {
                                                Fleet = new Fleet
                                                {
                                                    Customer = new Customer
                                                    {
                                                        AppUser = new AppUser
                                                        {
                                                            Email = "faahad.hossain@gmail.com",
                                                            JoinDate = DateTime.Now,
                                                            PasswordHash = CreatePasswordHash("password"),
                                                            PasswordSalt = CreatePasswordSalt ("password"),
                                                        },
                                                        OrganizationName = "Individual",
                                                        CustomerType= EnumCustomerType.RentCustomer,
                                                        CustomerAddresses = new List<CustomerAddress>
                                                        {
                                                            new CustomerAddress
                                                            {
                                                                Address = new Address
                                                                {
                                                                    House = "34/6",
                                                                    Road = "Lalkha",
                                                                    City= "Narayanganj",
                                                                    State= "Dhaka",
                                                                    Country= "Bangladesh",
                                                                    IsDeleted= true
                                                                }
                                                            }
                                                        },
                                                        CustomerContacts = new List<CustomerContact>
                                                        {
                                                            new CustomerContact
                                                            {
                                                                Contact = new Contact{Detail="+11225486544"}
                                                            },
                                                            new CustomerContact
                                                            {
                                                                Contact = new Contact{Detail="+16525486544"}
                                                            },
                                                        },
                                                        CustomerPhotos = new List<CustomerPhoto>
                                                        {
                                                            new CustomerPhoto
                                                            {
                                                                Photo = new Photo{ PhotoUrl ="UserDefault.jpg", IsMain = true}
                                                            }
                                                        },
                                                    },
                                                    StartDate = new DateTime(2016,12,12) ,
                                                    EndDate = new DateTime(2020,12,31),
                                                    FleetPayments = new List<FleetPayment>
                                                    {
                                                        new FleetPayment
                                                        {
                                                            Payment = new Payment
                                                            {
                                                                paymentMedia = "Swift-pay",
                                                                PaidAmount = 500000,
                                                                PaymentDate = new DateTime(2019,06,30)
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                               },
                               new VehicleFleet
                               {
                                   Vehicle = new Vehicle
                                    {
                                        ModelName = "Kia Picanto",
                                        RegNo = "L99 5TT",
                                        Type = EnumVehicleType.SmallCar,
                                        IsAvailable = true,
                                        VehiclePhotos = new List<VehiclePhoto>
                                        {
                                            new VehiclePhoto
                                            {
                                                Photo = new Photo
                                                {
                                                    PhotoUrl = "DefaultCar.jpg",
                                                    IsMain =  true
                                                }
                                            }
                                        },
                                        Descriptions = new List<VehicleDescription>
                                        {
                                            new VehicleDescription
                                            {
                                                Description = "Any Supermini, small family car or city car"
                                            }
                                        },
                                        RentalArrangements = new List<RentalArrangement>
                                        {
                                            new RentalArrangement
                                            {
                                                StartDate = new DateTime(2017, 03, 01),
                                                EndDate = new DateTime(2018, 03, 01),
                                                ArrangementType = EnumArrangementType.OneOff,
                                                Driver= new Driver
                                                {
                                                    UniqeId = "D100",
                                                    FirstName = "Mark",
                                                    LastName = "Smith",
                                                    InsuranceNumber = "MS-1566",
                                                    IsAvailable = true,
                                                    JoinDate = new DateTime(2013, 1, 22),
                                                    DriverContacts =  new List<DriverContact>
                                                    {
                                                        new DriverContact
                                                        {
                                                            Contact = new Contact
                                                            {
                                                                Detail = "+332888852"
                                                            }
                                                        },
                                                        new DriverContact
                                                        {
                                                            Contact = new Contact
                                                            {
                                                                Detail = "+998756852"
                                                            }
                                                        }
                                                    },
                                                    DriverPhotos = new List<DriverPhoto>
                                                    {
                                                        new DriverPhoto
                                                        {
                                                            Photo = new Photo
                                                            {
                                                                PhotoUrl = "UserDefault.jpg",
                                                                IsMain =  true
                                                            }
                                                        }
                                                    },
                                                    DriverPayments = new List<DriverPayment>
                                                    {
                                                        new DriverPayment
                                                        {
                                                            Payment = new Payment
                                                            {
                                                                paymentMedia = "Swift-pay",
                                                                PaidAmount = 70000,
                                                                PaymentDate = new DateTime(2019, 1, 3)
                                                            }
                                                        }
                                                    },
                                                    AppUser = new AppUser
                                                    {
                                                        Email ="mark.smith@budget.com",
                                                        JoinDate = DateTime.Now,
                                                        PasswordHash = CreatePasswordHash("password"),
                                                        PasswordSalt = CreatePasswordSalt("password"),
                                                    },
                                                    DriverAddresses = new List<DriverAddress>
                                                    {
                                                        new DriverAddress
                                                        {
                                                            Address = new Address
                                                            {
                                                                House = "34/6",
                                                                Road = "Camp nu",
                                                                City= "Lalbag",
                                                                State= "Dhaka",
                                                                Country= "Bangladesh"
                                                            }
                                                        }

                                                    }
                                                }
                                            }
                                        }
                                    }
                               }
                           }
                       }
                    },
                    CustomerPhotos = new List<CustomerPhoto>
                    {
                        new CustomerPhoto
                        {
                            Photo = new Photo{ PhotoUrl = "UserDefault.jpg", IsMain = true}
                        }
                    }
                },
                    
                #endregion
                    
                #region Brown Estate Agents

                new Customer()
                {
                    OrganizationName = "Brown Estate Agents",
                    CustomerType = EnumCustomerType.CorpCustomer,
                    AppUser = new AppUser
                    {
                        Email = "BrownEstate@gmail.com",
                        PasswordHash = CreatePasswordHash("password"),
                        PasswordSalt = CreatePasswordSalt("password"),
                        JoinDate = DateTime.Now
                    },
                    CustomerContacts = new List<CustomerContact>
                    {
                        new CustomerContact()
                        {
                            Contact = new Contact
                            {
                                Detail = "+66545245",
                                IsDeleted = false
                            }
                        },
                        new CustomerContact()
                        {
                            Contact = new Contact
                            {
                                Detail = "+86541252",
                                IsDeleted = false
                            }
                        }
                    },
                    CustomerAddresses = new List<CustomerAddress>
                    {
                        new CustomerAddress
                        {
                            Address = new Address
                            {
                                House = "100",
                                Road = "New Bridge Street",
                                City= "Bridge",
                                State= "London",
                                Country= "United Kingdom",
                                IsDeleted= false
                            }
                        }
                    },
                    Fleets = new List<Fleet>
                    {
                       new Fleet
                       {
                           StartDate = new DateTime(2019, 4, 30) ,
                           EndDate = new DateTime(2024, 4, 30),
                           VehicleFleets = new List<VehicleFleet>
                           {
                               new VehicleFleet
                               {
                                   Vehicle = new Vehicle
                                    {
                                        ModelName = "Ford Transit",
                                        RegNo = "L87 WXH",
                                        Type = Model.EnumVehicleType.Van,
                                        IsAvailable = true,
                                        VehiclePhotos = new List<VehiclePhoto>
                                        {
                                            new VehiclePhoto
                                            {
                                                Photo = new Photo
                                                {
                                                    PhotoUrl = "CarDefault.jpg",
                                                    IsMain =  true
                                                }
                                            }
                                        },
                                        Descriptions = new List<VehicleDescription>
                                        {
                                            new VehicleDescription
                                            {
                                                Description = "Any van"
                                            }
                                        },
                                        RentalArrangements = new List<RentalArrangement>
                                        {
                                            new RentalArrangement
                                            {
                                                StartDate = new DateTime(2017, 02, 01),
                                                EndDate = new DateTime(2018, 03, 02),
                                                ArrangementType = EnumArrangementType.Monthly,
                                                RepairSessions = new List<RepairSession>
                                                {
                                                    new RepairSession
                                                    {
                                                        RepairingEmployees = new List<RepairingEmployee>
                                                        {
                                                            new RepairingEmployee
                                                            {
                                                                Employee = new Employee
                                                                {
                                                                    Department = EnumDepartment.Staff,
                                                                    UniqeId = "S78",
                                                                    FirstName = "Dave",
                                                                    LastName = "Smith",
                                                                    IsAvailable = true,
                                                                    EmployeeAddresses = new List<EmployeeAddress>
                                                                    {
                                                                        new EmployeeAddress
                                                                        {
                                                                            Address = new Address
                                                                            {
                                                                                House = "34/6",
                                                                                Road = "Dave Smith",
                                                                                City= "Employee",
                                                                                State= "New York",
                                                                                Country= "United States"
                                                                            }
                                                                        }
                                                                    },
                                                                    EmployeeContacts =  new List<EmployeeContact>
                                                                    {
                                                                        new EmployeeContact
                                                                        {
                                                                            Contact = new Contact
                                                                            {
                                                                                Detail = "+23698752"
                                                                            }
                                                                        }
                                                                    },
                                                                    EmployeePhotos = new List<EmployeePhoto>
                                                                    {
                                                                        new EmployeePhoto
                                                                        {
                                                                            Photo = new Photo
                                                                            {
                                                                                PhotoUrl = "CarDefault.jpg",
                                                                                IsMain =  true
                                                                            }
                                                                        }
                                                                    },
                                                                    AppUser = new AppUser
                                                                    {
                                                                        Email = "dave.smith@budget.com",
                                                                        JoinDate = DateTime.Now,
                                                                        PasswordHash = CreatePasswordHash("password"),
                                                                        PasswordSalt = CreatePasswordSalt("password"),
                                                                    },
                                                                }
                                                            },
                                                            new RepairingEmployee
                                                            {
                                                                Employee = new Employee
                                                                {
                                                                    Department = EnumDepartment.Staff,
                                                                    UniqeId = "S78",
                                                                    FirstName = "Holly",
                                                                    LastName = "Leman",
                                                                    IsAvailable = true,
                                                                    EmployeeAddresses = new List<EmployeeAddress>
                                                                    {
                                                                        new EmployeeAddress
                                                                        {
                                                                            Address = new Address
                                                                            {
                                                                                House = "34/6",
                                                                                Road = "Holly Leman",
                                                                                City= "Employee",
                                                                                State= "New Jersey",
                                                                                Country= "United States"
                                                                            }
                                                                        }
                                                                    },
                                                                    EmployeeContacts =  new List<EmployeeContact>
                                                                    {
                                                                        new EmployeeContact
                                                                        {
                                                                            Contact = new Contact
                                                                            {
                                                                                Detail = "+278569852"
                                                                            }
                                                                        }
                                                                    },
                                                                    EmployeePhotos = new List<EmployeePhoto>
                                                                    {
                                                                        new EmployeePhoto
                                                                        {
                                                                            Photo = new Photo
                                                                            {
                                                                                PhotoUrl = "UserDefault.jpg",
                                                                                IsMain =  true
                                                                            }
                                                                        }
                                                                    },
                                                                    AppUser = new AppUser
                                                                    {
                                                                        Email = "holly.leman@budget.com",
                                                                        JoinDate = DateTime.Now,
                                                                        PasswordHash = CreatePasswordHash("password"),
                                                                        PasswordSalt = CreatePasswordSalt("password"),
                                                                    },
                                                                }

                                                            },
                                                        },
                                                        PartsForRepairs = new List<PartsForRepair>
                                                        {
                                                            new PartsForRepair
                                                            {
                                                                Qty = 2,
                                                                Parts = new Parts
                                                                {
                                                                    PartsCode = "BL",
                                                                    PartName = "Back Lights",
                                                                    Price = 30,
                                                                    PartsPhotos = new List<PartsPhoto>
                                                                    {
                                                                        new PartsPhoto
                                                                        {
                                                                            Photo = new Photo
                                                                            {
                                                                                PhotoUrl = "PartsDefault.jpg",
                                                                                IsMain = true
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            },
                                                            new PartsForRepair
                                                            {
                                                                Qty = 1,
                                                                Parts = new Parts
                                                                {
                                                                    PartsCode = "FW",
                                                                    PartName = "Front Window Screen",
                                                                    Price = 30,
                                                                    PartsPhotos = new List<PartsPhoto>
                                                                    {
                                                                        new PartsPhoto
                                                                        {
                                                                            Photo = new Photo
                                                                            {
                                                                                PhotoUrl = "PartsDefault.jpg",
                                                                                IsMain = true
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            },
                                                            new PartsForRepair
                                                            {
                                                                Qty = 1,
                                                                Parts = new Parts
                                                                {
                                                                    PartsCode = "BW",
                                                                    PartName = "Back Window Screen",
                                                                    Price = 30,
                                                                    PartsPhotos = new List<PartsPhoto>
                                                                    {
                                                                        new PartsPhoto
                                                                        {
                                                                            Photo = new Photo
                                                                            {
                                                                                PhotoUrl = "PartsDefault.jpg",
                                                                                IsMain = true
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            },
                                                            new PartsForRepair
                                                            {
                                                                Qty = 1,
                                                                Parts = new Parts
                                                                {
                                                                    PartsCode = "SB",
                                                                    PartName = "Seat Belt",
                                                                    Price = 30,
                                                                    PartsPhotos = new List<PartsPhoto>
                                                                    {
                                                                        new PartsPhoto
                                                                        {
                                                                            Photo = new Photo
                                                                            {
                                                                                PhotoUrl = "PartsDefault.jpg",
                                                                                IsMain = true
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            },
                                                        },
                                                        RepairDate = new DateTime(2017,03,01) ,
                                                    }
                                                },
                                                Driver= new Driver
                                                {
                                                    UniqeId = "D101",
                                                    FirstName = "Jeff",
                                                    LastName = "Moon",
                                                    InsuranceNumber = "JM-1566",
                                                    IsAvailable = true,
                                                    JoinDate = new DateTime(2015, 4, 22),
                                                    DriverContacts =  new List<DriverContact>
                                                    {
                                                        new DriverContact
                                                        {
                                                            Contact = new Contact
                                                            {
                                                                Detail = "+331117852"
                                                            }
                                                        },
                                                        new DriverContact
                                                        {
                                                            Contact = new Contact
                                                            {
                                                                Detail = "+23546852"
                                                            }
                                                        }
                                                    },
                                                    DriverPhotos = new List<DriverPhoto>
                                                    {
                                                        new DriverPhoto
                                                        {
                                                            Photo = new Photo
                                                            {
                                                                PhotoUrl = "CarDefault.jpg",
                                                                IsMain =  true
                                                            }
                                                        }
                                                    },
                                                    DriverPayments = new List<DriverPayment>
                                                    {
                                                        new DriverPayment
                                                        {
                                                            Payment = new Payment
                                                            {
                                                                paymentMedia = "Bank",
                                                                PaidAmount = 30000,
                                                                PaymentDate = new DateTime(2019, 1, 3)
                                                            }
                                                        }
                                                    },
                                                    AppUser = new AppUser
                                                    {
                                                        Email ="leongarfield@budget.com",
                                                        JoinDate = DateTime.Now,
                                                        PasswordHash = CreatePasswordHash("password"),
                                                        PasswordSalt = CreatePasswordSalt("password"),
                                                    },
                                                    DriverAddresses = new List<DriverAddress>
                                                    {
                                                        new DriverAddress
                                                        {
                                                            Address = new Address
                                                            {
                                                                House = "34/6",
                                                                Road = "Jeff Moon",
                                                                City= "Driver",
                                                                State= "Ariana",
                                                                Country= "Bangladesh"
                                                            }
                                                        }

                                                    }
                                                }
                                            }
                                        }
                                    }
                               },
                               new VehicleFleet
                               {
                                   Vehicle = new Vehicle
                                    {
                                        ModelName = "Fiat Uno",
                                        RegNo = "S20 UHH",
                                        Type = EnumVehicleType.SmallCar,
                                        IsAvailable = true,
                                        VehiclePhotos = new List<VehiclePhoto>
                                        {
                                            new VehiclePhoto
                                            {
                                                Photo = new Photo
                                                {
                                                    PhotoUrl = "CarDefault.jpg",
                                                    IsMain =  true
                                                }
                                            }
                                        },
                                        Descriptions = new List<VehicleDescription>
                                        {
                                            new VehicleDescription
                                            {
                                                Description = "Any supermini, small family car or city car"
                                            }
                                        },
                                        VehicleFleets = new List<VehicleFleet>
                                        {
                                            new VehicleFleet
                                            {
                                                Fleet = new Fleet
                                                {
                                                    Customer = new Customer
                                                    {
                                                        AppUser = new AppUser
                                                        {
                                                            Email = "BigBug@gmail.com",
                                                            JoinDate = DateTime.Now,
                                                            PasswordHash = CreatePasswordHash("password"),
                                                            PasswordSalt = CreatePasswordSalt ("password"),
                                                        },
                                                        OrganizationName = "Individual",
                                                        CustomerType= EnumCustomerType.RentCustomer,
                                                        CustomerAddresses = new List<CustomerAddress>
                                                        {
                                                            new CustomerAddress
                                                            {
                                                                Address = new Address
                                                                {
                                                                    House = "34/6",
                                                                    Road = "Lalkha",
                                                                    City= "Narayanganj",
                                                                    State= "Dhaka",
                                                                    Country= "Bangladesh",
                                                                    IsDeleted= true
                                                                }
                                                            }
                                                        },
                                                        CustomerContacts = new List<CustomerContact>
                                                        {
                                                            new CustomerContact
                                                            {
                                                                Contact = new Contact{Detail="+8801675759801"}
                                                            },
                                                            new CustomerContact
                                                            {
                                                                Contact = new Contact{Detail="+8801836030022"}
                                                            },
                                                        },
                                                        CustomerPhotos = new List<CustomerPhoto>
                                                        {
                                                            new CustomerPhoto
                                                            {
                                                                Photo = new Photo{ PhotoUrl ="UserDefault.jpg", IsMain = true}
                                                            }
                                                        },
                                                    },
                                                    StartDate = new DateTime(2018,12,12) ,
                                                    EndDate = new DateTime(2020,12,31),
                                                    FleetPayments = new List<FleetPayment>
                                                    {
                                                        new FleetPayment
                                                        {
                                                            Payment = new Payment
                                                            {
                                                                PaidAmount = 300000,
                                                                PaymentDate = new DateTime(2018,06,30)
                                                            }
                                                        },
                                                        new FleetPayment
                                                        {
                                                            Payment = new Payment
                                                            {
                                                                paymentMedia = "Swift pay",
                                                                PaidAmount = 300000,
                                                                PaymentDate = new DateTime(2019,12,31)
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                               }
                           }
                       }
                    },
                    CustomerPhotos = new List<CustomerPhoto>
                    {
                        new CustomerPhoto
                        {
                            Photo = new Photo{ PhotoUrl = "DefaultCustomer.jpg", IsMain = true}
                        }
                    }
                },

                #endregion

                #region White Holdings

                new Customer()
                {
                    OrganizationName = "White Holdings",
                    CustomerType = EnumCustomerType.CorpCustomer,
                    AppUser = new AppUser
                    {
                        Email = "WhiteHoldings@gmail.com",
                        PasswordHash = CreatePasswordHash("password"),
                        PasswordSalt = CreatePasswordSalt("password"),
                        JoinDate = DateTime.Now
                    },
                    CustomerContacts = new List<CustomerContact>
                    {
                        new CustomerContact()
                        {
                            Contact = new Contact
                            {
                                Detail = "+6856445245",
                                IsDeleted = false
                            }
                        },
                        new CustomerContact()
                        {
                            Contact = new Contact
                            {
                                Detail = "+8565461252",
                                IsDeleted = false
                            }
                        }
                    },
                    CustomerAddresses = new List<CustomerAddress>
                    {
                        new CustomerAddress
                        {
                            Address = new Address
                            {
                                House = "36",
                                Road = "Linkoln Road",
                                City= "Oklahoma City",
                                State= "Oklahoman",
                                Country= "United States",
                                IsDeleted= false
                            }
                        }
                    },
                    Fleets = new List<Fleet>
                    {
                       new Fleet
                       {
                           StartDate = new DateTime(2019, 4, 30) ,
                           EndDate = new DateTime(2024, 4, 30),
                           VehicleFleets = new List<VehicleFleet>
                           {
                               new VehicleFleet
                               {
                                   Vehicle = new Vehicle
                                    {
                                        ModelName = "Chevrolet Malibu",
                                        RegNo = "S50 RSE",
                                        Type = EnumVehicleType.MediumCar,
                                        IsAvailable = true,
                                        VehiclePhotos = new List<VehiclePhoto>
                                        {
                                            new VehiclePhoto
                                            {
                                                Photo = new Photo
                                                {
                                                    PhotoUrl = "CarDefault.jpg",
                                                    IsMain =  true
                                                }
                                            }
                                        },
                                        Descriptions = new List<VehicleDescription>
                                        {
                                            new VehicleDescription
                                            {
                                                Description = "Midsized, intermediate or large family car"
                                            }
                                        },
                                        VehicleFleets = new List<VehicleFleet>
                                        {
                                            new VehicleFleet
                                            {
                                                Fleet = new Fleet
                                                {
                                                    Customer = new Customer
                                                    {
                                                        AppUser = new AppUser
                                                        {
                                                            Email = "Ron.Dimitrov@gmail.com",
                                                            JoinDate = DateTime.Now,
                                                            PasswordHash = CreatePasswordHash("password"),
                                                            PasswordSalt = CreatePasswordSalt ("password"),
                                                        },
                                                        OrganizationName = "Individual",
                                                        CustomerType= EnumCustomerType.RentCustomer,
                                                        CustomerAddresses = new List<CustomerAddress>
                                                        {
                                                            new CustomerAddress
                                                            {
                                                                Address = new Address
                                                                {
                                                                    House = "34/6",
                                                                    Road = "Lima lane",
                                                                    City= "Hoston",
                                                                    State= "Canberry",
                                                                    Country= "Austrailia",
                                                                }
                                                            }
                                                        },
                                                        CustomerContacts = new List<CustomerContact>
                                                        {
                                                            new CustomerContact
                                                            {
                                                                Contact = new Contact{Detail="+8801675759801"}
                                                            },
                                                            new CustomerContact
                                                            {
                                                                Contact = new Contact{Detail="+8801836030022"}
                                                            },
                                                        },
                                                        CustomerPhotos = new List<CustomerPhoto>
                                                        {
                                                            new CustomerPhoto
                                                            {
                                                                Photo = new Photo{ PhotoUrl ="UserDefault.jpg", IsMain = true}
                                                            }
                                                        },
                                                    },
                                                    StartDate = new DateTime(2018,12,12) ,
                                                    EndDate = new DateTime(2020,12,31),
                                                    FleetPayments = new List<FleetPayment>
                                                    {
                                                        new FleetPayment
                                                        {
                                                            Payment = new Payment
                                                            {
                                                                PaidAmount = 300000,
                                                                PaymentDate = new DateTime(2018,06,30)
                                                            }
                                                        },
                                                        new FleetPayment
                                                        {
                                                            Payment = new Payment
                                                            {
                                                                PaidAmount = 300000,
                                                                PaymentDate = new DateTime(2019,12,31)
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                               }
                           }
                       }
                    },
                    CustomerPhotos = new List<CustomerPhoto>
                    {
                        new CustomerPhoto
                        {
                            Photo = new Photo{ PhotoUrl = "DefaultCustomer.jpg", IsMain = true}
                        }
                    }
                }

                #endregion

                };
                _context.AddRange(Data);
                _context.SaveChanges();

                

            }

        }


        private byte[] CreatePasswordHash(string password)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
               var passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return passwordHash;
            }

        }

        private byte[] CreatePasswordSalt(string password)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
               var passwordSalt = hmac.Key;
                return passwordSalt;
            }

        }


    }
}
